using shopping_app.Data;
using shopping_app.Interfaces;

public class CustomerCoupons : ICustomerCoupon
{   
      private readonly ApplicationDbContext _db;

        public CustomerCoupons(ApplicationDbContext db)
        {
            _db = db;
        }
    public IEnumerable<CustomerCoupon> GetAllCoupons()
    {
        return _db.Customer_Coupons.ToList();
    }    
    public CustomerCoupon? checkCouponById(int id)
    {
        return _db.Customer_Coupons.FirstOrDefault(c => c.customerId == id);
    }

    public List<CustomerCoupon> checkByCouponCode(string couponCode)
    {
        return _db.Customer_Coupons.Where(c => c.couponCode == couponCode).OrderByDescending(c=>c.customerId).ToList();
    }
    public int checkByCustomerandCode(int customerId,string couponCode)
    {
        var data =  _db.Customer_Coupons.FirstOrDefault(c => c.couponCode == couponCode && c.customerId==customerId);
    
        return (int)((data?.couponId!=null)?data?.couponStatus:0);
    }
    
    public string updateCouponStatus(int customerId,string couponCode)
    {
        var value = checkByCustomerandCode(customerId,couponCode);
        if (value==1)
        {
             var list = _db.Customer_Coupons
                  .Where(c => c.customerId == customerId)
                  .ToList();
            foreach (var item in list)
            {
                item.couponStatus = 3;
            }

            _db.SaveChanges();
            return "Updated Successfully";
        }
        else
        {
            if (value == 3)
            {
                return "Coupon Already Used!";
            }
            else
            {
                return "OOPS! Record Not Updated!";   
            }
             
        }
       
    }
    public string createCoupons(CustomerCoupon customerCoupon)
    {
        return "Test";
    }
}