<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 30-Jan-2013, 03:35:13
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACJournal.aspx.cs" Inherits="Bay.ERP.Web.UI.ACJournalPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/AC/ACJournal.ascx" TagName="ACJournalEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Journal</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACJournalEntity ID="ucACJournalEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>