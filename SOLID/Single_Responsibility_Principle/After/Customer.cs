namespace SOLID.Single_Responsibility_Principle.After
{
    public sealed class Customer
    {
        //The code is correct because the responsibilities have been split,
        //    each class has only one reason to change.
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool isActive { get; private set; }

        public void Activate() =>
            this.isActive = true;

        public void Inactivate() =>
            this.isActive = false;
    }
}
