<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="HREmployeeMonthlyTimeSheet.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeMonthlyTimeSheetPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeMonthlyTimeSheet.ascx" TagName="HREmployeeMonthlyTimeSheetEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Create Employee Monthly Time Sheet
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:HREmployeeMonthlyTimeSheetEntity ID="ucHREmployeeMonthlyTimeSheetEntity" runat="server" />   
    </div>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>