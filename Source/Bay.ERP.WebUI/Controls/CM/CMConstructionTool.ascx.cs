// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMConstructionToolControl : BaseControl
    {       
        #region Properties

        public Int64 _ConstructionToolID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public CMConstructionToolEntity _CMConstructionToolEntity
        {
            get
            {
                CMConstructionToolEntity entity = new CMConstructionToolEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConstructionToolEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConstructionToolEntity CurrentCMConstructionToolEntity
        {
            get
            {
                if (_ConstructionToolID > 0)
                {
                    if (_CMConstructionToolEntity.ConstructionToolID != _ConstructionToolID)
                    {
                        _CMConstructionToolEntity = FCCCMConstructionTool.GetFacadeCreate().GetByID(_ConstructionToolID);
                    }
                }

                return _CMConstructionToolEntity;
            }
            set
            {
                _CMConstructionToolEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDConstructionToolCategory(ddlConstructionToolCategoryID, true);
            MiscUtil.PopulateMDUnit(ddlUnitID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtToolName.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConstructionToolEntity cMConstructionToolEntity = CurrentCMConstructionToolEntity;


            if (!cMConstructionToolEntity.IsNew)
            {
                if (ddlConstructionToolCategoryID.Items.Count > 0 && cMConstructionToolEntity.ConstructionToolCategoryID != null)
                {
                    ddlConstructionToolCategoryID.SelectedValue = cMConstructionToolEntity.ConstructionToolCategoryID.ToString();
                }

                txtToolName.Text = cMConstructionToolEntity.ToolName.ToString();
                if (ddlUnitID.Items.Count > 0 && cMConstructionToolEntity.UnitID != null)
                {
                    ddlUnitID.SelectedValue = cMConstructionToolEntity.UnitID.ToString();
                }

                chkIsRemoved.Checked = cMConstructionToolEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConstructionToolList();
        }

        private void BindCMConstructionToolList()
        {
            lvCMConstructionTool.DataBind();
        }

        private CMConstructionToolEntity BuildCMConstructionToolEntity()
        {
            CMConstructionToolEntity cMConstructionToolEntity = CurrentCMConstructionToolEntity;

            if (ddlConstructionToolCategoryID.Items.Count > 0)
            {
                if (ddlConstructionToolCategoryID.SelectedValue == "0")
                {
                    cMConstructionToolEntity.ConstructionToolCategoryID = null;
                }
                else
                {
                    cMConstructionToolEntity.ConstructionToolCategoryID = Int64.Parse(ddlConstructionToolCategoryID.SelectedValue);
                }
            }

            cMConstructionToolEntity.ToolName = txtToolName.Text.Trim();
            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                    cMConstructionToolEntity.UnitID = null;
                }
                else
                {
                    cMConstructionToolEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
                }
            }

            cMConstructionToolEntity.IsRemoved = chkIsRemoved.Checked;


            return cMConstructionToolEntity;
        }

        private void SaveCMConstructionToolEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConstructionToolEntity cMConstructionToolEntity = BuildCMConstructionToolEntity();

                    Int64 result = -1;

                    if (cMConstructionToolEntity.IsNew)
                    {
                        result = FCCCMConstructionTool.GetFacadeCreate().Add(cMConstructionToolEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConstructionToolEntity.FLD_NAME_ConstructionToolID, cMConstructionToolEntity.ConstructionToolID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConstructionTool.GetFacadeCreate().Update(cMConstructionToolEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConstructionToolID = 0;
                        _CMConstructionToolEntity = new CMConstructionToolEntity();
                        PrepareInitialView();
                        BindCMConstructionToolList();

                        if (cMConstructionToolEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConstructionToolEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Construction Tool Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MConstruction Tool Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMConstructionTool_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMConstructionTool_DetailedEntity ent = (CMConstructionTool_DetailedEntity)dataItem.DataItem;

                HyperLink hypToolDetails = (HyperLink)e.Item.FindControl("hypToolDetails");

                hypToolDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConstructionToolDetail.aspx", String.Empty, UrlConstants.OVERVIEW_CONSTRUCTION_TOOL_ID, ent.ConstructionToolID.ToString()).ToString();
                hypToolDetails.Target = "_blank";
            }
        }

        

        protected void lvCMConstructionTool_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConstructionToolID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConstructionToolID);

            if (ConstructionToolID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConstructionToolID = ConstructionToolID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConstructionToolEntity.FLD_NAME_ConstructionToolID, ConstructionToolID.ToString(), SQLMatchType.Equal);

                        CMConstructionToolEntity cMConstructionToolEntity = new CMConstructionToolEntity();


                        result = FCCCMConstructionTool.GetFacadeCreate().Delete(cMConstructionToolEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConstructionToolID = 0;
                            _CMConstructionToolEntity = new CMConstructionToolEntity();
                            PrepareInitialView();
                            BindCMConstructionToolList();

                            MiscUtil.ShowMessage(lblMessage, "Construction Tool has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Construction Tool.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsCMConstructionTool_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConstructionToolEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConstructionToolID = 0;
            _CMConstructionToolEntity = new CMConstructionToolEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
