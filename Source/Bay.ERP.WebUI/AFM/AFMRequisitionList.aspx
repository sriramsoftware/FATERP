<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="AFMRequisitionList.aspx.cs" Inherits="Bay.ERP.Web.UI.AFMRequisitionListPage" Title="ERP" %>

<%@ Register Src="~/Controls/AFM/AFMRequisitionList.ascx" TagName="AFMRequisitionListEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Requisition List</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:AFMRequisitionListEntity ID="ucAFMRequisitionListEntity" runat="server" />   
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
