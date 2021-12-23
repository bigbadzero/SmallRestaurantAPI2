using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmallRestaurantAPI.Data;
using SmallRestaurantAPI.DTOs;
using SmallRestaurantAPI.IRepository;
using SmallRestaurantAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<ApiUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;
        private readonly IUnitOfWork _unitOfWork;

        public AccountController(UserManager<ApiUser> userManager, ILogger<AccountController> logger, IMapper mapper, SignInManager<ApiUser> signInManager, IAuthManager authManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
            _signInManager = signInManager;
            _authManager = authManager;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            _logger.LogInformation($"Registration Attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                //inform sender what went wrong
                return BadRequest(ModelState);
            }
            var user = _mapper.Map<ApiUser>(userDTO);
            user.UserName = userDTO.Email;
            var results = await _userManager.CreateAsync(user, userDTO.Password);

            if (!results.Succeeded)
            {
                foreach (var error in results.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _userManager.AddToRolesAsync(user, userDTO.Roles);
            return Accepted();
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO userDTO)
        {
            var timeout = 15;
            _logger.LogInformation($"Login Attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                //inform sender what went wrong
                return BadRequest(ModelState);
            }
            if (!await _authManager.ValidateUser(userDTO))
            {
                return Unauthorized();
            }

            return Accepted(new { Token = await _authManager.CreateToken(), timeout });
        }

        [HttpPost]
        [Route("users")]
        public async Task<IActionResult> GetUserData([FromBody] UserDTO userDTO)
        {
            var user = await _unitOfWork.SelectedApiUsers.Get(q => q.Email == userDTO.Email);
            var results = _mapper.Map<UserDTO>(user);
            return Ok(results);
        }


        [HttpPut]
        [Route("answers")]
        public async Task<IActionResult> SubmitAnswers([FromBody] UserDTO userDTO)
        {
            var user = await _unitOfWork.SelectedApiUsers.Get(q => q.Email == userDTO.Email);
            if (userDTO.Birthday != null)
            {
                user.Birthday = userDTO.Birthday;
            }
            if (userDTO.Question1 != null)
            {
                user.Question1 = userDTO.Question1;
            }
            if (userDTO.Question2 != null)
            {
                user.Question2 = userDTO.Question2;
            }
            if (userDTO.Question3 != null)
            {
                user.Question3 = userDTO.Question3;
            }

             _unitOfWork.SelectedApiUsers.Update(user);
            await _unitOfWork.Save();
            var results = _mapper.Map<UserDTO>(user);
            return Ok(results);
        }
    }
}
