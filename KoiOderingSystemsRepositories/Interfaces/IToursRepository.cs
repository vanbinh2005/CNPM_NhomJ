using KoiOderingSystemsRepositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsRepositories.Interfaces
{
    public interface IToursRepository
    {
        Task<Tour> GetTourByIdAsync(int TourId);
        Task<IEnumerable<Tour>> GetAllToursAsync();
        Task<IEnumerable<Tour>> FindToursAsync(string departureCity, string destinationCity, DateTime departureDate);
        Task AddTourAsync(Tour tour);
        Task UpdateTourAsync(Tour tour);
        Task DeleteTourAsync(int TourId);

    }
}
