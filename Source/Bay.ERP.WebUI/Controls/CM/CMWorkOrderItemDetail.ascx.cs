// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2012, 04:57:13




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
    public partial class CMWorkOrderItemDetailControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkOrderItemDetailID
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

        public PRMWorkOrderItemDetailEntity _PRMWorkOrderItemDetailEntity
        {
            get
            {
                PRMWorkOrderItemDetailEntity entity = new PRMWorkOrderItemDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderItemDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMWorkOrderItemDetailEntity CurrentPRMWorkOrderItemDetailEntity
        {
            get
            {
                if (_WorkOrderItemDetailID > 0)
                {
                    if (_PRMWorkOrderItemDetailEntity.WorkOrderItemDetailID != _WorkOrderItemDetailID)
                    {
                        _PRMWorkOrderItemDetailEntity = FCCPRMWorkOrderItemDetail.GetFacadeCreate().GetByID(_WorkOrderItemDetailID);
                    }
                }

                return _PRMWorkOrderItemDetailEntity;
            }
            set
            {
                _PRMWorkOrderItemDetailEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
           // MiscUtil.PopulatePRMWorkOrderItemMap(ddlWorkOrderItemMapID, false);
            MiscUtil.PopulateMDUnit(ddlUnitID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDescription.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtQty.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = CurrentPRMWorkOrderItemDetailEntity;


            if (!pRMWorkOrderItemDetailEntity.IsNew)
            {
                if (ddlWorkOrderItemMapID.Items.Count > 0 && pRMWorkOrderItemDetailEntity.WorkOrderItemMapID != null)
                {
                    ddlWorkOrderItemMapID.SelectedValue = pRMWorkOrderItemDetailEntity.WorkOrderItemMapID.ToString();
                }

                txtDescription.Text = pRMWorkOrderItemDetailEntity.Description.ToString();
                if (ddlUnitID.Items.Count > 0 && pRMWorkOrderItemDetailEntity.UnitID != null)
                {
                    ddlUnitID.SelectedValue = pRMWorkOrderItemDetailEntity.UnitID.ToString();
                }

                txtRate.Text = pRMWorkOrderItemDetailEntity.Rate.ToString();
                txtQty.Text = pRMWorkOrderItemDetailEntity.Qty.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMWorkOrderItemDetailList();
        }

        private void BindPRMWorkOrderItemDetailList()
        {
            lvPRMWorkOrderItemDetail.DataBind();
        }

        private PRMWorkOrderItemDetailEntity BuildPRMWorkOrderItemDetailEntity()
        {
            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = CurrentPRMWorkOrderItemDetailEntity;

            if (ddlWorkOrderItemMapID.Items.Count > 0)
            {
                if (ddlWorkOrderItemMapID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderItemDetailEntity.WorkOrderItemMapID = Int64.Parse(ddlWorkOrderItemMapID.SelectedValue);
                }
            }

            pRMWorkOrderItemDetailEntity.Description = txtDescription.Text.Trim();
            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                    pRMWorkOrderItemDetailEntity.UnitID = null;
                }
                else
                {
                    pRMWorkOrderItemDetailEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
                }
            }

            if (!txtRate.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderItemDetailEntity.Rate = Decimal.Parse(txtRate.Text.Trim());
            }

            if (!txtQty.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderItemDetailEntity.Qty = Decimal.Parse(txtQty.Text.Trim());
            }


            return pRMWorkOrderItemDetailEntity;
        }

        private void SavePRMWorkOrderItemDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = BuildPRMWorkOrderItemDetailEntity();

                    Int64 result = -1;

                    if (pRMWorkOrderItemDetailEntity.IsNew)
                    {
                        result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Add(pRMWorkOrderItemDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, pRMWorkOrderItemDetailEntity.WorkOrderItemDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Update(pRMWorkOrderItemDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkOrderItemDetailID = 0;
                        _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
                        PrepareInitialView();
                        BindPRMWorkOrderItemDetailList();

                        if (pRMWorkOrderItemDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMWorkOrderItemDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Item Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Item Detail Information.", false);
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

        protected void lvPRMWorkOrderItemDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderItemDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderItemDetailID);

            if (WorkOrderItemDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkOrderItemDetailID = WorkOrderItemDetailID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, WorkOrderItemDetailID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();


                        result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Delete(pRMWorkOrderItemDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderItemDetailID = 0;
                            _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderItemDetailList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Item Detail.", true);
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

        protected void odsPRMWorkOrderItemDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMWorkOrderItemDetailEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkOrderItemDetailID = 0;
            _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
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
