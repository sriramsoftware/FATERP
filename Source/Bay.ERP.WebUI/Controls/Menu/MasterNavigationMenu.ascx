<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MasterNavigationMenu.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MasterNavigationMenuControl" EnableViewState="false" %>
<asp:Menu ID="mnu" Width="1050px" Orientation="Horizontal" runat="server" StaticEnableDefaultPopOutImage="false">
    <DynamicHoverStyle BackColor="#3A3A3A" ForeColor="#94b52c" Font-Size="11px"  />
    <DynamicMenuItemStyle Height="16" Font-Bold="true" ForeColor="White" HorizontalPadding="4"
        VerticalPadding="6px" ItemSpacing="10" Font-Size="11px" />
    <DynamicMenuStyle BackColor="#575757" Width="200px" />
    <StaticItemTemplate>
        <div class="dreamSeperator">
            &nbsp;&nbsp;<%# Eval("Text") %>&nbsp;&nbsp;
        </div>
    </StaticItemTemplate>
    <DynamicItemTemplate>
        <%# Eval("Text") %>
    </DynamicItemTemplate>
    <StaticHoverStyle BackColor="#3A3A3A" ForeColor="#94b52c"/>
    <StaticMenuItemStyle Height="37" Font-Bold="true" ForeColor="White" HorizontalPadding="0"
        VerticalPadding="0" ItemSpacing="30" />
</asp:Menu>
<%--<asp:SiteMapDataSource ID="SiteMapDataSource1" SiteMapProvider="defaultSiteMapProvider" runat="server" ShowStartingNode="false" />--%>
<%--<asp:SiteMapDataSource ID="SiteMapDataSource1" SiteMapProvider="MasterNavigationMenuSitemapProviderDB"
    runat="server" ShowStartingNode="false" />--%>
