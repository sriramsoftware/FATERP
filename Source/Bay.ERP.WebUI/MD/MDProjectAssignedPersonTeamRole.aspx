<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 15-Jul-2012, 05:23:43
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDProjectAssignedPersonTeamRole.aspx.cs" Inherits="Bay.ERP.Web.UI.MDProjectAssignedPersonTeamRolePage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDProjectAssignedPersonTeamRole.ascx" TagName="MDProjectAssignedPersonTeamRoleEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Project Assigned Person Team Role</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:MDProjectAssignedPersonTeamRoleEntity ID="ucMDProjectAssignedPersonTeamRoleEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>