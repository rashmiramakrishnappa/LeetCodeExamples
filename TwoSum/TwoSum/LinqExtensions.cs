using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public static class LinqExtensions
    {
        public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> PivotList<TSource, TFirstKey, TSecondKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TFirstKey>
            firstKeySelector, Func<TSource, TSecondKey> secondKeySelector, Func<IEnumerable<TSource>, TValue> aggregate)
        {
            var retVal = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();
            foreach (var item in source.ToLookup(firstKeySelector))
            {
                var dict = new Dictionary<TSecondKey, TValue>();
                retVal.Add(item.Key, dict);
                foreach (var subitem in item.ToLookup(secondKeySelector))
                {
                    dict.Add(subitem.Key, aggregate(subitem));
                }
            }
            return retVal;
        }
        public static Dictionary<TFirstKey, TSecondKey> PivotColumns<TSource, TFirstKey, TSecondKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TFirstKey>
            firstKeySelector, Func<TSource, TSecondKey> secondKeySelector, Func<IEnumerable<TSource>, TValue> aggregate)
        {
            var retVal = new Dictionary<TFirstKey, TSecondKey>();
            foreach (var item in source.ToLookup(firstKeySelector))
            {
                var dict = new Dictionary<TSecondKey, TValue>();
                foreach (var subitem in item.ToLookup(secondKeySelector))
                {
                    dict.Add(subitem.Key, aggregate(subitem));
                }
                retVal.Add(item.Key, dict.FirstOrDefault().Key);
            }
            return retVal;
        }
    }
}
