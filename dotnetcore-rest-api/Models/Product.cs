using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetcore_rest_api.common.BaseTypes;

namespace dotnetcore_rest_api.Models
{
    public class Product : BaseIntEntity
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
