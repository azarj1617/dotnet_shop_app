namespace shopping_app.Interfaces
{
    public interface ICustomerCoupon
    {
        IEnumerable<CustomerCoupon> GetAllCoupons();
        CustomerCoupon? checkCouponById(int id);

        List<CustomerCoupon> checkByCouponCode(string couponCode);
        int checkByCustomerandCode(int customerId,string couponCode);
        string updateCouponStatus(int customerId,string couponCode);
        string createCoupons(CustomerCoupon customerCoupon);
    }
}