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
    public class PicturesController : ControllerBase
    {
        private readonly IPictureInfoService _pictureInfoService;

        public PicturesController(IPictureInfoService pictureInfoService)
        {
            _pictureInfoService = pictureInfoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_pictureInfoService.GetAllPictures());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => Ok(_pictureInfoService.GetPictureInfoById(id));
    }
}
