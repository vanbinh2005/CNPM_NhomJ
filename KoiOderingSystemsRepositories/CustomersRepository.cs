using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsRepositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace KoiOderingSystemsRepositories
{
    public class CustomersRepository : ICustomerRepository
    {
        private readonly KoiOrderingFarmDbContext _dpContext;

        public CustomersRepository(KoiOrderingFarmDbContext dpContext)
        {
            _dpContext = dpContext;
        }
        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _dpContext.Customers.ToListAsync();
        }
    }
}


