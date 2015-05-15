using System;
using System.Configuration;
using System.Xml;
using Bay.ERP.Common.Helper;


namespace Bay.ERP.DataAccess.Configuration
{
    /*
		<configSections>
			<section
				name="dataAccessFactoryConfiguration"
				type="Bay.ERP.DataAccess.Configuration.ConfigurationSectionHandler, EPMS.IDataAccess, Version=1.0.0.0, Culture=neutral"
			/>
		</configSections>
		
		<dataAccessFactoryConfiguration>
			<dataAccessFactory
				typeName="DataAccess.DataAccessFactory"
				assemblyName="DataAccess, Version=1.0.0.0, Culture=neutral"
			/>
		</dataAccessFactoryConfiguration>
    */


    internal sealed class ConfigurationSectionHandler : IConfigurationSectionHandler
    {
        public const string SectionName = "dataAccessFactoryConfiguration";

        object IConfigurationSectionHandler.Create(object parent,
        object configContext,
        XmlNode section)
        {
            if (section.ChildNodes.Count == 0)
            {
                throw new ConfigurationErrorsException("Please specify the dataAccessFactoryConfiguration.", section);
            }

            string typeName = null;
            string assemblyName = null;

            foreach (XmlNode xndChild in section.ChildNodes)
            {
                if (StringHelper.IsEqual(xndChild.LocalName, "dataAccessFactory"))
                {
                    typeName = GetAttributeValue(xndChild.Attributes["typeName"]);
                    assemblyName = GetAttributeValue(xndChild.Attributes["assemblyName"]);

                    if (!StringHelper.IsBlank(typeName) && !StringHelper.IsBlank(assemblyName))
                    {
                        break;
                    }
                }
            }

            if (StringHelper.IsBlank(typeName) || StringHelper.IsBlank(assemblyName))
            {
                throw new ConfigurationErrorsException("Please specify the data access factory.", section);
            }

            return new TypeInfo(typeName, assemblyName);
        }

        [System.Diagnostics.DebuggerStepThrough()]
        private static string GetAttributeValue(XmlNode attribute)
        {
            try
            {
                return attribute.Value.Trim();
            }
            catch (NullReferenceException)
            {
            }

            return string.Empty;
        }
    }
}