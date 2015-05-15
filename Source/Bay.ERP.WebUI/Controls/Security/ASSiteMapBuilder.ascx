<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ASSiteMapBuilder.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ASSiteMapBuilderControl" %>
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

    function nodeSelectHandler(elem) {

        document.getElementById('<%=this.txtSelectedNode.ClientID%>').value = elem.parentNode.getAttribute("treeNodeValue");
        document.getElementById('<%=this.btnSelectionPBTrigger.ClientID%>').click();

    }

    function nodeCheckHandler(elem) {
        var tempStr = elem.parentNode.getAttribute("treeNodeText");
        tempStr += ";";
        tempStr += elem.parentNode.getAttribute("treeNodeValue");
        tempStr += ";";
        tempStr += elem.parentNode.getAttribute("checkedState"); //
        tempStr += ";";
        tempStr += elem.parentNode.getAttribute("additional-attributes");

        document.getElementById('<%=this.txtCheckedNode.ClientID%>').value = tempStr;
        //document.getElementById('<%=this.txtCheckedNodeState.ClientID%>').value = elem.parentNode.getAttribute("checkedState");
        document.getElementById('<%=this.btnCheckedPBTrigger.ClientID%>').click();
    }


    function psContextMenuItemClicked(commandName, id) {
        document.getElementById('<%=this.hydPSTreeContextMenuCommandName.ClientID%>').value = commandName;
        document.getElementById('<%=this.hydPSTreeContextMenuNodeID.ClientID%>').value = id;
        document.getElementById('<%=this.btnPSTreeContextMenuClickTrigger.ClientID%>').click();

    }

    function smContextMenuItemClicked(commandName, id, additionalAttributes) {
        var jsonObject = JSON.parse(additionalAttributes);

        var aSSiteMapID = jsonObject.ASSiteMapID;
        var uniqueKey = jsonObject.UniqueKey;

        document.getElementById('<%=this.hydSMTreeContextMenuCommandName.ClientID%>').value = commandName;
        document.getElementById('<%=this.hydSMTreeContextMenuNodeID.ClientID%>').value = id;
        document.getElementById('<%=this.hydSMTreeContextMenuASSiteMapID.ClientID%>').value = aSSiteMapID;
        document.getElementById('<%=this.hydSMTreeContextMenuUniqueKey.ClientID%>').value = uniqueKey;

        document.getElementById('<%=this.btnSMTreeContextMenuClickTrigger.ClientID%>').click();
    }

    function dndHandler(elem, newParent) {
        console.log(elem);
        //alert(elem);
        //alert(elem.getAttribute("treeNodeValue"));

        //console.log(newParent);
        //alert(newParent);
        //alert(newParent.getAttribute("treeNodeValue"));


        var sourceNodeID = elem.getAttribute("treeNodeValue");
        var sourceNodeText = elem.getElementsByTagName("A")[0].innerHTML;
        var destinationNodeID = newParent.getAttribute("treeNodeValue");

        var destinationNodeAdditionalAttributes = newParent.getAttribute("additional-attributes");

        var destinationNodeJSONObject = JSON.parse(destinationNodeAdditionalAttributes);

        var destinationNodeNodeType = destinationNodeJSONObject.NodeType;
        var destinationNodeASSiteMapID = destinationNodeJSONObject.ASSiteMapID;

        //alert(sourceNodeID);
        //alert(sourceNodeText);
        //alert(destinationNodeID);
        //alert(destinationNodeNodeType);
        //alert(destinationNodeASSiteMapID);


        document.getElementById('<%=this.hypPSTreeDNDSourceNodeID.ClientID%>').value = sourceNodeID;
        document.getElementById('<%=this.hypPSTreeDNDSourceNodeText.ClientID%>').value = sourceNodeText;
        document.getElementById('<%=this.hypPSTreeDNDDestinationNodeID.ClientID%>').value = destinationNodeID;
        document.getElementById('<%=this.hypPSTreeDNDDestinationNodeNodeType.ClientID%>').value = destinationNodeNodeType;
        document.getElementById('<%=this.hypPSTreeDNDDestinationNodeASSiteMapID.ClientID%>').value = destinationNodeASSiteMapID;


        document.getElementById('<%=this.btnPSTreeDNDTrigger.ClientID%>').click();
    }

    function dndHandlerSM(elem, newParent) {
        var currentNodeID = elem.getAttribute("treeNodeValue");
        var newParentNodeID = newParent.getAttribute("treeNodeValue");

        var currentNodeAdditionalAttributes = elem.getAttribute("additional-attributes");
        var currentNodeJSONObject = JSON.parse(currentNodeAdditionalAttributes);
        var currentNodeNodeType = currentNodeJSONObject.NodeType;

        var newParentNodeAdditionalAttributes = newParent.getAttribute("additional-attributes");
        var newParentNodeJSONObject = JSON.parse(newParentNodeAdditionalAttributes);
        var newParentNodeNodeType = newParentNodeJSONObject.NodeType;

        alert(currentNodeID);
        alert(newParentNodeID);
        alert(currentNodeNodeType);
        alert(newParentNodeNodeType);


        document.getElementById('<%=this.hypSMTreeDNDCurrentNodeID.ClientID%>').value = currentNodeID;
        document.getElementById('<%=this.hypSMTreeDNDNewParentNodeID.ClientID%>').value = newParentNodeID;
        document.getElementById('<%=this.hypSMTreeDNDCurrentNodeNodeType.ClientID%>').value = currentNodeNodeType;
        document.getElementById('<%=this.hypSMTreeDNDNewParentNodeNodeType.ClientID%>').value = newParentNodeNodeType;

        document.getElementById('<%=this.btnSMTreeDNDTrigger.ClientID%>').click();
    }

