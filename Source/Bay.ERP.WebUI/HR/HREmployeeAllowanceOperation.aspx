<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-Jan-2014, 11:30:08
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="HREmployeeAllowanceOperation.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeAllowanceOperationPage"
    Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeAllowanceOperation.ascx" TagName="HREmployeeAllowanceOperationEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Employee Allowance</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:HREmployeeAllowanceOperationEntity ID="ucHREmployeeAllowanceOperationEntity"
            runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
