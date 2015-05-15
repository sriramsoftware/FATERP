// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    public partial class PRMPreBOQFloorDetailControl : BaseControl
    {       
        #region Properties

        public Int64 _PreBOQFloorDetailID
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

        public PRMPreBOQFloorDetailEntity _PRMPreBOQFloorDetailEntity
        {
            get
            {
                PRMPreBOQFloorDetailEntity entity = new PRMPreBOQFloorDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMPreBOQFloorDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMPreBOQFloorDetailEntity CurrentPRMPreBOQFloorDetailEntity
        {
            get
            {
                if (_PreBOQFloorDetailID > 0)
                {
                    if (_PRMPreBOQFloorDetailEntity.PreBOQFloorDetailID != _PreBOQFloorDetailID)
                    {
                        _PRMPreBOQFloorDetailEntity = FCCPRMPreBOQFloorDetail.GetFacadeCreate().GetByID(_PreBOQFloorDetailID);
                    }
                }

                return _PRMPreBOQFloorDetailEntity;
            }
            set
            {
                _PRMPreBOQFloorDetailEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulatePRMPreBOQDetail(ddlPreBOQDetailID, false);
            MiscUtil.PopulateBDProjectFloor(ddlProjectFloorID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtQty.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtEntryDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity = CurrentPRMPreBOQFloorDetailEntity;


            if (!pRMPreBOQFloorDetailEntity.IsNew)
            {
                if (ddlPreBOQDetailID.Items.Count > 0 && pRMPreBOQFloorDetailEntity.PreBOQDetailID != null)
                {
                    ddlPreBOQDetailID.SelectedValue = pRMPreBOQFloorDetailEntity.PreBOQDetailID.ToString();
                }

                if (ddlProjectFloorID.Items.Count > 0 && pRMPreBOQFloorDetailEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = pRMPreBOQFloorDetailEntity.ProjectFloorID.ToString();
                }

                txtQty.Text = pRMPreBOQFloorDetailEntity.Qty.ToString();
                txtRate.Text = pRMPreBOQFloorDetailEntity.Rate.ToString();
                txtRemarks.Text = pRMPreBOQFloorDetailEntity.Remarks.ToString();
                txtEntryDate.Text = pRMPreBOQFloorDetailEntity.EntryDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMPreBOQFloorDetailList();
        }

        private void BindPRMPreBOQFloorDetailList()
        {
            lvPRMPreBOQFloorDetail.DataBind();
        }

        private PRMPreBOQFloorDetailEntity BuildPRMPreBOQFloorDetailEntity()
        {
            PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity = CurrentPRMPreBOQFloorDetailEntity;

            if (ddlPreBOQDetailID.Items.Count > 0)
            {
                if (ddlPreBOQDetailID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMPreBOQFloorDetailEntity.PreBOQDetailID = Int64.Parse(ddlPreBOQDetailID.SelectedValue);
                }
            }

            if (ddlProjectFloorID.Items.Count > 0)
            {
                if (ddlProjectFloorID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMPreBOQFloorDetailEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                }
            }

            if (!txtQty.Text.Trim().IsNullOrEmpty())
            {
                pRMPreBOQFloorDetailEntity.Qty = Decimal.Parse(txtQty.Text.Trim());
            }
            else
            {
                pRMPreBOQFloorDetailEntity.Qty = null;
            }

            if (!txtRate.Text.Trim().IsNullOrEmpty())
            {
                pRMPreBOQFloorDetailEntity.Rate = Decimal.Parse(txtRate.Text.Trim());
            }
            else
            {
                pRMPreBOQFloorDetailEntity.Rate = null;
            }

            pRMPreBOQFloorDetailEntity.Remarks = txtRemarks.Text.Trim();
            if (txtEntryDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMPreBOQFloorDetailEntity.EntryDate = MiscUtil.ParseToDateTime(txtEntryDate.Text);
            }


            return pRMPreBOQFloorDetailEntity;
        }

        private void SavePRMPreBOQFloorDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity = BuildPRMPreBOQFloorDetailEntity();

                    Int64 result = -1;

                    if (pRMPreBOQFloorDetailEntity.IsNew)
                    {
                        result = FCCPRMPreBOQFloorDetail.GetFacadeCreate().Add(pRMPreBOQFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQFloorDetailID, pRMPreBOQFloorDetailEntity.PreBOQFloorDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMPreBOQFloorDetail.GetFacadeCreate().Update(pRMPreBOQFloorDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PreBOQFloorDetailID = 0;
                        _PRMPreBOQFloorDetailEntity = new PRMPreBOQFloorDetailEntity();
                        PrepareInitialView();
                        BindPRMPreBOQFloorDetailList();

                        if (pRMPreBOQFloorDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pre BOQFloor Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pre BOQFloor Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMPreBOQFloorDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Pre BOQFloor Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Pre BOQFloor Detail Information.", false);
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

        protected void lvPRMPreBOQFloorDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PreBOQFloorDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out PreBOQFloorDetailID);

            if (PreBOQFloorDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PreBOQFloorDetailID = PreBOQFloorDetailID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQFloorDetailID, PreBOQFloorDetailID.ToString(), SQLMatchType.Equal);

                        PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity = new PRMPreBOQFloorDetailEntity();


                        result = FCCPRMPreBOQFloorDetail.GetFacadeCreate().Delete(pRMPreBOQFloorDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PreBOQFloorDetailID = 0;
                            _PRMPreBOQFloorDetailEntity = new PRMPreBOQFloorDetailEntity();
                            PrepareInitialView();
                            BindPRMPreBOQFloorDetailList();

                            MiscUtil.ShowMessage(lblMessage, "Pre BOQFloor Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Pre BOQFloor Detail.", true);
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

        protected void odsPRMPreBOQFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMPreBOQFloorDetailEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PreBOQFloorDetailID = 0;
            _PRMPreBOQFloorDetailEntity = new PRMPreBOQFloorDetailEntity();
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
