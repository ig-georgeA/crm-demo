using CRMApp7.Models.Northwind;

namespace CRMApp7.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>> GetCustomers();
    }
}
