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
using System.Linq;
using System.Text;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeControl : BaseControl
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
                if (_MemberID > 0)
                {
                    if (_HRMemberEntity.MemberID != _MemberID)
                    {
                        _HRMemberEntity = FCCHRMember.GetFacadeCreate().GetByID(_MemberID);
                    }
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
                if (_EmployeeID > 0)
                {
                    if (_HREmployeeEntity.EmployeeID != _EmployeeID)
                    {
                        _HREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(_EmployeeID);
                    }
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
            MiscUtil.PopulateMDDesignation(ddlDesignationID, false);
            MiscUtil.PopulateMDEmployeeJobType(ddlEmployeeJobTypeID, false);
            MiscUtil.PopulateMDBloodGroup(ddlBloodGroupID, true);
            MiscUtil.PopulateMDEmploymentStatus(ddlEmploymentStatusID, false);
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, false);
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
            txtSalaryLevel.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
            pnlDiscontinuedDate.Visible = false;


            #region Employee Info

            IList<HREmployeeEntity> lstHREmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            if (lstHREmployee != null && lstHREmployee.Count > 0)
            {
                lblTotalEmployee.Text = lstHREmployee.Count.ToString();

                lblActiveEmployee.Text = (from s in lstHREmployee
                                          where s.EmploymentStatusID == MasterDataConstants.MDEmploymentStatus.ACTIVE
                                          select s).Count().ToString();
            }

            else
            {
                lblTotalEmployee.Text = "0";

                lblActiveEmployee.Text = "0";
                                        
            }


            #endregion
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

                if (ddlDesignationID.Items.Count > 0 && hREmployeeEntity.DesignationID != null)
                {
                    ddlDesignationID.SelectedValue = hREmployeeEntity.DesignationID.ToString();
                }

                if (hREmployeeEntity.ConfirmDate != null)
                {
                    DateTime datetime = (DateTime)hREmployeeEntity.ConfirmDate;

                    txtConfirmDate.Text = datetime.ToValidDateString();
                }
                else
                {
                    txtConfirmDate.Text = hREmployeeEntity.ConfirmDate.ToStringDefault();
                }
                txtJoinDate.Text = hREmployeeEntity.JoinDate.ToStringDefault();
                txtDOB.Text = hREmployeeEntity.DOB.ToStringDefault();
                txtSalaryLevel.Text = hREmployeeEntity.SalaryLevel.ToString();
                if (ddlBloodGroupID.Items.Count > 0 && hREmployeeEntity.BloodGroupID != null)
                {
                    ddlBloodGroupID.SelectedValue = hREmployeeEntity.BloodGroupID.ToString();
                }

                txtPrimaryEmail.Text = hREmployeeEntity.PrimaryEmail.ToString();
                txtSecondaryEmail.Text = hREmployeeEntity.SecondaryEmail.ToString();
                txtInitials.Text = hREmployeeEntity.Initials.ToString();

                if (ddlEmploymentStatusID.Items.Count > 0 && hREmployeeEntity.EmploymentStatusID != null)
                {
                    ddlEmploymentStatusID.SelectedValue = hREmployeeEntity.EmploymentStatusID.ToString();
                }

                if (ddlEmploymentStatusID.Items.Count > 0 && hREmployeeEntity.EmploymentStatusID != null && hREmployeeEntity.EmploymentStatusID == MasterDataConstants.MDEmploymentStatus.DISCONTINUED)
                {
                    pnlDiscontinuedDate.Visible = true;
                }
                else
                {
                    pnlDiscontinuedDate.Visible = false;
                }

                txtDiscontinuedDate.Text = hREmployeeEntity.DiscontinuedDate.ToStringDefault();

                if (ddlDepartmentID.Items.Count > 0 && hREmployeeEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = hREmployeeEntity.DepartmentID.ToString();
                }

                if (ddlProjectID.Items.Count > 0 && hREmployeeEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = hREmployeeEntity.ProjectID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeList();
        }

        private void BindHREmployeeList()
        {
            lvHREmployee.DataBind();
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

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                    hREmployeeEntity.DepartmentID = null;
                }
                else
                {
                    hREmployeeEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
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

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (txtConfirmDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEntity.ConfirmDate = DateTime.Parse(txtConfirmDate.Text);
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

            if (ddlEmploymentStatusID.Items.Count > 0)
            {
                hREmployeeEntity.EmploymentStatusID = Int64.Parse(ddlEmploymentStatusID.SelectedValue);
            }

            if (txtDiscontinuedDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEntity.DiscontinuedDate = MiscUtil.ParseToDateTime(txtDiscontinuedDate.Text);
            }
            else
            {
                hREmployeeEntity.DiscontinuedDate = null;
            }

            hREmployeeEntity.PrimaryEmail = txtPrimaryEmail.Text.Trim();
            hREmployeeEntity.SecondaryEmail = txtSecondaryEmail.Text.Trim();
            hREmployeeEntity.Initials = txtInitials.Text.Trim();
            hREmployeeEntity.SalaryLevel = Int32.Parse(txtSalaryLevel.Text);
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

                        #region Create Six Task For HR

                        try
                        {
                            StringBuilder xmlStr = new StringBuilder();
                            Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                            Int64 referenceID = 49;
                            DateTime joinDate = (DateTime)hREmployeeEntity.JoinDate;
                            String fe = "DepartmentID = "+MasterDataConstants.MDDepartment.HR_DEPARTMENTID+"";

                            IList<HREmployeeEntity> lst = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            #region Delete Old Task 

                            String filter = "IssueIdentityCategoryID = " + MasterDataConstants.MDIssueIdentityCategory .HRMETTINGWITHEMPLOYEE+ " and SupervisorEmployeeID = " + hREmployeeEntity.EmployeeID + "";
                            IList<OTIssueEntity> issueList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty, filter, DatabaseOperationType.LoadWithFilterExpression);
                            if (issueList != null && issueList.Count > 0)
                            {
                                OTIssueEntity oTIssueEntity = new OTIssueEntity();
                                FCCOTIssue.GetFacadeCreate().Delete(oTIssueEntity, filter, DatabaseOperationType.Delete, TransactionRequired.No);
                            }

                            #endregion

                            String title = "Employee Name: " + hRMemberEntity.FirstName + " " + hRMemberEntity.MiddleName + " " + hRMemberEntity.LastName + ", Code: " + hREmployeeEntity.EmployeeCode + " join Date: " + hREmployeeEntity.JoinDate + " has metting with you";

                            xmlStr.Append("<m>");
                            if (lst != null && lst.Count > 0)
                            {
                                
                                foreach (HREmployeeEntity e in lst)
                                {
                                    for (int i = 1; i <= 6; i++)
                                    {
                                        String subXmlStr = null;
                                        subXmlStr = subXmlStr + "<i><a>" + title + "</a><b>" + hREmployeeEntity.EmployeeID + "</b><c>" + e.EmployeeID + "</c><d>" + CurrentMember.MemberID + "</d><e>" + referenceID + "</e><f>" + joinDate.AddDays(i * 30) + "</f><g>" + joinDate.AddDays((i * 30) + 1) + "</g></i>";
                                        xmlStr.Append(subXmlStr.ToString());
                                    }
                                }
                            }
                            xmlStr.Append("</m>");

                            FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.CreateSixTaskForHR);

                            MiscUtil.ShowMessage(lblMessage, "Six Task has created for HR Successfully.", false);

                        }
                        catch (Exception ex)
                        {
                            MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
                        }

                        #endregion

                        if (resultC > 0)
                        {
                            _EmployeeID = 0;
                            _HREmployeeEntity = new HREmployeeEntity();
                            PrepareInitialView();
                            BindHREmployeeList();

                            if (hREmployeeEntity.IsNew)
                            {
                                ResourceEntity resourceEntity = new ResourceEntity();

                                resourceEntity.ReferenceID = resultC; // means new employee id
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
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployee_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployee_DetailedEntity ent = (HREmployee_DetailedEntity)dataItem.DataItem;
                HyperLink hypEmployeeFullName = (HyperLink)e.Item.FindControl("hypEmployeeFullName");
                HyperLink hypEmployeeDetailsReport = (HyperLink)e.Item.FindControl("hypEmployeeDetailsReport");
                HyperLink hypEmployeePersonalFile = (HyperLink)e.Item.FindControl("hypEmployeePersonalFile");
                

                hypEmployeeDetailsReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "EmployeeDetailsReport", UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                hypEmployeeFullName.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeEditor.aspx", string.Empty, UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                hypEmployeePersonalFile.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeePersonalFile.aspx", string.Empty, UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                
                hypEmployeeFullName.Target = "_blank";
                hypEmployeeDetailsReport.Target = "_blank";
                hypEmployeePersonalFile.Target = "_blank"; 
            }
        }

        protected void lvHREmployee_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeID);

            if (EmployeeID > 0)
            {


                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeID = EmployeeID;
                    _MemberID = CurrentHREmployeeEntity.MemberID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        HREmployeeEntity tempEmployee = FCCHREmployee.GetFacadeCreate().GetByID(EmployeeID);

                        #region Resource Delete

                        Int64 resultOne = -1;

                        String fe1_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ReferenceID, EmployeeID.ToString(), SQLMatchType.Equal);
                        String fe2_re = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID, MasterDataConstants.ResourceCategory.EMPLOYEE.ToString(), SQLMatchType.Equal);
                        String fe_re = SqlExpressionBuilder.PrepareFilterExpression(fe1_re, SQLJoinType.AND, fe2_re);

                        IList<ResourceEntity> resourceList = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe_re, DatabaseOperationType.LoadWithFilterExpression);

                        foreach (ResourceEntity ent in resourceList)
                        {
                            String fe_re_delete = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceID, ent.ResourceID.ToString(), SQLMatchType.Equal);

                            resultOne = FCCResource.GetFacadeCreate().Delete(ent, fe_re_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        #region Employee Delete

                        Int64 resultTwo = -1;

                        if (resultOne == 0)
                        {
                            String fe_con_delete = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_EmployeeID, EmployeeID.ToString(), SQLMatchType.Equal);

                            HREmployeeEntity hREmployeeEntity = new HREmployeeEntity();

                            resultTwo = FCCHREmployee.GetFacadeCreate().Delete(hREmployeeEntity, fe_con_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        #region Member Delete

                        Int64 resultThree = -1;

                        if (resultTwo == 0)
                        {
                            String fe_mem_delete = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, tempEmployee.MemberID.ToString(), SQLMatchType.Equal);

                            HRMemberEntity hRMemberEntity = new HRMemberEntity();

                            resultThree = FCCHRMember.GetFacadeCreate().Delete(hRMemberEntity, fe_mem_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        }

                        #endregion

                        if (resultOne == 0 && resultTwo == 0 && resultThree == 0)
                        {
                            _EmployeeID = 0;
                            _HREmployeeEntity = new HREmployeeEntity();
                            _MemberID = 0;
                            _HRMemberEntity = new HRMemberEntity();

                            PrepareInitialView();
                            BindHREmployeeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee.", true);
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

        protected void odsHREmployee_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            
            hypEmployeeListReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "EmployeeListReport").ToString();
            hypEmployeeListReport.Target = "_blank";
            if (e.ExecutingSelectCount == false)
            {
                BindHREmployeeList();
            }
            String fe = String.Empty;
            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }
            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";
                String fe3 = "MDEmploymentStatus.Name like '%"+txtSearchText.Text+"%'";
                //String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployee_DetailedEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.Equal);
                //String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployee_DetailedEntity.FLD_NAME_EmployeeFullName, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                //fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe3);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberID = 0;
            _HRMemberEntity = new HRMemberEntity();

            _EmployeeID = 0;
            _HREmployeeEntity = new HREmployeeEntity();

            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #region Drop Down Event 

        protected void ddlEmploymentStatusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEmploymentStatusID != null && ddlEmploymentStatusID.SelectedValue.ToString() == MasterDataConstants.MDEmploymentStatus.DISCONTINUED.ToString())
            {
                pnlDiscontinuedDate.Visible = true;
            }
            if (ddlEmploymentStatusID != null && ddlEmploymentStatusID.SelectedValue.ToString() != MasterDataConstants.MDEmploymentStatus.DISCONTINUED.ToString())
            {
                txtDiscontinuedDate.Text = String.Empty;
                pnlDiscontinuedDate.Visible = false;
            }
        }

        #endregion

        #endregion Event
    }
}
