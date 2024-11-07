using KoiOderingSystemsRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices.Interfaces
{
    public interface IDeliveringStaffServices
    {
        Task<List<Deliveringstaff>> DeliveringStaff();
    }
}
