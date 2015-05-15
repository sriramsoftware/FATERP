<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SiteRequisitionItemView.aspx.cs" Inherits="Bay.ERP.Web.UI.SiteRequisitionItemViewPage" %>
<%@ Register Src="~/Controls/REQ/REQRequisitionItemView.ascx" TagName="REQRequisitionItemViewEntity"
    TagPrefix="uc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Styles/view.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <uc:REQRequisitionItemViewEntity ID="ucREQRequisitionItemViewEntity" runat="server" />
    </div>
    </form>
</body>
</html>
