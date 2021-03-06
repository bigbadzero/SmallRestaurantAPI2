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
    public class ComboController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public ComboController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper, UserManager<ApiUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCombos()
        {
            

            var combos = await _unitOfWork.Combos.GetAll();
            var results = _mapper.Map<IList<InitialComboDTO>>(combos);
            return Ok(results);
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpGet("{id:int}", Name = "GetCombo")]
        //public async Task<IActionResult> GetCombo(int id)
        //{
        //    try
        //    {
        //        var combo = await _unitOfWork.Combos.Get(q => q.ID == id, include: q => q
        //        .Include(x => x.Entree).ThenInclude(x => x.EntreeBaseIngredients).ThenInclude(x => x.Ingredient)
        //        .Include(x => x.Entree).ThenInclude(x => x.EntreeAddons).ThenInclude(x => x.Ingredient)
        //        .Include(x => x.Entree).ThenInclude(x => x.EntreeSizes).ThenInclude(x => x.Size));
        //        var result = _mapper.Map<ComboOptionsDTO>(combo);
        //        return Ok(result);
        //    }
        //    catch(Exception ex)
        //    {
        //        _logger.LogError(ex.ToString());
        //    }
        //    return Ok();
        //}
    }
}
