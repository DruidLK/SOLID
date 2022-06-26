using SOLID.Interface_Segragation_Principle.After.Contracts;

namespace SOLID.Interface_Segragation_Principle.After
{
    public sealed class Customer : ICustomer
    {
        //The code is correct because the generic interface has been split
        //into specific interfaces.The classes do not implement methods that are
        //not part of your business logic.

        //the Interface Segregation Principle says that many specific interfaces
        //are better than a single interface.
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        public void ChangeId(int Id) =>
            this.Id = Id;

        public void ChangeName(string Name) =>
            this.Name = Name;

        public void ChangeAddress(string Address) =>
            this.Address = Address;
    }
}
