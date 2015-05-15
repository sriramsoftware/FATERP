<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 04:59:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMNavigation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMNavigationControl" %>

    <%@ Register Src="~/Controls/Common/CMNDashboardItemView.ascx" TagName="CMNDashboardItemViewEntity"
    TagPrefix="uc" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
         <uc:CMNDashboardItemViewEntity ID="ucCMNDashboardItemViewEntity" runat="server" />
    </ContentTemplate>
</asp:UpdatePanel>
