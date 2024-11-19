using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsRepositories
{
    public class DeliveringStaffRepository : IDeliveringStaffRepository
    {
        private readonly KoiOrderingFarmDbContext _dbContext;
        public DeliveringStaffRepository(KoiOrderingFarmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Deliveringstaff>> GetAllDeliveringstaff()
        {
            return await _dbContext.Deliveringstaffs.ToListAsync();
        }
    }
}
