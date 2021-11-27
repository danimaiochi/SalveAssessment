using System.Collections.Generic;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Helpers
{
    public static class CsvHelper
    {
        public static List<T> Parse<T>(string[] csv) where T : ISalveEntity, new () {
            var list = new List<T>();
            foreach (var s in csv.Skip(1))
            {
                var entity = new T();
                entity.Parse<T>(s);
                list.Add(entity);
            }

            return list;
        }

    }
}