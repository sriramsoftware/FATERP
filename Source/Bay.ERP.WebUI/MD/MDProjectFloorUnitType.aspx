<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 01-Apr-2013, 03:04:35
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDProjectFloorUnitType.aspx.cs" Inherits="Bay.ERP.Web.UI.MDProjectFloorUnitTypePage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/MD/MDProjectFloorUnitType.ascx" TagName="MDProjectFloorUnitTypeEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        Create Project Floor Unit Type
    </div>
    <uc:MDProjectFloorUnitTypeEntity ID="ucMDProjectFloorUnitTypeEntity" runat="server" />
</asp:Content>
