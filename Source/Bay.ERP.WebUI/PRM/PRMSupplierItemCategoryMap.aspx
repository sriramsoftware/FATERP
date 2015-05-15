<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-May-2012, 11:02:33
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Supplier.master" AutoEventWireup="true" CodeFile="PRMSupplierItemCategoryMap.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMSupplierItemCategoryMapPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/PRM/PRMSupplierItemCategoryMap.ascx" TagName="PRMSupplierItemCategoryMapEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Vendor Item Category Map</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:PRMSupplierItemCategoryMapEntity ID="ucPRMSupplierItemCategoryMapEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>