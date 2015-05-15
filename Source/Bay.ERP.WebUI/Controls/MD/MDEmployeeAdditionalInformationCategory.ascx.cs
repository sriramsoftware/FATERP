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
    public partial class MDEmployeeAdditionalInformationCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeAdditionalInformationCategoryID
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

        public MDEmployeeAdditionalInformationCategoryEntity _MDEmployeeAdditionalInformationCategoryEntity
        {
            get
            {
                MDEmployeeAdditionalInformationCategoryEntity entity = new MDEmployeeAdditionalInformationCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeAdditionalInformationCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeAdditionalInformationCategoryEntity CurrentMDEmployeeAdditionalInformationCategoryEntity
        {
            get
            {
                if (_EmployeeAdditionalInformationCategoryID > 0)
                {
                    if (_MDEmployeeAdditionalInformationCategoryEntity.EmployeeAdditionalInformationCategoryID != _EmployeeAdditionalInformationCategoryID)
                    {
                        _MDEmployeeAdditionalInformationCategoryEntity = FCCMDEmployeeAdditionalInformationCategory.GetFacadeCreate().GetByID(_EmployeeAdditionalInformationCategoryID);
                    }
                }

                return _MDEmployeeAdditionalInformationCategoryEntity;
            }
            set
            {
                _MDEmployeeAdditionalInformationCategoryEntity = value;
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
            MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity = CurrentMDEmployeeAdditionalInformationCategoryEntity;


            if (!mDEmployeeAdditionalInformationCategoryEntity.IsNew)
            {
                txtName.Text = mDEmployeeAdditionalInformationCategoryEntity.Name.ToString();
                txtDescription.Text = mDEmployeeAdditionalInformationCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDEmployeeAdditionalInformationCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeAdditionalInformationCategoryList();
        }

        private void BindMDEmployeeAdditionalInformationCategoryList()
        {
            lvMDEmployeeAdditionalInformationCategory.DataBind();
        }

        private MDEmployeeAdditionalInformationCategoryEntity BuildMDEmployeeAdditionalInformationCategoryEntity()
        {
            MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity = CurrentMDEmployeeAdditionalInformationCategoryEntity;

            mDEmployeeAdditionalInformationCategoryEntity.Name = txtName.Text.Trim();
            mDEmployeeAdditionalInformationCategoryEntity.Description = txtDescription.Text.Trim();
            mDEmployeeAdditionalInformationCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeAdditionalInformationCategoryEntity;
        }

        private void SaveMDEmployeeAdditionalInformationCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity = BuildMDEmployeeAdditionalInformationCategoryEntity();

                    Int64 result = -1;

                    if (mDEmployeeAdditionalInformationCategoryEntity.IsNew)
                    {
                        result = FCCMDEmployeeAdditionalInformationCategory.GetFacadeCreate().Add(mDEmployeeAdditionalInformationCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeAdditionalInformationCategoryEntity.FLD_NAME_EmployeeAdditionalInformationCategoryID, mDEmployeeAdditionalInformationCategoryEntity.EmployeeAdditionalInformationCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeAdditionalInformationCategory.GetFacadeCreate().Update(mDEmployeeAdditionalInformationCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeAdditionalInformationCategoryID = 0;
                        _MDEmployeeAdditionalInformationCategoryEntity = new MDEmployeeAdditionalInformationCategoryEntity();
                        PrepareInitialView();
                        BindMDEmployeeAdditionalInformationCategoryList();

                        if (mDEmployeeAdditionalInformationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Additional Information Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Additional Information Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeAdditionalInformationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Additional Information Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Additional Information Category Information.", false);
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

        protected void lvMDEmployeeAdditionalInformationCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeAdditionalInformationCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeAdditionalInformationCategoryID);

            if (EmployeeAdditionalInformationCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeAdditionalInformationCategoryID = EmployeeAdditionalInformationCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeAdditionalInformationCategoryEntity.FLD_NAME_EmployeeAdditionalInformationCategoryID, EmployeeAdditionalInformationCategoryID.ToString(), SQLMatchType.Equal);

                        MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity = new MDEmployeeAdditionalInformationCategoryEntity();


                        result = FCCMDEmployeeAdditionalInformationCategory.GetFacadeCreate().Delete(mDEmployeeAdditionalInformationCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeAdditionalInformationCategoryID = 0;
                            _MDEmployeeAdditionalInformationCategoryEntity = new MDEmployeeAdditionalInformationCategoryEntity();
                            PrepareInitialView();
                            BindMDEmployeeAdditionalInformationCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Additional Information Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Additional Information Category.", true);
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

        protected void odsMDEmployeeAdditionalInformationCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeAdditionalInformationCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeAdditionalInformationCategoryID = 0;
            _MDEmployeeAdditionalInformationCategoryEntity = new MDEmployeeAdditionalInformationCategoryEntity();
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
