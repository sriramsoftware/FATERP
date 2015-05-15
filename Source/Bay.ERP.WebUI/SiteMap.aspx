<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="SiteMap.aspx.cs" Inherits="Bay.ERP.Web.UI.SiteMapPage" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Site Map</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" 
            StaticDisplayLevels="5" StaticPopOutImageTextFormatString="Expand {2}" 
            StaticSubMenuIndent="16px">
            <StaticMenuItemStyle VerticalPadding="5px" />
            <StaticMenuStyle VerticalPadding="10px" />
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" SiteMapProvider="defaultSiteMapProvider" runat="server" />
    </div>
</asp:Content>
        