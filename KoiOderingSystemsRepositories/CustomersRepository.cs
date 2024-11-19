using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsRepositories.Entities;
using Microsoft.EntityFrameworkCore;

public class CustomersRepository : IAccountRepository
{
    private readonly KoiOrderingFarmDbContext _context;

<<<<<<< HEAD
        public CustomersRepository(KoiOrderingFarmDbContext dpContext)
        {
            _dpContext = dpContext;
        }
        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _dpContext.Customers.ToListAsync();
        }
        public async Task AddCustomer(Customer customer)
        {
            await _dpContext.Customers.AddAsync(customer);
            await _dpContext.SaveChangesAsync();
        }
        public async Task<Customer?> GetCustomerByUsername(string username)
        {
            return await _dpContext.Customers.FirstOrDefaultAsync(c => c.Username == username);
        }

=======
    public CustomersRepository(KoiOrderingFarmDbContext context)
    {
        _context = context;
    }

    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    public Task<List<Account>> GetAllAccount()
    {
        throw new NotImplementedException();
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return await _context.Customers.FindAsync(id);
>>>>>>> b8788f25a8611fcba17269a1e22778d1b371024b
    }

}

