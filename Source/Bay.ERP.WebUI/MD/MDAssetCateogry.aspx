<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Oct-2013, 02:28:24
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDAssetCateogry.aspx.cs" Inherits="Bay.ERP.Web.UI.MDAssetCateogryPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDAssetCateogry.ascx" TagName="MDAssetCateogryEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Asset Cateogry</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:MDAssetCateogryEntity ID="ucMDAssetCateogryEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>