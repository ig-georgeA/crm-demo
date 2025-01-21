using CRMApp7.Models.ECommerce;

namespace CRMApp7.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<RevenueType>> GetRevenueList()
        {
            return Task.FromResult<List<RevenueType>>(new());
        }
    }
}
