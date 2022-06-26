namespace SOLID.Dependency_Inversion_Principle.Before
{
    public sealed class CustomerService
    {
        private readonly CustomerRepository customerRepository;
        //The code is incorrect because the CustomerService
        //class depends on the CustomerRepository class and also knows
        //how to instantiate it.
        public CustomerService() =>
            new CustomerRepository(ConnectionString: "ConnectionString");

        public void Add(Customer customer) =>
            this.customerRepository.Add(customer);
    }
}
