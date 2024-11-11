using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;

namespace KoiOderingSystemsRepositories.Interfaces
{
    public interface IConsultingstaffRepository
    {
        Task<List<Consultingstaff>> GetAllConsultingstaff();

    }
}
