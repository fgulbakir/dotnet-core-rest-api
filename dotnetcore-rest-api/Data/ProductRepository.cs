using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using dotnetcore_rest_api.Contracts;
using dotnetcore_rest_api.Models;

namespace dotnetcore_rest_api.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public IDbConnection DbConnection => new SqlConnection(_connectionString);

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public int Add(Product request)
        {

            using (var dbConnection = DbConnection)
            {
                var query = @"Insert into [dbo].[Products]
                            (
                                CategoryId,
                                Name,
                                Description
                                Price
                                CreatedDate
                                Creator
                                ModifiedDate
                                Modifier
                                IsDeleted
                            )
                            Values
                            (
                                @CategoryId,
                                @Name,
                                @Description,
                                @Price,
                                @CreatedDate,
                                @Creator,
                                @ModifiedDate,
                                @Modifier,
                                @IsDeleted

                            )";

                return dbConnection.Execute(query, request);


            }


        }

        public IEnumerable<Product> Get()
        {

            using (var dbConnection = DbConnection)
            {
                var query = @"Select Id,CategoryId,Name,Description,Price
                            from [dbo].[Products]";

                var products = dbConnection.Query<Product>(query);
                return products;
            }
        }

        public Product Get(int id)
        {
            using (var dbConnection = DbConnection)
            {
                var query = @"Select Id,CategoryId,Name,Description,Price
                            from [dbo].[Products]
                            where Id=@Id

                            ";

                var product = dbConnection.QueryFirstOrDefault<Product>(query, new { @Id = id });
                return product;
            }
        }
    }
}
