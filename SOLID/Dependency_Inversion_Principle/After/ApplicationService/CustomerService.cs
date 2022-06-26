using SOLID.Dependency_Inversion_Principle.After.Domain.Contracts;

namespace SOLID.Dependency_Inversion_Principle.After.ApplicationService
{
    public sealed class CustomerService
    {
        private readonly ICustomerRepository customerRepository;
        //The code is correct because the CustomerService
        //class depends only on the ICustomerRepository interface.
        //It does not know the implementation or how to instantiate it.
        public CustomerService(ICustomerRepository customerRepository) =>
            this.customerRepository = customerRepository;

        public void Add(Customer customer) =>
            this.customerRepository.Add(customer);
    }
}
