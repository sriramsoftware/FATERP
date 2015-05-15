// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public partial class MDSalaryRateDurationControl : BaseControl
    {       
        #region Properties

        public Int64 _SalaryRateDurationID
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

        public MDSalaryRateDurationEntity _MDSalaryRateDurationEntity
        {
            get
            {
                MDSalaryRateDurationEntity entity = new MDSalaryRateDurationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSalaryRateDurationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSalaryRateDurationEntity CurrentMDSalaryRateDurationEntity
        {
            get
            {
                if (_SalaryRateDurationID > 0)
                {
                    if (_MDSalaryRateDurationEntity.SalaryRateDurationID != _SalaryRateDurationID)
                    {
                        _MDSalaryRateDurationEntity = FCCMDSalaryRateDuration.GetFacadeCreate().GetByID(_SalaryRateDurationID);
                    }
                }

                return _MDSalaryRateDurationEntity;
            }
            set
            {
                _MDSalaryRateDurationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDSalaryRateDurationEntity mDSalaryRateDurationEntity = CurrentMDSalaryRateDurationEntity;


            if (!mDSalaryRateDurationEntity.IsNew)
            {
                txtName.Text = mDSalaryRateDurationEntity.Name.ToString();
                chkIsRemoved.Checked = mDSalaryRateDurationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSalaryRateDurationList();
        }

        private void BindMDSalaryRateDurationList()
        {
            lvMDSalaryRateDuration.DataBind();
        }

        private MDSalaryRateDurationEntity BuildMDSalaryRateDurationEntity()
        {
            MDSalaryRateDurationEntity mDSalaryRateDurationEntity = CurrentMDSalaryRateDurationEntity;

            mDSalaryRateDurationEntity.Name = txtName.Text.Trim();
            mDSalaryRateDurationEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSalaryRateDurationEntity;
        }

        private void SaveMDSalaryRateDurationEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSalaryRateDurationEntity mDSalaryRateDurationEntity = BuildMDSalaryRateDurationEntity();

                    Int64 result = -1;

                    if (mDSalaryRateDurationEntity.IsNew)
                    {
                        result = FCCMDSalaryRateDuration.GetFacadeCreate().Add(mDSalaryRateDurationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryRateDurationEntity.FLD_NAME_SalaryRateDurationID, mDSalaryRateDurationEntity.SalaryRateDurationID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSalaryRateDuration.GetFacadeCreate().Update(mDSalaryRateDurationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalaryRateDurationID = 0;
                        _MDSalaryRateDurationEntity = new MDSalaryRateDurationEntity();
                        PrepareInitialView();
                        BindMDSalaryRateDurationList();

                        if (mDSalaryRateDurationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Rate Duration Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Rate Duration Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSalaryRateDurationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Rate Duration Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Rate Duration Information.", false);
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

        protected void lvMDSalaryRateDuration_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalaryRateDurationID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalaryRateDurationID);

            if (SalaryRateDurationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalaryRateDurationID = SalaryRateDurationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryRateDurationEntity.FLD_NAME_SalaryRateDurationID, SalaryRateDurationID.ToString(), SQLMatchType.Equal);

                        MDSalaryRateDurationEntity mDSalaryRateDurationEntity = new MDSalaryRateDurationEntity();


                        result = FCCMDSalaryRateDuration.GetFacadeCreate().Delete(mDSalaryRateDurationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalaryRateDurationID = 0;
                            _MDSalaryRateDurationEntity = new MDSalaryRateDurationEntity();
                            PrepareInitialView();
                            BindMDSalaryRateDurationList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Rate Duration has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Rate Duration.", true);
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

        protected void odsMDSalaryRateDuration_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSalaryRateDurationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalaryRateDurationID = 0;
            _MDSalaryRateDurationEntity = new MDSalaryRateDurationEntity();
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
