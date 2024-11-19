<<<<<<< HEAD
﻿using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;
using KoiOderingSystemsServices.Interfaces.KoiOderingSystemsServices.Interfaces;
using System.Linq;
=======
using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsServices.Interfaces;
using Microsoft.EntityFrameworkCore;
>>>>>>> b8788f25a8611fcba17269a1e22778d1b371024b
using System.Threading.Tasks;

namespace KoiOrderingFarm.Services
{
    public class CustomerService : ICustomerServices
    {
<<<<<<< HEAD
        private readonly ICustomerRepository _repository;

        public CustomerServices(ICustomerRepository repository)
=======
        private readonly KoiOrderingFarmDbContext _context;

        public CustomerService(KoiOrderingFarmDbContext context)
>>>>>>> b8788f25a8611fcba17269a1e22778d1b371024b
        {
            _context = context;
        }

<<<<<<< HEAD
        public async Task<Customer?> AuthenticateCustomer(string username, string password)
        {
            // Giả định rằng trong thực tế, bạn có logic mã hóa mật khẩu
            var customers = await _repository.GetAllCustomer();
            return customers.FirstOrDefault(c => c.Username == username && c.Password == password);
        }

        public async Task<bool> RegisterCustomer(Customer customer)
        {
            var customers = await _repository.GetAllCustomer();
            if (customers.Any(c => c.Username == customer.Username))
            {
                return false; // Username already exists
            }

            // Thêm logic lưu Customer mới vào database
            // Cần thêm phương thức trong ICustomerRepository để lưu Customer
            return true;
=======
        // Register customer method
        public async Task<bool> RegisterCustomerAsync(CustomerRegisterRequest request)
        {
            // Kiểm tra email có trùng không
            var existingCustomer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == request.Email);

            if (existingCustomer != null)
            {
                return false; // Email đã tồn tại
            }

            // Tạo đối tượng Customer mới và thêm vào cơ sở dữ liệu
            var customer = new Customer
            {
                Fullname = request.Fullname,
                Email = request.Email,
                Password = request.Password, // Bạn cần mã hóa mật khẩu trước khi lưu vào DB
                Phone = request.Phone,
                Address = request.Address
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return true;
        }

        // Get customers method implementation
        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
>>>>>>> b8788f25a8611fcba17269a1e22778d1b371024b
        }
    }
}
