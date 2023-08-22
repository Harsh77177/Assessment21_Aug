using CustomerService1.Model;



namespace CustomerService1
{
    public interface ICustomerService
    {
        Customer AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        int DeleteCustomer(int customerId);

    }
}

