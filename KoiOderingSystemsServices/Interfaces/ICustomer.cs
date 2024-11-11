using KoiOderingSystemsRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices.Interfaces
{

    public interface ICustomerServices
    {
        Task<List<Customer>> Customer();
    }
}
