using System.ComponentModel.DataAnnotations;

public class CustomerCoupon
{   [Key]
    public int couponId{get;set;}
    public int customerId{get;set;}
    public string? couponCode{get;set;}
    public DateTime validity{get;set;}
    public double? couponValue{get;set;}
    public int couponStatus{get;set;} = 1;

    
}