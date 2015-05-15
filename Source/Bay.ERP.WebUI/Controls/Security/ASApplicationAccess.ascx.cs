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


namespace Bay.ERP.Web.UI
{
    public partial class ASApplicationAccessControl : ASBaseControl
    {
        #region Member Variables

        #endregion

        #region Properties

        #endregion

        #region Methods

        private void GenerateRoles()
        {   
            ddlRole.Items.Clear();

            foreach (String rolename in Roles.GetAllRoles())
            {
                ddlRole.Items.Add(new ListItem(rolename, rolename));
            }

            ddlRole.SelectedValue = this.CurrentRole;
            ddlRole.Enabled = false;
        }

        private void BuildDropDownList()
        {
            GenerateRoles();
            
            MiscUtil.PopulateASSiteMap(rcbSitemapList, false);            
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

            InititializeSiteMapTree();
        }

        private void TreeNodeCheck(TreeNode checkedNode)
        {
            //#region Role Permission

            //if (checkedNode.Checked)
            //{
            //    ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

            //    aSRolePermissionEntity.ASRoleName = ddlRole.SelectedValue;

            //    if (checkedNode.Attributes["NodeType"] == "WebPage")
            //    {
            //        aSRolePermissionEntity.PermissionKey = checkedNode.Attributes["UniqueKey"];
            //    }
            //    else if (checkedNode.Attributes["NodeType"] == "Control")
            //    {
            //        aSRolePermissionEntity.PermissionKey = checkedNode.Attributes["CombinedUniqueKey"];
            //    }
            //    else if (checkedNode.Attributes["NodeType"] == "Folder")
            //    {
            //        aSRolePermissionEntity.PermissionKey = checkedNode.Attributes["UniqueKey"];
            //    }

            //    FCCASRolePermission.GetFacadeCreate().Add(aSRolePermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //}
            //else
            //{
            //    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_ASRoleName, ddlRole.SelectedValue, SQLMatchType.Equal);
            //    String filterExpression2 = String.Empty;
            //    if (checkedNode.Attributes["NodeType"] == "WebPage")
            //    {
            //        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_PermissionKey, checkedNode.Attributes["UniqueKey"], SQLMatchType.Equal);
            //    }
            //    else if (checkedNode.Attributes["NodeType"] == "Control")
            //    {
            //        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_PermissionKey, checkedNode.Attributes["CombinedUniqueKey"], SQLMatchType.Equal);
            //    }
            //    else if (checkedNode.Attributes["NodeType"] == "Folder")
            //    {
            //        filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASRolePermissionEntity.FLD_NAME_PermissionKey, checkedNode.Attributes["UniqueKey"], SQLMatchType.Equal);
            //    }

            //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            //    IList<ASRolePermissionEntity> aSRolePermissionEntityList = FCCASRolePermission.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            //    if (aSRolePermissionEntityList != null && aSRolePermissionEntityList.Count > 0)
            //    {
            //        FCCASRolePermission.GetFacadeCreate().Delete(aSRolePermissionEntityList[0], filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);
            //    }
            //}

            //PermissionHelper.PreserveRolePermissionKeys(ddlRole.SelectedValue);

            //#endregion


            PermissionHelper.PreserveUserPermissionKeys(HttpContext.Current.User.Identity.Name);
        }

        #region SiteMap methods

