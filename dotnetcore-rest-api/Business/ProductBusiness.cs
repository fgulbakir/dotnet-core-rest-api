using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using dotnetcore_rest_api.Contracts;
using dotnetcore_rest_api.Data;
using dotnetcore_rest_api.Models;

namespace dotnetcore_rest_api.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;
        public ProductBusiness(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public int Add(ProductRequest request)
        {
            var product = new Product();
            product.CategoryId = request.CategoryId;
            product.Description = request.Description;
            product.Name = request.Name;
            product.Price = request.Price;

            return _productRepository.Add(product);


        }

        public ProductResponse Get(int id)
        {
            var response = new ProductResponse();

            var product = _productRepository.Get(id);
            if (product == null)
            {
                response.Message = "Product not found";
            }
            else
            {
                response.Products.Add(product);

            }

            return response;
        }

        public ProductResponse Get()
        {
            var response = new ProductResponse();

            IEnumerable<Product> products = _productRepository.Get();

            if (!products.Any())
            {
                response.Message = "Product not found";
            }
            else
            {
                response.Products.AddRange(products);
            }

            return response;


        }
    }
}
