using shopping_app.Models;
namespace shopping_app.Interfaces
{    public interface ICustomerRepository
    {
        IEnumerable<CustomerModel> GetAll();
        CustomerModel? GetById(int id);
        CustomerModel Add(CustomerModel customer);
        CustomerModel Update(CustomerModel customer);
        void Delete(int id);
    }
}
