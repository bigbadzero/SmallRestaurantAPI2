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

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpPost]
        //public async Task<IActionResult> AddItemToCart

        private string GetCurrentUserID()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var idClaim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = idClaim.Value;

            return userId;
        }
    }
}
