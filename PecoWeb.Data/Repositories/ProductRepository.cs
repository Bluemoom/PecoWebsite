using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PecoWeb.Data.Infrastructure;
using PecoWeb.Model.Models;

namespace PecoWeb.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
