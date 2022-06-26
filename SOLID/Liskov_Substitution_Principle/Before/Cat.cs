namespace SOLID.Liskov_Substitution_Principle.Before
{
    public class Cat
    {
        public virtual string GetName() =>
            nameof(Cat);

        public void Move() { }

        public void Eat() { }
    }
}
