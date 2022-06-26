using SOLID.Interface_Segragation_Principle.After.Base;

namespace SOLID.Interface_Segragation_Principle.After.Contracts
{
    public interface ICustomer : IBase
    {
        void ChangeName(string Name);
        void ChangeAddress(string Address);
    }
}
