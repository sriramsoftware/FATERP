<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Employee.master" AutoEventWireup="true" CodeFile="HREmployeeSalarySessionDeducationInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeSalarySessionDeducationInfoPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeSalarySessionDeducationInfo.ascx" TagName="HREmployeeSalarySessionDeducationInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
        Create Employee Salary Session Deducation Info
    </asp:Content>
     <asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:HREmployeeSalarySessionDeducationInfoEntity ID="ucHREmployeeSalarySessionDeducationInfoEntity" runat="server" />
    </div>
    </asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>