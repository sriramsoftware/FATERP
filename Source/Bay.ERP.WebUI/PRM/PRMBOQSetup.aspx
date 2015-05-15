<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:47:41
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Project.master" AutoEventWireup="true" CodeFile="PRMBOQSetup.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMBOQSetupPage" Title="ERP" %>

<%@ Register Src="~/Controls/PRM/PRMBOQSetup.ascx" TagName="PRMBOQSetupEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Project Cost Setup</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:PRMBOQSetupEntity ID="ucPRMBOQSetupEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>