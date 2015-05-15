<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMWorkOrderPaymentTerm.aspx.cs" Inherits="Bay.ERP.Web.UI.CMWorkOrderPaymentTermPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/PRM/PRMWorkOrderPaymentTerm.ascx" TagName="CMWorkOrderPaymentTermEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Work Order Payment Term</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMWorkOrderPaymentTermEntity ID="ucCMWorkOrderPaymentTermEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>