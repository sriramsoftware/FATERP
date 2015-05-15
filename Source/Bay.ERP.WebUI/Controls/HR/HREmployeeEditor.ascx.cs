// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
using AjaxControlToolkit;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeEditorControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _MemberID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["CurrentMemberID"] != null)
                {
                    Int64.TryParse(ViewState["CurrentMemberID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["CurrentMemberID"] = value;
            }
        }

        public HRMemberEntity _HRMemberEntity
        {
            get
            {
                HRMemberEntity entity = new HRMemberEntity();

                if (ViewState["CurrentMemberEntity"] != null)
                {
                    entity = (HRMemberEntity)ViewState["CurrentMemberEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentMemberEntity"] = value;
            }
        }

        private HRMemberEntity CurrentHRMemberEntity
        {
            get
            {
                if (CurrentHREmployeeEntity.MemberID > 0)
                {
                    _HRMemberEntity = FCCHRMember.GetFacadeCreate().GetByID(CurrentHREmployeeEntity.MemberID);
                }

                return _HRMemberEntity;
            }
            set
            {
                _HRMemberEntity = value;
            }
        }


        public Int64 _EmployeeID
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

        public HREmployeeEntity _HREmployeeEntity
        {
            get
            {
                HREmployeeEntity entity = new HREmployeeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeEntity CurrentHREmployeeEntity
        {
            get
            {
                if (OverviewEmployeeID > 0)
                {   
                        _HREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(OverviewEmployeeID);
                }

                return _HREmployeeEntity;
            }
            set
            {
                _HREmployeeEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDesignation(ddlDesignationID, true);
            MiscUtil.PopulateMDEmployeeJobType(ddlEmployeeJobTypeID, false);
            MiscUtil.PopulateMDBloodGroup(ddlBloodGroupID, true);
        }

        private void PrepareValidator()
        {
            revPrimaryEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtPrimaryEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revPrimaryEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revSecondaryEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtSecondaryEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revSecondaryEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;

            txtEmployeeCode.Text = String.Empty;
            txtConfirmDate.Text = String.Empty;
            txtJoinDate.Text = String.Empty;
            txtDOB.Text = String.Empty;
            txtPrimaryEmail.Text = String.Empty;
            txtSecondaryEmail.Text = String.Empty;
            txtInitials.Text = String.Empty;
            //btnSubmit.Enabled = true;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            HREmployeeEntity hREmployeeEntity = CurrentHREmployeeEntity;

            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            if (!hRMemberEntity.IsNew)
            {
                txtFirstName.Text = hRMemberEntity.FirstName.ToString();
                txtMiddleName.Text = hRMemberEntity.MiddleName.ToString();
                txtLastName.Text = hRMemberEntity.LastName.ToString();
            }

            if (!hREmployeeEntity.IsNew)
            {
                txtEmployeeCode.Text = hREmployeeEntity.EmployeeCode.ToString();

                if (ddlEmployeeJobTypeID.Items.Count > 0 && hREmployeeEntity.EmployeeJobTypeID != null)
                {
                    ddlEmployeeJobTypeID.SelectedValue = hREmployeeEntity.EmployeeJobTypeID.ToString();
                }

                txtConfirmDate.Text = hREmployeeEntity.ConfirmDate.ToStringDefault();
                txtJoinDate.Text = hREmployeeEntity.JoinDate.ToStringDefault();
                txtDOB.Text = hREmployeeEntity.DOB.ToStringDefault();
                if (ddlBloodGroupID.Items.Count > 0 && hREmployeeEntity.BloodGroupID != null)
                {
                    ddlBloodGroupID.SelectedValue = hREmployeeEntity.BloodGroupID.ToString();
                }

                txtPrimaryEmail.Text = hREmployeeEntity.PrimaryEmail.ToString();
                txtSecondaryEmail.Text = hREmployeeEntity.SecondaryEmail.ToString();
                txtInitials.Text = hREmployeeEntity.Initials.ToString();

                //btnSubmit.Enabled = true;
                btnSubmit.Text = "Update";
            }
        }

        private HRMemberEntity BuildHRMemberEntity()
        {
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            hRMemberEntity.FirstName = txtFirstName.Text.Trim();
            hRMemberEntity.MiddleName = txtMiddleName.Text.Trim();
            hRMemberEntity.LastName = txtLastName.Text.Trim();

            if (hRMemberEntity.IsNew)
            {
                hRMemberEntity.MemberTypeID = MasterDataConstants.MemberType.HR_MEMBER;
            }

            return hRMemberEntity;
        }

        private void BindMemberImageList()
        {
            lvMemberImage.DataBind();
        }

        private HREmployeeEntity BuildHREmployeeEntity()
        {
            HREmployeeEntity hREmployeeEntity = CurrentHREmployeeEntity;

            hREmployeeEntity.EmployeeCode = txtEmployeeCode.Text.Trim();

            if (ddlDesignationID.Items.Count > 0)
            {
                if (ddlDesignationID.SelectedValue == "0")
                {
                    hREmployeeEntity.DesignationID = null;
                }
                else
                {
                    hREmployeeEntity.DesignationID = Int64.Parse(ddlDesignationID.SelectedValue);
                }
            }

            hREmployeeEntity.EmployeeCode = txtEmployeeCode.Text.Trim();
            if (ddlEmployeeJobTypeID.Items.Count > 0)
            {
                if (ddlEmployeeJobTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEntity.EmployeeJobTypeID = Int64.Parse(ddlEmployeeJobTypeID.SelectedValue);
                }
            }

            if (txtConfirmDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEntity.ConfirmDate = MiscUtil.ParseToDateTime(txtConfirmDate.Text);
            }
            else
            {
                hREmployeeEntity.ConfirmDate = null;
            }

            if (txtJoinDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEntity.JoinDate = MiscUtil.ParseToDateTime(txtJoinDate.Text);
            }
            else
            {
                hREmployeeEntity.JoinDate = null;
            }

            if (txtDOB.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEntity.DOB = MiscUtil.ParseToDateTime(txtDOB.Text);
            }
            else
            {
                hREmployeeEntity.DOB = null;
            }

            if (ddlBloodGroupID.Items.Count > 0)
            {
                if (ddlBloodGroupID.SelectedValue == "0")
                {
                    hREmployeeEntity.BloodGroupID = null;
                }
                else
                {
                    hREmployeeEntity.BloodGroupID = Int64.Parse(ddlBloodGroupID.SelectedValue);
                }
            }

            hREmployeeEntity.PrimaryEmail = txtPrimaryEmail.Text.Trim();
            hREmployeeEntity.SecondaryEmail = txtSecondaryEmail.Text.Trim();
            hREmployeeEntity.Initials = txtInitials.Text.Trim();
            hREmployeeEntity.IsRemoved = false;

            return hREmployeeEntity;
        }

        private void SaveHREmployeeEntity()
        {
            if (IsValid)
            {
                try
                {
                    #region Member

                    HRMemberEntity hRMemberEntity = BuildHRMemberEntity();

                    Int64 result = -1;

                    if (hRMemberEntity.IsNew)
                    {
                        result = FCCHRMember.GetFacadeCreate().Add(hRMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, hRMemberEntity.MemberID.ToString(), SQLMatchType.Equal);
                        result = FCCHRMember.GetFacadeCreate().Update(hRMemberEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    #endregion

                    if (result > 0)
                    {
                        _MemberID = 0;
                        _HRMemberEntity = new HRMemberEntity();
                    }

                    if (result > 0)
                    {

                        HREmployeeEntity hREmployeeEntity = BuildHREmployeeEntity();

                        Int64 resultC = -1;

                        if (hREmployeeEntity.IsNew)
                        {
                            hREmployeeEntity.MemberID = result;

                            resultC = FCCHREmployee.GetFacadeCreate().Add(hREmployeeEntity, DatabaseOperationType.Add, TransactionRequired.No);


                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_EmployeeID, hREmployeeEntity.EmployeeID.ToString(), SQLMatchType.Equal);
                            resultC = FCCHREmployee.GetFacadeCreate().Update(hREmployeeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }



                        if (resultC > 0)
                        {
                            _EmployeeID = 0;
                            _HREmployeeEntity = new HREmployeeEntity();
                            PrepareEditView();

                            if (hREmployeeEntity.IsNew)
                            {
                                ResourceEntity resourceEntity = new ResourceEntity();

                                resourceEntity.ReferenceID = resultC; // means new contractor id
                                resourceEntity.ResourceCategoryID = MasterDataConstants.ResourceCategory.EMPLOYEE;

                                FCCResource.GetFacadeCreate().Add(resourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }

                            if (hREmployeeEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Employee Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Employee Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (hREmployeeEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Information.", false);
                            }
                        }
                    }
                    else
                    {
                        if (hRMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Member Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Member Information.", false);
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
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEntity();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindMemberImageList();
        }

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            IList<HREmployeePhotoEntity> lstmemberImageEntity = FCCHREmployeePhoto.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            HREmployeePhotoEntity memberImageEntity = new HREmployeePhotoEntity();

            Boolean isSaveFlag = true;
            
            if (lstmemberImageEntity != null && lstmemberImageEntity.Count > 0)
            {
                isSaveFlag = false;
            }

            memberImageEntity.EmployeeID = this.OverviewEmployeeID;
            memberImageEntity.OriginalFileName = Path.GetFileName(e.FileName);
            memberImageEntity.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            memberImageEntity.FileType = "";
            memberImageEntity.Extension = Path.GetExtension(e.FileName);
            memberImageEntity.Path = FileUploadConstants.HR.Employee + memberImageEntity.CurrentFileName;
            memberImageEntity.Remarks = String.Empty;
            memberImageEntity.IsCurrent = true;

            Int64 result = -1;

            if (isSaveFlag)
            {
                result = FCCHREmployeePhoto.GetFacadeCreate().Add(memberImageEntity, DatabaseOperationType.Add, TransactionRequired.No);
            }
            else
            {
                result = FCCHREmployeePhoto.GetFacadeCreate().Update(memberImageEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
            }

            if (result > 0)
            {
                MiscUtil.ShowMessage(lblMessage, "Image Uploaded Successfully.", false);
                BindMemberImageList();
            }

            // file upload

            afuFiles.SaveAs(Server.MapPath(memberImageEntity.Path));

            //LoadFileListGried
            BindMemberImageList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion

        #region ObjectDataSource Event

        protected void odsMemberImage_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
