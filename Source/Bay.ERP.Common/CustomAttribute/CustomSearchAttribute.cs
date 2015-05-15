using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomSearchAttribute
/// </summary>

namespace Bay.ERP.Common.CustomAttribute
{

    [System.AttributeUsage(System.AttributeTargets.All, AllowMultiple = false)]
    public class CustomSearchAttribute : System.Attribute
    {
       
        public String Title { get; set; }
        public String Value { get; set; }
        public Boolean AllowSearch { get; set; }
        public String DataType { get; set; }

        public CustomSearchAttribute(String title,String value, Boolean allowSearch, String dataType)
        {
            this.Title = title;
            this.AllowSearch = allowSearch;
            this.Value = value;
            this.DataType = dataType;
        }
    }
}