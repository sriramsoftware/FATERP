<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 06-Oct-2012, 10:59:14
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="APWOPanelItemCategoryMap.aspx.cs" Inherits="Bay.ERP.Web.UI.APWOPanelItemCategoryMapPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AP/APWOPanelItemCategoryMap.ascx" TagName="APWOPanelItemCategoryMapEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Work Order Approval Process Panel & Item Category Map</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:APWOPanelItemCategoryMapEntity ID="ucAPWOPanelItemCategoryMapEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>