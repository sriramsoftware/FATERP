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
    public partial class MDSalaryTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _SalaryTypeID
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

        public MDSalaryTypeEntity _MDSalaryTypeEntity
        {
            get
            {
                MDSalaryTypeEntity entity = new MDSalaryTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSalaryTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSalaryTypeEntity CurrentMDSalaryTypeEntity
        {
            get
            {
                if (_SalaryTypeID > 0)
                {
                    if (_MDSalaryTypeEntity.SalaryTypeID != _SalaryTypeID)
                    {
                        _MDSalaryTypeEntity = FCCMDSalaryType.GetFacadeCreate().GetByID(_SalaryTypeID);
                    }
                }

                return _MDSalaryTypeEntity;
            }
            set
            {
                _MDSalaryTypeEntity = value;
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
            MDSalaryTypeEntity mDSalaryTypeEntity = CurrentMDSalaryTypeEntity;


            if (!mDSalaryTypeEntity.IsNew)
            {
                txtName.Text = mDSalaryTypeEntity.Name.ToString();
                chkIsRemoved.Checked = mDSalaryTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSalaryTypeList();
        }

        private void BindMDSalaryTypeList()
        {
            lvMDSalaryType.DataBind();
        }

        private MDSalaryTypeEntity BuildMDSalaryTypeEntity()
        {
            MDSalaryTypeEntity mDSalaryTypeEntity = CurrentMDSalaryTypeEntity;

            mDSalaryTypeEntity.Name = txtName.Text.Trim();
            mDSalaryTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSalaryTypeEntity;
        }

        private void SaveMDSalaryTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSalaryTypeEntity mDSalaryTypeEntity = BuildMDSalaryTypeEntity();

                    Int64 result = -1;

                    if (mDSalaryTypeEntity.IsNew)
                    {
                        result = FCCMDSalaryType.GetFacadeCreate().Add(mDSalaryTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryTypeEntity.FLD_NAME_SalaryTypeID, mDSalaryTypeEntity.SalaryTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSalaryType.GetFacadeCreate().Update(mDSalaryTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalaryTypeID = 0;
                        _MDSalaryTypeEntity = new MDSalaryTypeEntity();
                        PrepareInitialView();
                        BindMDSalaryTypeList();

                        if (mDSalaryTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSalaryTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Type Information.", false);
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

        protected void lvMDSalaryType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalaryTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalaryTypeID);

            if (SalaryTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalaryTypeID = SalaryTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryTypeEntity.FLD_NAME_SalaryTypeID, SalaryTypeID.ToString(), SQLMatchType.Equal);

                        MDSalaryTypeEntity mDSalaryTypeEntity = new MDSalaryTypeEntity();


                        result = FCCMDSalaryType.GetFacadeCreate().Delete(mDSalaryTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalaryTypeID = 0;
                            _MDSalaryTypeEntity = new MDSalaryTypeEntity();
                            PrepareInitialView();
                            BindMDSalaryTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Type.", true);
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

        protected void odsMDSalaryType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSalaryTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalaryTypeID = 0;
            _MDSalaryTypeEntity = new MDSalaryTypeEntity();
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
