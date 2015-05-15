#region using
using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Geekees.Common.Controls;
using Geekees.Common.Utilities;

using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

#endregion

namespace Bay.ERP.Web.UI
{
    public partial class ASSMTreeViewEditNodeHandlerPage : BasePage
	{
        public override string UniqueKey
        {
            get
            {
                return "ASSMTreeViewEditNodeHandlerPage";
            }
        }

		ASTreeViewAjaxReturnCode returnCode;
		string errorMessage = string.Empty;

		const string CUS_RETURN_CODE_OK = "0";
		const string CUS_RETURN_CODE_ERROR = "1";
		string cusReturnCode = "0";
		string cusMessage = "Edit Succeed!";

		public string NodeValue
		{
			get
			{
				return HttpUtility.UrlDecode( Request.QueryString["nodeValue"] );
			}
		}

		public string NewNodeText
		{
			get
			{
				return HttpUtility.UrlDecode( Request.QueryString["newNodeText"] );
			}
		}


		protected void Page_Load( object sender, EventArgs e )
		{
			if( string.IsNullOrEmpty( this.NodeValue ) || string.IsNullOrEmpty( this.NewNodeText ) )
			{
				returnCode = ASTreeViewAjaxReturnCode.ERROR;
				return;
			}

			try
			{
				Int64 aSSiteMapNodeID = Int64.Parse(this.NodeValue);

                this.RenameNode(aSSiteMapNodeID, this.NewNodeText);
			}
			catch( Exception ex )
			{
				this.returnCode = ASTreeViewAjaxReturnCode.ERROR;
				this.errorMessage = ex.Message;
			}
		}

		protected override void Render( HtmlTextWriter writer )
		{
			if( this.returnCode == ASTreeViewAjaxReturnCode.OK )
				writer.Write( ( (int)this.returnCode ).ToString() + "|" + this.cusReturnCode + "|" + this.cusMessage );
			else
				writer.Write( this.errorMessage );
		}

		protected void RenameNode(Int64 aSSiteMapNodeID, String newNodeText)
		{
            ASSiteMapNodeEntity ent = FCCASSiteMapNode.GetFacadeCreate().GetByID(aSSiteMapNodeID);

            ent.MenuTitle = newNodeText;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeID.ToString(), SQLMatchType.Equal);

            FCCASSiteMapNode.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
		}
	}
}
