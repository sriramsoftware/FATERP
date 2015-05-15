<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true"
    CodeFile="BDProjectRequisitionItemMaster.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectRequisitionItemMasterPage"
    Title="ERP" %>

<%@ Register Src="~/Controls/REQ/REQRequisitionItemMaster.ascx" TagName="BDProjectRequisitionItemMasterEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Requisition Item</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:BDProjectRequisitionItemMasterEntity ID="ucBDProjectRequisitionItemMasterEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
