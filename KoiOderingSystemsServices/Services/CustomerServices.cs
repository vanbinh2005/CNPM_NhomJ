using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KoiOrderingFarm.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly KoiOrderingFarmDbContext _context;

        public CustomerService(KoiOrderingFarmDbContext context)
        {
            _context = context;
        }

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
        }
    }
}
