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
    public partial class DMSFileTrackingControl : BaseControl
    {       
        #region Properties

        public Int64 _FileTrackingID
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

        public DMSFileTrackingEntity _DMSFileTrackingEntity
        {
            get
            {
                DMSFileTrackingEntity entity = new DMSFileTrackingEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (DMSFileTrackingEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private DMSFileTrackingEntity CurrentDMSFileTrackingEntity
        {
            get
            {
                if (_FileTrackingID > 0)
                {
                    if (_DMSFileTrackingEntity.FileTrackingID != _FileTrackingID)
                    {
                        _DMSFileTrackingEntity = FCCDMSFileTracking.GetFacadeCreate().GetByID(_FileTrackingID);
                    }
                }

                return _DMSFileTrackingEntity;
            }
            set
            {
                _DMSFileTrackingEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFileNo.Text = String.Empty;
            txtFileName.Text = String.Empty;
            txtCreatedDateTime.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtFileParmanentPlace.Text = String.Empty;
            txtFileCurrentPlace.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            DMSFileTrackingEntity dMSFileTrackingEntity = CurrentDMSFileTrackingEntity;


            if (!dMSFileTrackingEntity.IsNew)
            {
                txtFileNo.Text = dMSFileTrackingEntity.FileNo.ToString();
                txtFileName.Text = dMSFileTrackingEntity.FileName.ToString();
                if (ddlDepartmentID.Items.Count > 0 && dMSFileTrackingEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = dMSFileTrackingEntity.DepartmentID.ToString();
                }

                txtCreatedDateTime.Text = dMSFileTrackingEntity.CreatedDateTime.ToStringDefault();
                txtFileParmanentPlace.Text = dMSFileTrackingEntity.FileParmanentPlace.ToString();
                txtFileCurrentPlace.Text = dMSFileTrackingEntity.FileCurrentPlace.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindDMSFileTrackingList();
        }

        private void BindDMSFileTrackingList()
        {
            lvDMSFileTracking.DataBind();
        }

        private DMSFileTrackingEntity BuildDMSFileTrackingEntity()
        {
            DMSFileTrackingEntity dMSFileTrackingEntity = CurrentDMSFileTrackingEntity;

            dMSFileTrackingEntity.FileNo = txtFileNo.Text.Trim();
            dMSFileTrackingEntity.FileName = txtFileName.Text.Trim();
            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    dMSFileTrackingEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                dMSFileTrackingEntity.CreatedByEmployeeID = lstEmployee[0].EmployeeID;
            }

            if (txtCreatedDateTime.Text.Trim().IsNotNullOrEmpty())
            {
                dMSFileTrackingEntity.CreatedDateTime = MiscUtil.ParseToDateTime(txtCreatedDateTime.Text);
            }

            dMSFileTrackingEntity.FileParmanentPlace = txtFileParmanentPlace.Text.Trim();
            dMSFileTrackingEntity.FileCurrentPlace = txtFileCurrentPlace.Text.Trim();

            #region File Upload

            String HoverImageUrlpath;

            if (fuImageUrl.HasFile == true && dMSFileTrackingEntity.SoftFileName.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(dMSFileTrackingEntity.SoftFileName)))
                {
                    File.Delete(Server.MapPath(dMSFileTrackingEntity.SoftFileName));
                }
                HoverImageUrlpath = FileUploadConstants.DMS.FILE + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                dMSFileTrackingEntity.SoftFileName = HoverImageUrlpath;
            }

            if (dMSFileTrackingEntity.SoftFileName.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                dMSFileTrackingEntity.SoftFileName = dMSFileTrackingEntity.SoftFileName;
            }

            if (fuImageUrl.HasFile == false && dMSFileTrackingEntity.SoftFileName.IsNullOrEmpty())
            {
                dMSFileTrackingEntity.SoftFileName = null;
            }

            if (fuImageUrl.HasFile == true && dMSFileTrackingEntity.SoftFileName.IsNullOrEmpty())
            {
                HoverImageUrlpath = FileUploadConstants.DMS.FILE + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                dMSFileTrackingEntity.SoftFileName = HoverImageUrlpath;
            }

            #endregion

            dMSFileTrackingEntity.Extension = Path.GetExtension(fuImageUrl.FileName);

            if (dMSFileTrackingEntity.CurrentFileName != null)
            {
                dMSFileTrackingEntity.Path = FileUploadConstants.DMS.FILE + dMSFileTrackingEntity.CurrentFileName;
            }
            else
            {
                dMSFileTrackingEntity.Path = null;
            }
            dMSFileTrackingEntity.OriginalFileName = Path.GetFileName(fuImageUrl.FileName);
            dMSFileTrackingEntity.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(fuImageUrl.FileName);
            dMSFileTrackingEntity.FileType = "";

            return dMSFileTrackingEntity;
        }

        private void SaveDMSFileTrackingEntity()
        {
            if (IsValid)
            {
                try
                {
                    DMSFileTrackingEntity dMSFileTrackingEntity = BuildDMSFileTrackingEntity();

                    Int64 result = -1;

                    if (dMSFileTrackingEntity.IsNew)
                    {
                        result = FCCDMSFileTracking.GetFacadeCreate().Add(dMSFileTrackingEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSFileTrackingEntity.FLD_NAME_FileTrackingID, dMSFileTrackingEntity.FileTrackingID.ToString(), SQLMatchType.Equal);
                        result = FCCDMSFileTracking.GetFacadeCreate().Update(dMSFileTrackingEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FileTrackingID = 0;
                        _DMSFileTrackingEntity = new DMSFileTrackingEntity();
                        PrepareInitialView();
                        BindDMSFileTrackingList();

                        if (dMSFileTrackingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "File Tracking Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "File Tracking Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (dMSFileTrackingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add File Tracking Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update File Tracking Information.", false);
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

        protected void lvDMSFileTracking_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FileTrackingID;

            Int64.TryParse(e.CommandArgument.ToString(), out FileTrackingID);

            if (FileTrackingID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FileTrackingID = FileTrackingID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSFileTrackingEntity.FLD_NAME_FileTrackingID, FileTrackingID.ToString(), SQLMatchType.Equal);

                        DMSFileTrackingEntity dMSFileTrackingEntity = new DMSFileTrackingEntity();


                        result = FCCDMSFileTracking.GetFacadeCreate().Delete(dMSFileTrackingEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FileTrackingID = 0;
                            _DMSFileTrackingEntity = new DMSFileTrackingEntity();
                            PrepareInitialView();
                            BindDMSFileTrackingList();

                            MiscUtil.ShowMessage(lblMessage, "File Tracking has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete File Tracking.", true);
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

        protected void odsDMSFileTracking_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveDMSFileTrackingEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FileTrackingID = 0;
            _DMSFileTrackingEntity = new DMSFileTrackingEntity();
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
