<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="OTEmployeeIssueSchedule.aspx.cs" Inherits="Bay.ERP.Web.UI.OTEmployeeIssueSchedulePage" Title="ERP" %>

<%@ Register Src="~/Controls/OT/OTEmployeeIssueSchedule.ascx" TagName="OTEmployeeIssueScheduleEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Employee Issue Schedule</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:OTEmployeeIssueScheduleEntity ID="ucOTEmployeeIssueScheduleEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>