        private void InititializeSiteMapTree()
        {
            //Int64 aSSiteMapID = Int64.Parse(rcbSitemapList.SelectedValue);

            //rtvSiteMap.Nodes.Clear();

            //String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapNodeID, SQLSortOrderType.Assending);
            //String filterExpression1 = "ASSiteMapNode." + SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapID, aSSiteMapID.ToString(), SQLMatchType.Equal);
            //String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, String.Empty, SQLMatchType.IsNull);
            //String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            //IList<ASSiteMapNode_DetailedEntity> aSSiteMapNodeEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            //if (aSSiteMapNodeEntityList != null && aSSiteMapNodeEntityList.Count > 0)
            //{
            //    TreeNode rootNode = new TreeNode();

            //    rootNode.Text = aSSiteMapNodeEntityList[0].MenuTitle;
            //    rootNode.Value = aSSiteMapNodeEntityList[0].ASSiteMapNodeID.ToString();
            //    rootNode.Attributes["ASSiteMapID"] = aSSiteMapID.ToString();
            //    rootNode.Attributes["UniqueKey"] = aSSiteMapNodeEntityList[0].UniqueKey;
            //    rootNode.ExpandMode = TreeNodeExpandMode.ServerSideCallBack;
            //    rootNode.ImageUrl = @"~/Images/folder.jpg";
            //    rootNode.Checkable = false;
            //    rootNode.Attributes["NodeType"] = "Folder";

            //    rtvSiteMap.Nodes.Add(rootNode);
            //}
        }

        private void AddChildsNodesToSiteMap(Int64 parentID, TreeNode currentNode)
        {
            //String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
            //String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, parentID.ToString(), SQLMatchType.Equal);

            //IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            //if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
            //{
            //    foreach (ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity in aSSiteMapNode_DetailedEntityList)
            //    {
            //        RadTreeNode treeNode = new RadTreeNode();

            //        treeNode.Text = aSSiteMapNode_DetailedEntity.MenuTitle;
            //        treeNode.Value = aSSiteMapNode_DetailedEntity.ASSiteMapNodeID.ToString();
            //        treeNode.Attributes["ASSiteMapID"] = aSSiteMapNode_DetailedEntity.ASSiteMapID.ToString();
            //        treeNode.Attributes["ParentASSiteMapNodeID"] = parentID.ToString();
            //        treeNode.Attributes["SequenceNumber"] = aSSiteMapNode_DetailedEntity.SequenceNumber.ToString();
            //        treeNode.Checkable = true;

            //        if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID == null)
            //        {
            //            treeNode.Attributes["UniqueKey"] = aSSiteMapNode_DetailedEntity.UniqueKey;
            //            treeNode.ImageUrl = @"~/Images/folder.jpg";
            //            treeNode.ExpandMode = TreeNodeExpandMode.ServerSideCallBack;
            //            treeNode.Checked = PermissionHelper.IsRoleHasPermission(aSSiteMapNode_DetailedEntity.UniqueKey);
            //            treeNode.Attributes["UniqueKey"] = aSSiteMapNode_DetailedEntity.UniqueKey;
            //            treeNode.Attributes["NodeType"] = "Folder";
            //        }
            //        else if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID > 0)
            //        {
            //            treeNode.Attributes["UniqueKey"] = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey;
            //            treeNode.ImageUrl = @"~/Images/aspx.png";

            //            #region Adding Controls

            //            String filterExpressionControl1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID.ToString(), SQLMatchType.Equal);
            //            String filterExpressionControl2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, String.Empty, SQLMatchType.IsNull);
            //            String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(filterExpressionControl1, SQLJoinType.AND, filterExpressionControl2);

            //            IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

            //            if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            //            {
            //                foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
            //                {
            //                    RadTreeNode controlNode = new RadTreeNode();

            //                    controlNode.Text = aSPhysicalSiteMapControlEntity.ControlName;
            //                    controlNode.Attributes["ASPhysicalSiteMapControlID"] = aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString();
            //                    controlNode.Attributes["ASPhysicalSiteMapID"] = aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID.ToString();

            //                    if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.BUTTON_EPMS)
            //                    {
            //                        controlNode.ImageUrl = @"~/Images/button.JPG";
            //                        controlNode.Checkable = true;
            //                    }
            //                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_EPMS)
            //                    {
            //                        controlNode.ImageUrl = @"~/Images/tab.JPG";
            //                        controlNode.Checkable = true;
            //                    }
            //                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_STRIP)
            //                    {
            //                        controlNode.ImageUrl = @"~/Images/tabstrip.gif";
            //                        controlNode.Checkable = false;
            //                    }
            //                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID)
            //                    {
            //                        controlNode.ImageUrl = @"~/Images/Grid.png";
            //                        controlNode.Checkable = false;
            //                    }
            //                    else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS)
            //                    {
            //                        controlNode.ImageUrl = @"~/Images/LinkButton.gif";
            //                        controlNode.Checkable = true;
            //                    }

            //                    //String combinedUniqueKey = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;

            //                    String combinedUniqueKey = String.Empty;

            //                    if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNotNullOrEmpty() && aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey != "undefined")
            //                    {
            //                        combinedUniqueKey = aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
            //                    }
            //                    else
            //                    {
            //                        combinedUniqueKey = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
            //                    }

            //                    controlNode.Checked = PermissionHelper.IsRoleHasPermission(combinedUniqueKey);

            //                    controlNode.Attributes["CombinedUniqueKey"] = combinedUniqueKey;
            //                    controlNode.Attributes["NodeType"] = "Control";

            //                    controlNode.Attributes["ASPhysicalSiteMapUniqueKey"] = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey;

            //                    AddSubControlsToSiteMap(controlNode);

            //                    treeNode.Nodes.Add(controlNode);
            //                }
            //            }

            //            #endregion

            //            #region Pgae Permission
            //            treeNode.Checked = PermissionHelper.IsRoleHasPermission(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey);

            //            treeNode.Attributes["UniqueKey"] = aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey;
            //            treeNode.Attributes["NodeType"] = "WebPage";
            //        }
            //        else
            //        {
            //            treeNode.Attributes["UniqueKey"] = String.Empty;
            //        }

            //        currentNode.Nodes.Add(treeNode);
            //    }
            //}
        }

