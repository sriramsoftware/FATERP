<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2015, 10:29:49
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDZoneDesignation.aspx.cs" Inherits="Bay.ERP.Web.UI.MDZoneDesignationPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDZoneDesignation.ascx" TagName="MDZoneDesignationEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Zone Designation
    </div>
    <uc:MDZoneDesignationEntity ID="ucMDZoneDesignationEntity" runat="server" />
</asp:Content>
