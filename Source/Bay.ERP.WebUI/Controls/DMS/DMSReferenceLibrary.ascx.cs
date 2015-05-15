// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    public partial class DMSReferenceLibraryControl : BaseControl
    {       
        #region Properties

        public Int64 _ReferenceLibraryID
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

        public DMSReferenceLibraryEntity _DMSReferenceLibraryEntity
        {
            get
            {
                DMSReferenceLibraryEntity entity = new DMSReferenceLibraryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (DMSReferenceLibraryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private DMSReferenceLibraryEntity CurrentDMSReferenceLibraryEntity
        {
            get
            {
                if (_ReferenceLibraryID > 0)
                {
                    if (_DMSReferenceLibraryEntity.ReferenceLibraryID != _ReferenceLibraryID)
                    {
                        _DMSReferenceLibraryEntity = FCCDMSReferenceLibrary.GetFacadeCreate().GetByID(_ReferenceLibraryID);
                    }
                }

                return _DMSReferenceLibraryEntity;
            }
            set
            {
                _DMSReferenceLibraryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDReferenceLibraryCategory(ddlReferenceLibraryCategoryID, false);
            MiscUtil.PopulateHREmployee(ddlReferencedByEmployeeID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtUrl.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            DMSReferenceLibraryEntity dMSReferenceLibraryEntity = CurrentDMSReferenceLibraryEntity;


            if (!dMSReferenceLibraryEntity.IsNew)
            {
                if (ddlReferenceLibraryCategoryID.Items.Count > 0 && dMSReferenceLibraryEntity.ReferenceLibraryCategoryID != null)
                {
                    ddlReferenceLibraryCategoryID.SelectedValue = dMSReferenceLibraryEntity.ReferenceLibraryCategoryID.ToString();
                }

                txtUrl.Text = dMSReferenceLibraryEntity.Url.ToString();
                txtDescription.Text = dMSReferenceLibraryEntity.Description.ToString();

                if (ddlReferencedByEmployeeID.Items.Count > 0 && dMSReferenceLibraryEntity.ReferencedByEmployeeID != null)
                {
                    ddlReferencedByEmployeeID.SelectedValue = dMSReferenceLibraryEntity.ReferencedByEmployeeID.ToString();
                }
               
                txtRemarks.Text = dMSReferenceLibraryEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindDMSReferenceLibraryList();
        }

        private void BindDMSReferenceLibraryList()
        {
            lvDMSReferenceLibrary.DataBind();
        }

        private DMSReferenceLibraryEntity BuildDMSReferenceLibraryEntity()
        {
            DMSReferenceLibraryEntity dMSReferenceLibraryEntity = CurrentDMSReferenceLibraryEntity;

            if (ddlReferenceLibraryCategoryID.Items.Count > 0)
            {
                if (ddlReferenceLibraryCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    dMSReferenceLibraryEntity.ReferenceLibraryCategoryID = Int64.Parse(ddlReferenceLibraryCategoryID.SelectedValue);
                }
            }

            dMSReferenceLibraryEntity.Url = txtUrl.Text.Trim();
            dMSReferenceLibraryEntity.Description = txtDescription.Text.Trim();

            #region FileUpload Info

            String HoverImageUrlpath;

            if (fuImageUrl.HasFile == true && dMSReferenceLibraryEntity.FileName.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(dMSReferenceLibraryEntity.FileName)))
                {
                    File.Delete(Server.MapPath(dMSReferenceLibraryEntity.FileName));
                }
                HoverImageUrlpath = FileUploadConstants.DMS.DMS_REFERENCE+ Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                dMSReferenceLibraryEntity.FileName = HoverImageUrlpath;
            }

            if (dMSReferenceLibraryEntity.FileName.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                dMSReferenceLibraryEntity.FileName = dMSReferenceLibraryEntity.FileName;
            }

            if (fuImageUrl.HasFile == false && dMSReferenceLibraryEntity.FileName.IsNullOrEmpty())
            {
                dMSReferenceLibraryEntity.FileName = null;
            }

            if (fuImageUrl.HasFile == true && dMSReferenceLibraryEntity.FileName.IsNullOrEmpty())
            {
                HoverImageUrlpath = FileUploadConstants.DMS.DMS_REFERENCE + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                dMSReferenceLibraryEntity.FileName = HoverImageUrlpath;
            }

            #endregion

            dMSReferenceLibraryEntity.Extension = Path.GetExtension(fuImageUrl.FileName);
            dMSReferenceLibraryEntity.Path = FileUploadConstants.DMS.DMS_REFERENCE + dMSReferenceLibraryEntity.CurrentFileName;
            dMSReferenceLibraryEntity.OriginalFileName = Path.GetFileName(fuImageUrl.FileName);
            dMSReferenceLibraryEntity.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(fuImageUrl.FileName);
            dMSReferenceLibraryEntity.FileType = "";

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                dMSReferenceLibraryEntity.CreatedByEmployeeID = lstEmployee[0].EmployeeID;
            }


            if (ddlReferencedByEmployeeID.Items.Count > 0)
            {
                if (ddlReferencedByEmployeeID.SelectedValue == "0")
                {
                    dMSReferenceLibraryEntity.ReferencedByEmployeeID = null;
                }
                else
                {
                    dMSReferenceLibraryEntity.ReferencedByEmployeeID = Int64.Parse(ddlReferencedByEmployeeID.SelectedValue);
                }
            }
            dMSReferenceLibraryEntity.Remarks = txtRemarks.Text.Trim();

            return dMSReferenceLibraryEntity;
        }

        private void SaveDMSReferenceLibraryEntity()
        {
            if (IsValid)
            {
                try
                {
                    DMSReferenceLibraryEntity dMSReferenceLibraryEntity = BuildDMSReferenceLibraryEntity();

                    Int64 result = -1;

                    if (dMSReferenceLibraryEntity.IsNew)
                    {
                        result = FCCDMSReferenceLibrary.GetFacadeCreate().Add(dMSReferenceLibraryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSReferenceLibraryEntity.FLD_NAME_ReferenceLibraryID, dMSReferenceLibraryEntity.ReferenceLibraryID.ToString(), SQLMatchType.Equal);
                        result = FCCDMSReferenceLibrary.GetFacadeCreate().Update(dMSReferenceLibraryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ReferenceLibraryID = 0;
                        _DMSReferenceLibraryEntity = new DMSReferenceLibraryEntity();
                        PrepareInitialView();
                        BindDMSReferenceLibraryList();

                        if (dMSReferenceLibraryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Reference Library Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Reference Library Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (dMSReferenceLibraryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Reference Library Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Reference Library Information.", false);
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

        protected void lvDMSReferenceLibrary_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ReferenceLibraryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ReferenceLibraryID);

            if (ReferenceLibraryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ReferenceLibraryID = ReferenceLibraryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSReferenceLibraryEntity.FLD_NAME_ReferenceLibraryID, ReferenceLibraryID.ToString(), SQLMatchType.Equal);

                        DMSReferenceLibraryEntity dMSReferenceLibraryEntity = new DMSReferenceLibraryEntity();


                        result = FCCDMSReferenceLibrary.GetFacadeCreate().Delete(dMSReferenceLibraryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ReferenceLibraryID = 0;
                            _DMSReferenceLibraryEntity = new DMSReferenceLibraryEntity();
                            PrepareInitialView();
                            BindDMSReferenceLibraryList();

                            MiscUtil.ShowMessage(lblMessage, "D MSReference Library has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete D MSReference Library.", true);
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

        protected void odsDMSReferenceLibrary_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveDMSReferenceLibraryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ReferenceLibraryID = 0;
            _DMSReferenceLibraryEntity = new DMSReferenceLibraryEntity();
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
