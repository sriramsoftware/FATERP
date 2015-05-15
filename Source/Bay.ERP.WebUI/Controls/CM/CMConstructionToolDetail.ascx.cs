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
    public partial class CMConstructionToolDetailControl : BaseControl
    {       
        #region Properties

        public Int64 _ConstructionToolDetailID
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

        public CMConstructionToolDetailEntity _CMConstructionToolDetailEntity
        {
            get
            {
                CMConstructionToolDetailEntity entity = new CMConstructionToolDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConstructionToolDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConstructionToolDetailEntity CurrentCMConstructionToolDetailEntity
        {
            get
            {
                if (_ConstructionToolDetailID > 0)
                {
                    if (_CMConstructionToolDetailEntity.ConstructionToolDetailID != _ConstructionToolDetailID)
                    {
                        _CMConstructionToolDetailEntity = FCCCMConstructionToolDetail.GetFacadeCreate().GetByID(_ConstructionToolDetailID);
                    }
                }

                return _CMConstructionToolDetailEntity;
            }
            set
            {
                _CMConstructionToolDetailEntity = value;
            }
        }

        public Int64 CurrentConstructionToolID
        {
            get
            {
                Int64 id = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CONSTRUCTION_TOOL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CONSTRUCTION_TOOL_ID], out id);
                }

                return id;
            }
        }

        private CMConstructionToolEntity CurrentCMConstructionToolEntity
        {
            get
            {
                CMConstructionToolEntity ent = null;

                if (ViewState["CurrentCMConstructionToolEntity"] != null)
                {
                    ent = (CMConstructionToolEntity)ViewState["CurrentCMConstructionToolEntity"];
                }
                else
                {
                    if (CurrentConstructionToolID > 0)
                    {
                        ent = FCCCMConstructionTool.GetFacadeCreate().GetByID(CurrentConstructionToolID);
                    }
                }

                return ent;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDConstructionToolWorkingCondition(ddlConstructionToolWorkingConditionID, false);
            MiscUtil.PopulateMDBrand(ddlBrandID, true);
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, true);
            MiscUtil.PopulateBDProject(ddlProjectID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            lblConstructionTool.Text = CurrentCMConstructionToolEntity.ToolName;
            txtSpecification.Text = String.Empty;
            txtNextMaintananceDate.Text = String.Empty;
            txtUsedOrHandeledBy.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConstructionToolDetailEntity cMConstructionToolDetailEntity = CurrentCMConstructionToolDetailEntity;


            if (!cMConstructionToolDetailEntity.IsNew)
            {
                lblConstructionTool.Text = CurrentCMConstructionToolEntity.ToolName;
                txtSpecification.Text = cMConstructionToolDetailEntity.Specification.ToString();
                if (ddlConstructionToolWorkingConditionID.Items.Count > 0 && cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID != null)
                {
                    ddlConstructionToolWorkingConditionID.SelectedValue = cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID.ToString();
                }

                if (ddlBrandID.Items.Count > 0 && cMConstructionToolDetailEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = cMConstructionToolDetailEntity.BrandID.ToString();
                }

                if (ddlSupplierID.Items.Count > 0 && cMConstructionToolDetailEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = cMConstructionToolDetailEntity.SupplierID.ToString();
                }

                txtNextMaintananceDate.Text = cMConstructionToolDetailEntity.NextMaintananceDate.ToStringDefault();
                txtUsedOrHandeledBy.Text = cMConstructionToolDetailEntity.UsedOrHandeledBy.ToString();
                if (ddlProjectID.Items.Count > 0 && cMConstructionToolDetailEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cMConstructionToolDetailEntity.ProjectID.ToString();
                }

                txtRemarks.Text = cMConstructionToolDetailEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConstructionToolDetailList();
        }

        private void BindCMConstructionToolDetailList()
        {
            lvCMConstructionToolDetail.DataBind();
        }

        private CMConstructionToolDetailEntity BuildCMConstructionToolDetailEntity()
        {
            CMConstructionToolDetailEntity cMConstructionToolDetailEntity = CurrentCMConstructionToolDetailEntity;

            cMConstructionToolDetailEntity.ConstructionToolID = CurrentCMConstructionToolEntity.ConstructionToolID;            
            cMConstructionToolDetailEntity.Specification = txtSpecification.Text.Trim();
            if (ddlConstructionToolWorkingConditionID.Items.Count > 0)
            {
                if (ddlConstructionToolWorkingConditionID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID = Int64.Parse(ddlConstructionToolWorkingConditionID.SelectedValue);
                }
            }

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                    cMConstructionToolDetailEntity.BrandID = null;
                }
                else
                {
                    cMConstructionToolDetailEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                    cMConstructionToolDetailEntity.SupplierID = null;
                }
                else
                {
                    cMConstructionToolDetailEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (txtNextMaintananceDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMConstructionToolDetailEntity.NextMaintananceDate = MiscUtil.ParseToDateTime(txtNextMaintananceDate.Text);
            }
            else
            {
                cMConstructionToolDetailEntity.NextMaintananceDate = null;
            }

            cMConstructionToolDetailEntity.UsedOrHandeledBy = txtUsedOrHandeledBy.Text.Trim();
            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                    cMConstructionToolDetailEntity.ProjectID = null;
                }
                else
                {
                    cMConstructionToolDetailEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            cMConstructionToolDetailEntity.Remarks = txtRemarks.Text.ToString();

            if (cMConstructionToolDetailEntity.IsNew)
            {
                cMConstructionToolDetailEntity.IsRemoved = false;
            }

            return cMConstructionToolDetailEntity;
        }

        private void SaveCMConstructionToolDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConstructionToolDetailEntity cMConstructionToolDetailEntity = BuildCMConstructionToolDetailEntity();

                    Int64 result = -1;

                    if (cMConstructionToolDetailEntity.IsNew)
                    {
                        result = FCCCMConstructionToolDetail.GetFacadeCreate().Add(cMConstructionToolDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConstructionToolDetailEntity.FLD_NAME_ConstructionToolDetailID, cMConstructionToolDetailEntity.ConstructionToolDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConstructionToolDetail.GetFacadeCreate().Update(cMConstructionToolDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConstructionToolDetailID = 0;
                        _CMConstructionToolDetailEntity = new CMConstructionToolDetailEntity();
                        PrepareInitialView();
                        BindCMConstructionToolDetailList();

                        if (cMConstructionToolDetailEntity.IsNew)
                        {
                            #region Adding Rsource Information

                            ResourceEntity resourceEntity = new ResourceEntity();

                            resourceEntity.ReferenceID = result; // means new contractor id
                            resourceEntity.ResourceCategoryID = MasterDataConstants.ResourceCategory.TOOL;

                            FCCResource.GetFacadeCreate().Add(resourceEntity, DatabaseOperationType.Add, TransactionRequired.No);

                            #endregion

                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConstructionToolDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Construction Tool Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Construction Tool Detail Information.", false);
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

        protected void lvCMConstructionToolDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConstructionToolDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConstructionToolDetailID);

            if (ConstructionToolDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConstructionToolDetailID = ConstructionToolDetailID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        #region Resource Delete

                        Int64 resultOne = -1;

                        String fe1_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ReferenceID, ConstructionToolDetailID.ToString(), SQLMatchType.Equal);
                        String fe2_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID, MasterDataConstants.ResourceCategory.TOOL.ToString(), SQLMatchType.Equal);
                        String fe_re = SqlExpressionBuilder.PrepareFilterExpression(fe1_re, SQLJoinType.AND, fe2_re);

                        IList<ResourceEntity> resourceList = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe_re, DatabaseOperationType.LoadWithFilterExpression);

                        foreach (ResourceEntity ent in resourceList)
                        {
                            String fe_re_delete = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceID, ent.ResourceID.ToString(), SQLMatchType.Equal);

                            resultOne = FCCResource.GetFacadeCreate().Delete(ent, fe_re_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        if (resultOne == 0)
                        {

                            Int64 result = -1;

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConstructionToolDetailEntity.FLD_NAME_ConstructionToolDetailID, ConstructionToolDetailID.ToString(), SQLMatchType.Equal);

                            CMConstructionToolDetailEntity cMConstructionToolDetailEntity = new CMConstructionToolDetailEntity();


                            result = FCCCMConstructionToolDetail.GetFacadeCreate().Delete(cMConstructionToolDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                            if (result == 0)
                            {
                                _ConstructionToolDetailID = 0;
                                _CMConstructionToolDetailEntity = new CMConstructionToolDetailEntity();
                                PrepareInitialView();
                                BindCMConstructionToolDetailList();

                                MiscUtil.ShowMessage(lblMessage, "Construction Tool Detail has been successfully deleted.", true);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to delete Construction Tool Detail.", true);
                            }
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Construction Tool Detail and Resource Information.", true);
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

        protected void odsCMConstructionToolDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMConstructionToolDetail." + CMConstructionToolDetailEntity.FLD_NAME_ConstructionToolID, CurrentCMConstructionToolEntity.ConstructionToolID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConstructionToolDetailEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConstructionToolDetailID = 0;
            _CMConstructionToolDetailEntity = new CMConstructionToolDetailEntity();
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
