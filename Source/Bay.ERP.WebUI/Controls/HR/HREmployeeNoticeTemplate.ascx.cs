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
    public partial class HREmployeeNoticeTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeNoticeTemplateID
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

        public HREmployeeNoticeTemplateEntity _HREmployeeNoticeTemplateEntity
        {
            get
            {
                HREmployeeNoticeTemplateEntity entity = new HREmployeeNoticeTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeNoticeTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeNoticeTemplateEntity CurrentHREmployeeNoticeTemplateEntity
        {
            get
            {
                if (_EmployeeNoticeTemplateID > 0)
                {
                    if (_HREmployeeNoticeTemplateEntity.EmployeeNoticeTemplateID != _EmployeeNoticeTemplateID)
                    {
                        _HREmployeeNoticeTemplateEntity = FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetByID(_EmployeeNoticeTemplateID);
                    }
                }

                return _HREmployeeNoticeTemplateEntity;
            }
            set
            {
                _HREmployeeNoticeTemplateEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDHRNoticeTemplateType(ddlNoticeTemplateTypeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTemplateName.Text = String.Empty;
            txtText.Content = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeNoticeTemplateEntity hREmployeeNoticeTemplateEntity = CurrentHREmployeeNoticeTemplateEntity;


            if (!hREmployeeNoticeTemplateEntity.IsNew)
            {
                if (ddlNoticeTemplateTypeID.Items.Count > 0 && hREmployeeNoticeTemplateEntity.NoticeTemplateTypeID != null)
                {
                    ddlNoticeTemplateTypeID.SelectedValue = hREmployeeNoticeTemplateEntity.NoticeTemplateTypeID.ToString();
                }

                txtTemplateName.Text = hREmployeeNoticeTemplateEntity.TemplateName.ToString();
                txtText.Content = hREmployeeNoticeTemplateEntity.Text.ToString();
                txtRemarks.Text = hREmployeeNoticeTemplateEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeNoticeTemplateList();
        }

        private void BindHREmployeeNoticeTemplateList()
        {
            lvHREmployeeNoticeTemplate.DataBind();
        }

        private HREmployeeNoticeTemplateEntity BuildHREmployeeNoticeTemplateEntity()
        {
            HREmployeeNoticeTemplateEntity hREmployeeNoticeTemplateEntity = CurrentHREmployeeNoticeTemplateEntity;

            if (ddlNoticeTemplateTypeID.Items.Count > 0)
            {
                if (ddlNoticeTemplateTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeNoticeTemplateEntity.NoticeTemplateTypeID = Int64.Parse(ddlNoticeTemplateTypeID.SelectedValue);
                }
            }

            hREmployeeNoticeTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            hREmployeeNoticeTemplateEntity.Text = txtText.Content.Trim();
            hREmployeeNoticeTemplateEntity.Remarks = txtRemarks.Text.Trim();
           
            hREmployeeNoticeTemplateEntity.CreateDate = System.DateTime.Now;
            hREmployeeNoticeTemplateEntity.IP = MiscUtil.GetLocalIP();
            hREmployeeNoticeTemplateEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);


            return hREmployeeNoticeTemplateEntity;
        }

        private void SaveHREmployeeNoticeTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeNoticeTemplateEntity hREmployeeNoticeTemplateEntity = BuildHREmployeeNoticeTemplateEntity();

                    Int64 result = -1;

                    if (hREmployeeNoticeTemplateEntity.IsNew)
                    {
                        result = FCCHREmployeeNoticeTemplate.GetFacadeCreate().Add(hREmployeeNoticeTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeTemplateEntity.FLD_NAME_EmployeeNoticeTemplateID, hREmployeeNoticeTemplateEntity.EmployeeNoticeTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeNoticeTemplate.GetFacadeCreate().Update(hREmployeeNoticeTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeNoticeTemplateID = 0;
                        _HREmployeeNoticeTemplateEntity = new HREmployeeNoticeTemplateEntity();
                        PrepareInitialView();
                        BindHREmployeeNoticeTemplateList();

                        if (hREmployeeNoticeTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Notice Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Notice Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeNoticeTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Notice Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Notice Template Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        public string GetSubstring(string str, int length)
        {
            return str.Length > length ? str.Substring(0, length) : str;
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

        protected void lvHREmployeeNoticeTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeNoticeTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeNoticeTemplateID);

            if (EmployeeNoticeTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeNoticeTemplateID = EmployeeNoticeTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeNoticeTemplateEntity.FLD_NAME_EmployeeNoticeTemplateID, EmployeeNoticeTemplateID.ToString(), SQLMatchType.Equal);

                        HREmployeeNoticeTemplateEntity hREmployeeNoticeTemplateEntity = new HREmployeeNoticeTemplateEntity();


                        result = FCCHREmployeeNoticeTemplate.GetFacadeCreate().Delete(hREmployeeNoticeTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeNoticeTemplateID = 0;
                            _HREmployeeNoticeTemplateEntity = new HREmployeeNoticeTemplateEntity();
                            PrepareInitialView();
                            BindHREmployeeNoticeTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Notice Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Notice Template.", true);
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

        protected void odsHREmployeeNoticeTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeNoticeTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeNoticeTemplateID = 0;
            _HREmployeeNoticeTemplateEntity = new HREmployeeNoticeTemplateEntity();
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
