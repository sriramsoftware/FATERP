<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 27-Jan-2013, 02:50:43
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACCurrencyExchangeRates.aspx.cs" Inherits="Bay.ERP.Web.UI.ACCurrencyExchangeRatesPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AC/ACCurrencyExchangeRates.ascx" TagName="ACCurrencyExchangeRatesEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Currency Exchange Rates</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACCurrencyExchangeRatesEntity ID="ucACCurrencyExchangeRatesEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
