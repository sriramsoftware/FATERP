using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public static class ButtonExtension
    {
        public static string GetText(this System.Web.UI.WebControls.Button target)
        {
            return target.Text;
        }

        private static String _UniqueKey;
        public static String UniqueKey 
        {
            get
            {
                return _UniqueKey;
            }
            set
            {
                _UniqueKey = value;
            }
        }
    }
}