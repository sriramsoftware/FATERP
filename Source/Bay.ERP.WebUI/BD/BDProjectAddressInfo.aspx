<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 07-Dec-2011, 11:00:45
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="BDProjectAddressInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectAddressInfoPage" Title="ERP" %>

<%@ Register Src="~/Controls/BD/BDProjectAddressInfo.ascx" TagName="BDProjectAddressInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Project Address Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDProjectAddressInfoEntity ID="ucBDProjectAddressInfoEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>