<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-May-2015, 10:52:29
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BDProject.aspx.cs" Inherits="Bay.ERP.Web.UI.BDProjectPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/BD/BDProject.ascx" TagName="BDProjectEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create Project
    </div>
    <uc:BDProjectEntity ID="ucBDProjectEntity" runat="server" />
</asp:Content>
