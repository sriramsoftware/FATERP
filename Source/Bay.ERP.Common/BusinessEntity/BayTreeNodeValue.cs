// Copyright and All Rights Reserved by
// B2B Solution, Bangladesh;
// Code Generate Time - 30-Nov-2011, 01:41:28



using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    public partial class BayTreeNodeValue
    {
        #region Properties
        
        public String Value { get; set; }

        public Dictionary<String, String> Attributes = new Dictionary<string,string>();
        
        #endregion

        #region Constructor

        public BayTreeNodeValue()
            : base()
        {
        }

        #endregion

        #region Methods

        public String GetValueString()
        {
            String strValue = String.Empty;

            strValue = "Value:" + Value;

            foreach (String key in Attributes.Keys)
            {
                strValue += ";" + key + ":" + Attributes[key];
            }

            return strValue;
        }

        public static String GetValue(String strValue)
        {
            String val = String.Empty;

            String[] items = strValue.Split(';');

            if (items.Length > 0)
            {
                val = (items[0].Split(':'))[1];
            }

            return val;
        }

        public void SetValuesFromString(String strValue)
        {
            String[] items = strValue.Split(';');

            if (items.Length > 0)
            {
                Value = (items[0].Split(':'))[1]; 
            }

            if (items.Length > 1)
            {
                Attributes.Clear();

                for (int i = 1; i < items.Length; i++)
                {
                    String[] attItem =  items[i].Split(':');
                    Attributes.Add(attItem[0], attItem[1]); 
                } 
            }
        }
       
        #endregion
    }
}
