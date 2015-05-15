// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




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
    public partial class CMNMailTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _MailTemplateID
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

        public CMNMailTemplateEntity _CMNMailTemplateEntity
        {
            get
            {
                CMNMailTemplateEntity entity = new CMNMailTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNMailTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNMailTemplateEntity CurrentCMNMailTemplateEntity
        {
            get
            {
                if (_MailTemplateID > 0)
                {
                    if (_CMNMailTemplateEntity.MailTemplateID != _MailTemplateID)
                    {
                        _CMNMailTemplateEntity = FCCCMNMailTemplate.GetFacadeCreate().GetByID(_MailTemplateID);
                    }
                }

                return _CMNMailTemplateEntity;
            }
            set
            {
                _CMNMailTemplateEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDMailTemplateType(ddlMailTemplateTypeID, false);
            MiscUtil.PopulateMDMailTextType(ddlMailTextTypeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTemplateName.Text = String.Empty;
            txtSubject.Text = String.Empty;
            txtBodyMessage.Content = String.Empty;
            txtSignature.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNMailTemplateEntity cMNMailTemplateEntity = CurrentCMNMailTemplateEntity;


            if (!cMNMailTemplateEntity.IsNew)
            {
                if (ddlMailTemplateTypeID.Items.Count > 0 && cMNMailTemplateEntity.MailTemplateTypeID != null)
                {
                    ddlMailTemplateTypeID.SelectedValue = cMNMailTemplateEntity.MailTemplateTypeID.ToString();
                }

                txtTemplateName.Text = cMNMailTemplateEntity.TemplateName.ToString();
                txtSubject.Text = cMNMailTemplateEntity.Subject.ToString();
                txtBodyMessage.Content = cMNMailTemplateEntity.BodyMessage.ToString();
                txtSignature.Text = cMNMailTemplateEntity.Signature.ToString();
                if (ddlMailTextTypeID.Items.Count > 0 && cMNMailTemplateEntity.MailTextTypeID != null)
                {
                    ddlMailTextTypeID.SelectedValue = cMNMailTemplateEntity.MailTextTypeID.ToString();
                }

                txtRemarks.Text = cMNMailTemplateEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNMailTemplateList();
        }

        private void BindCMNMailTemplateList()
        {
            lvCMNMailTemplate.DataBind();
        }

        private CMNMailTemplateEntity BuildCMNMailTemplateEntity()
        {
            CMNMailTemplateEntity cMNMailTemplateEntity = CurrentCMNMailTemplateEntity;

            if (ddlMailTemplateTypeID.Items.Count > 0)
            {
                if (ddlMailTemplateTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNMailTemplateEntity.MailTemplateTypeID = Int64.Parse(ddlMailTemplateTypeID.SelectedValue);
                }
            }

            cMNMailTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            cMNMailTemplateEntity.Subject = txtSubject.Text.Trim();
            cMNMailTemplateEntity.BodyMessage = txtBodyMessage.Content.Trim();
            cMNMailTemplateEntity.Signature = txtSignature.Text.Trim();
            if (ddlMailTextTypeID.Items.Count > 0)
            {
                if (ddlMailTextTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNMailTemplateEntity.MailTextTypeID = Int64.Parse(ddlMailTextTypeID.SelectedValue);
                }
            }

            cMNMailTemplateEntity.Remarks = txtRemarks.Text.Trim();

            return cMNMailTemplateEntity;
        }

        private void SaveCMNMailTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNMailTemplateEntity cMNMailTemplateEntity = BuildCMNMailTemplateEntity();

                    Int64 result = -1;

                    if (cMNMailTemplateEntity.IsNew)
                    {
                        result = FCCCMNMailTemplate.GetFacadeCreate().Add(cMNMailTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNMailTemplateEntity.FLD_NAME_MailTemplateID, cMNMailTemplateEntity.MailTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNMailTemplate.GetFacadeCreate().Update(cMNMailTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MailTemplateID = 0;
                        _CMNMailTemplateEntity = new CMNMailTemplateEntity();
                        PrepareInitialView();
                        BindCMNMailTemplateList();

                        if (cMNMailTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Mail Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Mail Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNMailTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Mail Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Mail Template Information.", false);
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

        protected void lvCMNMailTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MailTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out MailTemplateID);

            if (MailTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MailTemplateID = MailTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMailTemplateEntity.FLD_NAME_MailTemplateID, MailTemplateID.ToString(), SQLMatchType.Equal);

                        CMNMailTemplateEntity cMNMailTemplateEntity = new CMNMailTemplateEntity();


                        result = FCCCMNMailTemplate.GetFacadeCreate().Delete(cMNMailTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MailTemplateID = 0;
                            _CMNMailTemplateEntity = new CMNMailTemplateEntity();
                            PrepareInitialView();
                            BindCMNMailTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "Mail Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Mail Template.", true);
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

        protected void odsCMNMailTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNMailTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MailTemplateID = 0;
            _CMNMailTemplateEntity = new CMNMailTemplateEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void ContentChanged(object sender, EventArgs e)
        {
            //ContentChangedLabel.Text = "<span style='color:red'>Content changed</span>";
        }

        #endregion

        #endregion Event
    }
}
