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
    public partial class CMBillFloorDetailControl : BaseControl
    {       
        #region Properties

        public Int64 _BillFloorDetailID
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

        public CMBillFloorDetailEntity _CMBillFloorDetailEntity
        {
            get
            {
                CMBillFloorDetailEntity entity = new CMBillFloorDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMBillFloorDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMBillFloorDetailEntity CurrentCMBillFloorDetailEntity
        {
            get
            {
                if (_BillFloorDetailID > 0)
                {
                    if (_CMBillFloorDetailEntity.BillFloorDetailID != _BillFloorDetailID)
                    {
                        _CMBillFloorDetailEntity = FCCCMBillFloorDetail.GetFacadeCreate().GetByID(_BillFloorDetailID);
                    }
                }

                return _CMBillFloorDetailEntity;
            }
            set
            {
                _CMBillFloorDetailEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMBill(ddlBillID, false);
            //MiscUtil.PopulateCMMDBillFloorDetailCategory(ddlBillFloorDetailCategoryID, false);
            MiscUtil.PopulateBDProjectFloor(ddlProjectFloorID, false);
            MiscUtil.PopulateBDProjectFloorUnit(ddlProjectFloorUnitID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFloorBillAmount.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtEntryDate.Text = String.Empty;
            txtExtra1.Text = String.Empty;
            txtExtra2.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMBillFloorDetailEntity cMBillFloorDetailEntity = CurrentCMBillFloorDetailEntity;


            if (!cMBillFloorDetailEntity.IsNew)
            {
                if (ddlBillID.Items.Count > 0 && cMBillFloorDetailEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = cMBillFloorDetailEntity.BillID.ToString();
                }

                if (ddlBillFloorDetailCategoryID.Items.Count > 0 && cMBillFloorDetailEntity.BillFloorDetailCategoryID != null)
                {
                    ddlBillFloorDetailCategoryID.SelectedValue = cMBillFloorDetailEntity.BillFloorDetailCategoryID.ToString();
                }

                if (ddlProjectFloorID.Items.Count > 0 && cMBillFloorDetailEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = cMBillFloorDetailEntity.ProjectFloorID.ToString();
                }

                if (ddlProjectFloorUnitID.Items.Count > 0 && cMBillFloorDetailEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = cMBillFloorDetailEntity.ProjectFloorUnitID.ToString();
                }

                txtFloorBillAmount.Text = cMBillFloorDetailEntity.FloorBillAmount.ToString();
                txtRemarks.Text = cMBillFloorDetailEntity.Remarks.ToString();
                txtEntryDate.Text = cMBillFloorDetailEntity.EntryDate.ToStringDefault();
                txtExtra1.Text = cMBillFloorDetailEntity.Extra1.ToString();
                txtExtra2.Text = cMBillFloorDetailEntity.Extra2.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMBillFloorDetailList();
        }

        private void BindCMBillFloorDetailList()
        {
            lvCMBillFloorDetail.DataBind();
        }

        private CMBillFloorDetailEntity BuildCMBillFloorDetailEntity()
        {
            CMBillFloorDetailEntity cMBillFloorDetailEntity = CurrentCMBillFloorDetailEntity;

            if (ddlBillID.Items.Count > 0)
            {
                if (ddlBillID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillFloorDetailEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                }
            }

            if (ddlBillFloorDetailCategoryID.Items.Count > 0)
            {
                if (ddlBillFloorDetailCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillFloorDetailEntity.BillFloorDetailCategoryID = Int64.Parse(ddlBillFloorDetailCategoryID.SelectedValue);
                }
            }

            if (ddlProjectFloorID.Items.Count > 0)
            {
                if (ddlProjectFloorID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillFloorDetailEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                }
            }

            if (ddlProjectFloorUnitID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitID.SelectedValue == "0")
                {
                    cMBillFloorDetailEntity.ProjectFloorUnitID = null;
                }
                else
                {
                    cMBillFloorDetailEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                }
            }

            if (!txtFloorBillAmount.Text.Trim().IsNullOrEmpty())
            {
                cMBillFloorDetailEntity.FloorBillAmount = Decimal.Parse(txtFloorBillAmount.Text.Trim());
            }
            else
            {
                cMBillFloorDetailEntity.FloorBillAmount = null;
            }

            cMBillFloorDetailEntity.Remarks = txtRemarks.Text.Trim();
            if (txtEntryDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMBillFloorDetailEntity.EntryDate = MiscUtil.ParseToDateTime(txtEntryDate.Text);
            }

            cMBillFloorDetailEntity.Extra1 = txtExtra1.Text.Trim();
            cMBillFloorDetailEntity.Extra2 = txtExtra2.Text.Trim();

            return cMBillFloorDetailEntity;
        }

        private void SaveCMBillFloorDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMBillFloorDetailEntity cMBillFloorDetailEntity = BuildCMBillFloorDetailEntity();

                    Int64 result = -1;

                    if (cMBillFloorDetailEntity.IsNew)
                    {
                        result = FCCCMBillFloorDetail.GetFacadeCreate().Add(cMBillFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMBillFloorDetailEntity.FLD_NAME_BillFloorDetailID, cMBillFloorDetailEntity.BillFloorDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCCMBillFloorDetail.GetFacadeCreate().Update(cMBillFloorDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BillFloorDetailID = 0;
                        _CMBillFloorDetailEntity = new CMBillFloorDetailEntity();
                        PrepareInitialView();
                        BindCMBillFloorDetailList();

                        if (cMBillFloorDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MBill Floor Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MBill Floor Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMBillFloorDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MBill Floor Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MBill Floor Detail Information.", false);
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

        protected void lvCMBillFloorDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillFloorDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillFloorDetailID);

            if (BillFloorDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillFloorDetailID = BillFloorDetailID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillFloorDetailEntity.FLD_NAME_BillFloorDetailID, BillFloorDetailID.ToString(), SQLMatchType.Equal);

                        CMBillFloorDetailEntity cMBillFloorDetailEntity = new CMBillFloorDetailEntity();


                        result = FCCCMBillFloorDetail.GetFacadeCreate().Delete(cMBillFloorDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillFloorDetailID = 0;
                            _CMBillFloorDetailEntity = new CMBillFloorDetailEntity();
                            PrepareInitialView();
                            BindCMBillFloorDetailList();

                            MiscUtil.ShowMessage(lblMessage, "C MBill Floor Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MBill Floor Detail.", true);
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

        protected void odsCMBillFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMBillFloorDetailEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BillFloorDetailID = 0;
            _CMBillFloorDetailEntity = new CMBillFloorDetailEntity();
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
