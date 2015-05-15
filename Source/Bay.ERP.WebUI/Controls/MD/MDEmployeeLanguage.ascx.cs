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
    public partial class MDEmployeeLanguageControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeLanguageID
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

        public MDEmployeeLanguageEntity _MDEmployeeLanguageEntity
        {
            get
            {
                MDEmployeeLanguageEntity entity = new MDEmployeeLanguageEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeLanguageEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeLanguageEntity CurrentMDEmployeeLanguageEntity
        {
            get
            {
                if (_EmployeeLanguageID > 0)
                {
                    if (_MDEmployeeLanguageEntity.EmployeeLanguageID != _EmployeeLanguageID)
                    {
                        _MDEmployeeLanguageEntity = FCCMDEmployeeLanguage.GetFacadeCreate().GetByID(_EmployeeLanguageID);
                    }
                }

                return _MDEmployeeLanguageEntity;
            }
            set
            {
                _MDEmployeeLanguageEntity = value;
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
            MDEmployeeLanguageEntity mDEmployeeLanguageEntity = CurrentMDEmployeeLanguageEntity;


            if (!mDEmployeeLanguageEntity.IsNew)
            {
                txtName.Text = mDEmployeeLanguageEntity.Name.ToString();
                chkIsRemoved.Checked = mDEmployeeLanguageEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeLanguageList();
        }

        private void BindMDEmployeeLanguageList()
        {
            lvMDEmployeeLanguage.DataBind();
        }

        private MDEmployeeLanguageEntity BuildMDEmployeeLanguageEntity()
        {
            MDEmployeeLanguageEntity mDEmployeeLanguageEntity = CurrentMDEmployeeLanguageEntity;

            mDEmployeeLanguageEntity.Name = txtName.Text.Trim();
            mDEmployeeLanguageEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeLanguageEntity;
        }

        private void SaveMDEmployeeLanguageEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeLanguageEntity mDEmployeeLanguageEntity = BuildMDEmployeeLanguageEntity();

                    Int64 result = -1;

                    if (mDEmployeeLanguageEntity.IsNew)
                    {
                        result = FCCMDEmployeeLanguage.GetFacadeCreate().Add(mDEmployeeLanguageEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeLanguageEntity.FLD_NAME_EmployeeLanguageID, mDEmployeeLanguageEntity.EmployeeLanguageID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeLanguage.GetFacadeCreate().Update(mDEmployeeLanguageEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeLanguageID = 0;
                        _MDEmployeeLanguageEntity = new MDEmployeeLanguageEntity();
                        PrepareInitialView();
                        BindMDEmployeeLanguageList();

                        if (mDEmployeeLanguageEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Language Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Language Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeLanguageEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Language Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Language Information.", false);
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

        protected void lvMDEmployeeLanguage_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeLanguageID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeLanguageID);

            if (EmployeeLanguageID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeLanguageID = EmployeeLanguageID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeLanguageEntity.FLD_NAME_EmployeeLanguageID, EmployeeLanguageID.ToString(), SQLMatchType.Equal);

                        MDEmployeeLanguageEntity mDEmployeeLanguageEntity = new MDEmployeeLanguageEntity();


                        result = FCCMDEmployeeLanguage.GetFacadeCreate().Delete(mDEmployeeLanguageEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeLanguageID = 0;
                            _MDEmployeeLanguageEntity = new MDEmployeeLanguageEntity();
                            PrepareInitialView();
                            BindMDEmployeeLanguageList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Language has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Language.", true);
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

        protected void odsMDEmployeeLanguage_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeLanguageEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeLanguageID = 0;
            _MDEmployeeLanguageEntity = new MDEmployeeLanguageEntity();
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
