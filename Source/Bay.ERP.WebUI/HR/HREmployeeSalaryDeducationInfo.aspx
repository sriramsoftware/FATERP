<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Employee.master" AutoEventWireup="true"
    CodeFile="HREmployeeSalaryDeducationInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeSalaryDeducationInfoPage"
    Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeSalaryDeducationInfo.ascx" TagName="HREmployeeSalaryDeducationInfoEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/HR/HREmployeeBasicOverview.ascx" TagName="HREmployeeBasicOverviewEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Create Employee Salary Deducation Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:HREmployeeBasicOverviewEntity ID="ucHREmployeeBasicOverviewEntity" runat="server" />
        <div id="tab-contents">
            <uc:HREmployeeSalaryDeducationInfoEntity ID="ucHREmployeeSalaryDeducationInfoEntity"
                runat="server" />
            <br />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
