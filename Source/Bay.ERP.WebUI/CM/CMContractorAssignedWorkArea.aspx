<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 04-Jun-2012, 10:26:50
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMContractorAssignedWorkArea.aspx.cs" Inherits="Bay.ERP.Web.UI.CMContractorAssignedWorkAreaPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/CM/CMContractorAssignedWorkArea.ascx" TagName="CMContractorAssignedWorkAreaEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Contractor Assigned Work Area</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMContractorAssignedWorkAreaEntity ID="ucCMContractorAssignedWorkAreaEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>