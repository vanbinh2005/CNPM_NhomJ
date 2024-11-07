using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices
{
    public class DeliveringStaffServices : IDeliveringStaffServices
    {
        private readonly IDeliveringStaffRepository _repository;
        public DeliveringStaffServices(IDeliveringStaffRepository repository)
        { 
            _repository = repository;
        }

        public Task<List<Deliveringstaff>> DeliveringStaff()
        {
            return _repository.GetAllDeliveringstaff();
        }
    }
}
