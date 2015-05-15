<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-May-2012, 12:28:10
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="PRMBOQFloorDetail.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMBOQFloorDetailPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/PRM/PRMBOQFloorDetail.ascx" TagName="PRMBOQFloorDetailEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        Create Project Cost Floor Detail
    </div>
    <uc:PRMBOQFloorDetailEntity ID="ucPRMBOQFloorDetailEntity" runat="server" />
</asp:Content>
