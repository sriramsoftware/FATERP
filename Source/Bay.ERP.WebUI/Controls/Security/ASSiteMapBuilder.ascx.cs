using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web.Compilation;
using System.Collections.Generic;

using Bay.ERP.Web.UI;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;
using Geekees.Common.Controls;
using System.Web.Script.Serialization;

namespace Bay.ERP.Web.UI
{
    public partial class ASSiteMapBuilderControl : BaseControl
    {
        #region Member Variables

        public KeyValuePair<String, String> CMI_SYNCHRONIZE = new KeyValuePair<string, string>("Synchronize", "Synchronize");
        public KeyValuePair<String, String> CMI_DELETE_CONTROL = new KeyValuePair<string, string>("Delete Control", "DeleteControl");
        public KeyValuePair<String, String> CMI_DELETE_PAGE = new KeyValuePair<string, string>("Delete Page", "DeletePage");
        public KeyValuePair<String, String> CMI_DELETE_FOLDER = new KeyValuePair<string, string>("Delete Folder", "DeleteFolder");

        public KeyValuePair<String, String> CMI_ADD_BLANK_NODE = new KeyValuePair<string, string>("Add Blank Node", "AddBlankNode");        

        Dictionary<String, String> psContextMenuItems = new Dictionary<String, String>();
        Dictionary<String, String> smContextMenuItems = new Dictionary<String, String>();

        #endregion

        #region Properties

        #endregion

        #region Methods

        private void AddDefaultContextMenuItemsInPSTree()
        {
            psContextMenuItems.Add(CMI_SYNCHRONIZE.Key, CMI_SYNCHRONIZE.Value);
            psContextMenuItems.Add(CMI_DELETE_CONTROL.Key, CMI_DELETE_CONTROL.Value);
            psContextMenuItems.Add(CMI_DELETE_PAGE.Key, CMI_DELETE_PAGE.Value);
            psContextMenuItems.Add(CMI_DELETE_FOLDER.Key, CMI_DELETE_FOLDER.Value);

            foreach (KeyValuePair<String, String> pair in psContextMenuItems)
            {
                this.psTree.ContextMenu.MenuItems.Add(
                    new ASContextMenuItem(
                        pair.Key //menu text
                        , "psContextMenuItemClicked('" + pair.Value + "', "
                            + this.psTree.ContextMenuClientID
                            + ".getSelectedItem().parentNode.getAttribute('treeNodeValue')"
                            + ");return false;" //execution javascript
                        , pair.Value)); //command name 
            }
        }

        private void AddDefaultContextMenuItemsInSMTree()
        {
            smContextMenuItems.Add(CMI_ADD_BLANK_NODE.Key, CMI_ADD_BLANK_NODE.Value);
            smContextMenuItems.Add(CMI_DELETE_PAGE.Key, CMI_DELETE_PAGE.Value);
            smContextMenuItems.Add(CMI_DELETE_FOLDER.Key, CMI_DELETE_FOLDER.Value);

            foreach (KeyValuePair<String, String> pair in smContextMenuItems)
            {
                this.smTree.ContextMenu.MenuItems.Add(
                    new ASContextMenuItem(
                        pair.Key //menu text
                        , "smContextMenuItemClicked(" 
                            + "'" + pair.Value + "', "
                            + this.smTree.ContextMenuClientID + ".getSelectedItem().parentNode.getAttribute('treeNodeValue')" + ", "
                            + this.smTree.ContextMenuClientID + ".getSelectedItem().parentNode.getAttribute('additional-attributes')"
                            + ");return false;" //execution javascript
                        , pair.Value)); //command name 
            }
        }

        private void EnableContextMenuItemToPSTree(ASTreeViewNode treeNode, String[] contextMenuItems)
        {
            foreach (KeyValuePair<String, String> pair in psContextMenuItems)
            {
                Boolean found = false;

                foreach (String contextMenuItem in contextMenuItems)
                {
                    if (pair.Key == contextMenuItem)
                    {
                        found = true;
                    }
                    
                }

                if (found == false)
                {
                    treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("disable" + pair.Value, "true"));
                }
            }
        }

