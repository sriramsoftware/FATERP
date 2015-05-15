<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2010 – 2013.

 Code Generate Time - 21-Jan-2013, 04:58:29
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ACCRequisitionWorkOrderMRRDetail_DetailedDetailedListCustom.aspx.cs"
    Inherits="Bay.ERP.Web.UI.ACCRequisitionWorkOrderMRRDetail_DetailedPageDetailedListCustom" Title="" %>

<%@ Register Src="~/Controls/ACC/ACCRequisitionWorkOrderMRRDetail_DetailedListCustom.ascx" TagName="ACCRequisitionWorkOrderMRRDetail_DetailedEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>ACC View</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:ACCRequisitionWorkOrderMRRDetail_DetailedEntity ID="ucACCRequisitionWorkOrderMRRDetail_DetailedEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>