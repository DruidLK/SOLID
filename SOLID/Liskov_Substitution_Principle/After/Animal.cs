namespace SOLID.Liskov_Substitution_Principle.After
{
    //The Liskov Substitution Principle says that derived classes must
    //be substitutable for their base classes.
    public abstract class Animal
    {
        //The code is correct because the Cat and Dog classes can be replaced
        //by the Animal class without having unexpected behaviors.
        protected string Name { get; }
        public abstract void Eat();

        public Animal(string Name) =>
            this.Name = Name;
    }
}
