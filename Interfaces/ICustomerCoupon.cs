namespace shopping_app.Interfaces
{
    public interface ICustomerCoupon
    {
        IEnumerable<CustomerCoupon> GetAllCoupons();
        CustomerCoupon? checkCouponById(int id);

        List<CustomerCoupon> checkByCouponCode(string couponCode);
        bool checkByCustomerandCode(int customerId,string couponCode);
    }
}