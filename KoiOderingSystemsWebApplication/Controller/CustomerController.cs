using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsServices.Interfaces;
using WebApplication.DTOs;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;
using KoiOderingSystemsServices.Interfaces.KoiOderingSystemsServices.Interfaces;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomerServices customerServices) : ControllerBase
{
    private readonly ICustomerServices _customerServices = customerServices;

    public object BCrypt { get; private set; }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var customer = await _customerServices.AuthenticateCustomer(request.Username, request.Password);
        if (customer == null)
        {
            return Unauthorized("Invalid username or password.");
        }

        return Ok(new CustomerDto
        {
            Username = customer.Username,
            Email = customer.Email,
            Phone = customer.Phone
        });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var newCustomer = new Customer
        {
            Username = request.Username,
            Email = request.Email,
            Phone = request.Phone,
          //  Password = BCrypt.Net.BCrypt.HashPassword(request.Password)
        };

        var result = await _customerServices.RegisterCustomer(newCustomer);
        if (!result)
        {
            return BadRequest("Username already exists.");
        }

        return Ok("Registration successful!");
    }
}
