using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AcutrackFulfillment.Infrastructure.Data
{
    /// <summary>
    /// List of SearchFieldMutators
    /// </summary>
    /// <typeparam name="TSearch">Object to perform condition checking on</typeparam>
    /// <typeparam name="TQuery">Object to perform expression on</typeparam>
    public class SearchFieldMutators<TSearch, TQuery> : IEnumerable<SearchFieldMutator<TSearch, TQuery>>
    {
        readonly IList<SearchFieldMutator<TSearch, TQuery>> _inner = new List<SearchFieldMutator<TSearch, TQuery>>();

        /// <summary>
        /// Adds a Search Field Mutator item
        /// </summary>
        /// <param name="condition">Condition to check</param>
        /// <param name="mutator">Expression to run if true</param>
        public void Add(Predicate<TSearch> condition, QueryMutator<TQuery> mutator)
        {
            _inner.Add(new SearchFieldMutator<TSearch, TQuery>(condition, mutator));
        }

        #region Implemented members

        public IEnumerator<SearchFieldMutator<TSearch, TQuery>> GetEnumerator()
        {
            return _inner.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _inner.GetEnumerator();
        }

        #endregion
    }
}
