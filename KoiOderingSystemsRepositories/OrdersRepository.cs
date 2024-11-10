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
    public class OrdersRepository : IOrdersRepository
    {
        private readonly KoiOrderingFarmDbContext _dbContext;
        public OrdersRepository(KoiOrderingFarmDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            return await _dbContext.Orders.ToListAsync();
        }
    }
}
