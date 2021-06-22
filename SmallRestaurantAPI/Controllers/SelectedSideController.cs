using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class SelectedSideController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;

        public SelectedSideController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id:int}", Name = "GetSelectedSide")]
        public async Task<IActionResult> GetSelectedSide(int id)
        {
            var selectedSide = await _unitOfWork.SelectedSides.Get(q => q.ID == id, include: q => q.Include(x => x.SelectedSideIngredients));
            var results = _mapper.Map<SelectedSideDTO>(selectedSide);

            return Ok(results);
        }

        [Authorize]
        [HttpPost(Name = "AddSideToCart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddSideToCart([FromBody] SelectedSideDTO selectedSideDTO = null)
        {
            var userID = GetCurrentUserID();
            //checkIfCartExists
            var cartItem = await _unitOfWork.CartItems.Get(q => q.UserID == userID);
            if (cartItem == null)
            {
                cartItem = new CartItem()
                {
                    UserID = userID,
                    CartItemStatusID = 1

                };
                await _unitOfWork.CartItems.Insert(cartItem);
                await _unitOfWork.Save();
            }

            if (selectedSideDTO != null)
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid Post attempt in {nameof(AddSideToCart)}");
                    return BadRequest(ModelState);
                }

                var selectedSide = _mapper.Map<SelectedSide>(selectedSideDTO);
                selectedSide.CartItemID = cartItem.ID;
                await _unitOfWork.SelectedSides.Insert(selectedSide);
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
        public async Task<IActionResult> RemoveSideFromCart(int id)
        {
            if(id < 1)
            {
                return BadRequest();
            }

            var selectedSide = await _unitOfWork.SelectedSides.Get(q => q.ID == id, include: q => q.Include(x => x.SelectedSideIngredients));
            if(selectedSide == null)
            {
                return BadRequest("Submitted Data is Invalid");
            }
            await _unitOfWork.SelectedSides.Delete(id);
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
