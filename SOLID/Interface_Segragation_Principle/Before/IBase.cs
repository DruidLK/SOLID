namespace SOLID.Interface_Segragation_Principle.Before
{
    public interface IBase
    {
        void ChangeDescription(string Description);
        void ChangeId(int Id);
        void ChangePrice(decimal Price);
        void ChangeAddress(string Address);
        void ChangeName(string Name);
    }
}