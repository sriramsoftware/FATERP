<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 31-Jan-2013, 04:31:48
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACBankAccountPaymentDetailsWithApproval.aspx.cs" Inherits="Bay.ERP.Web.UI.ACBankAccountPaymentDetailsWithApprovalPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AC/ACBankAccountPaymentDetailsWithApproval.ascx" TagName="ACBankAccountPaymentDetailsWithApprovalEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Approval View</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACBankAccountPaymentDetailsWithApprovalEntity ID="ucACBankAccountPaymentDetailsWithApprovalEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
