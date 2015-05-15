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
    public partial class MDSalaryTaxTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _SalaryTaxTypeID
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

        public MDSalaryTaxTypeEntity _MDSalaryTaxTypeEntity
        {
            get
            {
                MDSalaryTaxTypeEntity entity = new MDSalaryTaxTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSalaryTaxTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSalaryTaxTypeEntity CurrentMDSalaryTaxTypeEntity
        {
            get
            {
                if (_SalaryTaxTypeID > 0)
                {
                    if (_MDSalaryTaxTypeEntity.SalaryTaxTypeID != _SalaryTaxTypeID)
                    {
                        _MDSalaryTaxTypeEntity = FCCMDSalaryTaxType.GetFacadeCreate().GetByID(_SalaryTaxTypeID);
                    }
                }

                return _MDSalaryTaxTypeEntity;
            }
            set
            {
                _MDSalaryTaxTypeEntity = value;
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
            MDSalaryTaxTypeEntity mDSalaryTaxTypeEntity = CurrentMDSalaryTaxTypeEntity;


            if (!mDSalaryTaxTypeEntity.IsNew)
            {
                txtName.Text = mDSalaryTaxTypeEntity.Name.ToString();
                chkIsRemoved.Checked = mDSalaryTaxTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSalaryTaxTypeList();
        }

        private void BindMDSalaryTaxTypeList()
        {
            lvMDSalaryTaxType.DataBind();
        }

        private MDSalaryTaxTypeEntity BuildMDSalaryTaxTypeEntity()
        {
            MDSalaryTaxTypeEntity mDSalaryTaxTypeEntity = CurrentMDSalaryTaxTypeEntity;

            mDSalaryTaxTypeEntity.Name = txtName.Text.Trim();
            mDSalaryTaxTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSalaryTaxTypeEntity;
        }

        private void SaveMDSalaryTaxTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSalaryTaxTypeEntity mDSalaryTaxTypeEntity = BuildMDSalaryTaxTypeEntity();

                    Int64 result = -1;

                    if (mDSalaryTaxTypeEntity.IsNew)
                    {
                        result = FCCMDSalaryTaxType.GetFacadeCreate().Add(mDSalaryTaxTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryTaxTypeEntity.FLD_NAME_SalaryTaxTypeID, mDSalaryTaxTypeEntity.SalaryTaxTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSalaryTaxType.GetFacadeCreate().Update(mDSalaryTaxTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalaryTaxTypeID = 0;
                        _MDSalaryTaxTypeEntity = new MDSalaryTaxTypeEntity();
                        PrepareInitialView();
                        BindMDSalaryTaxTypeList();

                        if (mDSalaryTaxTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Tax Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Tax Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSalaryTaxTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Tax Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Tax Type Information.", false);
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

        protected void lvMDSalaryTaxType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalaryTaxTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalaryTaxTypeID);

            if (SalaryTaxTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalaryTaxTypeID = SalaryTaxTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryTaxTypeEntity.FLD_NAME_SalaryTaxTypeID, SalaryTaxTypeID.ToString(), SQLMatchType.Equal);

                        MDSalaryTaxTypeEntity mDSalaryTaxTypeEntity = new MDSalaryTaxTypeEntity();


                        result = FCCMDSalaryTaxType.GetFacadeCreate().Delete(mDSalaryTaxTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalaryTaxTypeID = 0;
                            _MDSalaryTaxTypeEntity = new MDSalaryTaxTypeEntity();
                            PrepareInitialView();
                            BindMDSalaryTaxTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Tax Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Tax Type.", true);
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

        protected void odsMDSalaryTaxType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSalaryTaxTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalaryTaxTypeID = 0;
            _MDSalaryTaxTypeEntity = new MDSalaryTaxTypeEntity();
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
