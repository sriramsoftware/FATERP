<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 06-Oct-2013, 05:27:25
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CMNMDSharedSetting.aspx.cs" Inherits="Bay.ERP.Web.UI.CMNMDSharedSettingPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/CMNMDSharedSetting.ascx" TagName="CMNMDSharedSettingEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Shared Setting</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMNMDSharedSettingEntity ID="ucCMNMDSharedSettingEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>