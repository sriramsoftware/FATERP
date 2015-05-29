<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-May-2015, 11:33:13
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDOperator.aspx.cs" Inherits="Bay.ERP.Web.UI.BDOperatorPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDOperator.ascx" TagName="BDOperatorEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Operator
    </div>
    <uc:BDOperatorEntity ID="ucBDOperatorEntity" runat="server" />
</asp:Content>
