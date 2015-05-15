<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:47:41
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="PRMPreBOQToBOQMigration.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMPreBOQToBOQMigrationPage" Title="ERP" %>

<%@ Register Src="~/Controls/PRM/PRMPreBOQToBOQMigration.ascx" TagName="PRMPreBOQToBOQMigrationEntity" TagPrefix="uc" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>BOQ to Project Cost Migration</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:PRMPreBOQToBOQMigrationEntity ID="ucPRMPreBOQToBOQMigrationEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>