<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>

<%--<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="BDProject.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectPage" Title="ERP" %>--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="BDProjectCategoryStatusReport.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectCategoryStatusPage" Title="ERP" %>


<%@ Register Src="~/Controls/BD/BDProjectCategoryStatusReport.ascx" TagName="BDProjectCategoryStatusReportEntity" TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Project Category Status Report</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
<div style="width: 1100px;">
    <uc:BDProjectCategoryStatusReportEntity ID="ucBDProjectCategoryStatusReportEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>