        private void AddSubControlsToSiteMap(TreeNode currentControl)
        {
            //String filterExpressionControl = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, currentControl.Attributes["ASPhysicalSiteMapControlID"], SQLMatchType.Equal);

            //IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionControl, DatabaseOperationType.LoadWithFilterExpression);

            //if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            //{
            //    foreach (ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity in aSPhysicalSiteMapControlEntityList)
            //    {
            //        RadTreeNode controlNode = new RadTreeNode();

            //        controlNode.Text = aSPhysicalSiteMapControlEntity.ControlName;
            //        controlNode.Attributes["ASPhysicalSiteMapControlID"] = aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID.ToString();
            //        controlNode.Attributes["ASPhysicalSiteMapID"] = aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID.ToString();

            //        if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.BUTTON_EPMS)
            //        {
            //            controlNode.ImageUrl = @"~/Images/button.JPG";
            //            controlNode.ContextMenuID = "buttonContextMenu";
            //        }
            //        else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_EPMS)
            //        {
            //            controlNode.ImageUrl = @"~/Images/tab.JPG";
            //            controlNode.ContextMenuID = "tabContextMenu";
            //        }
            //        else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.TAB_STRIP)
            //        {
            //            controlNode.ImageUrl = @"~/Images/tabstrip.gif";
            //            controlNode.ContextMenuID = "tabStripContextMenu";
            //        }
            //        else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID)
            //        {
            //            controlNode.ImageUrl = @"~/Images/Grid.png";
            //            controlNode.Checkable = false;
            //        }
            //        else if (aSPhysicalSiteMapControlEntity.MDASControlTypeID == SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS)
            //        {
            //            controlNode.ImageUrl = @"~/Images/LinkButton.gif";
            //            controlNode.Checkable = true;
            //        }

            //        String combinedUniqueKey = String.Empty;

            //        if (aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey.IsNotNullOrEmpty() && aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey != "undefined")
            //        {
            //            combinedUniqueKey = aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
            //        }
            //        else
            //        {
            //            combinedUniqueKey = currentControl.Attributes["ASPhysicalSiteMapUniqueKey"] + SecurityConstants.KEY_GLUE + aSPhysicalSiteMapControlEntity.UniqueKey;
            //        }

            //        #region Control Permission
            //        controlNode.Checked = PermissionHelper.IsRoleHasPermission(combinedUniqueKey);

            //        controlNode.Attributes["CombinedUniqueKey"] = combinedUniqueKey;
            //        controlNode.Attributes["NodeType"] = "Control";

            //        controlNode.Attributes["ASPhysicalSiteMapUniqueKey"] = currentControl.Attributes["ASPhysicalSiteMapUniqueKey"];

            //        AddSubControlsToSiteMap(controlNode);

            //        currentControl.Nodes.Add(controlNode);
            //    }
            //}
        }

