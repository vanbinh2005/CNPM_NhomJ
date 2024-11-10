using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace KoiOderingSystemsRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly KoiOrderingFarmDbContext _dbContext;
        public ProductRepository(KoiOrderingFarmDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
