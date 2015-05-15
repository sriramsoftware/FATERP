<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 02-Feb-2012, 02:51:45
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="HRMemberChangePassword.aspx.cs" Inherits="Bay.ERP.Web.UI.HRMemberChangePasswordPage" Title="ERP" %>

<%@ Register Src="~/Controls/HR/HRMemberChangePassword.ascx" TagName="HRMemberChangePasswordEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Change Password</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:HRMemberChangePasswordEntity ID="ucHRMemberChangePasswordEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>