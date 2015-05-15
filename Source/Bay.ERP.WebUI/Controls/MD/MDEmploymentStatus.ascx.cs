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
    public partial class MDEmploymentStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _EmploymentStatusID
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

        public MDEmploymentStatusEntity _MDEmploymentStatusEntity
        {
            get
            {
                MDEmploymentStatusEntity entity = new MDEmploymentStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmploymentStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmploymentStatusEntity CurrentMDEmploymentStatusEntity
        {
            get
            {
                if (_EmploymentStatusID > 0)
                {
                    if (_MDEmploymentStatusEntity.EmploymentStatusID != _EmploymentStatusID)
                    {
                        _MDEmploymentStatusEntity = FCCMDEmploymentStatus.GetFacadeCreate().GetByID(_EmploymentStatusID);
                    }
                }

                return _MDEmploymentStatusEntity;
            }
            set
            {
                _MDEmploymentStatusEntity = value;
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
            MDEmploymentStatusEntity mDEmploymentStatusEntity = CurrentMDEmploymentStatusEntity;


            if (!mDEmploymentStatusEntity.IsNew)
            {
                txtName.Text = mDEmploymentStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDEmploymentStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmploymentStatusList();
        }

        private void BindMDEmploymentStatusList()
        {
            lvMDEmploymentStatus.DataBind();
        }

        private MDEmploymentStatusEntity BuildMDEmploymentStatusEntity()
        {
            MDEmploymentStatusEntity mDEmploymentStatusEntity = CurrentMDEmploymentStatusEntity;

            mDEmploymentStatusEntity.Name = txtName.Text.Trim();
            mDEmploymentStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmploymentStatusEntity;
        }

        private void SaveMDEmploymentStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmploymentStatusEntity mDEmploymentStatusEntity = BuildMDEmploymentStatusEntity();

                    Int64 result = -1;

                    if (mDEmploymentStatusEntity.IsNew)
                    {
                        result = FCCMDEmploymentStatus.GetFacadeCreate().Add(mDEmploymentStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmploymentStatusEntity.FLD_NAME_EmploymentStatusID, mDEmploymentStatusEntity.EmploymentStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmploymentStatus.GetFacadeCreate().Update(mDEmploymentStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmploymentStatusID = 0;
                        _MDEmploymentStatusEntity = new MDEmploymentStatusEntity();
                        PrepareInitialView();
                        BindMDEmploymentStatusList();

                        if (mDEmploymentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employment Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employment Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmploymentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employment Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employment Status Information.", false);
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

        protected void lvMDEmploymentStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmploymentStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmploymentStatusID);

            if (EmploymentStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmploymentStatusID = EmploymentStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmploymentStatusEntity.FLD_NAME_EmploymentStatusID, EmploymentStatusID.ToString(), SQLMatchType.Equal);

                        MDEmploymentStatusEntity mDEmploymentStatusEntity = new MDEmploymentStatusEntity();


                        result = FCCMDEmploymentStatus.GetFacadeCreate().Delete(mDEmploymentStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmploymentStatusID = 0;
                            _MDEmploymentStatusEntity = new MDEmploymentStatusEntity();
                            PrepareInitialView();
                            BindMDEmploymentStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Employment Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employment Status.", true);
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

        protected void odsMDEmploymentStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmploymentStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmploymentStatusID = 0;
            _MDEmploymentStatusEntity = new MDEmploymentStatusEntity();
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
