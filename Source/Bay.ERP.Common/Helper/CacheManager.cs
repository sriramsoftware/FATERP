using Microsoft.Practices.EnterpriseLibrary.Caching;


namespace Bay.ERP.Common.Helper
{
    public static class CacheManager
    {
        #region Static Variables

        private static readonly Microsoft.Practices.EnterpriseLibrary.Caching.CacheManager _cache = CacheFactory.GetCacheManager();

        #endregion

        #region Methods

        public static void Clear()
        {
            _cache.Flush();
        }

        public static bool Contains(string key)
        {
            return _cache.Contains(key);
        }

        public static T Get<T>(string key) where T : class
        {
            if (!_cache.Contains(key))
            {
                return null;
            }

            return _cache.GetData(key) as T;
        }

        public static void Set<T>(string key,
        T value)
        {
            if (_cache.Contains(key))
            {
                _cache.Remove(key);
            }

            if (value != null)
            {
                _cache.Add(key, value);
            }
        }

        #endregion
    }
}