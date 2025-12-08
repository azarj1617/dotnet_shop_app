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
        var msg = (customers==1)?"Coupon Available for Given Customer":(customers==3)?"Coupon Already Used":"Coupon Not Available for Given Customer";
        return Ok(msg);
    }
    [HttpPost("updateCoupon/{customerId}/{couponCode}")]
    public IActionResult updateCoupon(int customerId,string couponCode)
    {
        return Ok(_repo.updateCouponStatus(customerId,couponCode));
    }
    
    [HttpPost("createCoupons")]
    public IActionResult createCoupons(CustomerCoupon customerCoupon)
    {
        return Ok(_repo.createCoupons(customerCoupon));
    }
}
