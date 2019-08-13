using AcutrackFulfillment.Core.Interfaces;
using AcutrackFulfillment.Core.ReadModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcutrackFulfillment.Infrastructure.Data
{
    public class SqlOrderSearchService : IOrderSearchService
    {
        private readonly AppDbContext _dbContext;

        public SqlOrderSearchService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<OrderSearchResult>> SearchOrdersAsync(string searchTerm)
        {
            var searchparam = new SqlParameter("searchparam", searchTerm);
            var o = await _dbContext.OrderSearchResults.FromSql("SELECT Id as OrderId, 'Firstname' as FirstName FROM dbo.Orders where Id=@searchparam", searchparam)
    .AsNoTracking()
    .ToListAsync();
            return o;
        }
    }
}
