// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 02:13:24




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeNoticeOperationControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeNoticeID
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

        public HREmployeeNoticeEntity _HREmployeeNoticeEntity
        {
            get
            {
                HREmployeeNoticeEntity entity = new HREmployeeNoticeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeNoticeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeNoticeEntity CurrentHREmployeeNoticeEntity
        {
            get
            {
                if (_EmployeeNoticeID > 0)
                {
                    if (_HREmployeeNoticeEntity.EmployeeNoticeID != _EmployeeNoticeID)
                    {
                        _HREmployeeNoticeEntity = FCCHREmployeeNotice.GetFacadeCreate().GetByID(_EmployeeNoticeID);
                    }
                }

                return _HREmployeeNoticeEntity;
            }
            set
            {
                _HREmployeeNoticeEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployee(ddlSendToEmployeeID, false);
            MiscUtil.PopulateHREmployeeNoticeTemplate(ddlTemplateID, false);
        }

        private void GetSalaryLevel()
        {
            HREmployeeEntity entity = FCCHREmployee.GetFacadeCreate().GetByID(Int64.Parse(ddlSendToEmployeeID.SelectedValue));
            txtMemo.Text = entity.SalaryLevel.ToString().Trim();
        }

        private void PrepareValidator()
        {
        }

        private void BuildNoticeTemplate()
        {
            if (ddlTemplateID != null && ddlTemplateID.Items.Count > 0)
            {
                HREmployeeNoticeTemplateEntity hREmployeeNoticeTemplateEntity = FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetByID(Int64.Parse(ddlTemplateID.SelectedValue));
                if (hREmployeeNoticeTemplateEntity != null && hREmployeeNoticeTemplateEntity.NoticeTemplateTypeID > 0)
                {
                    txtText.Content = hREmployeeNoticeTemplateEntity.Text.ToString();
                }
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtMemo.Text = String.Empty;
            //BuildNoticeTemplate();
            //txtText.Content = String.Empty;
            txtRemarks.Text = String.Empty;
            txtNoticeDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void SendMail(HREmployeeNoticeEntity noticeEntity)
        {
            HREmployeeNoticeEntity entity = noticeEntity;
            

            #region Notice Mail

            String MailBody = String.Empty;
            String Subject = String.Empty;

            StringBuilder sb = new StringBuilder();

            sb.Append("Dear Sir,");
            sb.Append("<br/>");
            sb.Append("This is a auto generated mail from the ERP.");
            sb.Append("<br/>");
            sb.Append("A "+entity.Memo+" Have Been send By HR. Please go to your profile and Check "+entity.Memo+".");
            sb.Append("<br/>");
            sb.Append("-");
            sb.Append("<br/>");
            sb.Append("Thanks");
            sb.Append("<br/>");
            sb.Append("ERP System");
            MailBody = sb.ToString();
            Subject = "ERP, Notice Reply";

            String[] sendToMail = new String[1];

            HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(entity.SendToEmployeeID);

            if (_hREmployeeEntity != null)
            {
                sendToMail[0] = _hREmployeeEntity.PrimaryEmail;
            }

            MiscUtil.SendMail(sendToMail, Subject, MailBody);

            #endregion
        }

        private void PrepareEditView()
        {
            HREmployeeNoticeEntity hREmployeeNoticeEntity = CurrentHREmployeeNoticeEntity;


            if (!hREmployeeNoticeEntity.IsNew)
            {
                if (ddlSendToEmployeeID.Items.Count > 0 && hREmployeeNoticeEntity.SendToEmployeeID != null)
                {
                    ddlSendToEmployeeID.SelectedValue = hREmployeeNoticeEntity.SendToEmployeeID.ToString();
                }

                txtMemo.Text = hREmployeeNoticeEntity.Memo.ToString();
                txtText.Content = hREmployeeNoticeEntity.Text.ToString();
                txtRemarks.Text = hREmployeeNoticeEntity.Remarks.ToString();
                txtNoticeDate.Text = hREmployeeNoticeEntity.NoticeDate.ToStringDefault();

                if (ddlTemplateID.Items.Count > 0 && hREmployeeNoticeEntity.TemplateID != null)
                {
                    ddlTemplateID.SelectedValue = hREmployeeNoticeEntity.TemplateID.ToString();
                }
                
           
                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeNoticeList();
        }

        private void BindHREmployeeNoticeList()
        {
            lvHREmployeeNotice.DataBind();
        }

        private HREmployeeNoticeEntity BuildHREmployeeNoticeEntity()
        {
            HREmployeeNoticeEntity hREmployeeNoticeEntity = CurrentHREmployeeNoticeEntity;

            if (ddlSendToEmployeeID.Items.Count > 0)
            {
                if (ddlSendToEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeNoticeEntity.SendToEmployeeID = Int64.Parse(ddlSendToEmployeeID.SelectedValue);
                }
            }

            if (!txtMemo.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeNoticeEntity.Memo = txtMemo.Text.Trim();
            }
            else
            {
                hREmployeeNoticeEntity.Memo = null;
            }

            hREmployeeNoticeEntity.Text = txtText.Content.Trim();
            hREmployeeNoticeEntity.Remarks = txtRemarks.Text.Trim();
            if (txtNoticeDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeNoticeEntity.NoticeDate = MiscUtil.ParseToDateTime(txtNoticeDate.Text);
            }
            hREmployeeNoticeEntity.PreparedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel = null;
            if (ddlTemplateID.Items.Count > 0)
            {
                if (ddlTemplateID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeNoticeEntity.TemplateID = Int64.Parse(ddlTemplateID.SelectedValue);
                }
            }

            hREmployeeNoticeEntity.ViewCount = 0;

            return hREmployeeNoticeEntity;
        }

        private void SaveHREmployeeNoticeEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeNoticeEntity hREmployeeNoticeEntity = BuildHREmployeeNoticeEntity();

                    Int64 result = -1;

                    if (hREmployeeNoticeEntity.IsNew)
                    {
                        result = FCCHREmployeeNotice.GetFacadeCreate().Add(hREmployeeNoticeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        SendMail(hREmployeeNoticeEntity);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeEntity.FLD_NAME_EmployeeNoticeID, hREmployeeNoticeEntity.EmployeeNoticeID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeNotice.GetFacadeCreate().Update(hREmployeeNoticeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeNoticeID = 0;
                        _HREmployeeNoticeEntity = new HREmployeeNoticeEntity();
                        PrepareInitialView();
                        BindHREmployeeNoticeList();

                        if (hREmployeeNoticeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Notice Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Notice Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeNoticeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Notice Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Notice Information.", false);
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
                //GetSalaryLevel();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeNotice_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeNoticeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeNoticeID);

            if (EmployeeNoticeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeNoticeID = EmployeeNoticeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeEntity.FLD_NAME_EmployeeNoticeID, EmployeeNoticeID.ToString(), SQLMatchType.Equal);

                        HREmployeeNoticeEntity hREmployeeNoticeEntity = new HREmployeeNoticeEntity();


                        result = FCCHREmployeeNotice.GetFacadeCreate().Delete(hREmployeeNoticeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeNoticeID = 0;
                            _HREmployeeNoticeEntity = new HREmployeeNoticeEntity();
                            PrepareInitialView();
                            BindHREmployeeNoticeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Notice has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Notice.", true);
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

        protected void odsHREmployeeNotice_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFiltring.Checked)
            {
                fe = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeNoticeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeNoticeID = 0;
            _HREmployeeNoticeEntity = new HREmployeeNoticeEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event 

        
        
        protected void ddlTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildNoticeTemplate();
        }

        //protected void ddlSendToEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //GetSalaryLevel();
        //}
        

        #endregion

        #region CheckBox Event

        protected void chbxFiltering_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
