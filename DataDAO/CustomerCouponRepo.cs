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
    public bool checkByCustomerandCode(int customerId,string couponCode)
    {
        var data =  _db.Customer_Coupons.FirstOrDefault(c => c.couponCode == couponCode && c.customerId==customerId);
        return data?.couponId!=null;
    }
    

}