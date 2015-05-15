<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="HREmployeeReportsUnderSalarySession.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeReportsUnderSalarySessionPage"
    Title="Bay's ERP" %>
    <%@ Register Src="~/Controls/HR/HREmployeeReportsUnderSalarySession.ascx" TagName="HREmployeeReportsUnderSalarySessionEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        HR Reports Under salary session</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
      
            <uc:HREmployeeReportsUnderSalarySessionEntity ID="ucHREmployeeReportsUnderSalarySessionEntity" runat="server" />
            <br />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
