<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 09-Dec-2012, 08:03:28
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACCPrePayableStatementDetail.aspx.cs" Inherits="Bay.ERP.Web.UI.ACCPrePayableStatementDetailPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/ACC/ACCPrePayableStatementDetail.ascx" TagName="ACCPrePayableStatementDetailEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Pre Payable Statement Detail</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACCPrePayableStatementDetailEntity ID="ucACCPrePayableStatementDetailEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
