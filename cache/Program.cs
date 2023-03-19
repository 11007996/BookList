using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
//using System.Web.Caching;

namespace cache
{
  class Program
  {
    static void Main(string[] args)
    {
    }


    public class CacheHelper
    {
      public static object GetCache(string cacheKey)
      {
        var objCache = HttpRuntime.Cache.Get(cacheKey);
        return objCache;
      }
      public static void SetCache(string cacheKey, object objobject)
      {
        var objCache = HttpRuntime.Cache;
        objCache.Insert(cacheKey, objobject);
      }
    public static void SetCache(string cacheKey, object objobject, int timeout = 7200)
      {
        try
        {
          if (objobject == null) return;
          var objCache = HttpRuntime.Cache;
          objCache.Insert(cacheKey, objobject, null, DateTime.Now.AddSeconds(timeout), TimeSpan.Zero, CacheItemPriority.High, null);
        }  
        catch (Exception)
        {
          //throw;
        }
      }
      public static void RemoveAllCache(string cacheKey)
      {
        var cache = HttpRuntime.Cache;
        cache.Remove(cacheKey);
      }
      public static void RemoveAllCache()
      {
        var cache = HttpRuntime.Cache;
        var cacheEnum = cache.GetEnumerator();
        while (cacheEnum.MoveNext())
        {
          cache.Remove(cacheEnum.Key.Tostring());
        }
      }
    }
    public IEnumerable<CompanyModel> FindCompanys()
    {
      var cache = CacheHelper.GetCache("commonData_Company";
      if (cache == null)
      {
        var queryCompany = _base.CompanyModel();
        var enumerable = queryComany.Tolist();
        CacheHelper.SetCache("commonData_Company", enumerable);
        return enumerable;
      }
      var result = (List<CompanyModel>)cache;
      return result;
    }
  }
}
