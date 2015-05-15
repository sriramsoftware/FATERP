<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 13-Dec-2012, 11:43:49
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDAccountPaybleStatementDetailCategory.aspx.cs" Inherits="Bay.ERP.Web.UI.MDAccountPaybleStatementDetailCategoryPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDAccountPaybleStatementDetailCategory.ascx" TagName="MDAccountPaybleStatementDetailCategoryEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Account Payble Statement Detail Category</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:MDAccountPaybleStatementDetailCategoryEntity ID="ucMDAccountPaybleStatementDetailCategoryEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
