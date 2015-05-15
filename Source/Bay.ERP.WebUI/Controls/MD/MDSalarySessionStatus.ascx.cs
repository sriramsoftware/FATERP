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
    public partial class MDSalarySessionStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _SalarySessionStatusID
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

        public MDSalarySessionStatusEntity _MDSalarySessionStatusEntity
        {
            get
            {
                MDSalarySessionStatusEntity entity = new MDSalarySessionStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSalarySessionStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSalarySessionStatusEntity CurrentMDSalarySessionStatusEntity
        {
            get
            {
                if (_SalarySessionStatusID > 0)
                {
                    if (_MDSalarySessionStatusEntity.SalarySessionStatusID != _SalarySessionStatusID)
                    {
                        _MDSalarySessionStatusEntity = FCCMDSalarySessionStatus.GetFacadeCreate().GetByID(_SalarySessionStatusID);
                    }
                }

                return _MDSalarySessionStatusEntity;
            }
            set
            {
                _MDSalarySessionStatusEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDSalarySessionStatusEntity mDSalarySessionStatusEntity = CurrentMDSalarySessionStatusEntity;


            if (!mDSalarySessionStatusEntity.IsNew)
            {
                txtName.Text = mDSalarySessionStatusEntity.Name.ToString();
                txtDescription.Text = mDSalarySessionStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDSalarySessionStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSalarySessionStatusList();
        }

        private void BindMDSalarySessionStatusList()
        {
            lvMDSalarySessionStatus.DataBind();
        }

        private MDSalarySessionStatusEntity BuildMDSalarySessionStatusEntity()
        {
            MDSalarySessionStatusEntity mDSalarySessionStatusEntity = CurrentMDSalarySessionStatusEntity;

            mDSalarySessionStatusEntity.Name = txtName.Text.Trim();
            mDSalarySessionStatusEntity.Description = txtDescription.Text.Trim();
            mDSalarySessionStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSalarySessionStatusEntity;
        }

        private void SaveMDSalarySessionStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSalarySessionStatusEntity mDSalarySessionStatusEntity = BuildMDSalarySessionStatusEntity();

                    Int64 result = -1;

                    if (mDSalarySessionStatusEntity.IsNew)
                    {
                        result = FCCMDSalarySessionStatus.GetFacadeCreate().Add(mDSalarySessionStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionStatusEntity.FLD_NAME_SalarySessionStatusID, mDSalarySessionStatusEntity.SalarySessionStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSalarySessionStatus.GetFacadeCreate().Update(mDSalarySessionStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalarySessionStatusID = 0;
                        _MDSalarySessionStatusEntity = new MDSalarySessionStatusEntity();
                        PrepareInitialView();
                        BindMDSalarySessionStatusList();

                        if (mDSalarySessionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Session Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Session Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSalarySessionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Session Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Session Status Information.", false);
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

        protected void lvMDSalarySessionStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalarySessionStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalarySessionStatusID);

            if (SalarySessionStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalarySessionStatusID = SalarySessionStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionStatusEntity.FLD_NAME_SalarySessionStatusID, SalarySessionStatusID.ToString(), SQLMatchType.Equal);

                        MDSalarySessionStatusEntity mDSalarySessionStatusEntity = new MDSalarySessionStatusEntity();


                        result = FCCMDSalarySessionStatus.GetFacadeCreate().Delete(mDSalarySessionStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalarySessionStatusID = 0;
                            _MDSalarySessionStatusEntity = new MDSalarySessionStatusEntity();
                            PrepareInitialView();
                            BindMDSalarySessionStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Session Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Session Status.", true);
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

        protected void odsMDSalarySessionStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSalarySessionStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalarySessionStatusID = 0;
            _MDSalarySessionStatusEntity = new MDSalarySessionStatusEntity();
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
