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
    public class AccountRepository : IAccountRepository
    {
        private readonly KoiOrderingFarmDbContext _dbContext;
       public AccountRepository(KoiOrderingFarmDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<Account>> GetAllAccount()
        {
            return await _dbContext.Accounts.ToListAsync();
        }
    }
}
