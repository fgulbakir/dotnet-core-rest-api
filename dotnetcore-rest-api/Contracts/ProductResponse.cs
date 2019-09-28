using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetcore_rest_api.Models;
using Newtonsoft.Json;

namespace dotnetcore_rest_api.Contracts
{
    public class ProductResponse
    {
        public ProductResponse()
        {
            Products = new List<Product>();
        }
        public List<Product> Products { get; set; }

        /// <summary>
        /// If The response doesnt have any data ,Json doesnt return any response 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

    }
}
