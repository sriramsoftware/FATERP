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
	public partial class ASSMTreeViewLoadNodeHandlerPage : BasePage
	{
        public override string UniqueKey
        {
            get
            {
                return "ASSMTreeViewLoadNodeHandlerPage";
            }
        }

        //protected override void Render(HtmlTextWriter writer)
        //{
        //    if (Request.QueryString["t1"] == "ajaxLoad")
        //    {
        //        string virtualParentKey = Request.QueryString["virtualParentKey"];

        //        string para = string.Empty;// "= 1";
        //        if (virtualParentKey == null)
        //            para = " is NULL";
        //        else
        //            para = "=" + virtualParentKey;

        //        //                string sql = @"SELECT p1.[ProductID] as ProductID, p1.[ProductName] as ProductName, p1.[ParentID] as ParentID, p3.childNodesCount as ChildNodesCount
        //        //FROM [Products] p1
        //        //LEFT OUTER JOIN 
        //        //(
        //        //	SELECT COUNT(*) AS childNodesCount , p2.[ParentID] AS pId 
        //        //	FROM [Products] p2
        //        //	GROUP BY p2.[ParentID]
        //        //) p3
        //        //ON p1.[ProductID] = p3.pId
        //        //WHERE p1.[ParentID] " + para;

        //        //                DataTable dt = OleDbHelper.ExecuteDataset(base.NorthWindConnectionString, CommandType.Text, sql).Tables[0];

        //        ASTreeViewNode root = new ASTreeViewNode("root");

        //        //foreach (DataRow dr in dt.Rows)
        //        //{
        //        //    string productName = dr["ProductName"].ToString();
        //        //    string productId = dr["ProductID"].ToString();
        //        //    string parentId = dr["ParentID"].ToString();
        //        //    int childNodesCount = 0;
        //        //    if (!string.IsNullOrEmpty(dr["ChildNodesCount"].ToString()))
        //        //        childNodesCount = int.Parse(dr["ChildNodesCount"].ToString());

        //        //    ASTreeViewLinkNode node = new ASTreeViewLinkNode(productName, productId);
        //        //    node.VirtualNodesCount = childNodesCount;
        //        //    node.VirtualParentKey = productId;
        //        //    node.IsVirtualNode = childNodesCount > 0;
        //        //    node.NavigateUrl = "#";
        //        //    node.AdditionalAttributes.Add(new KeyValuePair<string, string>("onclick", "return false;"));

        //        //    root.AppendChild(node);
        //        //}


        //        Int64 parentIDTemp = 0;

        //        Int64.TryParse(virtualParentKey, out parentIDTemp);


        //        //AddChildsNodesToDBTree(Int64 parentID, ASTreeViewNode currentNode)
        //        AddChildsNodesToDBTree(parentIDTemp, root);



        //        HtmlGenericControl ulRoot = new HtmlGenericControl("ul");
        //        psTree.TreeViewHelper.ConvertTree(ulRoot, root, false);
        //        foreach (Control c in ulRoot.Controls)
        //            c.RenderControl(writer);
        //    }
        //    else if (Request.QueryString["t2"] == "ajaxAdd")
        //    {
        //        //string addNodeText = Request.QueryString["addNodeText"];
        //        //int parentNodeValue = int.Parse(Request.QueryString["parentNodeValue"]);

        //        //string maxSql = "select max( productId ) from products";
        //        //int max = (int)OleDbHelper.ExecuteScalar(base.NorthWindConnectionString, CommandType.Text, maxSql);
        //        //int newId = max + 1;

        //        //string sql = string.Format(@"INSERT INTO products( productid, Discontinued, productname, parentid ) values( {0} ,0, '{1}', {2})"
        //        //    , max + 1, addNodeText.Replace("'", "''"), parentNodeValue);

        //        //int i = OleDbHelper.ExecuteNonQuery(base.NorthWindConnectionString, CommandType.Text, sql);

        //        //ASTreeViewNode root = new ASTreeViewNode("root");

        //        //ASTreeViewLinkNode node = new ASTreeViewLinkNode(addNodeText, newId.ToString());
        //        //node.NavigateUrl = "#";
        //        //node.AdditionalAttributes.Add(new KeyValuePair<string, string>("onclick", "return false;"));

        //        //root.AppendChild(node);

        //        //HtmlGenericControl ulRoot = new HtmlGenericControl("ul");
        //        //psTree.TreeViewHelper.ConvertTree(ulRoot, root, false);
        //        //foreach (Control c in ulRoot.Controls)
        //        //    c.RenderControl(writer);
        //    }
        //    else
        //        base.Render(writer);

        //}
	}
}
