<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-Mar-2013, 10:27:29
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACMDBankAccountTransferApprovalStatus.aspx.cs" Inherits="Bay.ERP.Web.UI.ACMDBankAccountTransferApprovalStatusPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/ACMDBankAccountTransferApprovalStatus.ascx" TagName="ACMDBankAccountTransferApprovalStatusEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Bank Account Transfer Approval Status</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACMDBankAccountTransferApprovalStatusEntity ID="ucACMDBankAccountTransferApprovalStatusEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
