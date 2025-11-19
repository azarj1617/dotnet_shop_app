using Microsoft.AspNetCore.Mvc;
using shopping_app.Interfaces;
[ApiController]
[Route("[controller]")]

public class CustomerController : ControllerBase
{   
    private readonly ICustomerRepository _repo;

    public CustomerController(ICustomerRepository repo)
    {
        _repo = repo;
    }
   [HttpGet("hello")]
    public IActionResult Hello()
    {
        return Content("Hello");
    }
    [HttpGet("getAllCustomers")]
    public IActionResult GetAll()
    {
        var customers = _repo.GetAll();
        return Ok(customers);
    }

    [HttpGet("getCustomerbyId/{id}")]
    public IActionResult GetById(int id)
    {
        var customers = _repo.GetById(id);
        return Ok(customers);
    }

    [HttpPost("addCustomer")]
    public IActionResult addCustomer(CustomerModel customer)
    {
        var customers = _repo.Add(customer);
        return Ok(customers);
    }

    [HttpPost("updateCustomer")]
    public IActionResult updateCustomer(CustomerModel customer)
    {
        var customers = _repo.Update(customer);
        return Ok(customers);
    }

    [HttpDelete("deleteCustomer/{customerId}")]
    public IActionResult deleteCustomer(int customerId)
    {
        _repo.Delete(customerId);
        return Ok("Deleted");
    }
}