using CRMApp7.Models.ECommerce;

namespace CRMApp7.ECommerce
{
    public interface IECommerceService
    {
        Task<List<RevenueType>> GetRevenueList();
    }
}
