using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PictureShopService.Contracts.Interface;

namespace KataPictureShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;

        public UsersController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_userInfoService.GetAllUsers());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => Ok(_userInfoService.GetUserInfoById(id));
    }
}
