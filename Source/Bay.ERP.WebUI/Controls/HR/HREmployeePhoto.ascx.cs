// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeePhotoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeePhotoID
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

        public HREmployeePhotoEntity _HREmployeePhotoEntity
        {
            get
            {
                HREmployeePhotoEntity entity = new HREmployeePhotoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeePhotoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeePhotoEntity CurrentHREmployeePhotoEntity
        {
            get
            {
                if (_EmployeePhotoID > 0)
                {
                    if (_HREmployeePhotoEntity.EmployeePhotoID != _EmployeePhotoID)
                    {
                        _HREmployeePhotoEntity = FCCHREmployeePhoto.GetFacadeCreate().GetByID(_EmployeePhotoID);
                    }
                }

                return _HREmployeePhotoEntity;
            }
            set
            {
                _HREmployeePhotoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCurrentFileName.Text = String.Empty;
            txtExtension.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtPath.Text = String.Empty;
            txtOriginalFileName.Text = String.Empty;
            txtFileType.Text = String.Empty;
            chkIsCurrent.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeePhotoEntity hREmployeePhotoEntity = CurrentHREmployeePhotoEntity;


            if (!hREmployeePhotoEntity.IsNew)
            {
                if (ddlEmployeeID.Items.Count > 0 && hREmployeePhotoEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeePhotoEntity.EmployeeID.ToString();
                }

                txtCurrentFileName.Text = hREmployeePhotoEntity.CurrentFileName.ToString();
                txtExtension.Text = hREmployeePhotoEntity.Extension.ToString();
                txtRemarks.Text = hREmployeePhotoEntity.Remarks.ToString();
                txtPath.Text = hREmployeePhotoEntity.Path.ToString();
                txtOriginalFileName.Text = hREmployeePhotoEntity.OriginalFileName.ToString();
                txtFileType.Text = hREmployeePhotoEntity.FileType.ToString();
                chkIsCurrent.Checked = hREmployeePhotoEntity.IsCurrent;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeePhotoList();
        }

        private void BindHREmployeePhotoList()
        {
            lvHREmployeePhoto.DataBind();
        }

        private HREmployeePhotoEntity BuildHREmployeePhotoEntity()
        {
            HREmployeePhotoEntity hREmployeePhotoEntity = CurrentHREmployeePhotoEntity;

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeePhotoEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            hREmployeePhotoEntity.CurrentFileName = txtCurrentFileName.Text.Trim();
            hREmployeePhotoEntity.Extension = txtExtension.Text.Trim();
            hREmployeePhotoEntity.Remarks = txtRemarks.Text.Trim();
            hREmployeePhotoEntity.Path = txtPath.Text.Trim();
            hREmployeePhotoEntity.OriginalFileName = txtOriginalFileName.Text.Trim();
            hREmployeePhotoEntity.FileType = txtFileType.Text.Trim();
            hREmployeePhotoEntity.IsCurrent = chkIsCurrent.Checked;


            return hREmployeePhotoEntity;
        }

        private void SaveHREmployeePhotoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeePhotoEntity hREmployeePhotoEntity = BuildHREmployeePhotoEntity();

                    Int64 result = -1;

                    if (hREmployeePhotoEntity.IsNew)
                    {
                        result = FCCHREmployeePhoto.GetFacadeCreate().Add(hREmployeePhotoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeePhotoID, hREmployeePhotoEntity.EmployeePhotoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeePhoto.GetFacadeCreate().Update(hREmployeePhotoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeePhotoID = 0;
                        _HREmployeePhotoEntity = new HREmployeePhotoEntity();
                        PrepareInitialView();
                        BindHREmployeePhotoList();

                        if (hREmployeePhotoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Photo Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Photo Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeePhotoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Photo Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Photo Information.", false);
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

        protected void lvHREmployeePhoto_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeePhotoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeePhotoID);

            if (EmployeePhotoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeePhotoID = EmployeePhotoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeePhotoID, EmployeePhotoID.ToString(), SQLMatchType.Equal);

                        HREmployeePhotoEntity hREmployeePhotoEntity = new HREmployeePhotoEntity();


                        result = FCCHREmployeePhoto.GetFacadeCreate().Delete(hREmployeePhotoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeePhotoID = 0;
                            _HREmployeePhotoEntity = new HREmployeePhotoEntity();
                            PrepareInitialView();
                            BindHREmployeePhotoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Photo has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Photo.", true);
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

        protected void odsHREmployeePhoto_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeePhotoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeePhotoID = 0;
            _HREmployeePhotoEntity = new HREmployeePhotoEntity();
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
