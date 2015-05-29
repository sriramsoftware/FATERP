<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 29-May-2015, 12:50:36
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDOperatorContactPerson.aspx.cs" Inherits="Bay.ERP.Web.UI.BDOperatorContactPersonPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDOperatorContactPerson.ascx" TagName="BDOperatorContactPersonEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Operator Contact Person
    </div>
    <uc:BDOperatorContactPersonEntity ID="ucBDOperatorContactPersonEntity" runat="server" />
</asp:Content>
