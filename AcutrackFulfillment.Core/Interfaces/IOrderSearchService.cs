using AcutrackFulfillment.Core.ReadModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AcutrackFulfillment.Core.Interfaces
{
   public interface IOrderSearchService
    {
        Task<IEnumerable<OrderSearchResult>> SearchOrdersAsync(String searchTerm);
    }
}
