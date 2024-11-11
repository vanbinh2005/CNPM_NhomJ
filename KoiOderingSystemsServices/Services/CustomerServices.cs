using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;

namespace KoiOderingSystemsServices
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _repository;
        public CustomerServices(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public Task<List<Customer>> Customer()
        {
            return _repository.GetAllCustomer();
        }
    }
}

