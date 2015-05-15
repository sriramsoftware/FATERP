<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDProjectCollectedDocumentCategoryInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectCollectedDocumentCategoryInfoPage" Title="ERP" %>

<%@ Register Src="~/Controls/BD/BDProjectCollectedDocumentCategoryInfo.ascx" TagName="BDProjectCollectedDocumentCategoryInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Project Collected Document Category Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDProjectCollectedDocumentCategoryInfoEntity ID="ucBDProjectCollectedDocumentCategoryInfoEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>