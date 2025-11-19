using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class CustomerModel
{
    [Key]
    public int customerId{get;set;}
    public string? customerFname {get;set;}
     public string? customerlname {get;set;}
    public string? mobileNumber {get;set;}
    public string? address {get;set;}
    public string? city {get;set;}
    public string? state {get;set;}
    public DateTime createdOn {get;set;} = DateTime.Now;
   
}