namespace SOLID.Liskov_Substitution_Principle.After
{
    public sealed class Cat : Animal
    {
        public Cat()
            : base(Name: nameof(Cat))
        { }

        public override void Eat() =>
            System.Console.WriteLine("Eat Cat Food.");
    }
}
