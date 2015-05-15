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
    public partial class MDLoanCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _LoanCategoryID
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

        public MDLoanCategoryEntity _MDLoanCategoryEntity
        {
            get
            {
                MDLoanCategoryEntity entity = new MDLoanCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDLoanCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDLoanCategoryEntity CurrentMDLoanCategoryEntity
        {
            get
            {
                if (_LoanCategoryID > 0)
                {
                    if (_MDLoanCategoryEntity.LoanCategoryID != _LoanCategoryID)
                    {
                        _MDLoanCategoryEntity = FCCMDLoanCategory.GetFacadeCreate().GetByID(_LoanCategoryID);
                    }
                }

                return _MDLoanCategoryEntity;
            }
            set
            {
                _MDLoanCategoryEntity = value;
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

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDLoanCategoryEntity mDLoanCategoryEntity = CurrentMDLoanCategoryEntity;


            if (!mDLoanCategoryEntity.IsNew)
            {
                txtName.Text = mDLoanCategoryEntity.Name.ToString();
                txtDescription.Text = mDLoanCategoryEntity.Description.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDLoanCategoryList();
        }

        private void BindMDLoanCategoryList()
        {
            lvMDLoanCategory.DataBind();
        }

        private MDLoanCategoryEntity BuildMDLoanCategoryEntity()
        {
            MDLoanCategoryEntity mDLoanCategoryEntity = CurrentMDLoanCategoryEntity;

            mDLoanCategoryEntity.Name = txtName.Text.Trim();
            mDLoanCategoryEntity.Description = txtDescription.Text.Trim();

            return mDLoanCategoryEntity;
        }

        private void SaveMDLoanCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDLoanCategoryEntity mDLoanCategoryEntity = BuildMDLoanCategoryEntity();

                    Int64 result = -1;

                    if (mDLoanCategoryEntity.IsNew)
                    {
                        result = FCCMDLoanCategory.GetFacadeCreate().Add(mDLoanCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDLoanCategoryEntity.FLD_NAME_LoanCategoryID, mDLoanCategoryEntity.LoanCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDLoanCategory.GetFacadeCreate().Update(mDLoanCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LoanCategoryID = 0;
                        _MDLoanCategoryEntity = new MDLoanCategoryEntity();
                        PrepareInitialView();
                        BindMDLoanCategoryList();

                        if (mDLoanCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Loan Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Loan Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDLoanCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Loan Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Loan Category Information.", false);
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

        protected void lvMDLoanCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LoanCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out LoanCategoryID);

            if (LoanCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LoanCategoryID = LoanCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDLoanCategoryEntity.FLD_NAME_LoanCategoryID, LoanCategoryID.ToString(), SQLMatchType.Equal);

                        MDLoanCategoryEntity mDLoanCategoryEntity = new MDLoanCategoryEntity();


                        result = FCCMDLoanCategory.GetFacadeCreate().Delete(mDLoanCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LoanCategoryID = 0;
                            _MDLoanCategoryEntity = new MDLoanCategoryEntity();
                            PrepareInitialView();
                            BindMDLoanCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Loan Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Loan Category.", true);
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

        protected void odsMDLoanCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDLoanCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LoanCategoryID = 0;
            _MDLoanCategoryEntity = new MDLoanCategoryEntity();
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
