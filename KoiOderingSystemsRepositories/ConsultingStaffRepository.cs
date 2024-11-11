namespace KoiOderingSystemsRepositories
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
    public class ConsultingstaffRepository : IConsultingstaffRepository
    {
        private readonly KoiOderingFarmDbContext _dpContext;
        public ConsultingstaffRepository(KoiOderingFarmDbContext dbContext)
        {
            _dpContext = dbContext;
        }
        public async Task<List<Consultingstaff>> GetAllConsultingstaff()
        {
            return await _dpContext.Consultingstaff.TolistAsync();
        }
    }
}



