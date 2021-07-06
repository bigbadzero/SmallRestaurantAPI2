using AutoMapper;
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
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;

        public MenuController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ViewMenuCategories()
        {
            var categories = await _unitOfWork.Categories.GetAll();
            var results = _mapper.Map<IList<CategoryDTO>>(categories);
            return Ok(results);
        }


        [HttpGet]
        [ActionName("ViewAllMenuCombos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ViewAllMenuCombos()
        {
            var combos = await _unitOfWork.Combos.GetAll( include: q => q
            .Include(x => x.ComboDrinkItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemCategories)
            .Include(x => x.ComboDrinkItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemBaseIngredients).ThenInclude(x => x.Ingredient)
            .Include(x => x.ComboDrinkItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemAvailableAddons).ThenInclude(x => x.Ingredient)
            .Include(x => x.ComboDrinkItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemSizes)

            .Include(x => x.ComboSideItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemCategories)
            .Include(x => x.ComboSideItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemBaseIngredients).ThenInclude(x => x.Ingredient)
            .Include(x => x.ComboSideItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemAvailableAddons).ThenInclude(x => x.Ingredient)
            .Include(x => x.ComboSideItems).ThenInclude(x => x.Item).ThenInclude(x => x.ItemSizes)
            );
            
            var results = _mapper.Map<IList<InitialComboDTO>>(combos);
            return Ok(results);
        }


        [HttpGet("id:int")]
        [ActionName("ViewMenuByType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ViewMenuByType(int id)
        {
            if(id <1 )
            {
                _logger.LogError($"Invalid id {nameof(ViewMenuByType)}");
                return BadRequest("Invalid id");
            }

            var itemsByType = await _unitOfWork.Items.GetAll(q => q.TypeID == id, include: q => q
            .Include(x => x.ItemCategories).ThenInclude(x => x.Category)
            .Include(x => x.ItemBaseIngredients).ThenInclude(x => x.Ingredient)
            .Include(x => x.ItemAvailableAddons).ThenInclude(x => x.Ingredient)
            .Include(x => x.ItemSizes).ThenInclude(x => x.Size));

            var result = _mapper.Map<IList<MenuItemDTO>>(itemsByType);
            return Ok(result);

        }


        [HttpGet("id:int")]
        [ActionName("ViewMenuByCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ViewMenuByCategory(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid id {nameof(ViewMenuByCategory)}");
                return BadRequest("Invalid id");
            }

            var items = await _unitOfWork.Items.GetAll(q => q.ItemCategories.Any(x => x.CategoryID == id), include: q => q
            .Include(x => x.ItemCategories).ThenInclude(x => x.Category)
            .Include(x => x.ItemBaseIngredients).ThenInclude(x => x.Ingredient)
            .Include(x => x.ItemAvailableAddons).ThenInclude(x => x.Ingredient)
            .Include(x => x.ItemSizes).ThenInclude(x => x.Size));

            var result = _mapper.Map<IList<MenuItemDTO>>(items);
            return Ok(result);
        }


        [HttpGet("id:int")]
        [ActionName("ViewMenuItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ViewMenuItem(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid id {nameof(ViewMenuItem)}");
                return BadRequest("Invalid id");
            }

            var item = await _unitOfWork.Items.Get(q => q.ID == id, include: q => q
            .Include(x => x.ItemCategories).ThenInclude(x => x.Category)
            .Include(x => x.ItemBaseIngredients).ThenInclude(x => x.Ingredient)
            .Include(x => x.ItemAvailableAddons).ThenInclude(x => x.Ingredient)
            .Include(x => x.ItemSizes).ThenInclude(x => x.Size));

            var result = _mapper.Map<MenuItemDTO>(item);
            return Ok(result);
        }
    }
}
