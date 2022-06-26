using SOLID.Interface_Segragation_Principle.After.Base;

namespace SOLID.Interface_Segragation_Principle.After.Contracts
{
    public interface IProduct : IBase
    {
        void ChangePrice(decimal Price);
        void ChangeDescripion(string Description);
    }
}