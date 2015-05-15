<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jan-2012, 03:00:49
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="MDConstructionToolWorkingCondition.aspx.cs" Inherits="Bay.ERP.Web.UI.MDConstructionToolWorkingConditionPage"
    Title="ERP" %>

<%@ Register Src="~/Controls/MD/MDConstructionToolWorkingCondition.ascx" TagName="MDConstructionToolWorkingConditionEntity"
    TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Create Construction Tool Working Condition</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <uc:mdconstructiontoolworkingconditionentity id="ucMDConstructionToolWorkingConditionEntity"
            runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
