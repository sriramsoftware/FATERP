<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 23-Dec-2013, 01:17:51
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="HREmployeeEvaluationReport.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeEvaluationReportPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeEvaluationReport.ascx" TagName="HREmployeeEvaluationReportEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Employee Evaluation Report</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:HREmployeeEvaluationReportEntity ID="ucHREmployeeEvaluationReportEntity" runat="server" />
    </div>
    </asp:Content>
    <asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
