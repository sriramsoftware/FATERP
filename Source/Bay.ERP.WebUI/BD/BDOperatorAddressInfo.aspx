<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-May-2015, 08:31:04
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDOperatorAddressInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.BDOperatorAddressInfoPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDOperatorAddressInfo.ascx" TagName="BDOperatorAddressInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1> Create Operator Address Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDOperatorAddressInfoEntity ID="ucBDOperatorAddressInfoEntity" runat="server" />   
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>