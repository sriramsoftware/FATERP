<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ASApplicationAccess.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ASApplicationAccessControl" %>

<%@ Register Assembly="ASTreeView" Namespace="Geekees.Common.Controls" TagPrefix="ct" %>
<link href="<%=ResolveUrl("~/Scripts/ASTreeview179/astreeview/astreeview.css")%>"
    type="text/css" rel="stylesheet" />
<link href="<%=ResolveUrl("~/Scripts/ASTreeview179/contextmenu/contextmenu.css")%>"
    type="text/css" rel="stylesheet" />
<script src="<%=ResolveUrl("~/Scripts/ASTreeview179/astreeview/astreeview_packed.js")%>"
    type="text/javascript"></script>
<script src="<%=ResolveUrl("~/Scripts/ASTreeview179/contextmenu/contextmenu_packed.js")%>"
    type="text/javascript"></script>
<script type="text/javascript">

<asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
<table>
    <tr>
        <td valign="top">
            Role
        </td>
        <td valign="top">
            :
        </td>
        <td valign="top">
            <asp:DropDownList ID="ddlRole" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                Width="236">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td valign="top">
            Sitemap
        </td>
        <td valign="top">
            :
        </td>
        <td valign="top">
            <asp:DropDownList ID="rcbSitemapList" CssClass="ktiSelect" ClientIDMode="Static"
                runat="server" AutoPostBack="true" Width="236">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td valign="top">
            Permission
        </td>
        <td valign="top">
            :
        </td>
        <td valign="top">
            <asp:TreeView ID="rtvSiteMap" runat="server" CheckBoxes="true" OnNodeExpand="rtvSiteMap_NodeExpand"
                OnNodeCheck="rtvSiteMap_NodeCheck">
                </asp:TreeView>


                <ct:ASTreeView 
                    ID="treeSitePhysicalStructure" 
                    runat="server" 
                    BasePath="~/Scripts/ASTreeview179/astreeview/"
                    EnableRoot="false" 
                    EnableCheckbox="true" 
                    EnableContextMenu="true" 
                    EnableDragDrop="false"
                    AutoPostBack="true" 
                    EnableTreeLines="false" 
                    EnableNodeIcon="true" 
                    EnableCustomizedNodeIcon="true"
                    EnableDebugMode="false" 
                    EnableContextMenuAdd="true" 
                    OnOnSelectedNodeChanged="treeSitePhysicalStructure_OnSelectedNodeChanged" />

            <%--<telerik:RadTreeView ID="rtvSiteMap" runat="server" CheckBoxes="true" OnNodeExpand="rtvSiteMap_NodeExpand"
                OnNodeCheck="rtvSiteMap_NodeCheck">
            </telerik:RadTreeView>--%>
        </td>
    </tr>
</table>
