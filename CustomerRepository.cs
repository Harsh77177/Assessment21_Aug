
using CustomerService1;

using CustomerService1.Model;

namespace CustomerService1

{



    public class CustomerRepository : ICustomerService

    {

        static List<Customer> customers = null;

        public CustomerRepository()

        {

            if (customers == null)

            {

                customers = new List<Customer>()

                {

                    new Customer(){CustomerId=1,CustomerName="Raj",CustomerMobile="12345677",CustomerAddress="Delhi"},

                     new Customer(){CustomerId=2,CustomerName="sid",CustomerMobile="1234566777",CustomerAddress="odisha"},

                };

            }

        }

        public Customer AddCustomer(Customer customer)

        {

            customer.CustomerId = customers.Count + 1; // Simulate generating a new ID

            customers.Add(customer);

            return customer;

        }


        public List<Customer> GetAllCustomers()

        {

            return customers;

        }


        public int DeleteCustomer(int customerId)

        {

            customers.RemoveAt(customerId);

            return 1;



        }

    }

}

