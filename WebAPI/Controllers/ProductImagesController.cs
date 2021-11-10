using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {

        IProductImageService _productImageService;

        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        //, IFormFile formFile
        [HttpPost("add")]
        public IActionResult Add([FromForm] ProductImageDto productImageDto)
        {

            ProductImage image = new ProductImage();
            if (productImageDto.ImageFileName != null)
            {
                var extension = Path.GetExtension(productImageDto.ImageFileName.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var placeToSave = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", newImageName);
                using (var stream = new FileStream(placeToSave, FileMode.Create))
                {
                    productImageDto.ImageFileName.CopyTo(stream);

                }
                image.ImagePath = newImageName;
            }
            image.Id = productImageDto.Id;
            image.ProductId = productImageDto.ProductId;
            image.Date = DateTime.Now;

            var result = _productImageService.Add(image);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
