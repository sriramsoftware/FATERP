<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jun-2013, 02:07:01
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="BDProjectParking.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectParkingPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDProjectParking.ascx" TagName="BDProjectParkingEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Update Project Parking</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDProjectParkingEntity ID="ucBDProjectParkingEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>