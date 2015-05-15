<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Sep-2012, 04:57:13
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="PRMWorkOrderItemDetail.aspx.cs" Inherits="Bay.ERP.Web.UI.PRMWorkOrderItemDetailPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/PRM/PRMWorkOrderItemDetail.ascx" TagName="PRMWorkOrderItemDetailEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Work Order Item Detail
    </div>
    <uc:PRMWorkOrderItemDetailEntity ID="ucPRMWorkOrderItemDetailEntity" runat="server" />
</asp:Content>
