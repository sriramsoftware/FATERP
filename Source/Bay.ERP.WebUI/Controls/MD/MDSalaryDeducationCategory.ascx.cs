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
    public partial class MDSalaryDeducationCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _SalaryDeducationCategoryID
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

        public MDSalaryDeducationCategoryEntity _MDSalaryDeducationCategoryEntity
        {
            get
            {
                MDSalaryDeducationCategoryEntity entity = new MDSalaryDeducationCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSalaryDeducationCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSalaryDeducationCategoryEntity CurrentMDSalaryDeducationCategoryEntity
        {
            get
            {
                if (_SalaryDeducationCategoryID > 0)
                {
                    if (_MDSalaryDeducationCategoryEntity.SalaryDeducationCategoryID != _SalaryDeducationCategoryID)
                    {
                        _MDSalaryDeducationCategoryEntity = FCCMDSalaryDeducationCategory.GetFacadeCreate().GetByID(_SalaryDeducationCategoryID);
                    }
                }

                return _MDSalaryDeducationCategoryEntity;
            }
            set
            {
                _MDSalaryDeducationCategoryEntity = value;
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

            //txtSalaryDeducationCategoryID.Text = String.Empty;
            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDSalaryDeducationCategoryEntity mDSalaryDeducationCategoryEntity = CurrentMDSalaryDeducationCategoryEntity;


            if (!mDSalaryDeducationCategoryEntity.IsNew)
            {
                //txtSalaryDeducationCategoryID.Text = mDSalaryDeducationCategoryEntity.SalaryDeducationCategoryID.ToString();
                txtName.Text = mDSalaryDeducationCategoryEntity.Name.ToString();
                txtDescription.Text = mDSalaryDeducationCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDSalaryDeducationCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSalaryDeducationCategoryList();
        }

        private void BindMDSalaryDeducationCategoryList()
        {
            lvMDSalaryDeducationCategory.DataBind();
        }

        private MDSalaryDeducationCategoryEntity BuildMDSalaryDeducationCategoryEntity()
        {
            MDSalaryDeducationCategoryEntity mDSalaryDeducationCategoryEntity = CurrentMDSalaryDeducationCategoryEntity;

            //if (!txtSalaryDeducationCategoryID.Text.Trim().IsNullOrEmpty())
            //{
            //    mDSalaryDeducationCategoryEntity.SalaryDeducationCategoryID = Int64.Parse(txtSalaryDeducationCategoryID.Text.Trim());
            //}

            mDSalaryDeducationCategoryEntity.Name = txtName.Text.Trim();
            mDSalaryDeducationCategoryEntity.Description = txtDescription.Text.Trim();
            mDSalaryDeducationCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSalaryDeducationCategoryEntity;
        }

        private void SaveMDSalaryDeducationCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSalaryDeducationCategoryEntity mDSalaryDeducationCategoryEntity = BuildMDSalaryDeducationCategoryEntity();

                    Int64 result = -1;

                    if (mDSalaryDeducationCategoryEntity.IsNew)
                    {
                        result = FCCMDSalaryDeducationCategory.GetFacadeCreate().Add(mDSalaryDeducationCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryDeducationCategoryEntity.FLD_NAME_SalaryDeducationCategoryID, mDSalaryDeducationCategoryEntity.SalaryDeducationCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSalaryDeducationCategory.GetFacadeCreate().Update(mDSalaryDeducationCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalaryDeducationCategoryID = 0;
                        _MDSalaryDeducationCategoryEntity = new MDSalaryDeducationCategoryEntity();
                        PrepareInitialView();
                        BindMDSalaryDeducationCategoryList();

                        if (mDSalaryDeducationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Deducation Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Deducation Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSalaryDeducationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Deducation Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Deducation Category Information.", false);
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

        protected void lvMDSalaryDeducationCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalaryDeducationCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalaryDeducationCategoryID);

            if (SalaryDeducationCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalaryDeducationCategoryID = SalaryDeducationCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryDeducationCategoryEntity.FLD_NAME_SalaryDeducationCategoryID, SalaryDeducationCategoryID.ToString(), SQLMatchType.Equal);

                        MDSalaryDeducationCategoryEntity mDSalaryDeducationCategoryEntity = new MDSalaryDeducationCategoryEntity();


                        result = FCCMDSalaryDeducationCategory.GetFacadeCreate().Delete(mDSalaryDeducationCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalaryDeducationCategoryID = 0;
                            _MDSalaryDeducationCategoryEntity = new MDSalaryDeducationCategoryEntity();
                            PrepareInitialView();
                            BindMDSalaryDeducationCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Deducation Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Deducation Category.", true);
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

        protected void odsMDSalaryDeducationCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSalaryDeducationCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalaryDeducationCategoryID = 0;
            _MDSalaryDeducationCategoryEntity = new MDSalaryDeducationCategoryEntity();
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
