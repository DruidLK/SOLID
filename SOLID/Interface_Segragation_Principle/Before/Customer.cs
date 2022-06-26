namespace SOLID.Interface_Segragation_Principle.Before
{
    public sealed class Customer : IBase
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        public void ChangeId(int Id) =>
            this.Id = Id;

        public void ChangeName(string Name) =>
            this.Name = Name;

        public void ChangeAddress(string Address) =>
            this.Address = Address;

        // adding unecessary stuff wich is bad
        public void ChangeDescription(string Description) =>
            throw new System.NotImplementedException();

        public void ChangePrice(decimal Price) =>
            throw new System.NotImplementedException();
    }
}
