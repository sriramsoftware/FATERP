<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Apr-2013, 01:28:07
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CRMAgreement.aspx.cs" Inherits="Bay.ERP.Web.UI.CRMAgreementPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/CRM/CRMAgreement.ascx" TagName="CRMAgreementEntity" TagPrefix="uc" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Agreement</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CRMAgreementEntity ID="ucCRMAgreementEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>