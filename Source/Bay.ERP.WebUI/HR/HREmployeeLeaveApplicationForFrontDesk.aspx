<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="HREmployeeLeaveApplicationForFrontDesk.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeLeaveApplicationForFrontDeskPage"
    Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeLeaveApplicationForFrontDesk.ascx" TagName="HREmployeeLeaveApplicationForFrontDeskEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Create Employee Leave Application</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:HREmployeeLeaveApplicationForFrontDeskEntity ID="ucHREmployeeLeaveApplicationForFrontDeskEntity" runat="server" />
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
