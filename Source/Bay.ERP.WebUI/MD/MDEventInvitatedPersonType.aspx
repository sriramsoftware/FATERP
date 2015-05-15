<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Nov-2013, 12:21:52
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDEventInvitatedPersonType.aspx.cs" Inherits="Bay.ERP.Web.UI.MDEventInvitatedPersonTypePage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDEventInvitatedPersonType.ascx" TagName="MDEventInvitatedPersonTypeEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Event Invitated Person Type</h1>
    </asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:MDEventInvitatedPersonTypeEntity ID="ucMDEventInvitatedPersonTypeEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
    </asp:Content>