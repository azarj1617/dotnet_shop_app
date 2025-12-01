using Microsoft.AspNetCore.Mvc;
using shopping_app.Interfaces;
[ApiController]
[Route("[controller]")]
public class CustomerCouponController : ControllerBase
{
    private readonly ICustomerCoupon _repo;
     public CustomerCouponController(ICustomerCoupon repo)
    {
        _repo = repo;
    }

    [HttpGet("coupon")]
    public IActionResult Hello()
    {
        return Content("Hello");
    }

    [HttpGet("getAllCoupons")]
    public IActionResult getAllCoupons()
    {
        var customerCoupons = _repo.GetAllCoupons();
        return Ok(customerCoupons);
    }
    
    [HttpGet("checkCoupon/{customerId}")]
    public IActionResult checkCouponById(int customerId)
    {
        var customers = _repo.checkCouponById(customerId);
        return Ok(customers);
    }
     [HttpGet("checkCouponbyCode/{couponCode}")]
    public IActionResult checkByCouponCode(string couponCode)
    {
        var customers = _repo.checkByCouponCode(couponCode);
        return Ok(customers);
    }

    [HttpGet("checkCouponbyIdCode/{id}/{couponCode}")]
    public IActionResult checkByCustomerandCode(int id, string couponCode)
    {
        var customers = _repo.checkByCustomerandCode(id,couponCode);
        var msg = (customers)?"Coupon Available for Given Customer":"Coupon Not Available for Given Customer";
        return Ok(msg);
    }
}
