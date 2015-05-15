<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-Jan-2014, 11:30:08
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDAllowanceCategory.aspx.cs" Inherits="Bay.ERP.Web.UI.MDAllowanceCategoryPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDAllowanceCategory.ascx" TagName="MDAllowanceCategoryEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Allowance Category
    </div>
    <uc:MDAllowanceCategoryEntity ID="ucMDAllowanceCategoryEntity" runat="server" />
</asp:Content>
