<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jun-2013, 02:07:01
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="BDProjectSubstationAndGenerator.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectSubstationAndGeneratorPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDProjectSubstationAndGenerator.ascx" TagName="BDProjectSubstationAndGeneratorEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Update Project Substation And Generator</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDProjectSubstationAndGeneratorEntity ID="ucBDProjectSubstationAndGeneratorEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>