<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 08-Mar-2012, 11:45:48
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMNDashboardItemQuicklink.aspx.cs" Inherits="Bay.ERP.Web.UI.CMNDashboardItemQuicklinkPage" Title="ERP" %>

<%@ Register Src="~/Controls/Common/CMNDashboardItemQuicklink.ascx" TagName="CMNDashboardItemQuicklinkEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Dashboard Item Quicklink</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMNDashboardItemQuicklinkEntity ID="ucCMNDashboardItemQuicklinkEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>