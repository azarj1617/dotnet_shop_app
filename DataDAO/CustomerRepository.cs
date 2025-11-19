using shopping_app.Data;
using shopping_app.Interfaces;

public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            return _db.Customers.ToList();
        }

        public CustomerModel? GetById(int id)
        {
            return _db.Customers.FirstOrDefault(c => c.customerId == id);
        }

        public CustomerModel Add(CustomerModel customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return customer;
        }

        public CustomerModel Update(CustomerModel customer)
        {
            _db.Customers.Update(customer);
            _db.SaveChanges();
            return customer;
        }

        public void Delete(int id)
        {
            var data = _db.Customers.FirstOrDefault(c => c.customerId == id);
            if (data != null)
            {
                _db.Customers.Remove(data);
                _db.SaveChanges();
            }
        }
    }