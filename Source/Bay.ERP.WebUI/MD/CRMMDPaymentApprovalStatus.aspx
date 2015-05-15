<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 12:14:24
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CRMMDPaymentApprovalStatus.aspx.cs" Inherits="Bay.ERP.Web.UI.CRMMDPaymentApprovalStatusPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/CRMMDPaymentApprovalStatus.ascx" TagName="CRMMDPaymentApprovalStatusEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Payment Approval Status
    </div>
    <uc:CRMMDPaymentApprovalStatusEntity ID="ucCRMMDPaymentApprovalStatusEntity" runat="server" />
</asp:Content>
