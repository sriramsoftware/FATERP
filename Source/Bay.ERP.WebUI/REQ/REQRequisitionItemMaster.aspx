<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="REQRequisitionItemMaster.aspx.cs" Inherits="Bay.ERP.Web.UI.REQRequisitionItemMasterPage"
    Title="ERP" %>

<%@ Register Src="~/Controls/REQ/REQRequisitionItemMaster.ascx" TagName="REQRequisitionItemMasterEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Master Requisition Item</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:REQRequisitionItemMasterEntity ID="ucREQRequisitionItemMasterEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>