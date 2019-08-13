using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.Interfaces;
using System.Linq;

namespace AcutrackFulfillment.Infrastructure.Data
{
    public delegate IQueryable<T> QueryMutator<T>(IQueryable<T> item);
    public class SearchFieldMutator<TSearch, TQuery>
    {
        public Predicate<TSearch> Condition { get; set; }
        public QueryMutator<TQuery> Mutator { get; set; }

        /// <summary>
        /// Search Field Mutator construct
        /// </summary>
        /// <param name="condition">Condition to check</param>
        /// <param name="mutator">Expression to run if true</param>
        public SearchFieldMutator(Predicate<TSearch> condition, QueryMutator<TQuery> mutator)
        {
            Condition = condition;
            Mutator = mutator;
        }

        /// <summary>
        /// Applies the mutator to an IQueryable object if Search == true
        /// </summary>
        /// <param name="search">Object to check for conditions</param>
        /// <param name="query">Object to run the expression on</param>
        /// <returns>Result set</returns>
        public IQueryable<TQuery> Apply(TSearch search, IQueryable<TQuery> query)
        {
            return Condition(search) ? Mutator(query) : query;
        }

       
    }
}
