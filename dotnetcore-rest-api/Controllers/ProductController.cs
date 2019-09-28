using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetcore_rest_api.Business;
using dotnetcore_rest_api.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_rest_api.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;

        }

        [HttpGet("{id}")]
        public ProductResponse Get(int id)
        {

            return _productBusiness.Get(id);
        }
        [HttpGet]
        public ProductResponse Get()
        {
            return _productBusiness.Get();

        }
        [ProducesResponseType(201)]
        [HttpPost]
        public int Post([FromBody] ProductRequest request)
        {

            return _productBusiness.Add(request);

        }


    }
}
