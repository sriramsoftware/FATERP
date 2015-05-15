<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="BDProjectMilestoneSetup.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectMilestoneSetupPage" Title="ERP" %>

<%@ Register Src="~/Controls/BD/BDProjectMilestoneSetup.ascx" TagName="CMProjectScheduleTemplateItemMapEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Project Milestone Setup</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMProjectScheduleTemplateItemMapEntity ID="ucCMProjectScheduleTemplateItemMapEntity" runat="server" />     
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>