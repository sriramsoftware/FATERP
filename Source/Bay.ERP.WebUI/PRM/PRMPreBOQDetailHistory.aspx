<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 10-May-2012, 05:58:01
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="PRMPreBOQDetailHistory.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMPreBOQDetailHistoryPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/PRM/PRMPreBOQDetailHistory.ascx" TagName="PRMPreBOQDetailHistoryEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>BOQ Posting History</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:PRMPreBOQDetailHistoryEntity ID="ucPRMPreBOQDetailHistoryEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>