using System.Configuration;


namespace Bay.ERP.DataAccess.Configuration
{
    internal static class Settings
    {
        public static TypeInfo TypeInfo
        {
            [System.Diagnostics.DebuggerStepThrough()]
            get
            {
                return ConfigurationManager.GetSection(ConfigurationSectionHandler.SectionName) as TypeInfo;
            }
        }
    }
}