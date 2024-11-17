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
    }
}


