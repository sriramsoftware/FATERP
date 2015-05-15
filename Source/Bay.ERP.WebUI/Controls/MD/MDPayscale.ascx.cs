// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDPayscaleControl : BaseControl
    {       
        #region Properties

        public Int64 _PayscaleID
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

        public MDPayscaleEntity _MDPayscaleEntity
        {
            get
            {
                MDPayscaleEntity entity = new MDPayscaleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDPayscaleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDPayscaleEntity CurrentMDPayscaleEntity
        {
            get
            {
                if (_PayscaleID > 0)
                {
                    if (_MDPayscaleEntity.PayscaleID != _PayscaleID)
                    {
                        _MDPayscaleEntity = FCCMDPayscale.GetFacadeCreate().GetByID(_PayscaleID);
                    }
                }

                return _MDPayscaleEntity;
            }
            set
            {
                _MDPayscaleEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
           MiscUtil.PopulateMDSalaryRateDuration(ddlSalaryRateDurationID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtMinimumSalary.Text = String.Empty;
            txtMaximumSalary.Text = String.Empty;
            txtAverageSalary.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDPayscaleEntity mDPayscaleEntity = CurrentMDPayscaleEntity;


            if (!mDPayscaleEntity.IsNew)
            {
                txtName.Text = mDPayscaleEntity.Name.ToString();
                txtDescription.Text = mDPayscaleEntity.Description.ToString();
                txtMinimumSalary.Text = mDPayscaleEntity.MinimumSalary.ToString();
                txtMaximumSalary.Text = mDPayscaleEntity.MaximumSalary.ToString();
                txtAverageSalary.Text = mDPayscaleEntity.AverageSalary.ToString();
                if (ddlSalaryRateDurationID.Items.Count > 0 && mDPayscaleEntity.SalaryRateDurationID != null)
                {
                    ddlSalaryRateDurationID.SelectedValue = mDPayscaleEntity.SalaryRateDurationID.ToString();
                }

                chkIsRemoved.Checked = mDPayscaleEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDPayscaleList();
        }

        private void BindMDPayscaleList()
        {
            lvMDPayscale.DataBind();
        }

        private MDPayscaleEntity BuildMDPayscaleEntity()
        {
            MDPayscaleEntity mDPayscaleEntity = CurrentMDPayscaleEntity;

            mDPayscaleEntity.Name = txtName.Text.Trim();
            mDPayscaleEntity.Description = txtDescription.Text.Trim();
            if (!txtMinimumSalary.Text.Trim().IsNullOrEmpty())
            {
                mDPayscaleEntity.MinimumSalary = Decimal.Parse(txtMinimumSalary.Text.Trim());
            }

            if (!txtMaximumSalary.Text.Trim().IsNullOrEmpty())
            {
                mDPayscaleEntity.MaximumSalary = Decimal.Parse(txtMaximumSalary.Text.Trim());
            }

            if (!txtAverageSalary.Text.Trim().IsNullOrEmpty())
            {
                mDPayscaleEntity.AverageSalary = Decimal.Parse(txtAverageSalary.Text.Trim());
            }

            if (ddlSalaryRateDurationID.Items.Count > 0)
            {
                if (ddlSalaryRateDurationID.SelectedValue == "0")
                {
                }
                else
                {
                    mDPayscaleEntity.SalaryRateDurationID = Int64.Parse(ddlSalaryRateDurationID.SelectedValue);
                }
            }

            mDPayscaleEntity.IsRemoved = chkIsRemoved.Checked;


            return mDPayscaleEntity;
        }

        private void SaveMDPayscaleEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDPayscaleEntity mDPayscaleEntity = BuildMDPayscaleEntity();

                    Int64 result = -1;

                    if (mDPayscaleEntity.IsNew)
                    {
                        result = FCCMDPayscale.GetFacadeCreate().Add(mDPayscaleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDPayscaleEntity.FLD_NAME_PayscaleID, mDPayscaleEntity.PayscaleID.ToString(), SQLMatchType.Equal);
                        result = FCCMDPayscale.GetFacadeCreate().Update(mDPayscaleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PayscaleID = 0;
                        _MDPayscaleEntity = new MDPayscaleEntity();
                        PrepareInitialView();
                        BindMDPayscaleList();

                        if (mDPayscaleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payscale Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payscale Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDPayscaleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Payscale Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Payscale Information.", false);
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

        protected void lvMDPayscale_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PayscaleID;

            Int64.TryParse(e.CommandArgument.ToString(), out PayscaleID);

            if (PayscaleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PayscaleID = PayscaleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDPayscaleEntity.FLD_NAME_PayscaleID, PayscaleID.ToString(), SQLMatchType.Equal);

                        MDPayscaleEntity mDPayscaleEntity = new MDPayscaleEntity();


                        result = FCCMDPayscale.GetFacadeCreate().Delete(mDPayscaleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PayscaleID = 0;
                            _MDPayscaleEntity = new MDPayscaleEntity();
                            PrepareInitialView();
                            BindMDPayscaleList();

                            MiscUtil.ShowMessage(lblMessage, "Payscale has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payscale.", true);
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

        protected void odsMDPayscale_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDPayscaleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PayscaleID = 0;
            _MDPayscaleEntity = new MDPayscaleEntity();
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
