<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 18-Dec-2012, 01:46:09
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="INVTransferItemDetailsWithApproval.aspx.cs" Inherits="Bay.ERP.Web.UI.INVTransferItemDetailsWithApprovalPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/INV/INVTransferItemDetailsWithApproval.ascx" TagName="INVTransferItemDetailsWithApprovalEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Transfer Item Approval</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:INVTransferItemDetailsWithApprovalEntity ID="ucINVTransferItemDetailsWithApprovalEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>