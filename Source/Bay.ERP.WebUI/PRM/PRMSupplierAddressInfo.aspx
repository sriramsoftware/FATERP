<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Feb-2012, 05:41:59
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Supplier.master" AutoEventWireup="true" CodeFile="PRMSupplierAddressInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMSupplierAddressInfoPage" Title="ERP" %>

<%@ Register Src="~/Controls/PRM/PRMSupplierAddressInfo.ascx" TagName="PRMSupplierAddressInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Vendor Address Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:PRMSupplierAddressInfoEntity ID="ucPRMSupplierAddressInfoEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
