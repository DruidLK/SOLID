using SOLID.Interface_Segragation_Principle.After.Contracts;

namespace SOLID.Interface_Segragation_Principle.After
{
    public sealed class Product : IProduct
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public void ChangeId(int Id) =>
            this.Id = Id;

        public void ChangeDescripion(string Description) =>
            this.Description = Description;

        public void ChangePrice(decimal Price) =>
            this.Price = Price;
    }
}
