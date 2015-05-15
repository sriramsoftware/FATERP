<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 20-Oct-2012, 11:32:20
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="APPanelForwardMember.aspx.cs" Inherits="Bay.ERP.Web.UI.APPanelForwardMemberPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AP/APPanelForwardMember.ascx" TagName="APPanelForwardMemberEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Approval Panel Forward Member</h1>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:APPanelForwardMemberEntity ID="ucAPPanelForwardMemberEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>