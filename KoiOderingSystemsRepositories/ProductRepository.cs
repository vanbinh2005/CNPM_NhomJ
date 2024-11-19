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
        private readonly KoiOrderingFarmDbContext _context;

        public ProductRepository(KoiOrderingFarmDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.Id == productId);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }

}
