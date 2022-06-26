using SOLID.Single_Responsibility_Principle.After.Contracts;

namespace SOLID.Single_Responsibility_Principle.After
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        public void Insert()
        {
            // insert into database
        }

        public void Delete()
        {
            // delete from database
        }
    }
}