        private void EnableContextMenuItemToSMTree(ASTreeViewNode treeNode, String[] contextMenuItems)
        {
            foreach (KeyValuePair<String, String> pair in smContextMenuItems)
            {
                Boolean found = false;

                foreach (String contextMenuItem in contextMenuItems)
                {
                    if (pair.Key == contextMenuItem)
                    {
                        found = true;
                    }

                }

                if (found == false)
                {
                    treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("disable" + pair.Value, "true"));
                }
            }
        }

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateASSiteMap(ddlSitemap, false);
        }

        private void GenerateRoles()
        {
            ddlRole.Items.Clear();

            foreach (String rolename in Roles.GetAllRoles())
            {
                ddlRole.Items.Add(new ListItem(rolename, rolename));
            }

            GenerateUsers();
        }

        private void GenerateUsers()
        {
            ddlUser.Items.Clear();

            if (ddlRole.Items.Count > 0)
            {
                String[] users = Roles.GetUsersInRole(ddlRole.SelectedValue);

                foreach (String user in users)
                {
                    ddlUser.Items.Add(new ListItem(user, user));
                }
            }
        }

        private void PrepareInitialView()
        {
            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();

            BuildDropDownList();

            GenerateRoles();

            PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

            InititializeDBTree();

            InititializeSiteMapTree();
        }

        private void TreeNodeCheck(ASTreeViewNode checkedNode)
        {
            if (chkIsUserPermission.Checked)
            {
                #region User Permission

                if (checkedNode.CheckedState == ASTreeViewCheckboxState.Checked)
                {
                    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_ASUserName, ddlUser.SelectedValue, SQLMatchType.Equal);
                    String filterExpression2 = String.Empty;
                    if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "WebPage")
                    {
                        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_PermissionKey, MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey"), SQLMatchType.Equal);
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Control")
                    {
                        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_PermissionKey, MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "CombinedUniqueKey"), SQLMatchType.Equal);
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Folder")
                    {
                        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_PermissionKey, MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey"), SQLMatchType.Equal);
                    }

                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                    IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList = FCCASUserPermissionExcluded.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                    if (aSUserPermissionExcludedEntityList != null && aSUserPermissionExcludedEntityList.Count > 0)
                    {
                        FCCASUserPermissionExcluded.GetFacadeCreate().Delete(aSUserPermissionExcludedEntityList[0], filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }
                else
                {
                    ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity = new ASUserPermissionExcludedEntity();

                    aSUserPermissionExcludedEntity.ASUserName = ddlUser.SelectedValue;

                    if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "WebPage")
                    {
                        aSUserPermissionExcludedEntity.PermissionKey = MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey");
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Control")
                    {
                        aSUserPermissionExcludedEntity.PermissionKey = MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "CombinedUniqueKey");
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Folder")
                    {
                        aSUserPermissionExcludedEntity.PermissionKey = MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey");
                    }

                    FCCASUserPermissionExcluded.GetFacadeCreate().Add(aSUserPermissionExcludedEntity, DatabaseOperationType.Add, TransactionRequired.No);
                }

                PermissionHelper.PreserveUserPermissionKeysForPermissionApply(ddlUser.SelectedValue);

                #endregion
            }
            else
            {
                #region Role Permission

                if (checkedNode.CheckedState == ASTreeViewCheckboxState.Checked)
                {
                    ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

                    aSRolePermissionEntity.ASRoleName = ddlRole.SelectedValue;

                    if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "WebPage")
                    {
                        aSRolePermissionEntity.PermissionKey =MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey");
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Control")
                    {
                        aSRolePermissionEntity.PermissionKey = MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "CombinedUniqueKey");
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Folder")
                    {
                        aSRolePermissionEntity.PermissionKey = MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey");
                    }

                    FCCASRolePermission.GetFacadeCreate().Add(aSRolePermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                }
                else
                {
                    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_ASRoleName, ddlRole.SelectedValue, SQLMatchType.Equal);
                    String filterExpression2 = String.Empty;
                    if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "WebPage")
                    {
                        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_PermissionKey, MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey"), SQLMatchType.Equal);
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Control")
                    {
                        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_PermissionKey, MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "CombinedUniqueKey"), SQLMatchType.Equal);
                    }
                    else if (MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "NodeType") == "Folder")
                    {
                        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_PermissionKey, MiscUtil.GetASTreeNodeAttributeValue(checkedNode.AdditionalAttributes, "UniqueKey"), SQLMatchType.Equal);
                    }

                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                    IList<ASRolePermissionEntity> aSRolePermissionEntityList = FCCASRolePermission.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                    if (aSRolePermissionEntityList != null && aSRolePermissionEntityList.Count > 0)
                    {
                        FCCASRolePermission.GetFacadeCreate().Delete(aSRolePermissionEntityList[0], filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }

                PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

                #endregion
            }

            PermissionHelper.PreserveUserPermissionKeys(HttpContext.Current.User.Identity.Name);
        }

        #region DB tree methods

        private void InititializeDBTree()
        {
            psTree.RootNode.ChildNodes.Clear();

            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ParentASPhysicalSiteMapID, String.Empty, SQLMatchType.IsNull);

            IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, null, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
            {
                ASTreeViewNode rootNode = new ASTreeViewNode(aSPhysicalSiteMapEntityList[0].Name,aSPhysicalSiteMapEntityList[0].ASPhysicalSiteMapID.ToString());

                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapEntityList[0].ASPhysicalSiteMapID.ToString()));
                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("PhysicalPath", aSPhysicalSiteMapEntityList[0].PhysicalPath));
                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ParentASPhysicalSiteMapID", "null"));
                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Folder"));
                rootNode.EnableCheckbox = false;
                rootNode.NodeIcon = @"~/Images/folder.jpg";
                AddChildsNodesToDBTree(aSPhysicalSiteMapEntityList[0].ASPhysicalSiteMapID, rootNode);

                EnableContextMenuItemToPSTree(rootNode, new String[] { CMI_SYNCHRONIZE.Key });

                psTree.RootNode.ChildNodes.Add(rootNode);
            }
        }

        private void AddChildsNodesToDBTree(Int64 parentID, ASTreeViewNode currentNode)
        {
            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASPhysicalSiteMapEntity.FLD_NAME_Name, SQLSortOrderType.Assending);
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ParentASPhysicalSiteMapID, parentID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);

            if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
            {
                #region Adding the Folders

                foreach (ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity in aSPhysicalSiteMapEntityList)
                {
                    ASTreeViewNode treeNode = new ASTreeViewNode(aSPhysicalSiteMapEntity.Name, aSPhysicalSiteMapEntity.ASPhysicalSiteMapID.ToString());

                    switch (aSPhysicalSiteMapEntity.MDASNodeTypeID)
                    {
                        case SecurityConstants.MDASNodeType.FOLDER:
                            treeNode.NodeIcon = @"~/Images/folder.jpg";
                            treeNode.EnableCheckbox = false;

                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Folder"));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapEntity.ASPhysicalSiteMapID.ToString()));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("PhysicalPath", aSPhysicalSiteMapEntity.PhysicalPath));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ParentASPhysicalSiteMapID", aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID.ToString()));
                            EnableContextMenuItemToPSTree(treeNode, new String[] { CMI_SYNCHRONIZE.Key, CMI_DELETE_FOLDER.Key });

                            //additional settings for astree
                            treeNode.VirtualNodesCount = 0;
                            treeNode.VirtualParentKey = aSPhysicalSiteMapEntity.ASPhysicalSiteMapID.ToString();
                            treeNode.IsVirtualNode = true;
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("onclick", "return false;"));
                            

                            currentNode.ChildNodes.Add(treeNode);

                            break;
                    }
                }

                #endregion

                #region Adding the Pages

                foreach (ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity in aSPhysicalSiteMapEntityList)
                {
                    ASTreeViewNode treeNode = new ASTreeViewNode("d", "d", "http://localhost:7777/Bay.ERP.WebUI/Images/aspx.png");

                    switch (aSPhysicalSiteMapEntity.MDASNodeTypeID)
                    {
                        case SecurityConstants.MDASNodeType.WEB_PAGE:
                            treeNode.NodeIcon = @"~/Images/aspx.png";                            
                            treeNode.EnableCheckbox = true;
                            treeNode.OpenState = ASTreeViewNodeOpenState.Close;

                            #region Adding Controls

                            String filterExpressionControl1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, aSPhysicalSiteMapEntity.ASPhysicalSiteMapID.ToString(), SQLMatchType.Equal);
                            String filterExpressionControl2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, String.Empty, SQLMatchType.IsNull);
                            String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(filterExpressionControl1, SQLJoinType.AND, filterExpressionControl2);

                            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

                            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
                            {
                                foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
                                {
                                    ASTreeViewNode controlNode = new ASTreeViewNode("","");

                                    //Newly added line to get the checked item
                                    controlNode.NodeValue = aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString();

                                    controlNode.NodeText = aSPhysicalSiteMapControlEntity.ControlName;
                                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapControlID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString()));
                                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID.ToString()));
                                    if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNullOrEmpty())
                                    {
                                        controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("TabPageReferenceUniqueKey", String.Empty));
                                    }
                                    else
                                    {
                                        controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("TabPageReferenceUniqueKey", aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey));
                                    }

                                    if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.BUTTON_EPMS)
                                    {
                                        controlNode.NodeIcon = @"~/Images/button.JPG";
                                        controlNode.EnableCheckbox = true;
                                        //controlNode.ContextMenuID = "DBS_Delete_Control_CM";
                                    }
                                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_EPMS)
                                    {
                                        controlNode.NodeIcon = @"~/Images/tab.JPG";
                                        controlNode.EnableCheckbox = true;
                                        //controlNode.ContextMenuID = "DBS_Tab_CM";
                                    }
                                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_STRIP)
                                    {
                                        controlNode.NodeIcon = @"~/Images/tabstrip.gif";                                        
                                        controlNode.EnableCheckbox = false;
                                        //controlNode.ContextMenuID = "DBS_TabStrip_CM";
                                    }
                                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID)
                                    {
                                        controlNode.NodeIcon = @"~/Images/Grid.png";                                        
                                        controlNode.EnableCheckbox = false;
                                        //controlNode.ContextMenuID = "DBS_Grid_CM";
                                    }
                                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS)
                                    {
                                        controlNode.NodeIcon = @"~/Images/LinkButton.gif";
                                        controlNode.EnableCheckbox = true;
                                        //controlNode.ContextMenuID = "DBS_Delete_Control_CM";
                                    }

                                    String combinedUniqueKey = String.Empty;

                                    if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNotNullOrEmpty() && aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey != "undefined")
                                    {
                                        combinedUniqueKey = aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                                    }
                                    else
                                    {
                                        combinedUniqueKey = aSPhysicalSiteMapEntity.UniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                                    }


                                    #region Control Permission

                                    if (chkIsUserPermission.Checked)
                                    {
                                        controlNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(combinedUniqueKey);

                                        if (controlNode.EnableCheckbox)
                                        {
                                            if(PermissionHelper.IsUerHasPermissionForPermissionApply(combinedUniqueKey) == true )
                                            {
                                                controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                            }
                                            else
                                            {
                                                controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if(PermissionHelper.IsRoleHasPermission(combinedUniqueKey) == true )
                                        {
                                            controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                        }
                                        else
                                        {
                                            controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                        }
                                    }

                                    #endregion

                                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("CombinedUniqueKey", combinedUniqueKey));
                                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Control"));

                                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapUniqueKey", aSPhysicalSiteMapEntity.UniqueKey));
                                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ParentASPhysicalSiteMapID", aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID.ToString()));

                                    EnableContextMenuItemToPSTree(controlNode, new String[] { CMI_DELETE_CONTROL.Key });

                                    AddSubControls(controlNode);

                                    treeNode.ChildNodes.Add(controlNode);
                                }
                            }

                            #endregion

                            #region Page Permission

                            if (chkIsUserPermission.Checked)
                            {
                                treeNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(aSPhysicalSiteMapEntity.UniqueKey);

                                if (treeNode.EnableCheckbox)
                                {
                                    if(PermissionHelper.IsUerHasPermissionForPermissionApply(aSPhysicalSiteMapEntity.UniqueKey) == true)
                                    {
                                        treeNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                    }
                                    else
                                    {
                                        treeNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                    }
                                }
                            }
                            else
                            {
                                if(PermissionHelper.IsRoleHasPermission(aSPhysicalSiteMapEntity.UniqueKey) == true)
                                {
                                    treeNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                }
                                else
                                {
                                    treeNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                }
                            }

                            #endregion

                            treeNode.NodeText = aSPhysicalSiteMapEntity.Name;
                            treeNode.NodeValue = aSPhysicalSiteMapEntity.ASPhysicalSiteMapID.ToString();
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("UniqueKey", aSPhysicalSiteMapEntity.UniqueKey));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "WebPage"));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapEntity.ASPhysicalSiteMapID.ToString()));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("PhysicalPath", aSPhysicalSiteMapEntity.PhysicalPath));
                            treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ParentASPhysicalSiteMapID", aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID.ToString()));
                            EnableContextMenuItemToPSTree(treeNode, new String[] { CMI_SYNCHRONIZE.Key, CMI_DELETE_PAGE.Key });

                            currentNode.ChildNodes.Add(treeNode);

                            break;
                    }
                }

                #endregion
            }
        }

        private void AddSubControls(ASTreeViewNode currentControl)
        {
            String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, MiscUtil.GetASTreeNodeAttributeValue(currentControl.AdditionalAttributes, "ASPhysicalSiteMapControlID"), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            {
                foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
                {
                    ASTreeViewNode controlNode = new ASTreeViewNode(aSPhysicalSiteMapControlEntity.ControlName, aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString());

                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapControlID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString()));
                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID.ToString()));
                    if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNullOrEmpty())
                    {
                        controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("TabPageReferenceUniqueKey", String.Empty));
                    }
                    else
                    {
                        controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("TabPageReferenceUniqueKey", aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey));
                    }

                    if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.BUTTON_EPMS)
                    {
                        controlNode.NodeIcon = @"~/Images/button.JPG";
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_EPMS)
                    {
                        controlNode.NodeIcon = @"~/Images/tab.JPG";
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_STRIP)
                    {
                        controlNode.NodeIcon = @"~/Images/tabstrip.gif";
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID)
                    {
                        controlNode.NodeIcon = @"~/Images/Grid.png";
                        controlNode.EnableCheckbox = false;
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS)
                    {
                        controlNode.NodeIcon = @"~/Images/LinkButton.gif";
                        controlNode.EnableCheckbox = true;
                    }

                    String combinedUniqueKey = String.Empty;

                    if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNotNullOrEmpty() && aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey != "undefined")
                    {
                        combinedUniqueKey = aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                    }
                    else
                    {

                        combinedUniqueKey = MiscUtil.GetASTreeNodeAttributeValue(currentControl.AdditionalAttributes, "ASPhysicalSiteMapUniqueKey") + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                    }

                    #region Control Permission

                    if (chkIsUserPermission.Checked)
                    {
                        controlNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(combinedUniqueKey);

                        if (controlNode.EnableCheckbox)
                        {
                            if(PermissionHelper.IsUerHasPermissionForPermissionApply(combinedUniqueKey) == true)
                            {
                                controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                            }
                            else
                            {
                                controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                            }
                        }
                    }
                    else
                    {
                        if (PermissionHelper.IsRoleHasPermission(combinedUniqueKey) == true)
                        {
                            controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                        }
                        else
                        {
                            controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                        }
                    }

                    #endregion

                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("CombinedUniqueKey", combinedUniqueKey));
                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Control"));

                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapUniqueKey", MiscUtil.GetASTreeNodeAttributeValue(currentControl.AdditionalAttributes, "ASPhysicalSiteMapUniqueKey")));

                    EnableContextMenuItemToPSTree(controlNode, new String[] { CMI_DELETE_CONTROL.Key });

                    AddSubControls(controlNode);

                    currentControl.ChildNodes.Add(controlNode);
                }
            }
        }

        #endregion

        #region SiteMap methods

        private void InititializeSiteMapTree()
        {
            Int64 aSSiteMapID = Int64.Parse(ddlSitemap.SelectedValue);

            smTree.RootNode.ChildNodes.Clear();

            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapNodeID, SQLSortOrderType.Assending);
            String filterExpression1 = "ASSiteMapNode." + SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapID, aSSiteMapID.ToString(), SQLMatchType.Equal);
            String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, String.Empty, SQLMatchType.IsNull);
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            IList<ASSiteMapNode_DetailedEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            if (aSSiteMapNodeEntityList != null && aSSiteMapNodeEntityList.Count > 0)
            {
                ASTreeViewNode rootNode = new ASTreeViewNode("Web Root", "0");

                rootNode.NodeText = aSSiteMapNodeEntityList[0].MenuTitle;
                rootNode.NodeValue = aSSiteMapNodeEntityList[0].ASSiteMapNodeID.ToString();
                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASSiteMapID", aSSiteMapID.ToString()));
                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("UniqueKey", aSSiteMapNodeEntityList[0].UniqueKey));                
                rootNode.NodeIcon = @"~/Images/folder.jpg";
                rootNode.EnableCheckbox = false;
                rootNode.EnableEditContextMenu = false;
                rootNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Folder"));

                EnableContextMenuItemToSMTree(rootNode, new String[] { CMI_ADD_BLANK_NODE.Key });

                AddChildsNodesToSiteMap(aSSiteMapNodeEntityList[0].ASSiteMapNodeID, rootNode);

                smTree.RootNode.ChildNodes.Add(rootNode);
            }
        }

        private void AddChildsNodesToSiteMap(Int64 parentID, ASTreeViewNode currentNode)
        {
            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, parentID.ToString(), SQLMatchType.Equal);

            IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
            {
                foreach (ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity in aSSiteMapNode_DetailedEntityList)
                {
                    ASTreeViewNode treeNode = new ASTreeViewNode(aSSiteMapNode_DetailedEntity.MenuTitle, aSSiteMapNode_DetailedEntity.ASSiteMapNodeID.ToString());

                    treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASSiteMapID", aSSiteMapNode_DetailedEntity.ASSiteMapID.ToString()));
                    treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ParentASSiteMapNodeID", parentID.ToString()));
                    treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("SequenceNumber", aSSiteMapNode_DetailedEntity.SequenceNumber.ToString()));
                    treeNode.EnableCheckbox = true;
                    treeNode.OpenState = ASTreeViewNodeOpenState.Close;

                    if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID == null)
                    {
                        treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("UniqueKey", aSSiteMapNode_DetailedEntity.UniqueKey));
                        treeNode.NodeIcon = @"~/Images/folder.jpg";

                        #region Blank Node Permission

                        if (chkIsUserPermission.Checked)
                        {
                            treeNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(aSSiteMapNode_DetailedEntity.UniqueKey);

                            if (treeNode.EnableCheckbox)
                            {
                                if (PermissionHelper.IsUerHasPermissionForPermissionApply(aSSiteMapNode_DetailedEntity.UniqueKey) == true)
                                {
                                    treeNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                }
                                else
                                {
                                    treeNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                }
                                
                            }
                        }
                        else
                        {
                            if (PermissionHelper.IsRoleHasPermission(aSSiteMapNode_DetailedEntity.UniqueKey) == true)
                            {
                                treeNode.CheckedState = ASTreeViewCheckboxState.Checked;
                            }
                            else
                            {
                                treeNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                            }
                            ;
                        }
                        #endregion
                        //treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("UniqueKey", aSSiteMapNode_DetailedEntity.UniqueKey));
                        treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Folder"));

                        EnableContextMenuItemToSMTree(treeNode, new String[] { CMI_ADD_BLANK_NODE.Key, CMI_DELETE_FOLDER.Key });
                    }
                    else if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID > 0)
                    {
                        treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("UniqueKey", aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey));
                        treeNode.NodeIcon = @"~/Images/aspx.png";                        

                        #region Adding Controls

                        String filterExpressionControl1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID.ToString(), SQLMatchType.Equal);
                        String filterExpressionControl2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, String.Empty, SQLMatchType.IsNull);
                        String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(filterExpressionControl1, SQLJoinType.AND, filterExpressionControl2);

                        IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

                        if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
                        {
                            foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
                            {
                                ASTreeViewNode controlNode = new ASTreeViewNode("d", "d");
                                // might need to add the node value here
                                controlNode.NodeText = aSPhysicalSiteMapControlEntity.ControlName;
                                controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapControlID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString()));
                                controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID.ToString()));

                                controlNode.EnableEditContextMenu = false;
                                EnableContextMenuItemToSMTree(controlNode, new String[] { });

                                if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.BUTTON_EPMS)
                                {
                                    controlNode.NodeIcon = @"~/Images/button.JPG";
                                    controlNode.EnableCheckbox = true;
                                }
                                else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_EPMS)
                                {
                                    controlNode.NodeIcon = @"~/Images/tab.JPG";
                                    controlNode.EnableCheckbox = true;
                                }
                                else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_STRIP)
                                {
                                    controlNode.NodeIcon = @"~/Images/tabstrip.gif";
                                    controlNode.EnableCheckbox = false;
                                }
                                else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID)
                                {
                                    controlNode.NodeIcon = @"~/Images/Grid.png";
                                    controlNode.EnableCheckbox = false;
                                }
                                else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS)
                                {
                                    controlNode.NodeIcon = @"~/Images/LinkButton.gif";
                                    controlNode.EnableCheckbox = true;
                                }

                                //String combinedUniqueKey = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;

                                String combinedUniqueKey = String.Empty;

                                if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNotNullOrEmpty() && aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey != "undefined")
                                {
                                    combinedUniqueKey = aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                                }
                                else
                                {
                                    combinedUniqueKey = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                                }

                                #region Control Permission
                                if (chkIsUserPermission.Checked)
                                {
                                    controlNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(combinedUniqueKey);

                                    if (controlNode.EnableCheckbox)
                                    {
                                        if (PermissionHelper.IsUerHasPermissionForPermissionApply(combinedUniqueKey) == true)
                                        {
                                            controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                        }
                                        else
                                        {
                                            controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                        }
                                    }
                                }
                                else
                                {
                                    if (PermissionHelper.IsRoleHasPermission(combinedUniqueKey) == true)
                                    {
                                        controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                    }
                                    else
                                    {
                                        controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                    }
                                }
                                #endregion
                                controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("CombinedUniqueKey", combinedUniqueKey));
                                controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Control"));

                                controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapUniqueKey", aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey));

                                AddSubControlsToSiteMap(controlNode);

                                treeNode.ChildNodes.Add(controlNode);
                            }
                        }

                        #endregion

                        #region Pgae Permission

                        if (chkIsUserPermission.Checked)
                        {
                            treeNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey);

                            if (treeNode.EnableCheckbox)
                            {
                                if (PermissionHelper.IsUerHasPermissionForPermissionApply(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey) == true)
                                {
                                    treeNode.CheckedState = ASTreeViewCheckboxState.Checked;
                                }
                                else
                                {
                                    treeNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                                }
                            }
                        }
                        else
                        {
                            if (PermissionHelper.IsRoleHasPermission(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey) == true)
                            {
                                treeNode.CheckedState = ASTreeViewCheckboxState.Checked;
                            }
                            else
                            {
                                treeNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                            }
                        }

                        #endregion
                        
                        //treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("UniqueKey", aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey));
                        treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "WebPage"));

                        EnableContextMenuItemToSMTree(treeNode, new String[] { CMI_DELETE_PAGE.Key });
                    }
                    else
                    {
                        treeNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("TabPageReferenceUniqueKey", String.Empty));
                    }

                    AddChildsNodesToSiteMap(aSSiteMapNode_DetailedEntity.ASSiteMapNodeID, treeNode);

                    currentNode.ChildNodes.Add(treeNode);
                }
            }
        }

        private void AddSubControlsToSiteMap(ASTreeViewNode currentControl)
        {
            String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, MiscUtil.GetASTreeNodeAttributeValue(currentControl.AdditionalAttributes, "ASPhysicalSiteMapControlID"), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            {
                foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
                {
                    ASTreeViewNode controlNode = new ASTreeViewNode("d", "d");

                    controlNode.NodeText = aSPhysicalSiteMapControlEntity.ControlName;
                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapControlID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString()));
                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapID", aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID.ToString()));
                    controlNode.OpenState = ASTreeViewNodeOpenState.Close;

                    if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.BUTTON_EPMS)
                    {
                        controlNode.NodeIcon = @"~/Images/button.JPG";
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_EPMS)
                    {
                        controlNode.NodeIcon = @"~/Images/tab.JPG";
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_STRIP)
                    {
                        controlNode.NodeIcon = @"~/Images/tabstrip.gif";
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID)
                    {
                        controlNode.NodeIcon = @"~/Images/Grid.png";
                        controlNode.EnableCheckbox = false;
                    }
                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS)
                    {
                        controlNode.NodeIcon = @"~/Images/LinkButton.gif";
                        controlNode.EnableCheckbox = true;
                    }

                    String combinedUniqueKey = String.Empty;

                    if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNotNullOrEmpty() && aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey != "undefined")
                    {
                        combinedUniqueKey = aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                    }
                    else
                    {
                        combinedUniqueKey = MiscUtil.GetASTreeNodeAttributeValue(currentControl.AdditionalAttributes, "ASPhysicalSiteMapUniqueKey") + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
                    }

                    #region Control Permission

                    if (chkIsUserPermission.Checked)
                    {
                        controlNode.EnableCheckbox = PermissionHelper.IsRoleHasPermission(combinedUniqueKey);

                        if (controlNode.EnableCheckbox)
                        {
                            if (PermissionHelper.IsUerHasPermissionForPermissionApply(combinedUniqueKey) == true)
                            {
                                controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                            }
                            else
                            {
                                controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                            }
                        }
                    }
                    else
                    {
                        if (PermissionHelper.IsRoleHasPermission(combinedUniqueKey) == true)
                        {
                            controlNode.CheckedState = ASTreeViewCheckboxState.Checked;
                        }
                        else
                        {
                            controlNode.CheckedState = ASTreeViewCheckboxState.Unchecked;
                        }
                    }

                    #endregion

                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("CombinedUniqueKey", combinedUniqueKey));
                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("NodeType", "Control"));

                    controlNode.AdditionalAttributes.Add(new KeyValuePair<string, string>("ASPhysicalSiteMapUniqueKey", MiscUtil.GetASTreeNodeAttributeValue(currentControl.AdditionalAttributes, "ASPhysicalSiteMapUniqueKey")));

                    controlNode.EnableEditContextMenu = false;
                    EnableContextMenuItemToSMTree(controlNode, new String[] { });

                    AddSubControlsToSiteMap(controlNode);

                    currentControl.ChildNodes.Add(controlNode);
                }
            }
        }

        #endregion

        #region Synchronization

        private void doSyn(DirectoryInfo directoryinfo, Int64 parentID)
        {
            #region Main Folder

            String physicalPath = directoryinfo.FullName.Replace(MapPath(@"~"), SecurityConstants.ROOT_FOLDER_NAME);


            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_PhysicalPath, physicalPath, SQLMatchType.Equal);

            IList<ASPhysicalSiteMapEntity> parentASPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            if (parentASPhysicalSiteMapEntityList == null)
            {
                ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity = new ASPhysicalSiteMapEntity();

                aSPhysicalSiteMapEntity.Name = directoryinfo.Name;
                aSPhysicalSiteMapEntity.PhysicalPath = physicalPath;
                aSPhysicalSiteMapEntity.NavigationURL = String.Empty;
                aSPhysicalSiteMapEntity.UniqueKey = String.Empty;
                aSPhysicalSiteMapEntity.MDASNodeTypeID = SecurityConstants.MDASNodeType.FOLDER;

                if (directoryinfo.FullName == MapPath(@"~"))
                {
                    //aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID = null;
                }
                else
                {

                    aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID = parentID;
                }

                parentID = FCCASPhysicalSiteMap.GetFacadeCreate().Add(aSPhysicalSiteMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
            }
            else if (parentASPhysicalSiteMapEntityList != null && parentASPhysicalSiteMapEntityList.Count > 0)
            {
                parentID = parentASPhysicalSiteMapEntityList[0].ASPhysicalSiteMapID;
            }

            #endregion

            #region Child Foldes

            foreach (DirectoryInfo childdirectory in directoryinfo.GetDirectories())
            {
                if (IsChildDirectoryValid(childdirectory))
                {
                    doSyn(childdirectory, parentID);
                }
            }

            #endregion

            #region ASPX Files

            foreach (FileInfo childfile in directoryinfo.GetFiles("*.aspx"))
            {
                Type type = BuildManager.GetCompiledType(childfile.FullName.Replace(MapPath("~"), "~"));
                System.Web.UI.Page page = (System.Web.UI.Page)BuildManager.CreateInstanceFromVirtualPath(childfile.FullName.Replace(MapPath("~"), "~"), type.BaseType);

                String physicalPathASPX = childfile.FullName.Replace(MapPath(@"~"), SecurityConstants.ROOT_FOLDER_NAME);


                String filterExpressionASPX = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_PhysicalPath, physicalPathASPX, SQLMatchType.Equal);

                IList<ASPhysicalSiteMapEntity> parentASPhysicalSiteMapEntityListASPX = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionASPX, DatabaseOperationType.LoadWithFilterExpression);

                ASPhysicalSiteMapEntity aSPhysicalSiteMapEntityASPX = new ASPhysicalSiteMapEntity();

                Int64 parentIDASPX = 0;

                if (parentASPhysicalSiteMapEntityListASPX == null)
                {

                    aSPhysicalSiteMapEntityASPX.Name = childfile.Name;
                    aSPhysicalSiteMapEntityASPX.PhysicalPath = physicalPathASPX;
                    aSPhysicalSiteMapEntityASPX.NavigationURL = childfile.FullName.Replace(MapPath("~"), "~");
                    if (page is BasePage && ((BasePage)page).UniqueKey != string.Empty)
                    {
                        aSPhysicalSiteMapEntityASPX.UniqueKey = ((BasePage)page).UniqueKey;
                    }
                    else
                    {
                        aSPhysicalSiteMapEntityASPX.UniqueKey = String.Empty;
                    }
                    aSPhysicalSiteMapEntityASPX.MDASNodeTypeID = SecurityConstants.MDASNodeType.WEB_PAGE;
                    aSPhysicalSiteMapEntityASPX.ParentASPhysicalSiteMapID = parentID;

                    parentIDASPX = FCCASPhysicalSiteMap.GetFacadeCreate().Add(aSPhysicalSiteMapEntityASPX, DatabaseOperationType.Add, TransactionRequired.No);
                }
                else if (parentASPhysicalSiteMapEntityListASPX != null && parentASPhysicalSiteMapEntityListASPX.Count > 0)
                {
                    if (page is BasePage && ((BasePage)page).UniqueKey != string.Empty)
                    {
                        parentASPhysicalSiteMapEntityListASPX[0].UniqueKey = ((BasePage)page).UniqueKey;
                    }
                    else
                    {
                        parentASPhysicalSiteMapEntityListASPX[0].UniqueKey = String.Empty;
                    }
                    parentIDASPX = FCCASPhysicalSiteMap.GetFacadeCreate().Update(parentASPhysicalSiteMapEntityListASPX[0], filterExpressionASPX, DatabaseOperationType.Update, TransactionRequired.No);
                }

                #region ASCX Files

                if (page is BasePage && ((BasePage)page).WebUserControlPaths.IsNotNullOrEmpty())
                {
                    String[] pathArray = ((BasePage)page).WebUserControlPaths.Split(new String[] { ";" }, StringSplitOptions.RemoveEmptyEntries);


                    if (pathArray.Length > 2)
                    {


                    }
                    foreach (String path in pathArray)
                    {
                        Page p = new Page();

                        try
                        {
                            Control control = p.LoadControl(path);

                            AddControlNodesToDB(control, parentIDASPX);
                        }
                        catch
                        { }
                    }
                }

                #endregion
            }

            #endregion ASPX Files

        }

        #region Controls

        private void AddControlNodesToDB(Control control, Int64 parentIDASPX)
        {
            if (control is SecureButton)
            {
                SecureButton btn = (SecureButton)control;

                String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);
                String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, btn.ID, SQLMatchType.Equal);
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
                {
                    aSPhysicalSiteMapControlEntityList[0].ControlName = btn.Text;
                    aSPhysicalSiteMapControlEntityList[0].UniqueKey = btn.UniqueKey;

                    Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                }
                else
                {
                    ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

                    aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
                    aSPhysicalSiteMapControlEntity.ControlId = btn.ID;
                    aSPhysicalSiteMapControlEntity.ControlName = btn.Text;
                    aSPhysicalSiteMapControlEntity.UniqueKey = btn.UniqueKey;
                    aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.BUTTON_EPMS;

                    Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);


                    #region Inserting the Permission Key By Default

                    if (controlID > 0)
                    {
                        String filterExpressionPermission = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);

                        IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionPermission, DatabaseOperationType.LoadWithFilterExpression);

                        if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
                        {
                            String permissionKey = String.Empty;

                            permissionKey = aSPhysicalSiteMapEntityList[0].UniqueKey + SecurityConstants.KEY_GLUE + btn.UniqueKey;

                            ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

                            aSRolePermissionEntity.ASRoleName = SecurityConstants.MASTER_ROLE;
                            aSRolePermissionEntity.PermissionKey = permissionKey;

                            FCCASRolePermission.GetFacadeCreate().Add(aSRolePermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }

                    #endregion
                }
            }
            else if (control is ListView)
            {
                ListView lv = (ListView)control;

                Int64 gridControlID = 0;
                
                #region Add the Grid

                String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);
                String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, lv.ID, SQLMatchType.Equal);
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
                {
                    aSPhysicalSiteMapControlEntityList[0].ControlName = MiscUtil.GetFormatedUILabel(lv.ID);
                    aSPhysicalSiteMapControlEntityList[0].UniqueKey = "No_Key";

                    gridControlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                }
                else
                {
                    ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

                    aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
                    aSPhysicalSiteMapControlEntity.ControlId = lv.ID;
                    aSPhysicalSiteMapControlEntity.ControlName = MiscUtil.GetFormatedUILabel(lv.ID);
                    aSPhysicalSiteMapControlEntity.UniqueKey = "No_Key";
                    aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.GRID;

                    gridControlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);
                }

                #endregion               

                #region Grid Columns

                if (gridControlID != 0)
                {
                    Control gridControls  = new Control();
                    lv.ItemTemplate.InstantiateIn(gridControls );

                    foreach (Control gc in gridControls.Controls)
                    {
                        if (gc is SecureLinkButton)                        
                        {
                            SecureLinkButton gbc = (SecureLinkButton)gc;

                            filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, gridControlID.ToString(), SQLMatchType.Equal);
                            filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, gbc.ID, SQLMatchType.Equal);
                            filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                            aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
                            {
                                aSPhysicalSiteMapControlEntityList[0].ControlName = gbc.Text;
                                aSPhysicalSiteMapControlEntityList[0].UniqueKey = gbc.UniqueKey;

                                Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                            }
                            else
                            {
                                ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

                                aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID = gridControlID;
                                aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;                                
                                aSPhysicalSiteMapControlEntity.ControlId = gbc.ID;
                                aSPhysicalSiteMapControlEntity.ControlName = gbc.Text;
                                aSPhysicalSiteMapControlEntity.UniqueKey = gbc.UniqueKey;
                                aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS;

                                Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                #region Inserting the Permission Key By Default

                                if (controlID > 0)
                                {
                                    String filterExpressionPermission = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);

                                    IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionPermission, DatabaseOperationType.LoadWithFilterExpression);

                                    if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
                                    {
                                        String permissionKey = String.Empty;

                                        permissionKey = aSPhysicalSiteMapEntityList[0].UniqueKey + SecurityConstants.KEY_GLUE + gbc.UniqueKey;

                                        ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

                                        aSRolePermissionEntity.ASRoleName = SecurityConstants.MASTER_ROLE;
                                        aSRolePermissionEntity.PermissionKey = permissionKey;

                                        FCCASRolePermission.GetFacadeCreate().Add(aSRolePermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                    }
                                }

                                #endregion
                            }
                        }
                    }
                }

                #endregion
            }
            //else if (control is TabEPMS)
            //{
            //    TabEPMS tab = (TabEPMS)control;

            //    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);
            //    String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, tab.ID, SQLMatchType.Equal);
            //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            //    IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            //    if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            //    {
            //        aSPhysicalSiteMapControlEntityList[0].ControlName = tab.Text;
            //        aSPhysicalSiteMapControlEntityList[0].UniqueKey = tab.UniqueKey;

            //        Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //    }
            //    else
            //    {
            //        ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

            //        aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
            //        aSPhysicalSiteMapControlEntity.ControlId = tab.ID;
            //        aSPhysicalSiteMapControlEntity.ControlName = tab.Text;
            //        aSPhysicalSiteMapControlEntity.UniqueKey = tab.UniqueKey;
            //        aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.TAB_EPMS;

            //        Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //    }
            //}

            foreach (Control ctl in control.Controls)
            {
                AddControlNodesToDB(ctl, parentIDASPX);
            }
        }

        #endregion

        private bool IsChildDirectoryValid(DirectoryInfo childdirectory)
        {
            Boolean isValid = true;
            String fullRoodPath = Server.MapPath("~");

            if (".svn" == childdirectory.Name)
            {
                isValid = false;
            }
            else if ("_svn" == childdirectory.Name)
            {
                isValid = false;
            }
            else if ("image".ToUpper() == childdirectory.Name.ToUpper() || "images".ToUpper() == childdirectory.Name.ToUpper())
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "App_Code") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Editor") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Upload") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "App_Data") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "App_Themes") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Bin") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Controls") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Images") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Scripts") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Sitemaps") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Style") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Template") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "ThirdParty") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if ("image".ToUpper() == childdirectory.Name.ToUpper() || "images".ToUpper() == childdirectory.Name.ToUpper())
            {
                isValid = false;
            }



            else if (String.Concat(fullRoodPath, "\\", "css") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "demos") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "fullcalendar") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "gs") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "jquery") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "js") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Upload") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "WebServices") == childdirectory.FullName)
            {
                isValid = false;
            }
            else if (String.Concat(fullRoodPath, "\\", "Styles") == childdirectory.FullName)
            {
                isValid = false;
            }

            return isValid;
        }

        #endregion

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["t1"] != "ajaxLoad")
            {
                PrepareInitialView();
            }
        }

        #endregion

        #region Button Event

        protected void btnSync_Click(object sender, EventArgs e)
        {
            //// this part will be required when we will do folder wise sync
            //String physicalPath = clickedNode.Attributes["PhysicalPath"];

            //Int64 parentID = 0;
            //Int64.TryParse(clickedNode.Attributes["ParentASPhysicalSiteMapID"], out parentID);

            //String fullPath = Server.MapPath("~");
            //if (physicalPath.Substring(SecurityConstants.ROOT_FOLDER_NAME.Length).IsNotNullOrEmpty())
            //{
            //    fullPath += "\\" + physicalPath.Substring(SecurityConstants.ROOT_FOLDER_NAME.Length);
            //}

            //DirectoryInfo di = new DirectoryInfo(fullPath);


            Int64 parentID = 0;
            String fullPath = Server.MapPath("~");
            DirectoryInfo di = new DirectoryInfo(fullPath);



            doSyn(di, parentID);

            PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

            InititializeDBTree();

            InititializeSiteMapTree();
        }

        #endregion

        #region DB Tree Events

        //protected void rtvDBStructure_NodeExpand(object sender, RadTreeNodeEventArgs e)
        //{
        //    AddChildsNodesToDBTree(Int64.Parse(e.Node.Value), e.Node);
        //}

        //protected void rtvDBStructure_NodeDrop(object sender, Telerik.Web.UI.RadTreeNodeDragDropEventArgs e)
        //{
        //    RadTreeNode destNode = e.DestDragNode;

        //    if (destNode.Attributes["NodeType"] == "Folder")
        //    {
        //        foreach (RadTreeNode sourceNode in e.DraggedNodes)
        //        {
        //            String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapID, destNode.Attributes["ASSiteMapID"].ToString(), SQLMatchType.Equal);
        //            String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASPhysicalSiteMapID, sourceNode.Value, SQLMatchType.Equal);

        //            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

        //            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

        //            if (aSSiteMapNodeEntityList == null)
        //            {
        //                ASSiteMapNodeEntity aSSiteMapNodeEntity = new ASSiteMapNodeEntity();

        //                aSSiteMapNodeEntity.ASSiteMapID = Int64.Parse(destNode.Attributes["ASSiteMapID"].ToString());
        //                aSSiteMapNodeEntity.ASPhysicalSiteMapID = Int64.Parse(sourceNode.Value);
        //                aSSiteMapNodeEntity.ParentASSiteMapNodeID = Int64.Parse(destNode.Value);
        //                aSSiteMapNodeEntity.MenuTitle = sourceNode.Text;
        //                aSSiteMapNodeEntity.SequenceNumber = GetNextSequenceID(Int64.Parse(destNode.Value));

        //                Int64 result = FCCASSiteMapNode.GetFacadeCreate().Add(aSSiteMapNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);
        //            }
        //        }

        //        InititializeDBTree();

        //        InititializeSiteMapTree();
        //    }
        //}

        //protected void rtvDBStructure_NodeCheck(object sender, RadTreeNodeEventArgs e)
        //{
        //    TreeNodeCheck(e.Node);

        //    InititializeDBTree();

        //    InititializeSiteMapTree();
        //}

        protected void rtvDBStructure_ContextMenuItemClick()
        {
            try
            {
                // need  to define this node, on which the context menu has been clicked and which context menu item has been clicked
                ASTreeViewNode clickedNode = new ASTreeViewNode("");

                String commanName = "";

                switch (commanName)
                {
                    case "Synchronize":
                        String physicalPath = MiscUtil.GetASTreeNodeAttributeValue(clickedNode.AdditionalAttributes, "PhysicalPath");

                        Int64 parentID = 0;
                        Int64.TryParse(MiscUtil.GetASTreeNodeAttributeValue(clickedNode.AdditionalAttributes, "ParentASPhysicalSiteMapID"), out parentID);

                        String fullPath = Server.MapPath("~");
                        if (physicalPath.Substring(SecurityConstants.ROOT_FOLDER_NAME.Length).IsNotNullOrEmpty())
                        {
                            fullPath += "\\" + physicalPath.Substring(SecurityConstants.ROOT_FOLDER_NAME.Length);
                        }

                        DirectoryInfo di = new DirectoryInfo(fullPath);

                        doSyn(di, parentID);

                        PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

                        InititializeDBTree();

                        InititializeSiteMapTree();

                        break;
                    case "DeleteControl":
                        Int64 aSPhysicalSiteMapControlID = 0;

                        Int64.TryParse(MiscUtil.GetASTreeNodeAttributeValue(clickedNode.AdditionalAttributes, "ASPhysicalSiteMapControlID"), out aSPhysicalSiteMapControlID);

                        if (aSPhysicalSiteMapControlID > 0)
                        {
                            DeleteDBControls(aSPhysicalSiteMapControlID);
                        }
                        break;
                    case "DeletePage":
                        DeleteDBPage(Int64.Parse(clickedNode.NodeValue));
                        break;
                    case "DeleteFolder":
                        DeleteDBFolder(Int64.Parse(clickedNode.NodeValue));
                        break;
                }

                InititializeDBTree();

                InititializeSiteMapTree();
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        private void DeleteDBFolder(Int64 aSPhysicalSiteMapID)
        {
            String filterExpressionFolder = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ParentASPhysicalSiteMapID, aSPhysicalSiteMapID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionFolder, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
            {
                foreach (ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity in aSPhysicalSiteMapEntityList)
                {
                    if (aSPhysicalSiteMapEntity.MDASNodeTypeID == SecurityConstants.MDASNodeType.FOLDER)
                    {
                        DeleteDBFolder(aSPhysicalSiteMapEntity.ASPhysicalSiteMapID);
                    }
                    else if (aSPhysicalSiteMapEntity.MDASNodeTypeID == SecurityConstants.MDASNodeType.WEB_PAGE)
                    {
                        DeleteDBPage(aSPhysicalSiteMapEntity.ASPhysicalSiteMapID);
                    }
                }
            }


            String filterExpressionDeletePage = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, aSPhysicalSiteMapID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityPageDeleteList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionDeletePage, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapEntityPageDeleteList != null && aSPhysicalSiteMapEntityPageDeleteList.Count > 0)
            {
                FCCASPhysicalSiteMap.GetFacadeCreate().Delete(aSPhysicalSiteMapEntityPageDeleteList[0], filterExpressionDeletePage, DatabaseOperationType.Delete, TransactionRequired.No);
            }

            InititializeDBTree();

            InititializeSiteMapTree();
        }

        private void DeleteDBPage(Int64 aSPhysicalSiteMapID)
        {
            String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, aSPhysicalSiteMapID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            {
                foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
                {
                    DeleteDBControls(aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID);
                }
            }

            String filterExpressionDeletePage = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, aSPhysicalSiteMapID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityPageDeleteList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionDeletePage, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapEntityPageDeleteList != null && aSPhysicalSiteMapEntityPageDeleteList.Count > 0)
            {
                FCCASPhysicalSiteMap.GetFacadeCreate().Delete(aSPhysicalSiteMapEntityPageDeleteList[0], filterExpressionDeletePage, DatabaseOperationType.Delete, TransactionRequired.No);
            }

            InititializeDBTree();

            InititializeSiteMapTree();
        }

        private void DeleteDBControls(Int64 aSPhysicalSiteMapControlID)
        {
            String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, aSPhysicalSiteMapControlID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            {
                foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
                {
                    DeleteDBControls(aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID);
                }
            }

            String filterExpressionDeleteControl = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapControlID, aSPhysicalSiteMapControlID.ToString(), SQLMatchType.Equal);

            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityDeleteList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionDeleteControl, DatabaseOperationType.LoadWithFilterExpression);

            if (aSPhysicalSiteMapControlEntityDeleteList != null && aSPhysicalSiteMapControlEntityDeleteList.Count > 0)
            {
                FCCASPhysicalSiteMapControl.GetFacadeCreate().Delete(aSPhysicalSiteMapControlEntityDeleteList[0], filterExpressionDeleteControl, DatabaseOperationType.Delete, TransactionRequired.No);
            }

            InititializeDBTree();

            InititializeSiteMapTree();
        }

        #endregion

        #region SiteMap Tree Events

        //protected void rtvSiteMap_NodeDrop(object sender, Telerik.Web.UI.RadTreeNodeDragDropEventArgs e)
        //{
        //    RadTreeNode destNode = e.DestDragNode;
        //    String filterExpression = String.Empty;

        //    if (destNode != null)
        //    {
        //        #region Update The Parent

        //        if (e.DropPosition == RadTreeViewDropPosition.Over)
        //        {
        //            if (destNode.Attributes["NodeType"] == "Folder")
        //            {
        //                foreach (RadTreeNode sourceNode in e.DraggedNodes)
        //                {
        //                    if (sourceNode.Attributes["NodeType"] == "Folder" || sourceNode.Attributes["NodeType"] == "WebPage")
        //                    {
        //                        filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, sourceNode.Value, SQLMatchType.Equal);
        //                        IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListOver = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

        //                        if (aSSiteMapNodeEntityListOver != null && aSSiteMapNodeEntityListOver.Count > 0)
        //                        {
        //                            aSSiteMapNodeEntityListOver[0].ParentASSiteMapNodeID = Int64.Parse(destNode.Value);

        //                            FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntityListOver[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        else if (e.DropPosition == RadTreeViewDropPosition.Above || e.DropPosition == RadTreeViewDropPosition.Below)
        //        {
        //            if (destNode.Attributes["NodeType"] == "Folder" || destNode.Attributes["NodeType"] == "WebPage")
        //            {
        //                foreach (RadTreeNode sourceNode in e.DraggedNodes)
        //                {
        //                    if (sourceNode.Attributes["NodeType"] == "Folder" || sourceNode.Attributes["NodeType"] == "WebPage")
        //                    {
        //                        if (destNode.Attributes["ParentASSiteMapNodeID"] != sourceNode.Attributes["ParentASSiteMapNodeID"])
        //                        {
        //                            filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, sourceNode.Value, SQLMatchType.Equal);
        //                            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListOver = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

        //                            if (aSSiteMapNodeEntityListOver != null && aSSiteMapNodeEntityListOver.Count > 0)
        //                            {
        //                                aSSiteMapNodeEntityListOver[0].SequenceNumber = GetNextSequenceID(Int64.Parse(destNode.Attributes["ParentASSiteMapNodeID"]));
        //                                aSSiteMapNodeEntityListOver[0].ParentASSiteMapNodeID = Int64.Parse(destNode.Attributes["ParentASSiteMapNodeID"]);

        //                                FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntityListOver[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        #endregion

        //        #region Update The Sequencing

        //        Int64 destinationNodeSequenceNumber = Int64.Parse(destNode.Attributes["SequenceNumber"].ToString());

        //        #region Above

        //        if (e.DropPosition == RadTreeViewDropPosition.Above)
        //        {
        //            if (destNode.Attributes["NodeType"] == "Folder" || destNode.Attributes["NodeType"] == "WebPage")
        //            {
        //                foreach (RadTreeNode sourceNode in e.DraggedNodes)
        //                {
        //                    Int64 sourceNodeSequenceNumber = Int64.Parse(sourceNode.Attributes["SequenceNumber"].ToString());

        //                    if (destinationNodeSequenceNumber < sourceNodeSequenceNumber)
        //                    {
        //                        if (sourceNode.Attributes["NodeType"] == "Folder" || sourceNode.Attributes["NodeType"] == "WebPage")
        //                        {
        //                            filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ParentASSiteMapNodeID, sourceNode.Attributes["ParentASSiteMapNodeID"].ToString(), SQLMatchType.Equal);
        //                            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNodeEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
        //                            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListAbove = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);

        //                            if (aSSiteMapNodeEntityListAbove != null && aSSiteMapNodeEntityListAbove.Count > 0)
        //                            {
        //                                Int64 sequenceNumber = 1;

        //                                Int64 destinationASSiteMapNodeID = Int64.Parse(destNode.Value);
        //                                Int64 sourceASSiteMapNodeID = Int64.Parse(sourceNode.Value);
        //                                Int64 sourceASSiteMapNodeIDWillBe = 0;

        //                                foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityListAbove)
        //                                {
        //                                    String filterExpressionUpdate = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeEntity.ASSiteMapNodeID.ToString(), SQLMatchType.Equal);

        //                                    if (aSSiteMapNodeEntity.ASSiteMapNodeID == destinationASSiteMapNodeID)
        //                                    {
        //                                        sourceASSiteMapNodeIDWillBe = sequenceNumber++;
        //                                    }

        //                                    if (aSSiteMapNodeEntity.ASSiteMapNodeID == sourceASSiteMapNodeID)
        //                                    {
        //                                        aSSiteMapNodeEntity.SequenceNumber = sourceASSiteMapNodeIDWillBe;
        //                                    }
        //                                    else
        //                                    {
        //                                        aSSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                    }

        //                                    FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntity, filterExpressionUpdate, DatabaseOperationType.Update, TransactionRequired.No);

        //                                }
        //                            }
        //                        }
        //                    }
        //                    else if (destinationNodeSequenceNumber > sourceNodeSequenceNumber)
        //                    {
        //                        if (sourceNode.Attributes["NodeType"] == "Folder" || sourceNode.Attributes["NodeType"] == "WebPage")
        //                        {
        //                            filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ParentASSiteMapNodeID, sourceNode.Attributes["ParentASSiteMapNodeID"].ToString(), SQLMatchType.Equal);
        //                            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNodeEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
        //                            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListAbove = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);

        //                            if (aSSiteMapNodeEntityListAbove != null && aSSiteMapNodeEntityListAbove.Count > 0)
        //                            {
        //                                Int64 sequenceNumber = 1;

        //                                Int64 destinationASSiteMapNodeID = Int64.Parse(destNode.Value);
        //                                Int64 sourceASSiteMapNodeID = Int64.Parse(sourceNode.Value);
        //                                ASSiteMapNodeEntity tempASSiteMapNodeEntity = new ASSiteMapNodeEntity();

        //                                foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityListAbove)
        //                                {
        //                                    String filterExpressionUpdate = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeEntity.ASSiteMapNodeID.ToString(), SQLMatchType.Equal);

        //                                    if (aSSiteMapNodeEntity.ASSiteMapNodeID == sourceASSiteMapNodeID)
        //                                    {
        //                                        tempASSiteMapNodeEntity = aSSiteMapNodeEntity;
        //                                    }
        //                                    else
        //                                    {
        //                                        if (aSSiteMapNodeEntity.ASSiteMapNodeID == destinationASSiteMapNodeID)
        //                                        {
        //                                            String filterExpressionUpdateSource = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, tempASSiteMapNodeEntity.ASSiteMapNodeID.ToString(), SQLMatchType.Equal);
        //                                            tempASSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                            FCCASSiteMapNode.GetFacadeCreate().Update(tempASSiteMapNodeEntity, filterExpressionUpdateSource, DatabaseOperationType.Update, TransactionRequired.No);
        //                                        }
        //                                        else
        //                                        {
        //                                            aSSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                            FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntity, filterExpressionUpdate, DatabaseOperationType.Update, TransactionRequired.No);
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        #endregion

        //        #region Below

        //        else if (e.DropPosition == RadTreeViewDropPosition.Below)
        //        {


        //            if (destNode.Attributes["NodeType"] == "Folder" || destNode.Attributes["NodeType"] == "WebPage")
        //            {
        //                foreach (RadTreeNode sourceNode in e.DraggedNodes)
        //                {
        //                    Int64 sourceNodeSequenceNumber = Int64.Parse(sourceNode.Attributes["SequenceNumber"].ToString());

        //                    if (destinationNodeSequenceNumber < sourceNodeSequenceNumber)
        //                    {
        //                        if (sourceNode.Attributes["NodeType"] == "Folder" || sourceNode.Attributes["NodeType"] == "WebPage")
        //                        {
        //                            filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ParentASSiteMapNodeID, sourceNode.Attributes["ParentASSiteMapNodeID"].ToString(), SQLMatchType.Equal);
        //                            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNodeEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
        //                            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListAbove = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);

        //                            if (aSSiteMapNodeEntityListAbove != null && aSSiteMapNodeEntityListAbove.Count > 0)
        //                            {
        //                                Int64 sequenceNumber = 1;

        //                                Int64 destinationASSiteMapNodeID = Int64.Parse(destNode.Value);
        //                                Int64 sourceASSiteMapNodeID = Int64.Parse(sourceNode.Value);
        //                                Int64 sourceASSiteMapNodeIDWillBe = 0;

        //                                foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityListAbove)
        //                                {
        //                                    String filterExpressionUpdate = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeEntity.ASSiteMapNodeID.ToString(), SQLMatchType.Equal);

        //                                    if (aSSiteMapNodeEntity.ASSiteMapNodeID == destinationASSiteMapNodeID)
        //                                    {
        //                                        aSSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                        sourceASSiteMapNodeIDWillBe = sequenceNumber++;
        //                                    }

        //                                    if (aSSiteMapNodeEntity.ASSiteMapNodeID == sourceASSiteMapNodeID)
        //                                    {
        //                                        aSSiteMapNodeEntity.SequenceNumber = sourceASSiteMapNodeIDWillBe;
        //                                    }
        //                                    else
        //                                    {
        //                                        if (aSSiteMapNodeEntity.ASSiteMapNodeID != destinationASSiteMapNodeID)
        //                                        {
        //                                            aSSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                        }
        //                                    }

        //                                    FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntity, filterExpressionUpdate, DatabaseOperationType.Update, TransactionRequired.No);

        //                                }
        //                            }
        //                        }
        //                    }
        //                    else if (destinationNodeSequenceNumber > sourceNodeSequenceNumber)
        //                    {
        //                        if (sourceNode.Attributes["NodeType"] == "Folder" || sourceNode.Attributes["NodeType"] == "WebPage")
        //                        {
        //                            filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ParentASSiteMapNodeID, sourceNode.Attributes["ParentASSiteMapNodeID"].ToString(), SQLMatchType.Equal);
        //                            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNodeEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
        //                            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListAbove = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);

        //                            if (aSSiteMapNodeEntityListAbove != null && aSSiteMapNodeEntityListAbove.Count > 0)
        //                            {
        //                                Int64 sequenceNumber = 1;

        //                                Int64 destinationASSiteMapNodeID = Int64.Parse(destNode.Value);
        //                                Int64 sourceASSiteMapNodeID = Int64.Parse(sourceNode.Value);
        //                                ASSiteMapNodeEntity tempASSiteMapNodeEntity = new ASSiteMapNodeEntity();

        //                                foreach (ASSiteMapNodeEntity aSSiteMapNodeEntity in aSSiteMapNodeEntityListAbove)
        //                                {
        //                                    String filterExpressionUpdate = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeEntity.ASSiteMapNodeID.ToString(), SQLMatchType.Equal);

        //                                    if (aSSiteMapNodeEntity.ASSiteMapNodeID == sourceASSiteMapNodeID)
        //                                    {
        //                                        tempASSiteMapNodeEntity = aSSiteMapNodeEntity;
        //                                    }
        //                                    else
        //                                    {
        //                                        aSSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                        FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntity, filterExpressionUpdate, DatabaseOperationType.Update, TransactionRequired.No);

        //                                        if (aSSiteMapNodeEntity.ASSiteMapNodeID == destinationASSiteMapNodeID)
        //                                        {
        //                                            String filterExpressionUpdateSource = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, tempASSiteMapNodeEntity.ASSiteMapNodeID.ToString(), SQLMatchType.Equal);
        //                                            tempASSiteMapNodeEntity.SequenceNumber = sequenceNumber++;
        //                                            FCCASSiteMapNode.GetFacadeCreate().Update(tempASSiteMapNodeEntity, filterExpressionUpdateSource, DatabaseOperationType.Update, TransactionRequired.No);
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        #endregion

        //        #endregion

        //    }

        //    InititializeDBTree();

        //    InititializeSiteMapTree();
        //}



        private Int64 GetNextSequenceID(Int64 aSSiteMapNodeID)
        {
            Int64 nextSequenceID = 1;

            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ParentASSiteMapNodeID, aSSiteMapNodeID.ToString(), SQLMatchType.Equal);
            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListOver = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            if (aSSiteMapNodeEntityListOver != null && aSSiteMapNodeEntityListOver.Count > 0)
            {
                nextSequenceID = aSSiteMapNodeEntityListOver.Count + 1;
            }

            return nextSequenceID;
        }
                
        protected void SMAddNewBlankNode(Int64 aSSiteMapID, Int64 clickedNodeID, String uniqueKey)
        {
            ASSiteMapNodeEntity aSSiteMapNodeEntity = new ASSiteMapNodeEntity();

            aSSiteMapNodeEntity.ASSiteMapID = aSSiteMapID;
            aSSiteMapNodeEntity.ParentASSiteMapNodeID = clickedNodeID;
            String tempUniqueKey = uniqueKey;

            if (tempUniqueKey.Contains("_Blank_Node"))
            {
                tempUniqueKey = tempUniqueKey.Replace("_Blank_Node", "");
            }
            tempUniqueKey += "_";
            tempUniqueKey += DateTime.Now.Ticks.ToString();
            tempUniqueKey += "_Blank_Node";
            aSSiteMapNodeEntity.UniqueKey = tempUniqueKey;
            aSSiteMapNodeEntity.MenuTitle = "New Menu Node";
            aSSiteMapNodeEntity.SequenceNumber = GetNextSequenceID(clickedNodeID);

            Int64 result = FCCASSiteMapNode.GetFacadeCreate().Add(aSSiteMapNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);
 
        }

        //protected void rtvSiteMap_ContextMenuItemClick(object sender, RadTreeViewContextMenuEventArgs e)
        //{
        //    try
        //    {
        //        RadTreeNode clickedNode = e.Node;

        //        switch (e.MenuItem.Value)
        //        {
        //            case "AddNewBlankNode":
        //                RadTreeNode clonedNode = clickedNode.Clone();

        //                ASSiteMapNodeEntity aSSiteMapNodeEntity = new ASSiteMapNodeEntity();

        //                aSSiteMapNodeEntity.ASSiteMapID = Int64.Parse(clickedNode.Attributes["ASSiteMapID"]);
        //                aSSiteMapNodeEntity.ParentASSiteMapNodeID = Int64.Parse(clickedNode.Value);
        //                String tempUniqueKey = clickedNode.Attributes["UniqueKey"];

        //                if (tempUniqueKey.Contains("_Blank_Node"))
        //                {
        //                    tempUniqueKey = tempUniqueKey.Replace("_Blank_Node", "");
        //                }
        //                tempUniqueKey += "_";
        //                tempUniqueKey += DateTime.Now.Ticks.ToString();
        //                tempUniqueKey += "_Blank_Node";
        //                aSSiteMapNodeEntity.UniqueKey = tempUniqueKey;
        //                aSSiteMapNodeEntity.MenuTitle = "New Menu Node";
        //                aSSiteMapNodeEntity.SequenceNumber = GetNextSequenceID(Int64.Parse(clickedNode.Value));

        //                Int64 result = FCCASSiteMapNode.GetFacadeCreate().Add(aSSiteMapNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);

        //                break;
        //            case "DeletePageNode":

        //                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, clickedNode.Value, SQLMatchType.Equal);

        //                IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

        //                if (aSSiteMapNodeEntityList != null && aSSiteMapNodeEntityList.Count > 0)
        //                {
        //                    FCCASSiteMapNode.GetFacadeCreate().Delete(aSSiteMapNodeEntityList[0], filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);
        //                }
        //                break;

        //            case "DeleteFolderNode":
        //                DeleteASSiteMapNode(Int64.Parse(clickedNode.Value));
        //                break;

        //            case "RemoveIcon":
        //                try
        //                {
        //                    String path = Server.MapPath("~") + "/Images/MenuImages/" + clickedNode.Attributes["ASSiteMapID"] + "/" + clickedNode.Value + ".png";
        //                    if (File.Exists(path))
        //                    {
        //                        File.Delete(path);

        //                        MiscUtil.ShowMessage(lblMessage, "Icon deleted successfully.", true);
        //                    }
        //                }
        //                catch (Exception ex)
        //                { }
        //                break;
        //        }

        //        InititializeDBTree();

        //        InititializeSiteMapTree();
        //    }
        //    catch (Exception ex)
        //    {
        //        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
        //    }
        //}

        private void SMDeleteASSiteMapPage(Int64 aSSiteMapNodeID)
        {
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeID.ToString(), SQLMatchType.Equal);

            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            if (aSSiteMapNodeEntityList != null && aSSiteMapNodeEntityList.Count > 0)
            {
                FCCASSiteMapNode.GetFacadeCreate().Delete(aSSiteMapNodeEntityList[0], filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);
            }
        }

        private void SMDeleteASSiteMapFolder(Int64 aSSiteMapNodeID)
        {
            String filterExpressionParent = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ParentASSiteMapNodeID, aSSiteMapNodeID.ToString(), SQLMatchType.Equal);

            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityChildList = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionParent, DatabaseOperationType.LoadWithFilterExpression);

            if (aSSiteMapNodeEntityChildList != null && aSSiteMapNodeEntityChildList.Count > 0)
            {
                foreach (ASSiteMapNodeEntity aSSiteMapNodeEntityChild in aSSiteMapNodeEntityChildList)
                {
                    SMDeleteASSiteMapFolder(aSSiteMapNodeEntityChild.ASSiteMapNodeID);
                }
            }

            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, aSSiteMapNodeID.ToString(), SQLMatchType.Equal);

            IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            if (aSSiteMapNodeEntityList != null && aSSiteMapNodeEntityList.Count > 0)
            {
                FCCASSiteMapNode.GetFacadeCreate().Delete(aSSiteMapNodeEntityList[0], filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);
            }
        }

        //protected void rtvSiteMap_NodeCheck(object sender, RadTreeNodeEventArgs e)
        //{
        //    TreeNodeCheck(e.Node);

        //    InititializeDBTree();

        //    InititializeSiteMapTree();
        //}

        #endregion

        #region DropdownList Events

        protected void ddlSitemap_SelectedIndexChanged(object o, EventArgs e)
        {
            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();
            InititializeDBTree();
            InititializeSiteMapTree();
        }

        protected void ddlRole_SelectedIndexChanged(object o, EventArgs e)
        {   
            PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

            GenerateUsers();

            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();
            InititializeDBTree();
            InititializeSiteMapTree();
        }

        protected void ddlUser_SelectedIndexChanged(object o, EventArgs e)
        {
            PermissionHelper.PreserveUserPermissionKeysForPermissionApply(ddlUser.SelectedValue);

            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();
            InititializeDBTree();
            InititializeSiteMapTree();        
        }

        #endregion DropdownList Events

        #region Check Box events

        protected void chkIsUserPermission_CheckedChanged(object sender, EventArgs e)
        {
            ddlUser.Enabled = ((CheckBox)sender).Checked;

            if (ddlUser.Enabled && ddlUser.Items.Count > 0)
            {
                PermissionHelper.PreserveUserPermissionKeysForPermissionApply(ddlUser.SelectedValue);
            }

            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();
            InititializeDBTree();
            InititializeSiteMapTree(); 
        }

        #endregion

        #endregion        

        #region Newly added events - will be placed inmproper place later on

        protected void btnPSTreeDNDTrigger_Click(object sender, EventArgs e)
        {
            Int64 sourceNodeID = Int64.Parse(hypPSTreeDNDSourceNodeID.Value.Trim());
            String sourceNodeText = hypPSTreeDNDSourceNodeText.Value.Trim();
            Int64 destinationNodeID = Int64.Parse(hypPSTreeDNDDestinationNodeID.Value.Trim());
            String destinationNodeNodeType = hypPSTreeDNDDestinationNodeNodeType.Value.Trim();
            Int64 destinationNodeASSiteMapID = Int64.Parse(hypPSTreeDNDDestinationNodeASSiteMapID.Value.Trim());



            //RadTreeNode destNode = e.DestDragNode;

            if (destinationNodeNodeType == "Folder")
            {
                //foreach (RadTreeNode sourceNode in e.DraggedNodes)
                //{
                    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapID, destinationNodeASSiteMapID.ToString(), SQLMatchType.Equal);
                    String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASPhysicalSiteMapID, sourceNodeID.ToString(), SQLMatchType.Equal);

                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                    IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                    if (aSSiteMapNodeEntityList == null)
                    {
                        ASSiteMapNodeEntity aSSiteMapNodeEntity = new ASSiteMapNodeEntity();

                        aSSiteMapNodeEntity.ASSiteMapID = Int64.Parse(destinationNodeASSiteMapID.ToString());
                        aSSiteMapNodeEntity.ASPhysicalSiteMapID = sourceNodeID;
                        aSSiteMapNodeEntity.ParentASSiteMapNodeID = destinationNodeID;
                        aSSiteMapNodeEntity.MenuTitle = sourceNodeText;
                        aSSiteMapNodeEntity.SequenceNumber = GetNextSequenceID(destinationNodeID);

                        Int64 result = FCCASSiteMapNode.GetFacadeCreate().Add(aSSiteMapNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                //}

                InititializeDBTree();

                InititializeSiteMapTree();
            }
        
        }

        protected void btnSMTreeDNDTrigger_Click(object sender, EventArgs e)
        {
            Int64 currentNodeID = Int64.Parse(hypSMTreeDNDCurrentNodeID.Value.Trim());
            String currentNodeNodeType = hypSMTreeDNDCurrentNodeNodeType.Value.Trim();
            Int64 newParentNodeID = Int64.Parse(hypSMTreeDNDNewParentNodeID.Value.Trim());
            String newParentNodeNodeType = hypSMTreeDNDNewParentNodeNodeType.Value.Trim();

            if (newParentNodeNodeType == "Folder")
            {

                if (currentNodeNodeType == "Folder" || currentNodeNodeType == "WebPage")
                {
                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNodeEntity.FLD_NAME_ASSiteMapNodeID, currentNodeID.ToString(), SQLMatchType.Equal);
                    IList<ASSiteMapNodeEntity> aSSiteMapNodeEntityListOver = FCCASSiteMapNode.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                    if (aSSiteMapNodeEntityListOver != null && aSSiteMapNodeEntityListOver.Count > 0)
                    {
                        aSSiteMapNodeEntityListOver[0].ParentASSiteMapNodeID = newParentNodeID;

                        FCCASSiteMapNode.GetFacadeCreate().Update(aSSiteMapNodeEntityListOver[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }
                }
            }
            else
            {
                // message here
            }
        }

        protected void btnPSTreeContextMenuClickTrigger_Click(object sender, EventArgs e)
        {
            String commandName = hydPSTreeContextMenuCommandName.Value.Trim();
            Int64 id = Int64.Parse(hydPSTreeContextMenuNodeID.Value.Trim());

            // reload....
            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();
            InititializeDBTree();
            InititializeSiteMapTree();
        }

        protected void btnSMTreeContextMenuClickTrigger_Click(object sender, EventArgs e)
        {
            String commandName = hydSMTreeContextMenuCommandName.Value.Trim();
            
            if(commandName == CMI_ADD_BLANK_NODE.Value)
            {
                Int64 id = Int64.Parse(hydSMTreeContextMenuNodeID.Value.Trim());
                Int64 aSSiteMapID = Int64.Parse(hydSMTreeContextMenuASSiteMapID.Value.Trim());
                String uniqueKey = hydSMTreeContextMenuUniqueKey.Value.Trim();

                SMAddNewBlankNode(aSSiteMapID, id, uniqueKey);
            }
            else if (commandName == CMI_DELETE_PAGE.Value)
            {
                Int64 id = Int64.Parse(hydSMTreeContextMenuNodeID.Value.Trim());
                SMDeleteASSiteMapFolder(id); 
            }
            else if (commandName == CMI_DELETE_FOLDER.Value)
            {
                Int64 id = Int64.Parse(hydSMTreeContextMenuNodeID.Value.Trim());
                SMDeleteASSiteMapFolder(id);  
            }

            // reload....
            AddDefaultContextMenuItemsInPSTree();
            AddDefaultContextMenuItemsInSMTree();
            InititializeDBTree();
            InititializeSiteMapTree();
        }

        protected void btnSelectionPBTrigger_Click(object sender, EventArgs e)
        {
            //this.divConsole.InnerHtml += (string.Format(">>Selected node: {0}<br />", this.txtSelectedNode.Text));
        }
        
        protected void btnCheckPBTrigger_Click(object sender, EventArgs e)
        {
            String[] items = this.txtCheckedNode.Text.Trim().Split(';');


            ASTreeViewNode node = new ASTreeViewNode(items[0], items[1]);

            if (items[2] == "0")
            {
                node.CheckedState = ASTreeViewCheckboxState.Checked;
            }
            if (items[2] == "1")
            {
                node.CheckedState = ASTreeViewCheckboxState.HalfChecked;
            }
            if (items[2] == "2")
            {
                node.CheckedState = ASTreeViewCheckboxState.Unchecked;
            }

            var json_serializer = new JavaScriptSerializer();
            var routes_list = (IDictionary<string, object>) json_serializer.DeserializeObject(items[3]);

            foreach (var pair in routes_list)
            {
                node.AdditionalAttributes.Add(new KeyValuePair<string, string>(pair.Key, (String)pair.Value));
            }
            
            TreeNodeCheck(node);
        }

        protected void psTree_OnCheckedNodeChanged(object src, ASTreeViewNodeCheckedEventArgs e)
        {   
            //ASTreeView tempTree = (ASTreeView)src;

            //tempTree

            //List<ASTreeViewNode> list = tempTree.GetCheckedNodes();

            //foreach (ASTreeViewNode node in psTree.UnCheckNodes( .child.Get list)
            //{
            //    if (node.NodeValue == e..NodeValue)
            //    {
            //        TreeNodeCheck(node);
            //    }
            //}

            //string toConsole = string.Format(">>OnCheckedNodeChanged checked: text:{0} value:{1} state:{2}", e.NodeText, e.NodeValue, e.CheckedState.ToString());
            
        }

        protected override void Render(HtmlTextWriter writer)
        {
            if (Request.QueryString["t1"] == "ajaxLoad")
            {
                string virtualParentKey = Request.QueryString["virtualParentKey"];

                string para = string.Empty;// "= 1";
                if (virtualParentKey == null)
                    para = " is NULL";
                else
                    para = "=" + virtualParentKey;

                //                string sql = @"SELECT p1.[ProductID] as ProductID, p1.[ProductName] as ProductName, p1.[ParentID] as ParentID, p3.childNodesCount as ChildNodesCount
                //FROM [Products] p1
                //LEFT OUTER JOIN 
                //(
                //	SELECT COUNT(*) AS childNodesCount , p2.[ParentID] AS pId 
                //	FROM [Products] p2
                //	GROUP BY p2.[ParentID]
                //) p3
                //ON p1.[ProductID] = p3.pId
                //WHERE p1.[ParentID] " + para;

                //                DataTable dt = OleDbHelper.ExecuteDataset(base.NorthWindConnectionString, CommandType.Text, sql).Tables[0];

                ASTreeViewNode root = new ASTreeViewNode("root");

                //foreach (DataRow dr in dt.Rows)
                //{
                //    string productName = dr["ProductName"].ToString();
                //    string productId = dr["ProductID"].ToString();
                //    string parentId = dr["ParentID"].ToString();
                //    int childNodesCount = 0;
                //    if (!string.IsNullOrEmpty(dr["ChildNodesCount"].ToString()))
                //        childNodesCount = int.Parse(dr["ChildNodesCount"].ToString());

                //    ASTreeViewLinkNode node = new ASTreeViewLinkNode(productName, productId);
                //    node.VirtualNodesCount = childNodesCount;
                //    node.VirtualParentKey = productId;
                //    node.IsVirtualNode = childNodesCount > 0;
                //    node.NavigateUrl = "#";
                //    node.AdditionalAttributes.Add(new KeyValuePair<string, string>("onclick", "return false;"));

                //    root.AppendChild(node);
                //}


                Int64 parentIDTemp = 0;

                Int64.TryParse(virtualParentKey, out parentIDTemp);


                //AddChildsNodesToDBTree(Int64 parentID, ASTreeViewNode currentNode)
                AddChildsNodesToDBTree(parentIDTemp, root);



                HtmlGenericControl ulRoot = new HtmlGenericControl("ul");
                psTree.TreeViewHelper.ConvertTree(ulRoot, root, false);
                foreach (Control c in ulRoot.Controls)
                    c.RenderControl(writer);
            }
            else if (Request.QueryString["t2"] == "ajaxAdd")
            {
                //string addNodeText = Request.QueryString["addNodeText"];
                //int parentNodeValue = int.Parse(Request.QueryString["parentNodeValue"]);

                //string maxSql = "select max( productId ) from products";
                //int max = (int)OleDbHelper.ExecuteScalar(base.NorthWindConnectionString, CommandType.Text, maxSql);
                //int newId = max + 1;

                //string sql = string.Format(@"INSERT INTO products( productid, Discontinued, productname, parentid ) values( {0} ,0, '{1}', {2})"
                //    , max + 1, addNodeText.Replace("'", "''"), parentNodeValue);

                //int i = OleDbHelper.ExecuteNonQuery(base.NorthWindConnectionString, CommandType.Text, sql);

                //ASTreeViewNode root = new ASTreeViewNode("root");

                //ASTreeViewLinkNode node = new ASTreeViewLinkNode(addNodeText, newId.ToString());
                //node.NavigateUrl = "#";
                //node.AdditionalAttributes.Add(new KeyValuePair<string, string>("onclick", "return false;"));

                //root.AppendChild(node);

                //HtmlGenericControl ulRoot = new HtmlGenericControl("ul");
                //psTree.TreeViewHelper.ConvertTree(ulRoot, root, false);
                //foreach (Control c in ulRoot.Controls)
                //    c.RenderControl(writer);
            }
            else
                base.Render(writer);

        }

        #endregion
    }
}