using CrudwithRepositary.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary.Controllers
{
    
    [Route("api/[controller]")]
    [EnableCors("Alloworigin")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IproductRepository _productRepo;
        public ProductController(IproductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        [Route("getdata")]
        public async Task< IActionResult> Index()
        {
            var products = await _productRepo.GetAll();
            return Ok(products);
        }
        [HttpPost]
        [Route("Addproduct")]
        public async Task<IActionResult>Addproduct([FromBody]product model)
        {
            if(model!=null)
            { 
            await _productRepo.Add(model);
            }
            else
            {
                return Ok("Data Not Saved Successfully");
            }
            return Ok("Prouduct Saved Successfully");
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromForm]product model)
        {
            if(model!=null)
            {

                await _productRepo.Update(model);

            }
            else
            {
                return Ok("Product Not Update");
            }
          
            return Ok("Product Update Successfully");
        }

        [HttpGet]
        [Route("GetProductById")]
        public async Task<IActionResult>GetProductById(int id)
        {
            var result= await _productRepo.GetById(id);
            return Ok(result);
        }
    }
}
