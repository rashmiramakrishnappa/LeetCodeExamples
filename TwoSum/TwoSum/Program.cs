using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    static class Program
    {
        static void Main(string[] args)
        {
            //new TwoSum();
            //new ListNodeTwoNum();
            //new LongestSubString();
            //new MedianOfArray();

            //List<List<string>> PersonInfo = new List<List<string>>()
            //{
            //    new List<string>() { "aa", "Lab Outcome", "cc","test","Weight measure","t23","number","Verb","Lab Outcome","Run test","Verb","Weight measure","Verb"},
            //    new List<string>() {"nv1234","Clinically Significant","test","Test_1","3","test","NULL","Headache","Clinically Significant","NULL","sd","1","head ache"}
            //};
            List<Data> datas = new List<Data>
            {
                new Data { Id = 365, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "aa", FieldId = 1, FieldValue = "nv1234", FieldType = 2, SubjectEventStatus = 3 },
                new Data { Id = 366, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "Lab Outcome", FieldId = 2, FieldValue = "Clinically Significant", FieldType = 2, SubjectEventStatus = 3 },
                new Data { Id = 694, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "cc", FieldId = 4, FieldValue = "test", FieldType = 3, SubjectEventStatus = 3 },
                new Data { Id = 683, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "test", FieldId = 7, FieldValue = "Test_1", FieldType = 3, SubjectEventStatus = 3 },
                new Data { Id = 932, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "Weight measure", FieldId = 27, FieldValue = "3", FieldType = 10, SubjectEventStatus = 3 },
                new Data { Id = 684, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "t23", FieldId = 46, FieldValue = "test", FieldType = 2, SubjectEventStatus = 3 },
                new Data { Id = 695, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "number", FieldId = 179, FieldValue = "NULL", FieldType = 7, SubjectEventStatus = 3 },
                new Data { Id = 846, SubjectEventId = 100, PageId = 1, EventId = 4, Field = "Verb", FieldId = 244, FieldValue = "Headache", FieldType = 16, SubjectEventStatus = 3 },
                new Data { Id = 878, SubjectEventId = 160, PageId = 1, EventId = 4, Field = "Lab Outcome", FieldId = 2, FieldValue = "Clinically Significan", FieldType = 2, SubjectEventStatus = 3 },
                new Data { Id = 879, SubjectEventId = 160, PageId = 1, EventId = 4, Field = "Run test", FieldId = 28, FieldValue = "NULL", FieldType = 6, SubjectEventStatus = 3 },
                new Data { Id = 880, SubjectEventId = 160, PageId = 1, EventId = 4, Field = "Verb", FieldId = 244, FieldValue = "sd", FieldType = 16, SubjectEventStatus = 3 },
                new Data { Id = 936, SubjectEventId = 164, PageId = 1, EventId = 4, Field = "Weight measure", FieldId = 27, FieldValue = "1", FieldType = 10, SubjectEventStatus = 3 },
                new Data { Id = 937, SubjectEventId = 164, PageId = 1, EventId = 4, Field = "Verb", FieldId = 244, FieldValue = "head ache", FieldType = 16, SubjectEventStatus = 3 }
            };
            var result2 = datas.PivotColumns(x => x.Field, y => y.FieldValue, z => z.Sum(a => a.PageId));
        }

        //var headers = datas.Select(x => x.Field).Distinct().ToList();
        //var subArray = datas.Select(i => new { i.Field, i.FieldValue }).Distinct().ToArray();
        //var result1 = subArray.Pivot().ToList();
        //var query = datas
        //            .GroupBy(c => c.Field)
        //            .Select(g => new
        //            {
        //                Field = g.Key,
        //                g.FirstOrDefault(x => x.Field == g.Key).FieldValue
        //            }).ToList();
        //var pivot = datas.ToPivot(x => x.Field, x => x.FieldValue, x => x.Sum(y => y.PageId));

        //var result = datas
        //                    .SelectMany(inner => inner.Select((item, index) => new { item, index }))
        //                    .GroupBy(i => i.index, i => i.item)
        //                    .Select(g => g.ToList())
        //                    .ToList();

        //var result1 = subArray.Pivot().ToList();
    }
    //public static IEnumerable<IEnumerable<T>> Pivot<T>(this IEnumerable<IEnumerable<T>> source)
    //{
    //    var enumerators = source.Select(e => e.GetEnumerator()).ToArray();
    //    try
    //    {
    //        while (enumerators.All(e => e.MoveNext()))
    //        {
    //            yield return enumerators.Select(e => e.Current).ToArray();
    //        }
    //    }
    //    finally
    //    {
    //        Array.ForEach(enumerators, e => e.Dispose());
    //    }
    //}
    public class Data
    {
        public int Id { get; set; }
        public int SubjectEventId { get; set; }
        public int PageId { get; set; }
        public int EventId { get; set; }
        public string Field { get; set; }
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public bool? FieldValueBool { get; set; }
        public DateTime? FieldValueDate { get; set; }
        public decimal? FieldValueDecimal { get; set; }
        public int? FieldValueInt { get; set; }
        public int FieldType { get; set; }
        public int SubjectEventStatus { get; set; }
    }
}