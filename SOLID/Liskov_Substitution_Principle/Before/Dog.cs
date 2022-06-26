namespace SOLID.Liskov_Substitution_Principle.Before
{
    public class Dog : Cat
    {
        //The code is incorrect because the Dog class is inheriting from the Cat 
        //class only because it has similar behaviors.Executing "cat.GetName()" will display "Dog".
        public override string GetName() =>
            nameof(Dog);
    }
}
