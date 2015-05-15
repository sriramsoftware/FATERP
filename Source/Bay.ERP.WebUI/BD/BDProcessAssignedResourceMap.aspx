<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDProcessAssignedResourceMap.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProcessAssignedResourceMapPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDProcessAssignedResourceMap.ascx" TagName="BDProcessAssignedResourceMapEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Process Assigned Resource Map</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDProcessAssignedResourceMapEntity ID="ucBDProcessAssignedResourceMapEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
