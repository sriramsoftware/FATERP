<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 08-Jan-2012, 04:47:08
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMConsultantAssignedWorkAreaStandalone.aspx.cs" Inherits="Bay.ERP.Web.UI.CMConsultantAssignedWorkAreaStandalonePage" Title="ERP" %>

<%@ Register Src="~/Controls/CM/CMConsultantAssignedWorkAreaStandalone.ascx" TagName="CMConsultantAssignedWorkAreaStandaloneEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Consultant Assigned Work Area</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMConsultantAssignedWorkAreaStandaloneEntity ID="ucCMConsultantAssignedWorkAreaStandaloneEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>