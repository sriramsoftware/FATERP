<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 03-Oct-2012, 03:53:48
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Bay.ERP.Web.UI.APDefaultPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AP/Default.ascx" TagName="APDefaultEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>My Approval Requestes</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:APDefaultEntity ID="ucAPDefaultEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>