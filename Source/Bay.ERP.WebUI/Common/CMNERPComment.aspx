<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 23-Mar-2013, 04:14:01
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMNERPComment.aspx.cs" Inherits="Bay.ERP.Web.UI.CMNERPCommentPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/Common/CMNERPComment.ascx" TagName="CMNERPCommentEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Comment</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMNERPCommentEntity ID="ucCMNERPCommentEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>