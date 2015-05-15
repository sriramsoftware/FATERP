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
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeDocumentControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeDocumentID
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

        public HREmployeeDocumentEntity _HREmployeeDocumentEntity
        {
            get
            {
                HREmployeeDocumentEntity entity = new HREmployeeDocumentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeDocumentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeDocumentEntity CurrentHREmployeeDocumentEntity
        {
            get
            {
                if (_EmployeeDocumentID > 0)
                {
                    if (_HREmployeeDocumentEntity.EmployeeDocumentID != _EmployeeDocumentID)
                    {
                        _HREmployeeDocumentEntity = FCCHREmployeeDocument.GetFacadeCreate().GetByID(_EmployeeDocumentID);
                    }
                }

                return _HREmployeeDocumentEntity;
            }
            set
            {
                _HREmployeeDocumentEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDocumentCategory(ddlDocumentCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            //txtExtension.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            //txtPath.Text = String.Empty;
            //txtOriginalFileName.Text = String.Empty;
            //txtCurrentFileName.Text = String.Empty;
            //txtFileType.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeDocumentEntity hREmployeeDocumentEntity = CurrentHREmployeeDocumentEntity;


            if (!hREmployeeDocumentEntity.IsNew)
            {
               
                if (ddlDocumentCategoryID.Items.Count > 0 && hREmployeeDocumentEntity.DocumentCategoryID != null)
                {
                    ddlDocumentCategoryID.SelectedValue = hREmployeeDocumentEntity.DocumentCategoryID.ToString();
                }

                //txtExtension.Text = hREmployeeDocumentEntity.Extension.ToString();
                txtRemarks.Text = hREmployeeDocumentEntity.Remarks.ToString();
                //txtPath.Text = hREmployeeDocumentEntity.Path.ToString();
                //txtOriginalFileName.Text = hREmployeeDocumentEntity.OriginalFileName.ToString();
                //txtCurrentFileName.Text = hREmployeeDocumentEntity.CurrentFileName.ToString();
                //txtFileType.Text = hREmployeeDocumentEntity.FileType.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeDocumentList();
        }

        private void BindHREmployeeDocumentList()
        {
            lvHREmployeeDocument.DataBind();
        }

        private HREmployeeDocumentEntity BuildHREmployeeDocumentEntity()
        {
            HREmployeeDocumentEntity hREmployeeDocumentEntity = CurrentHREmployeeDocumentEntity;


            hREmployeeDocumentEntity.EmployeeID = OverviewEmployeeID;

            if (ddlDocumentCategoryID.Items.Count > 0)
            {
                if (ddlDocumentCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeDocumentEntity.DocumentCategoryID = Int64.Parse(ddlDocumentCategoryID.SelectedValue);
                }
            }

          

            //hREmployeeDocumentEntity.Extension = txtExtension.Text.Trim();
            hREmployeeDocumentEntity.Remarks = txtRemarks.Text.Trim();
            //hREmployeeDocumentEntity.Path = txtPath.Text.Trim();
            //hREmployeeDocumentEntity.OriginalFileName = txtOriginalFileName.Text.Trim();
            //hREmployeeDocumentEntity.CurrentFileName = txtCurrentFileName.Text.Trim();
            //hREmployeeDocumentEntity.FileType = txtFileType.Text.Trim();


            #region File

            String Urlpath;

            if (fuFileUploadUrl.HasFile == true && hREmployeeDocumentEntity.Path.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(hREmployeeDocumentEntity.Path)))
                {
                    File.Delete(Server.MapPath(hREmployeeDocumentEntity.Path));
                }
                Urlpath = FileUploadConstants.HR.EmployeeDocument+ Guid.NewGuid() + fuFileUploadUrl.FileName;
                fuFileUploadUrl.SaveAs(Server.MapPath(Urlpath));
                hREmployeeDocumentEntity.Path = Urlpath;
            }

            if (hREmployeeDocumentEntity.Path.IsNotNullOrEmpty() && fuFileUploadUrl.HasFile == false)
            {
                hREmployeeDocumentEntity.Path = hREmployeeDocumentEntity.Path;
            }

            if (fuFileUploadUrl.HasFile == false && hREmployeeDocumentEntity.Path.IsNullOrEmpty())
            {
                hREmployeeDocumentEntity.Path = null;
            }

            if (fuFileUploadUrl.HasFile == true && hREmployeeDocumentEntity.Path.IsNullOrEmpty())
            {
                Urlpath = FileUploadConstants.HR.EmployeeDocument + Guid.NewGuid() + fuFileUploadUrl.FileName;
                fuFileUploadUrl.SaveAs(Server.MapPath(Urlpath));
                hREmployeeDocumentEntity.Path = Urlpath;
            }


            hREmployeeDocumentEntity.OriginalFileName = Path.GetFileName(fuFileUploadUrl.FileName);
            hREmployeeDocumentEntity.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(fuFileUploadUrl.FileName);
            hREmployeeDocumentEntity.FileType = "";
            hREmployeeDocumentEntity.Extension = Path.GetExtension(fuFileUploadUrl.FileName);
            //hREmployeeDocumentEntity.Path = FileUploadConstants.HR.EmployeeDocument + hREmployeeDocumentEntity.CurrentFileName;
            //hREmployeeDocumentEntity.Remarks = String.Empty;

            #endregion File

            return hREmployeeDocumentEntity;
        }

        private void SaveHREmployeeDocumentEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeDocumentEntity hREmployeeDocumentEntity = BuildHREmployeeDocumentEntity();

                    Int64 result = -1;

                    if (hREmployeeDocumentEntity.IsNew)
                    {
                        result = FCCHREmployeeDocument.GetFacadeCreate().Add(hREmployeeDocumentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeDocumentEntity.FLD_NAME_EmployeeDocumentID, hREmployeeDocumentEntity.EmployeeDocumentID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeDocument.GetFacadeCreate().Update(hREmployeeDocumentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeDocumentID = 0;
                        _HREmployeeDocumentEntity = new HREmployeeDocumentEntity();
                        PrepareInitialView();
                        BindHREmployeeDocumentList();

                        if (hREmployeeDocumentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Document Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Document Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeDocumentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Document Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Document Information.", false);
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

        protected void lvHREmployeeDocument_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeDocumentID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeDocumentID);

            if (EmployeeDocumentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeDocumentID = EmployeeDocumentID;

                    PrepareEditView();
                 
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeDocumentEntity.FLD_NAME_EmployeeDocumentID, EmployeeDocumentID.ToString(), SQLMatchType.Equal);

                        HREmployeeDocumentEntity hREmployeeDocumentEntity = new HREmployeeDocumentEntity();


                        result = FCCHREmployeeDocument.GetFacadeCreate().Delete(hREmployeeDocumentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeDocumentID = 0;
                            _HREmployeeDocumentEntity = new HREmployeeDocumentEntity();
                            PrepareInitialView();
                            BindHREmployeeDocumentList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Document has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Document.", true);
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

        protected void odsHREmployeeDocument_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeDocumentEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeDocumentEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeDocumentID = 0;
            _HREmployeeDocumentEntity = new HREmployeeDocumentEntity();
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