</script>
<asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
<table>
    <tr>
        <td colspan="2">
            <table>
                <tr>
                    <td>
                        Select Sitemap
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:DropDownList Width="220" MaxHeight="300" ID="ddlSitemap" runat="server" AutoPostBack="true"
                            OnSelectedIndexChanged="ddlSitemap_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Roles
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:DropDownList Width="220" ID="ddlRole" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlRole_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        User
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <asp:DropDownList Width="220" Enabled="false" ID="ddlUser" runat="server" AutoPostBack="True"
                                        OnSelectedIndexChanged="ddlUser_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkIsUserPermission" Checked="false" runat="server" Text="Enable User Permission"
                                        AutoPostBack="True" OnCheckedChanged="chkIsUserPermission_CheckedChanged" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>        
    </tr>
    <tr>
        <td style="font-weight: bold; font-size: 13px;">
            Physical Structure
        </td>
        <td style="font-weight: bold; font-size: 13px;">
            Sitemap
        </td>
    </tr>
    <tr>
        <td style="font-weight: bold; font-size: 13px;">
            <asp:Button ID="btnSync" runat="server" Text="Sync Physical Tree" OnClick="btnSync_Click" />
        </td>
        <td style="font-weight: bold; font-size: 13px;">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td valign="top" style="width: 500px; font-size: 12px; font-family: Verdana">
            <div style="display: none;">
                <asp:Button ID="btnSelectionPBTrigger" runat="server" OnClick="btnSelectionPBTrigger_Click" />
                <asp:Button ID="btnCheckedPBTrigger" runat="server" OnClick="btnCheckPBTrigger_Click" />
                <asp:TextBox ID="txtSelectedNode" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtCheckedNode" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtCheckedNodeState" runat="server"></asp:TextBox>
                <asp:Button ID="btnPSTreeContextMenuClickTrigger" runat="server" OnClick="btnPSTreeContextMenuClickTrigger_Click" />
                <asp:HiddenField ID="hydPSTreeContextMenuCommandName" runat="server" Value="" />
                <asp:HiddenField ID="hydPSTreeContextMenuNodeID" runat="server" Value="" />
                <asp:Button ID="btnSMTreeContextMenuClickTrigger" runat="server" OnClick="btnSMTreeContextMenuClickTrigger_Click" />
                <asp:HiddenField ID="hydSMTreeContextMenuCommandName" runat="server" Value="" />
                <asp:HiddenField ID="hydSMTreeContextMenuNodeID" runat="server" Value="" />
                <asp:HiddenField ID="hydSMTreeContextMenuASSiteMapID" runat="server" Value="" />
                <asp:HiddenField ID="hydSMTreeContextMenuUniqueKey" runat="server" Value="" />
                <asp:Button ID="btnPSTreeDNDTrigger" runat="server" OnClick="btnPSTreeDNDTrigger_Click" />
                <asp:HiddenField ID="hypPSTreeDNDSourceNodeID" runat="server" Value="" />
                <asp:HiddenField ID="hypPSTreeDNDSourceNodeText" runat="server" Value="" />
                <asp:HiddenField ID="hypPSTreeDNDDestinationNodeID" runat="server" Value="" />
                <asp:HiddenField ID="hypPSTreeDNDDestinationNodeNodeType" runat="server" Value="" />
                <asp:HiddenField ID="hypPSTreeDNDDestinationNodeASSiteMapID" runat="server" Value="" />
                <asp:Button ID="btnSMTreeDNDTrigger" runat="server" OnClick="btnSMTreeDNDTrigger_Click" />
                <asp:HiddenField ID="hypSMTreeDNDCurrentNodeID" runat="server" Value="" />
                <asp:HiddenField ID="hypSMTreeDNDNewParentNodeID" runat="server" Value="" />
                <asp:HiddenField ID="hypSMTreeDNDCurrentNodeNodeType" runat="server" Value="" />
                <asp:HiddenField ID="hypSMTreeDNDNewParentNodeNodeType" runat="server" Value="" />
            </div>
            <ct:ASTreeView Font-Names="Segoe UI" Font-Size="10px" EnableThreeStateCheckbox="false"
                AutoPostBack="false" ID="psTree" runat="server" EnableNodeIcon="true" EnableCustomizedNodeIcon="true"
                BasePath="~/Scripts/ASTreeview179/astreeview/" DataTableRootNodeValue="0" EnableRoot="false"
                EnableNodeSelection="true" EnableCheckbox="true" EnableDragDrop="true" EnableTreeLines="true"
                EnableContextMenu="true" EnableContextMenuAdd="false" EnableContextMenuEdit="false"
                EnableContextMenuDelete="false" EnableDebugMode="false" EnableAjaxOnEditDelete="true"
                AddNodeProvider="~/Security/ASSiteMapBuilder.aspx" AdditionalAddRequestParameters="{'t2':'ajaxAdd'}"
                EditNodeProvider="~/Security/ASTreeViewRenameNodeHandler.aspx" DeleteNodeProvider="~/Security/ASTreeViewDeleteNodeProvider.aspx"
                DeleteNodePromptMessage="Are you sure to delete this item?" 
                AdditionalLoadNodesRequestParameters="{'t1':'ajaxLoad'}"
                LoadNodesProvider="~/Security/ASSiteMapBuilder.aspx"
                OnNodeCheckedScript="nodeCheckHandler(elem);"
                RelatedTrees="smTree" OnNodeDragAndDropCompletingScript="dndHandler(elem, newParent);" 
                OnNodeSelectedScript="nodeSelectHandler(elem)" />
                
        </td>
        <td valign="top" style="width: 500px; font-size: 12px; font-family: Verdana">
            <ct:ASTreeView Font-Names="Segoe UI" Font-Size="10px" EnableThreeStateCheckbox="false"
                AutoPostBack="false" ID="smTree" runat="server" EnableNodeIcon="true" EnableCustomizedNodeIcon="true"
                BasePath="~/Scripts/ASTreeview179/astreeview/" DataTableRootNodeValue="0" EnableRoot="false"
                EnableNodeSelection="true" EnableCheckbox="true" EnableDragDrop="true" EnableTreeLines="true"
                EnableContextMenu="true" EnableContextMenuAdd="false" EnableContextMenuEdit="true"
                EnableContextMenuDelete="false" EnableDebugMode="false" EnableAjaxOnEditDelete="true"
                AddNodeProvider="~/Security/ASSiteMapBuilder.aspx" AdditionalAddRequestParameters="{'t2':'ajaxAdd'}"
                EditNodeProvider="~/Security/ASSMTreeViewEditNodeHandler.aspx" DeleteNodeProvider="~/Security/ASSMTreeViewDeleteNodeHandler.aspx"
                DeleteNodePromptMessage="Are you sure to delete this item?" LoadNodesProvider="~/Security/ASSiteMapBuilder.aspx"
                AdditionalLoadNodesRequestParameters="{'t1':'ajaxLoad'}" OnNodeCheckedScript="nodeCheckHandler(elem);"
                OnNodeDragAndDropCompletingScript="dndHandlerSM(elem, newParent);" 
                OnNodeSelectedScript="nodeSelectHandler(elem)"/>
        </td>
    </tr>
    <%--
    <tr>
        <td valign="top"> 
        
            <script  type="text/javascript">

                function rtvDBStructure_OnClientContextMenuItemClicking(sender, args) {
                    
                var menuItem = args.get_menuItem();
                var treeNode = args.get_node();
                
                menuItem.get_menu().hide();

                switch (menuItem.get_value()) {
                    case "AddButtonToPage":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=0&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=1&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;
                    case "AddGridToPage":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=0&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=4&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;
                    case "AddTabStripToPage":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=0&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=3&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;
                        
                        
                    case "AddGridButtonColumnEPMS":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapControlID") + '&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=6&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;
                    case "AddTab":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapControlID") + '&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=2&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;


                    case "AddButtonToControl":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapControlID") + '&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=1&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;
                    case "AddGridToControl":
                        var url = 'ASPhysicalSiteMapControl.aspx?ParentASPhysicalSiteMapControlID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapControlID") + '&ASPhysicalSiteMapID=' + treeNode.get_attributes().getAttribute("ASPhysicalSiteMapID") + '&MDASControlTypeID=4&TabPageReferenceUniqueKey=' + treeNode.get_attributes().getAttribute("TabPageReferenceUniqueKey") + '';
                        var oWnd = radopen(url, "RadWindow1");
                        oWnd.center();
                        break;                    
                }
            }
            </script>
            
            <telerik:RadTreeView 
                ID="rtvDBStructure" 
                Runat="server" 
                CheckBoxes="true"
                onnodeexpand="rtvDBStructure_NodeExpand"
                EnableDragAndDrop="True" 
                MultipleSelect="True" 
                onnodedrop="rtvDBStructure_NodeDrop" 
                onnodecheck="rtvDBStructure_NodeCheck"
                OnContextMenuItemClick="rtvDBStructure_ContextMenuItemClick"
                OnClientContextMenuItemClicking="rtvDBStructure_OnClientContextMenuItemClicking">
                <ContextMenus>                
                    <telerik:RadTreeViewContextMenu ID="DBS_Blank_CM" runat="server">
                            <Items>
                            </Items>
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_RootFolderSync_CM" runat="server">
                            <Items>
                                <telerik:RadMenuItem Value="Synchronize" Text="Synchronize">
                                </telerik:RadMenuItem>
                            </Items>
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_FolderSync_CM" runat="server">
                            <Items>
                                <telerik:RadMenuItem Value="Synchronize" Text="Synchronize">
                                </telerik:RadMenuItem>
                                <telerik:RadMenuItem Value="DeleteFolder" Text="Delete" PostBack="true">
                                </telerik:RadMenuItem>
                            </Items>
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_ASPX_Page_CM" runat="server">
                        <Items>
                            <telerik:RadMenuItem Value="AddButtonToPage" Text="Add Button" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="AddGridToPage" Text="Add Grid" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="AddTabStripToPage" Text="Add Tab Strip" PostBack="false">
                            </telerik:RadMenuItem> 
                            <telerik:RadMenuItem Value="DeletePage" Text="Delete" PostBack="true">
                            </telerik:RadMenuItem>                            
                        </Items>
                        <CollapseAnimation Type="none" />
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_Delete_Control_CM" runat="server">
                            <Items>
                                <telerik:RadMenuItem Value="DeleteControl" Text="Delete" PostBack="true">
                                </telerik:RadMenuItem>
                            </Items>
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_Grid_CM" runat="server">
                            <Items>
                                <telerik:RadMenuItem Value="AddGridButtonColumnEPMS" Text="Add Link Button" PostBack="false">
                                </telerik:RadMenuItem>
                                <telerik:RadMenuItem Value="DeleteControl" Text="Delete" PostBack="true">
                                </telerik:RadMenuItem>
                            </Items>
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_TabStrip_CM" runat="server">
                        <Items>
                            <telerik:RadMenuItem Value="AddTab" Text="Add Tab" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="DeleteControl" Text="Delete" PostBack="true">
                            </telerik:RadMenuItem>
                        </Items>
                        <CollapseAnimation Type="none" />
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="DBS_Tab_CM" runat="server">
                        <Items>
                            <telerik:RadMenuItem Value="AddTab" Text="Add Tab" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="AddButtonToControl" Text="Add Button" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="AddGridToControl" Text="Add Grid" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="DeleteControl" Text="Delete" PostBack="true">
                            </telerik:RadMenuItem>
                        </Items>
                        <CollapseAnimation Type="none" />
                    </telerik:RadTreeViewContextMenu>
                </ContextMenus>
            </telerik:RadTreeView>
            
        </td>
        <td valign="top">
            
            <script  type="text/javascript">
                function rtvSiteMap_OnClientContextMenuItemClicking(sender, args)
                {
                    var menuItem = args.get_menuItem();
                    var treeNode = args.get_node();

                    menuItem.get_menu().hide();
                    
                    switch(menuItem.get_value())
                    {
                        case "AddIcon":
                            var url = 'AddIconToMenuItem.aspx?ASSiteMapID=' + treeNode.get_attributes().getAttribute("ASSiteMapID") + '&ASSiteMapNodeID=' + treeNode.get_value();
                            var oWnd = radopen(url, "RadWindow1");
                            oWnd.center();
                            break;                                       
                    }
                }
            </script>   
                
            <telerik:RadTreeView 
                ID="rtvSiteMap" 
                Runat="server" 
                CheckBoxes="true"
                onnodeexpand="rtvSiteMap_NodeExpand"
                EnableDragAndDrop="True" 
                MultipleSelect="True" 
                onnodedrop="rtvSiteMap_NodeDrop"
                AllowNodeEditing="true"
                OnNodeEdit="rtvSiteMap_NodeEdit"
                OnContextMenuItemClick="rtvSiteMap_ContextMenuItemClick" 
                onnodecheck="rtvSiteMap_NodeCheck"
                EnableDragAndDropBetweenNodes="true"
                OnClientContextMenuItemClicking="rtvSiteMap_OnClientContextMenuItemClicking">
                <ContextMenus>
                    <telerik:RadTreeViewContextMenu ID="BlankContextMenu" runat="server">
                        <Items>
                        </Items>
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="RootContextMenu" runat="server">
                        <Items>
                            <telerik:RadMenuItem Value="AddNewBlankNode" Text="Add New Blank Node">
                            </telerik:RadMenuItem>
                        </Items>
                        <CollapseAnimation Type="none" />
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="FolderContextMenu" runat="server">
                        <Items>
                            <telerik:RadMenuItem Value="AddNewBlankNode" Text="Add New Blank Node">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="DeleteFolderNode" Text="Delete Node">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="AddIcon" Text="Add Icon" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="RemoveIcon" Text="Remove Icon">
                            </telerik:RadMenuItem>             
                        </Items>
                        <CollapseAnimation Type="none" />
                    </telerik:RadTreeViewContextMenu>
                    <telerik:RadTreeViewContextMenu ID="PageContextMenu" runat="server">
                        <Items>
                            <telerik:RadMenuItem Value="DeletePageNode" Text="Delete Node">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="AddIcon" Text="Add Icon" PostBack="false">
                            </telerik:RadMenuItem>
                            <telerik:RadMenuItem Value="RemoveIcon" Text="Remove Icon">
                            </telerik:RadMenuItem>                            
                        </Items>
                        <CollapseAnimation Type="none" />
                    </telerik:RadTreeViewContextMenu>
                </ContextMenus>
            </telerik:RadTreeView>
            
        </td>
    </tr>--%>
</table>
<%--<telerik:RadWindowManager ShowContentDuringLoad="false" ID="RadWindowManager1" Width="610px" Height="330px" runat="server">
</telerik:RadWindowManager>--%>