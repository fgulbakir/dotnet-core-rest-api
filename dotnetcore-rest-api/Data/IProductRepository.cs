using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetcore_rest_api.Contracts;
using dotnetcore_rest_api.Models;

namespace dotnetcore_rest_api.Data
{
    public interface IProductRepository
    {

        IEnumerable<Product> Get();
        Product Get(int id);
        int Add(Product request);



    }
}
