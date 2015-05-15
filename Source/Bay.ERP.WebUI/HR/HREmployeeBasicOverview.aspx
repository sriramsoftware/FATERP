<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-Feb-2013, 03:00:14
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Employee.master" AutoEventWireup="true"
    CodeFile="HREmployeeBasicOverview.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeBasicOverviewPage"
    Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeEditor.ascx" TagName="HREmployeeEditorEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/HR/HREmployeeBasicOverview.ascx" TagName="HREmployeeBasicOverviewEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        HR Basic Overview</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:HREmployeeBasicOverviewEntity ID="ucHREmployeeBasicOverviewEntity" runat="server" />
        <div id="tab-contents">
            <br />
            <uc:HREmployeeEditorEntity ID="ucHREmployeeEditorEntity" runat="server" />
            <br />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
