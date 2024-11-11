using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices.Services
{
    public class ConsultingStaffServices : IConsultingStaffServices
    {
        private readonly IConsultingstaffRepository _repository;
        public ConsultingStaffServices(IConsultingstaffRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Consultingstaff>> Consultingstaffs()
        {
            return _repository.GetAllConsultingstaff();
        }
    }
}
