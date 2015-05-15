// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    public partial class CRMSurveyOwnerControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveyOwnerID
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

        public CRMSurveyOwnerEntity _CRMSurveyOwnerEntity
        {
            get
            {
                CRMSurveyOwnerEntity entity = new CRMSurveyOwnerEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMSurveyOwnerEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMSurveyOwnerEntity CurrentCRMSurveyOwnerEntity
        {
            get
            {
                if (_SurveyOwnerID > 0)
                {
                    if (_CRMSurveyOwnerEntity.SurveyOwnerID != _SurveyOwnerID)
                    {
                        _CRMSurveyOwnerEntity = FCCCRMSurveyOwner.GetFacadeCreate().GetByID(_SurveyOwnerID);
                    }
                }

                return _CRMSurveyOwnerEntity;
            }
            set
            {
                _CRMSurveyOwnerEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDSurveyOwnerType(ddlSurveyOwnerTypeID, false);
        }

        private void PrepareValidator()
        {

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revWebLink.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebLink.ErrorMessage = ValidationConstants.ErrorMessage.Web;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtContactNo1.Text = String.Empty;
            txtContactNo2.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtWebLink.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMSurveyOwnerEntity cRMSurveyOwnerEntity = CurrentCRMSurveyOwnerEntity;


            if (!cRMSurveyOwnerEntity.IsNew)
            {
                if (ddlSurveyOwnerTypeID.Items.Count > 0 && cRMSurveyOwnerEntity.SurveyOwnerTypeID != null)
                {
                    ddlSurveyOwnerTypeID.SelectedValue = cRMSurveyOwnerEntity.SurveyOwnerTypeID.ToString();
                }

                txtName.Text = cRMSurveyOwnerEntity.Name.ToString();
                txtAddressLine1.Text = cRMSurveyOwnerEntity.AddressLine1.ToString();
                txtAddressLine2.Text = cRMSurveyOwnerEntity.AddressLine2.ToString();
                txtContactNo1.Text = cRMSurveyOwnerEntity.ContactNo1.ToString();
                txtContactNo2.Text = cRMSurveyOwnerEntity.ContactNo2.ToString();
                txtEmail.Text = cRMSurveyOwnerEntity.Email.ToString();
                txtWebLink.Text = cRMSurveyOwnerEntity.WebLink.ToString();
                txtRemarks.Text = cRMSurveyOwnerEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMSurveyOwnerList();
        }

        private void BindCRMSurveyOwnerList()
        {
            lvCRMSurveyOwner.DataBind();
        }

        private CRMSurveyOwnerEntity BuildCRMSurveyOwnerEntity()
        {
            CRMSurveyOwnerEntity cRMSurveyOwnerEntity = CurrentCRMSurveyOwnerEntity;

            if (ddlSurveyOwnerTypeID.Items.Count > 0)
            {
                if (ddlSurveyOwnerTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMSurveyOwnerEntity.SurveyOwnerTypeID = Int64.Parse(ddlSurveyOwnerTypeID.SelectedValue);
                }
            }

            cRMSurveyOwnerEntity.Name = txtName.Text.Trim();
            cRMSurveyOwnerEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            cRMSurveyOwnerEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            cRMSurveyOwnerEntity.ContactNo1 = txtContactNo1.Text.Trim();
            cRMSurveyOwnerEntity.ContactNo2 = txtContactNo2.Text.Trim();
            cRMSurveyOwnerEntity.Email = txtEmail.Text.Trim();
            cRMSurveyOwnerEntity.WebLink = txtWebLink.Text.Trim();
            cRMSurveyOwnerEntity.Remarks = txtRemarks.Text.Trim();

            return cRMSurveyOwnerEntity;
        }

        private void SaveCRMSurveyOwnerEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMSurveyOwnerEntity cRMSurveyOwnerEntity = BuildCRMSurveyOwnerEntity();

                    Int64 result = -1;

                    if (cRMSurveyOwnerEntity.IsNew)
                    {
                        result = FCCCRMSurveyOwner.GetFacadeCreate().Add(cRMSurveyOwnerEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerEntity.FLD_NAME_SurveyOwnerID, cRMSurveyOwnerEntity.SurveyOwnerID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMSurveyOwner.GetFacadeCreate().Update(cRMSurveyOwnerEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveyOwnerID = 0;
                        _CRMSurveyOwnerEntity = new CRMSurveyOwnerEntity();
                        PrepareInitialView();
                        BindCRMSurveyOwnerList();

                        if (cRMSurveyOwnerEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMSurvey Owner Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMSurvey Owner Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMSurveyOwnerEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMSurvey Owner Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMSurvey Owner Information.", false);
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

        protected void lvCRMSurveyOwner_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMSurveyOwner_DetailedEntity ent = (CRMSurveyOwner_DetailedEntity)dataItem.DataItem;

                HyperLink hypSurveyOwner = (HyperLink)e.Item.FindControl("hypSurveyOwner");
                hypSurveyOwner.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMSurveyOwnerContactPerson.aspx", string.Empty, UrlConstants.OVERVIEW_SURVEY_OWNER_ID, ent.SurveyOwnerID.ToString()).ToString();

                HyperLink hypSurveyReport = (HyperLink)e.Item.FindControl("hypSurveyReport");
                hypSurveyReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "SurveyReport", UrlConstants.OVERVIEW_SURVEY_OWNER_ID, ent.SurveyOwnerID.ToString()).ToString();
                
                hypSurveyReport.Target = "_blank";
                hypSurveyOwner.Target = "_blank";
                hypSurveyOwner.CssClass = "CommonButtonLink";
            }
        }

        protected void lvCRMSurveyOwner_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveyOwnerID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveyOwnerID);

            if (SurveyOwnerID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveyOwnerID = SurveyOwnerID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerEntity.FLD_NAME_SurveyOwnerID, SurveyOwnerID.ToString(), SQLMatchType.Equal);

                        CRMSurveyOwnerEntity cRMSurveyOwnerEntity = new CRMSurveyOwnerEntity();


                        result = FCCCRMSurveyOwner.GetFacadeCreate().Delete(cRMSurveyOwnerEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveyOwnerID = 0;
                            _CRMSurveyOwnerEntity = new CRMSurveyOwnerEntity();
                            PrepareInitialView();
                            BindCRMSurveyOwnerList();

                            MiscUtil.ShowMessage(lblMessage, "C RMSurvey Owner has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMSurvey Owner.", true);
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

        protected void odsCRMSurveyOwner_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMSurveyOwnerEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveyOwnerID = 0;
            _CRMSurveyOwnerEntity = new CRMSurveyOwnerEntity();
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
