using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road
{
    public static class Extension
    {
        public static void SaveObject<T>(this ISession session, string key,  T obj)
        {
            var str = JsonConvert.SerializeObject(obj);
            session.SetString(key, str);
        }

        public static T ReadObject<T>(this ISession session, string key)
        {
            var s = session.GetString(key);
            return JsonConvert.DeserializeObject<T>(s);
        }
    }
}
