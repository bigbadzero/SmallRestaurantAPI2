using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public class CartController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public CartController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper, UserManager<ApiUser> userManager)
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
            var carts = await _unitOfWork.Carts.GetAll(q => q.UserID == userID);
            return Ok();
        }


        [Authorize]
        [HttpPost(Name = "AddItemToCart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddItemToCart([FromBody] EntreeDTO entreeDTO =null)
        {
            if(entreeDTO != null)
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid Post attempt in {nameof(AddItemToCart)}");
                    return BadRequest(ModelState);
                }

                var entree = _mapper.Map<Entree>(entreeDTO);
                var userID = GetCurrentUserID();

                var cart = new Cart()
                {
                    UserID = userID,
                    EntreeID = entree.ID
                };

                await _unitOfWork.Carts.Insert(cart);
                await _unitOfWork.Save();
                return Ok();
            }

            return Ok();
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
