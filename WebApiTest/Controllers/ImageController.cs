using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Controllers
{
    [ApiController]
    public class ImageController:Controller
    {
        IImagesService _service;
        public ImageController(IImagesService service)
        {
            _service = service;
        }
        // POST: ImageController/ConvertImage
        [HttpPost]
        [Route("ConvertImage")]
        public ActionResult ConvertImage( ImagesDTO Images)
        {
            var data = _service.ConvertImage(Images);
            return Ok(data);
        }
    }
}
