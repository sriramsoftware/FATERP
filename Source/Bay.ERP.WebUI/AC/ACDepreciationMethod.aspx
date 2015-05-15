<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 30-Jan-2013, 03:35:13
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACDepreciationMethod.aspx.cs" Inherits="Bay.ERP.Web.UI.ACDepreciationMethodPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AC/ACDepreciationMethod.ascx" TagName="ACDepreciationMethodEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Depreciation Method</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACDepreciationMethodEntity ID="ucACDepreciationMethodEntity" runat="server" />    
    </div>
    </asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>