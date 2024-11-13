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
    public class TourService : IToursService
    {
        private readonly IToursRepository _tourRepository;

        public TourService(IToursRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public async Task<IEnumerable<Tour>> SearchToursAsync(string departureCity, string destinationCity, DateTime departureDate)
        {
            return await _tourRepository.FindToursAsync(departureCity, destinationCity, departureDate);
        }
    }
}
