<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 12:14:24
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CRMMDPaymentCategory.aspx.cs" Inherits="Bay.ERP.Web.UI.CRMMDPaymentCategoryPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/CRMMDPaymentCategory.ascx" TagName="CRMMDPaymentCategoryEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Payment Category
    </div>
    <uc:CRMMDPaymentCategoryEntity ID="ucCRMMDPaymentCategoryEntity" runat="server" />
</asp:Content>
