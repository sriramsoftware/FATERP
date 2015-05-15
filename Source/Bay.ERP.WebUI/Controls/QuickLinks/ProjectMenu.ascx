<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectMenu.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ProjectMenuControl" %>
<table border="0" cellpadding="0" cellspacing="0" class="ql-table" width="300px;">
    <tr>
        <th class="ql-top-left">
        </th>
        <td class="ql-top-border">
            &nbsp; Quick Link
        </td>
        <th class="ql-top-right">
        </th>        
    </tr>
    <tr>
        <td class="ql-left-border">
        </td>
        <td>
            <div class="ql-content">
                <div class="ql-content-inner">                
                    <asp:Menu ID="mnuQuickLink" runat="server" DataSourceID="SiteMapDataSource1" 
                        StaticDisplayLevels="2" onmenuitemdatabound="mnuQuickLink_MenuItemDataBound">
                        <StaticMenuItemStyle ForeColor="#4B4B4B" Font-Names="Verdana, Arial, Helvetica, sans-serif" Font-Size="9" Font-Bold="true" Font-Underline="false" />
                        <StaticHoverStyle Font-Underline="true" />
                        <StaticItemTemplate>
                            <div id="item" runat="server" visible='<%# (Eval("Depth").ToString() == "0") ? true : false %>'>
                                <div style="float: left; width: 30px;">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Gray/QuickLink/icon_edit.gif" BorderWidth="0" />
                                </div>
                                <div style="float: left; width:150px; overflow:hidden; display:inline-block;">
                                    <%# Eval("Text") %>
                                </div>
                                <div style="clear: both;"></div>
                            </div>
                            <div id="Div2" runat="server" visible='<%# (Eval("Depth").ToString() == "1") ? true : false %>' style="padding-left: 20px; padding-bottom: 3px;">
                                <div style="float: left; width: 15px; padding-top: 7px;">
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Gray/QuickLink/icon_list_arrow.gif" BorderWidth="0" />
                                </div>
                                <div style="float: left;">
                                    <a href='<%# Eval("NavigateUrl") %>' style="color: #92B22C;"><%# Eval("Text") %></a>
                                </div>
                                <div style="clear: both;"></div>
                            </div>
                        </StaticItemTemplate>
                    </asp:Menu>
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" SiteMapProvider="projectSiteMap" runat="server" ShowStartingNode="false" />
                </div>
            </div>
        </td>
        <td class="ql-right-border">
        </td>
    </tr>
    <tr>
        <th class="ql-bottom-left">
        </th>
        <td class="ql-bottom-border">
            &nbsp;
        </td>
        <th class="ql-bottom-right">
        </th>
    </tr>
</table>
