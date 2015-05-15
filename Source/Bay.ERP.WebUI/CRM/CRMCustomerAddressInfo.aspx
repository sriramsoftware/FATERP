<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-Feb-2013, 03:00:14
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CRMCustomerAddressInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.CRMCustomerAddressInfoPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/CRM/CRMCustomerAddressInfo.ascx" TagName="CRMCustomerAddressInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1> Create Customer Address Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:CRMCustomerAddressInfoEntity ID="ucCRMCustomerAddressInfoEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>