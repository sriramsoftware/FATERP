<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:47:41
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Supplier.master" AutoEventWireup="true" CodeFile="PRMSupplierEditor.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMSupplierEditorPage" Title="ERP" %>

<%@ Register Src="~/Controls/PRM/PRMSupplierEditor.ascx" TagName="PRMSupplierEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Edit Vendor</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
       <uc:PRMSupplierEntity ID="ucPRMSupplierEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>