using System.Diagnostics;

namespace Bay.ERP.DataAccess.Configuration
{
    internal sealed class TypeInfo
	{
        private string _typeName;
        private string _assemblyName;

		public string TypeName
		{
            [DebuggerStepThrough()]
            get
            {
                return _typeName;
            }
		}

        public string AssemblyName
        {
            [DebuggerStepThrough()]
            get
            {
                return _assemblyName;
            }
        }

		public TypeInfo(string typeName,
		string assemblyName)
		{
			_typeName = typeName;
            _assemblyName = assemblyName;
		}
	}
}