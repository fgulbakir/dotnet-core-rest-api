using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetcore_rest_api.Contracts;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace dotnetcore_rest_api.Business
{
    public interface IProductBusiness
    {
        ProductResponse Get(int id);
        ProductResponse Get();
        int Add(ProductRequest request);
    }
}
