<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 29-May-2015, 12:41:19
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDOperatorStatus.aspx.cs" Inherits="Bay.ERP.Web.UI.MDOperatorStatusPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDOperatorStatus.ascx" TagName="MDOperatorStatusEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Operator Status
    </div>
    <uc:MDOperatorStatusEntity ID="ucMDOperatorStatusEntity" runat="server" />
</asp:Content>
