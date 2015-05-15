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
    public partial class CRMSurveyMasterControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveyMasterID
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

        public CRMSurveyMasterEntity _CRMSurveyMasterEntity
        {
            get
            {
                CRMSurveyMasterEntity entity = new CRMSurveyMasterEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMSurveyMasterEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMSurveyMasterEntity CurrentCRMSurveyMasterEntity
        {
            get
            {
                if (_SurveyMasterID > 0)
                {
                    if (_CRMSurveyMasterEntity.SurveyMasterID != _SurveyMasterID)
                    {
                        _CRMSurveyMasterEntity = FCCCRMSurveyMaster.GetFacadeCreate().GetByID(_SurveyMasterID);
                    }
                }

                return _CRMSurveyMasterEntity;
            }
            set
            {
                _CRMSurveyMasterEntity = value;
            }
        }

        public Int64 OverViewSurveyMasterID
        {
            get
            {
                Int64 OverViewSurveyMasterID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_MASTER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_MASTER_ID], out OverViewSurveyMasterID);
                }

                return OverViewSurveyMasterID;
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

        private void PrepareInitialView()
        {
            txtTitle.Text = String.Empty;
            txtStartDate.Text =System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMSurveyMasterEntity cRMSurveyMasterEntity = CurrentCRMSurveyMasterEntity;


            if (!cRMSurveyMasterEntity.IsNew)
            {
                txtTitle.Text = cRMSurveyMasterEntity.Title.ToString();

                txtStartDate.Text = cRMSurveyMasterEntity.StartDate.ToStringDefault();
                txtEndDate.Text = cRMSurveyMasterEntity.EndDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMSurveyMasterList();
        }

        private void BindCRMSurveyMasterList()
        {
            lvCRMSurveyMaster.DataBind();
        }

        private CRMSurveyMasterEntity BuildCRMSurveyMasterEntity()
        {
            CRMSurveyMasterEntity cRMSurveyMasterEntity = CurrentCRMSurveyMasterEntity;

            cRMSurveyMasterEntity.Title = txtTitle.Text.Trim();
            
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMSurveyMasterEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMSurveyMasterEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }

            cRMSurveyMasterEntity.CreateDate = System.DateTime.Now;

            cRMSurveyMasterEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return cRMSurveyMasterEntity;
        }

        private void SaveCRMSurveyMasterEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMSurveyMasterEntity cRMSurveyMasterEntity = BuildCRMSurveyMasterEntity();

                    Int64 result = -1;

                    if (cRMSurveyMasterEntity.IsNew)
                    {
                        result = FCCCRMSurveyMaster.GetFacadeCreate().Add(cRMSurveyMasterEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyMasterEntity.FLD_NAME_SurveyMasterID, cRMSurveyMasterEntity.SurveyMasterID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMSurveyMaster.GetFacadeCreate().Update(cRMSurveyMasterEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveyMasterID = 0;
                        _CRMSurveyMasterEntity = new CRMSurveyMasterEntity();
                        PrepareInitialView();
                        BindCRMSurveyMasterList();

                        if (cRMSurveyMasterEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Master Information has been added successfully.", false);
                            String NavigationUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMSurvey.aspx", string.Empty, UrlConstants.OVERVIEW_SURVEY_MASTER_ID, result.ToString()).ToString();
                            Response.Redirect(NavigationUrl);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Master Information has been updated successfully.", false);
                            String NavigationUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMSurvey.aspx", string.Empty, UrlConstants.OVERVIEW_SURVEY_MASTER_ID, result.ToString()).ToString();
                            Response.Redirect(NavigationUrl);
                        }
                    }
                    else
                    {
                        if (cRMSurveyMasterEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Survey Master Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Survey Master Information.", false);
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

        protected void lvCRMServeyMaster_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMSurveyMasterEntity ent = (CRMSurveyMasterEntity)dataItem.DataItem;

                HyperLink hypTitle = (HyperLink)e.Item.FindControl("hypTitle");
                HyperLink hypSurveyMasterReport = (HyperLink)e.Item.FindControl("hypSurveyMasterReport");

                
                hypTitle.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMSurvey.aspx", string.Empty, UrlConstants.OVERVIEW_SURVEY_MASTER_ID, ent.SurveyMasterID.ToString()).ToString();
                
                hypSurveyMasterReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "SurveyMasterReport", UrlConstants.OVERVIEW_SURVEY_MASTER_ID, ent.SurveyMasterID.ToString()).ToString();
                hypSurveyMasterReport.Target = "_blank";
                hypTitle.Target = "_blank";
            }
        }

        protected void lvCRMSurveyMaster_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveyMasterID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveyMasterID);

            if (SurveyMasterID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveyMasterID = SurveyMasterID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyMasterEntity.FLD_NAME_SurveyMasterID, SurveyMasterID.ToString(), SQLMatchType.Equal);

                        CRMSurveyMasterEntity cRMSurveyMasterEntity = new CRMSurveyMasterEntity();


                        result = FCCCRMSurveyMaster.GetFacadeCreate().Delete(cRMSurveyMasterEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveyMasterID = 0;
                            _CRMSurveyMasterEntity = new CRMSurveyMasterEntity();
                            PrepareInitialView();
                            BindCRMSurveyMasterList();

                            MiscUtil.ShowMessage(lblMessage, "Survey Master has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Survey Master.", true);
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

        protected void odsCRMSurveyMaster_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMSurveyMasterEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveyMasterID = 0;
            _CRMSurveyMasterEntity = new CRMSurveyMasterEntity();
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
