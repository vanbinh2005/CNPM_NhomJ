using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;

namespace KoiOderingSystemsRepositories.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int productId);
        Task<List<Product>> GetAllProducts();
    }

}