                    #endregion

        #region Controls

        private void AddControlNodesToDB(Control control, Int64 parentIDASPX)
        {
            //if (control is ButtonEPMS)
            //{
            //    ButtonEPMS btn = (ButtonEPMS)control;

            //    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);
            //    String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, btn.ID, SQLMatchType.Equal);
            //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            //    IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            //    if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            //    {
            //        aSPhysicalSiteMapControlEntityList[0].ControlName = btn.Text;
            //        aSPhysicalSiteMapControlEntityList[0].UniqueKey = btn.UniqueKey;

            //        Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //    }
            //    else
            //    {
            //        ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

            //        aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
            //        aSPhysicalSiteMapControlEntity.ControlId = btn.ID;
            //        aSPhysicalSiteMapControlEntity.ControlName = btn.Text;
            //        aSPhysicalSiteMapControlEntity.UniqueKey = btn.UniqueKey;
            //        aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.BUTTON_EPMS;

            //        Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);


            //        #region Inserting the Permission Key By Default

            //        if (controlID > 0)
            //        {
            //            String filterExpressionPermission = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);

            //            IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionPermission, DatabaseOperationType.LoadWithFilterExpression);

            //            if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
            //            {
            //                String permissionKey = String.Empty;

            //                permissionKey = aSPhysicalSiteMapEntityList[0].UniqueKey + SecurityConstants.KEY_GLUE + btn.UniqueKey;

            //                ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

            //                aSRolePermissionEntity.ASRoleName = CommonConstants.MASTER_ROLE;
            //                aSRolePermissionEntity.PermissionKey = permissionKey;

            //                FCCASRolePermission.GetFacadeCreate().Add(aSRolePermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //            }
            //        }

            //        #endregion
            //    }
            //}
            //else if (control is RadGrid)
            //{
            //    RadGrid grid = (RadGrid)control;

            //    Int64 gridControlID = 0;

            //    #region Add the Grid

            //    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);
            //    String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, grid.ID, SQLMatchType.Equal);
            //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            //    IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            //    if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            //    {
            //        aSPhysicalSiteMapControlEntityList[0].ControlName = MiscUtil.GetFormatedUILabel(grid.ID);
            //        aSPhysicalSiteMapControlEntityList[0].UniqueKey = "No_Key";

            //        gridControlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //    }
            //    else
            //    {
            //        ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

            //        aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
            //        aSPhysicalSiteMapControlEntity.ControlId = grid.ID;
            //        aSPhysicalSiteMapControlEntity.ControlName = MiscUtil.GetFormatedUILabel(grid.ID);
            //        aSPhysicalSiteMapControlEntity.UniqueKey = "No_Key";
            //        aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.GRID;

            //        gridControlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //    }

            //    #endregion

            //    if (gridControlID != 0)
            //    {
            //        foreach (GridColumn gc in grid.MasterTableView.Columns)
            //        {
            //            if (gc.ColumnType == "GridButtonColumnEPMS")
            //            {
            //                GridButtonColumnEPMS gbc = (GridButtonColumnEPMS)gc;

            //                filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ParentASPhysicalSiteMapControlID, gridControlID.ToString(), SQLMatchType.Equal);
            //                filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, gbc.UniqueName, SQLMatchType.Equal);
            //                filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            //                aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            //                if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            //                {
            //                    aSPhysicalSiteMapControlEntityList[0].ControlName = gbc.Text;
            //                    aSPhysicalSiteMapControlEntityList[0].UniqueKey = gbc.UniqueKey;

            //                    Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //                }
            //                else
            //                {
            //                    ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

            //                    aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID = gridControlID;
            //                    aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
            //                    aSPhysicalSiteMapControlEntity.ControlId = gbc.UniqueName;
            //                    aSPhysicalSiteMapControlEntity.ControlName = gbc.Text;
            //                    aSPhysicalSiteMapControlEntity.UniqueKey = gbc.UniqueKey;
            //                    aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.GRID_BUTTON_COLUMN_EPMS;

            //                    Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);

            //                    #region Inserting the Permission Key By Default

            //                    if (controlID > 0)
            //                    {
            //                        String filterExpressionPermission = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);

            //                        IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList = FCCASPhysicalSiteMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionPermission, DatabaseOperationType.LoadWithFilterExpression);

            //                        if (aSPhysicalSiteMapEntityList != null && aSPhysicalSiteMapEntityList.Count > 0)
            //                        {
            //                            String permissionKey = String.Empty;

            //                            permissionKey = aSPhysicalSiteMapEntityList[0].UniqueKey + SecurityConstants.KEY_GLUE + gbc.UniqueKey;

            //                            ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

            //                            aSRolePermissionEntity.ASRoleName = CommonConstants.MASTER_ROLE;
            //                            aSRolePermissionEntity.PermissionKey = permissionKey;

            //                            FCCASRolePermission.GetFacadeCreate().Add(aSRolePermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //                        }
            //                    }

            //                    #endregion
            //                }
            //            }
            //        }
            //    }
            //}
            ////else if (control is TabEPMS)
            ////{
            ////    TabEPMS tab = (TabEPMS)control;

            ////    String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapID, parentIDASPX.ToString(), SQLMatchType.Equal);
            ////    String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ControlId, tab.ID, SQLMatchType.Equal);
            ////    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            ////    IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList = FCCASPhysicalSiteMapControl.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

            ////    if (aSPhysicalSiteMapControlEntityList != null && aSPhysicalSiteMapControlEntityList.Count > 0)
            ////    {
            ////        aSPhysicalSiteMapControlEntityList[0].ControlName = tab.Text;
            ////        aSPhysicalSiteMapControlEntityList[0].UniqueKey = tab.UniqueKey;

            ////        Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Update(aSPhysicalSiteMapControlEntityList[0], filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            ////    }
            ////    else
            ////    {
            ////        ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

            ////        aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = parentIDASPX;
            ////        aSPhysicalSiteMapControlEntity.ControlId = tab.ID;
            ////        aSPhysicalSiteMapControlEntity.ControlName = tab.Text;
            ////        aSPhysicalSiteMapControlEntity.UniqueKey = tab.UniqueKey;
            ////        aSPhysicalSiteMapControlEntity.MDASControlTypeID = SecurityConstants.MDASControlType.TAB_EPMS;

            ////        Int64 controlID = FCCASPhysicalSiteMapControl.GetFacadeCreate().Add(aSPhysicalSiteMapControlEntity, DatabaseOperationType.Add, TransactionRequired.No);
            ////    }
            ////}

            //foreach (Control ctl in control.Controls)
            //{
            //    AddControlNodesToDB(ctl, parentIDASPX);
            //}
        }

        #endregion

                        #endregion

       // #endregion

       // #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareInitialView();
            }
        }

        #endregion

        #region Button Event

        #endregion

        #region SiteMap Tree Events

        protected void rtvSiteMap_NodeExpand(object sender, TreeNodeEventArgs e)
        {
            //AddChildsNodesToSiteMap(Int64.Parse(e.Node.Value), e.Node);
        }

        protected void rtvSiteMap_NodeCheck(object sender, TreeNodeEventArgs e)
        {
            TreeNodeCheck(e.Node);

            //Need to think about SettingAttribute thepermission
            //InititializeDBTree();

            InititializeSiteMapTree();
        }

        #endregion

        #region DropdownList Events

        //protected void rcbSitemapList_SelectedIndexChanged(object o, SelectedIndexChangedEventArgs e)
        //{
        //    InititializeSiteMapTree();
        //}

        #endregion DropdownList Events

        #region Treeview Event

        protected void treeSitePhysicalStructure_OnSelectedNodeChanged(object src, ASTreeViewNodeSelectedEventArgs e)
        {
            //BindList();
        }

        #endregion

        #endregion
    }
}