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
    public class ConsultingStaffRepository : IConsultingStaffRepository
    {
        private readonly KoiOrderingFarmDbContext _dpContext;

        public ConsultingStaffRepository(KoiOrderingFarmDbContext dpContext)
        {
            _dpContext = dpContext;
        }
        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _dpContext.Customers.ToListAsync();
        }
    }
}



