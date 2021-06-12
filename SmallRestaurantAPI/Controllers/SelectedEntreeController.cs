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
    public class SelectedEntreeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public SelectedEntreeController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper, UserManager<ApiUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }



        [HttpGet("{id:int}", Name = "GetSelectedEntree")]
        public async Task<IActionResult> GetSelectedEntree(int id)
        {
            var selectedEntree = await _unitOfWork.SelectedEntrees.Get(q => q.ID == id, include: q => q.Include(x => x.SelectedEntreeIngredients));
            var results = _mapper.Map<SelectedEntreeDTO>(selectedEntree);

            return Ok(results);
        }

        [Authorize]
        [HttpPost(Name = "AddEntreeToCart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddEntreeToCart([FromBody] SelectedEntreeDTO selectedEntreeDTO = null)
        {
            var userID = GetCurrentUserID();
            //checkIfCartExists
            var cartItem = await _unitOfWork.CartItems.Get(q => q.UserID == userID);
            if (cartItem == null)
            {
                cartItem = new CartItem()
                {
                    UserID = userID
                };
                await _unitOfWork.CartItems.Insert(cartItem);
                await _unitOfWork.Save();
            }

            if (selectedEntreeDTO != null)
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
        public async Task<IActionResult> RemoveEntreeFromCart(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }

            var SelectedEntree = await _unitOfWork.SelectedEntrees.Get(q => q.ID == id, include: q => q.Include(x => x.SelectedEntreeIngredients));
            if (SelectedEntree == null)
            {
                return BadRequest("Submitted Data is Invalid");
            }
            await _unitOfWork.SelectedEntrees.Delete(id);
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
