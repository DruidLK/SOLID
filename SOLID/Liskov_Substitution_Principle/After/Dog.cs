namespace SOLID.Liskov_Substitution_Principle.After
{
    public sealed class Dog : Animal
    {
        public Dog()
            : base(Name: nameof(Dog))
        { }

        public override void Eat() =>
            System.Console.WriteLine("Eat Dog Food.");
    }
}
