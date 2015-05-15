using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bay.ERP.Common.BusinessEntity
{
    [Serializable]
    public class ScheduleJSON
    {
        #region Properties

        public Int64 id;
        public String title;
        public Int64 start;
        public Int64 end;
        public Boolean allDay;
        public String url;
        public String className;
        public Boolean editable;
        public String source;
        public String color;
        public String backgroundColor;
        public String borderColor;
        
        public String textColor;
        
        #endregion

        #region Constructor

        public ScheduleJSON()
        {
            this.id = 0;
            this.title = "Title";
            //this.start = String.Empty;
            //this.end = String.Empty;
            this.allDay = false;
            this.url = String.Empty;
            this.className = String.Empty;
            this.editable = true;
            this.source = String.Empty;
            this.color = "#FFFFFF";
            this.backgroundColor = "Green";
            this.borderColor = "Green";
            this.textColor = "#FFFFFF";
        }
        
        #endregion
    }
}