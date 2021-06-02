using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmallRestaurantAPI.DTOs;
using SmallRestaurantAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntreeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;

        public EntreeController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEntrees()
        {
            var entrees = await _unitOfWork.Entrees.GetAll();
            var results = _mapper.Map<IList<InitialEntreeDTO>>(entrees);
            return Ok(results);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id:int}", Name = "GetEntree")]
        public async Task<IActionResult> GetEntree(int id)
        {
            try
            {
                var entree = await _unitOfWork.Entrees.GetInclude(q => q.ID == id, include: q => q.Include(x => x.EntreeBaseIngredients).ThenInclude(x => x.Ingredient));
                var results = _mapper.Map<EntreeOptionsDTO>(entree);
                return Ok(results);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            
            return Ok();
        }
    }
}
