<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Dec-2012, 02:59:46
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="INVTransactionINOUT_CustomDetailedListCustom.aspx.cs"
    Inherits="Bay.ERP.Web.UI.INVTransactionINOUT_CustomPageDetailedListCustom" Title="" %>

<%@ Register Src="~/Controls/INV/INVTransactionINOUT_CustomDetailedListCustom.ascx" TagName="INVTransactionINOUT_CustomEntity" TagPrefix="uc" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Store Transaction</h1> This report is based on all store entry
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:INVTransactionINOUT_CustomEntity ID="ucINVTransactionEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
