using KoiOderingSystemsRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KoiOderingSystemsRepositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddCustomer(Customer customer);
        Task<List<Customer>> GetAllCustomer();
<<<<<<< HEAD
        Task<Customer?> GetCustomerByUsername(string username);
=======
        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Customer> GetCustomerByIdAsync(int id);
>>>>>>> b8788f25a8611fcba17269a1e22778d1b371024b
    }
}
