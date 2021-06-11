using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmallRestaurantAPI.Data;
using SmallRestaurantAPI.DTOs;
using SmallRestaurantAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public CartItemController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper, UserManager<ApiUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var userID = GetCurrentUserID();
            var cartItem = await _unitOfWork.CartItems.Get(q => q.UserID == userID, include: q => q.Include(x => x.SelectedEntrees).ThenInclude(x => x.SelectedEntreeIngredients));
            var results = _mapper.Map<CartItemDTO>(cartItem);

            return Ok(results);
        }


        [Authorize]
        [HttpPost(Name = "AddEntreeToCart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddEntreeToCart([FromBody] SelectedEntreeDTO selectedEntreeDTO =null)
        {
            var userID = GetCurrentUserID();
            //checkIfCartExists
            var cartItem = await _unitOfWork.CartItems.Get(q => q.UserID == userID);
            if(cartItem == null)
            {
                cartItem = new CartItem()
                {
                    UserID = userID
                };
                await _unitOfWork.CartItems.Insert(cartItem);
                await _unitOfWork.Save();
            }

            if(selectedEntreeDTO != null)
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid Post attempt in {nameof(AddEntreeToCart)}");
                    return BadRequest(ModelState);
                }
                
                var selectedEntree = _mapper.Map<SelectedEntree>(selectedEntreeDTO);
                await _unitOfWork.SelectedEntrees.Insert(selectedEntree);
                await _unitOfWork.Save();
                return Ok();
            }

            return Ok();
        }

        [Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveItemFromCart(int id)
        {
            if(id < 1)
            {
                return BadRequest();
            }

            CartItem cartItem = await _unitOfWork.CartItems.Get(q => q.ID == id);
            if (cartItem == null)
            {
                return BadRequest();
            }

            await _unitOfWork.CartItems.Delete(id);
            await _unitOfWork.Save();
            return NoContent();
        }



        private string GetCurrentUserID()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var idClaim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = idClaim.Value;

            return userId;
        }
    }
}
