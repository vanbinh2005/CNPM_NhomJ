using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;

namespace KoiOderingSystemsServices 
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _repository;
        public AccountServices(IAccountRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Account>> Account()
        {
           return _repository.GetAllAccount();
        }
    }
}
