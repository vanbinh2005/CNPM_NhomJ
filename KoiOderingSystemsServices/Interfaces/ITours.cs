using KoiOderingSystemsRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices.Interfaces
{
    public interface IToursService
    {
        Task<IEnumerable<Tour>> SearchToursAsync(string departureCity, string destinationCity, DateTime departureDate);
    }
}
