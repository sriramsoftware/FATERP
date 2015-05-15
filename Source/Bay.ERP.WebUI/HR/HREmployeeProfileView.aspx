<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Employee.master" AutoEventWireup="true" CodeFile="HREmployeeProfileView.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeProfileViewPage" Title="ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeProfileView.ascx" TagName="HREmployeeProfileViewEntity" TagPrefix="uc" %>
<%@ Register Src="~/Controls/HR/HREmployeeBasicOverview.ascx" TagName="HREmployeeBasicOverviewEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Profile View</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
      <uc:HREmployeeBasicOverviewEntity ID="ucHREmployeeBasicOverviewEntity" runat="server" />
                                                                        <div id="tab-contents">
    <uc:HREmployeeProfileViewEntity ID="ucHREmployeeProfileViewEntity" runat="server" /> 
                                                                         <br />
                                                                        </div>  
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>