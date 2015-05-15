// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMAgreementTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementTemplateID
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

        public CRMAgreementTemplateEntity _CRMAgreementTemplateEntity
        {
            get
            {
                CRMAgreementTemplateEntity entity = new CRMAgreementTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMAgreementTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMAgreementTemplateEntity CurrentCRMAgreementTemplateEntity
        {
            get
            {
                if (_AgreementTemplateID > 0)
                {
                    if (_CRMAgreementTemplateEntity.AgreementTemplateID != _AgreementTemplateID)
                    {
                        _CRMAgreementTemplateEntity = FCCCRMAgreementTemplate.GetFacadeCreate().GetByID(_AgreementTemplateID);
                    }
                }

                return _CRMAgreementTemplateEntity;
            }
            set
            {
                _CRMAgreementTemplateEntity = value;
            }
        }

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID = 0;

                if (ViewState["currentEmployeeID"] != null)
                {
                    Int64.TryParse(ViewState["currentEmployeeID"].ToString(), out _employeeID);
                }

                if (ViewState["currentEmployeeID"] == null)
                {
                    ViewState["currentEmployeeID"] = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    _employeeID = (Int64)ViewState["currentEmployeeID"];
                }

                return _employeeID;
            }
            set
            {
                ViewState["currentEmployeeID"] = value;
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

        protected string GetSubstring(string str, int length)
        {
            return str.Length > length ? str.Substring(0, length) : str;
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
            CRMAgreementTemplateEntity cRMAgreementTemplateEntity = CurrentCRMAgreementTemplateEntity;


            if (!cRMAgreementTemplateEntity.IsNew)
            {
                txtTemplateName.Text = cRMAgreementTemplateEntity.TemplateName.ToString();
                txtText.Content = cRMAgreementTemplateEntity.Text.ToString();
                txtRemarks.Text = cRMAgreementTemplateEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMAgreementTemplateList();
        }

        private void BindCRMAgreementTemplateList()
        {
            lvCRMAgreementTemplate.DataBind();
        }

        private CRMAgreementTemplateEntity BuildCRMAgreementTemplateEntity()
        {
            CRMAgreementTemplateEntity cRMAgreementTemplateEntity = CurrentCRMAgreementTemplateEntity;

            cRMAgreementTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            cRMAgreementTemplateEntity.Text = txtText.Content.Trim();
            cRMAgreementTemplateEntity.Remarks = txtRemarks.Text.Trim();
            cRMAgreementTemplateEntity.CreateDate = System.DateTime.Now;
            cRMAgreementTemplateEntity.IP = MiscUtil.GetLocalIP();
            cRMAgreementTemplateEntity.CreatedByEmployeeID = CurrentemployeeID;

            return cRMAgreementTemplateEntity;
        }

        private void SaveCRMAgreementTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMAgreementTemplateEntity cRMAgreementTemplateEntity = BuildCRMAgreementTemplateEntity();

                    Int64 result = -1;

                    if (cRMAgreementTemplateEntity.IsNew)
                    {
                        result = FCCCRMAgreementTemplate.GetFacadeCreate().Add(cRMAgreementTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementTemplateEntity.FLD_NAME_AgreementTemplateID, cRMAgreementTemplateEntity.AgreementTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMAgreementTemplate.GetFacadeCreate().Update(cRMAgreementTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AgreementTemplateID = 0;
                        _CRMAgreementTemplateEntity = new CRMAgreementTemplateEntity();
                        PrepareInitialView();
                        BindCRMAgreementTemplateList();

                        if (cRMAgreementTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMAgreementTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Agreement Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Agreement Template Information.", false);
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

        protected void lvCRMAgreementTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementTemplateID);

            if (AgreementTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementTemplateID = AgreementTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementTemplateEntity.FLD_NAME_AgreementTemplateID, AgreementTemplateID.ToString(), SQLMatchType.Equal);

                        CRMAgreementTemplateEntity cRMAgreementTemplateEntity = new CRMAgreementTemplateEntity();


                        result = FCCCRMAgreementTemplate.GetFacadeCreate().Delete(cRMAgreementTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementTemplateID = 0;
                            _CRMAgreementTemplateEntity = new CRMAgreementTemplateEntity();
                            PrepareInitialView();
                            BindCRMAgreementTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Template.", true);
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

        protected void odsCRMAgreementTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMAgreementTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementTemplateID = 0;
            _CRMAgreementTemplateEntity = new CRMAgreementTemplateEntity();
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
