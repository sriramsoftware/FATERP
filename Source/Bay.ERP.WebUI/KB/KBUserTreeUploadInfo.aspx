<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 23-Mar-2013, 04:14:01
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="KBUserTreeUploadInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.KBUserTreeUploadInfoPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/KB/KBUserTreeUploadInfo.ascx" TagName="KBUserTreeUploadInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create User Tree Upload Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:KBUserTreeUploadInfoEntity ID="ucKBUserTreeUploadInfoEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
