namespace SOLID.Dependency_Inversion_Principle.After
{
    public sealed class Customer
    {
        //The Dependency Inversion Principle says to depend on abstraction, not implementation.
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
