<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 09-Dec-2012, 08:03:28
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACCPrePayableStatementFromBill.aspx.cs" Inherits="Bay.ERP.Web.UI.ACCPrePayableStatementFromBillPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/ACC/ACCPrePayableStatementFromBill.ascx" TagName="ACCPrePayableStatementFromBillEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Pre Payable Statement</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACCPrePayableStatementFromBillEntity ID="ucACCPrePayableStatementFromBillEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
