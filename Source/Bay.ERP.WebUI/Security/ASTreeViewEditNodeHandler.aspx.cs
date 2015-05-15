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
#endregion

namespace Bay.ERP.Web.UI
{
	public partial class ASTreeViewEditNodeHandlerPage : BasePage
	{
        public override string UniqueKey
        {
            get
            {
                return "ASTreeViewEditNodeHandlerPage";
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
				if( this.NewNodeText.ToLower().IndexOf( "a" ) >= 0 )
				{
					this.cusMessage = "[Server Said]:Node cannot contain the letter 'a'";
					this.cusReturnCode = CUS_RETURN_CODE_ERROR;
				}
				else
				{
					this.RenameNode();
				}
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

		protected void RenameNode()
		{
            //string sql = "UPDATE [Products] SET [ProductName]=@NewName WHERE [ProductID]=@PId";
            //OleDbHelper.ExecuteNonQuery( base.NorthWindConnectionString
            //    , CommandType.Text
            //    , sql
            //    , new OleDbParameter( "@NewName", this.NewNodeText )
            //    , new OleDbParameter( "@PId", this.NodeValue ) );
            ////DataSet ds = OleDbHelper.ExecuteDataset( base.NorthWindConnectionString, CommandType.Text, "select * from [Products]" );

		}
	}
}
