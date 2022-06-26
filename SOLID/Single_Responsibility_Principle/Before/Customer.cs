namespace SOLID.Single_Responsibility_Principle.Before
{
    public sealed class Customer
    {
        //The code is incorrect because it has two responsibilities,
        //business rules and database persistence.
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool isActive { get; private set; }

        public void Activate() =>
            this.isActive = true;

        public void Inactivate() =>
            this.isActive = false;

        public void Insert()
        {
            // insert into database
        }

        public void Delete()
        {
            // delete from database
        }

    }
}
