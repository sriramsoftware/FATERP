<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Feb-2013, 12:00:20
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACMDBankAccountDepositApprovalStatus.aspx.cs" Inherits="Bay.ERP.Web.UI.ACMDBankAccountDepositApprovalStatusPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/ACMDBankAccountDepositApprovalStatus.ascx" TagName="ACMDBankAccountDepositApprovalStatusEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Bank Account Deposit Approval Status</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACMDBankAccountDepositApprovalStatusEntity ID="ucACMDBankAccountDepositApprovalStatusEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>