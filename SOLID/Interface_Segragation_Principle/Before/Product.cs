namespace SOLID.Interface_Segragation_Principle.Before
{
    public sealed class Product : IBase
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public void ChangeId(int Id) =>
            this.Id = Id;

        public void ChangePrice(decimal Price) =>
            this.Price = Price;

        public void ChangeDescription(string Description) =>
            this.Description = Description;

        // unecessary stuff wich is bad 
        public void ChangeAddress(string Address) =>
            throw new System.NotImplementedException();

        public void ChangeName(string Name) =>
            throw new System.NotImplementedException();
    }
}
