<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Oct-2013, 02:28:24
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDEventLocationCategory.aspx.cs" Inherits="Bay.ERP.Web.UI.MDEventLocationCategoryPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDEventLocationCategory.ascx" TagName="MDEventLocationCategoryEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Event Location Category
    </div>
    <uc:MDEventLocationCategoryEntity ID="ucMDEventLocationCategoryEntity" runat="server" />
</asp:Content>
