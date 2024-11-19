using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsRepositories
{
    public class TourRepository : IToursRepository
    {
        private readonly KoiOrderingFarmDbContext _context;

        public TourRepository(KoiOrderingFarmDbContext context)
        {
            _context = context;
        }

        public async Task<Tour> GetTourByIdAsync(int tourId)
        {
            return await _context.Tours.FindAsync(tourId);
        }

        public async Task<IEnumerable<Tour>> GetAllToursAsync()
        {
            return await _context.Tours.ToListAsync();
        }

        public async Task<IEnumerable<Tour>> FindToursAsync(string departureCity, string destinationCity, DateTime departureDate)
        {
            return await _context.Tours
                .Where(t => t.DepartureCity == departureCity && t.DestinationCity == destinationCity && t.DepartureDate == departureDate)
                .ToListAsync();
        }

        public async Task AddTourAsync(Tour tour)
        {
            await _context.Tours.AddAsync(tour);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTourAsync(Tour tour)
        {
            _context.Tours.Update(tour);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTourAsync(int tourId)
        {
            var tour = await GetTourByIdAsync(tourId);
            if (tour != null)
            {
                _context.Tours.Remove(tour);
                await _context.SaveChangesAsync();
            }

        }
    }
}
