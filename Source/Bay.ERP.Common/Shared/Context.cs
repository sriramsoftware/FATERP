using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Bay.ERP.Common.Shared
{
    public sealed class Context : IDisposable
    {
        private Dictionary<string, IDisposable> _pool = new Dictionary<string, IDisposable>(4, StringComparer.InvariantCultureIgnoreCase);

        public IDisposable this[string key]
        {
            [DebuggerStepThrough()]
            get
            {
                if (Contains(key))
                {
                    return _pool[key];
                }

                return null;
            }
            [DebuggerStepThrough()]
            set
            {
                if (value == null)
                {
                    IDisposable resource = this[key];

                    if (resource != null)
                    {
                        resource.Dispose();
                    }

                    _pool.Remove(key);
                }
                else
                {
                    _pool[key] = value;
                }
            }
        }

        public IDisposable this[Type resourceType]
        {
            [DebuggerStepThrough()]
            get
            {
                string fullName = resourceType.FullName;

                IDisposable resource = this[fullName];

                if (resource != null)
                {
                    return resource;
                }

                resource = (IDisposable)Activator.CreateInstance(resourceType, new object[] { this });

                this[fullName] = resource;

                return resource;
            }
        }

        public Context()
        {
        }

        [DebuggerStepThrough()]
        public void Dispose()
        {
            foreach (IDisposable resource in _pool.Values)
            {
                resource.Dispose();
            }

            _pool.Clear();
        }

        [DebuggerStepThrough()]
        public bool Contains(string key)
        {
            return _pool.ContainsKey(key);
        }

        [DebuggerStepThrough()]
        public void Clear()
        {
            _pool.Clear();
        }
    }
}