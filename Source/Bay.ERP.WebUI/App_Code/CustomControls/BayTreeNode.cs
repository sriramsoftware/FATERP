using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:BayTreeNode runat=server></{0}:BayTreeNode>")]
    public class BayTreeNode : TreeNode
    {
        private String _NodeType;

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string NodeType
        {
            get
            {
                return _NodeType;
            }

            set
            {
                _NodeType = value;
            }
        }       
    }
}