<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 09-Dec-2012, 08:03:28
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACCApprovedPostPayableStatementDetailList.aspx.cs" Inherits="Bay.ERP.Web.UI.ACCApprovedPostPayableStatementDetailListPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/ACC/ACCApprovedPostPayableStatementDetailList.ascx" TagName="ACCApprovedPostPayableStatementDetailListEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Approved Payable Statement Detail</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACCApprovedPostPayableStatementDetailListEntity ID="ucACCApprovedPostPayableStatementDetailListEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
