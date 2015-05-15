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
    public partial class MDDrivingLicenseCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _DrivingLicenseCategoryID
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

        public MDDrivingLicenseCategoryEntity _MDDrivingLicenseCategoryEntity
        {
            get
            {
                MDDrivingLicenseCategoryEntity entity = new MDDrivingLicenseCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDrivingLicenseCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDrivingLicenseCategoryEntity CurrentMDDrivingLicenseCategoryEntity
        {
            get
            {
                if (_DrivingLicenseCategoryID > 0)
                {
                    if (_MDDrivingLicenseCategoryEntity.DrivingLicenseCategoryID != _DrivingLicenseCategoryID)
                    {
                        _MDDrivingLicenseCategoryEntity = FCCMDDrivingLicenseCategory.GetFacadeCreate().GetByID(_DrivingLicenseCategoryID);
                    }
                }

                return _MDDrivingLicenseCategoryEntity;
            }
            set
            {
                _MDDrivingLicenseCategoryEntity = value;
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
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity = CurrentMDDrivingLicenseCategoryEntity;


            if (!mDDrivingLicenseCategoryEntity.IsNew)
            {
                txtName.Text = mDDrivingLicenseCategoryEntity.Name.ToString();
                txtRemarks.Text = mDDrivingLicenseCategoryEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDDrivingLicenseCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDrivingLicenseCategoryList();
        }

        private void BindMDDrivingLicenseCategoryList()
        {
            lvMDDrivingLicenseCategory.DataBind();
        }

        private MDDrivingLicenseCategoryEntity BuildMDDrivingLicenseCategoryEntity()
        {
            MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity = CurrentMDDrivingLicenseCategoryEntity;

            mDDrivingLicenseCategoryEntity.Name = txtName.Text.Trim();
            mDDrivingLicenseCategoryEntity.Remarks = txtRemarks.Text.Trim();
            mDDrivingLicenseCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDrivingLicenseCategoryEntity;
        }

        private void SaveMDDrivingLicenseCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity = BuildMDDrivingLicenseCategoryEntity();

                    Int64 result = -1;

                    if (mDDrivingLicenseCategoryEntity.IsNew)
                    {
                        result = FCCMDDrivingLicenseCategory.GetFacadeCreate().Add(mDDrivingLicenseCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDrivingLicenseCategoryEntity.FLD_NAME_DrivingLicenseCategoryID, mDDrivingLicenseCategoryEntity.DrivingLicenseCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDrivingLicenseCategory.GetFacadeCreate().Update(mDDrivingLicenseCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DrivingLicenseCategoryID = 0;
                        _MDDrivingLicenseCategoryEntity = new MDDrivingLicenseCategoryEntity();
                        PrepareInitialView();
                        BindMDDrivingLicenseCategoryList();

                        if (mDDrivingLicenseCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Driving License Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Driving License Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDrivingLicenseCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Driving License Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Driving License Category Information.", false);
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

        protected void lvMDDrivingLicenseCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DrivingLicenseCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out DrivingLicenseCategoryID);

            if (DrivingLicenseCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DrivingLicenseCategoryID = DrivingLicenseCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDrivingLicenseCategoryEntity.FLD_NAME_DrivingLicenseCategoryID, DrivingLicenseCategoryID.ToString(), SQLMatchType.Equal);

                        MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity = new MDDrivingLicenseCategoryEntity();


                        result = FCCMDDrivingLicenseCategory.GetFacadeCreate().Delete(mDDrivingLicenseCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DrivingLicenseCategoryID = 0;
                            _MDDrivingLicenseCategoryEntity = new MDDrivingLicenseCategoryEntity();
                            PrepareInitialView();
                            BindMDDrivingLicenseCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Driving License Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Driving License Category.", true);
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

        protected void odsMDDrivingLicenseCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDrivingLicenseCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DrivingLicenseCategoryID = 0;
            _MDDrivingLicenseCategoryEntity = new MDDrivingLicenseCategoryEntity();
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
