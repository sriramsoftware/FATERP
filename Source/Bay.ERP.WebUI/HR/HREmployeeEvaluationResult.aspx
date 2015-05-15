<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Sep-2013, 01:19:45
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="HREmployeeEvaluationResult.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeEvaluationResultPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeEvaluationResult.ascx" TagName="HREmployeeEvaluationResultEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Create Employee Evaluation Result</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:HREmployeeEvaluationResultEntity ID="ucHREmployeeEvaluationResultEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
    </asp:Content>