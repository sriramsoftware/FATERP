<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDMDProcessAssignedResourceApprovalStatus.aspx.cs" Inherits="Bay.ERP.Web.UI.BDMDProcessAssignedResourceApprovalStatusPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/BDMDProcessAssignedResourceApprovalStatus.ascx" TagName="BDMDProcessAssignedResourceApprovalStatusEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Process Assigned Resource Approval Status</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDMDProcessAssignedResourceApprovalStatusEntity ID="ucBDMDProcessAssignedResourceApprovalStatusEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>