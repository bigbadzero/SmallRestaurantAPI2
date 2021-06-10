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
        public async Task<IActionResult> AddItemToCart([FromBody] SelectedEntreeDTO selectedEntreeDTO =null)
        {
            if(selectedEntreeDTO != null)
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid Post attempt in {nameof(AddItemToCart)}");
                    return BadRequest(ModelState);
                }

                var selectedEntree = _mapper.Map<SelectedEntree>(selectedEntreeDTO);
                selectedEntree.UserId = GetCurrentUserID();
                await _unitOfWork.SelectedEntrees.Insert(selectedEntree);
                await _unitOfWork.Save();
                var insertedEntree = await _unitOfWork.SelectedEntrees.Get(q => q.UserId == selectedEntree.UserId);


                //get individual ingredients to insert into selected ingredients
                var ingredients = _mapper.Map<IList<Ingredient>>(selectedEntreeDTO.SelectedEntreeIngredients);
                foreach (Ingredient ingredient in ingredients)
                {
                    var selectedIngredient = new SelectedIngredient()
                    {
                        IngredientId = ingredient.ID,
                        SelectedEntreeID = insertedEntree.ID
                    };
                    await _unitOfWork.SelectedIngredients.Insert(selectedIngredient);
                    await _unitOfWork.Save();
                }
                var cart = new Cart()
                {
                    UserID = GetCurrentUserID(),
                    SelectedEntreeID = insertedEntree.ID
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
