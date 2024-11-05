using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;

namespace KoiOderingSystemsServices.Interfaces
{
    public interface IAccountServices
    {
        Task<List<Account>> Account();
    }
}
