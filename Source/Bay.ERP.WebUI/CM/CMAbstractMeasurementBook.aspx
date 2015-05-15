<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 03-Oct-2012, 04:24:34
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMAbstractMeasurementBook.aspx.cs" Inherits="Bay.ERP.Web.UI.CMAbstractMeasurementBookPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/CM/CMAbstractMeasurementBook.ascx" TagName="CMAbstractMeasurementBookEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Abstract Measurement Book</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMAbstractMeasurementBookEntity ID="ucCMAbstractMeasurementBookEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>