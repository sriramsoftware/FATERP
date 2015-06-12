<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 29-May-2015, 12:50:36
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Operator.master" AutoEventWireup="true" CodeFile="BDOperatorContactPerson.aspx.cs" Inherits="Bay.ERP.Web.UI.BDOperatorContactPersonPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDOperatorContactPerson.ascx" TagName="BDOperatorContactPersonEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntPageTitle" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Operator Contact Person</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:BDOperatorContactPersonEntity ID="ucBDOperatorContactPersonEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>