<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 07-Jan-2012, 02:49:42
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Contractor.master" AutoEventWireup="true" CodeFile="CMFinancialStrengthMajorWork.aspx.cs" Inherits="Bay.ERP.Web.UI.CMFinancialStrengthMajorWorkPage" Title="ERP" %>

<%@ Register Src="~/Controls/CM/CMFinancialStrengthMajorWork.ascx" TagName="CMFinancialStrengthMajorWorkEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Financial Strength Major Work</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMFinancialStrengthMajorWorkEntity ID="ucCMFinancialStrengthMajorWorkEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
