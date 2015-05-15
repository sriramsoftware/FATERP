// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class ACCPostPayableStatementControl : BaseControl
    {       
        #region Properties

        public Int64 _PostPayableStatementID
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

        public ACCPostPayableStatementEntity _ACCPostPayableStatementEntity
        {
            get
            {
                ACCPostPayableStatementEntity entity = new ACCPostPayableStatementEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCPostPayableStatementEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCPostPayableStatementEntity CurrentACCPostPayableStatementEntity
        {
            get
            {
                if (_PostPayableStatementID > 0)
                {
                    if (_ACCPostPayableStatementEntity.PostPayableStatementID != _PostPayableStatementID)
                    {
                        _ACCPostPayableStatementEntity = FCCACCPostPayableStatement.GetFacadeCreate().GetByID(_PostPayableStatementID);
                    }
                }

                return _ACCPostPayableStatementEntity;
            }
            set
            {
                _ACCPostPayableStatementEntity = value;
            }
        }       

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACCPrePayableStatement(ddlPrePayableStatementID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtPostPayableStatementID.Text = String.Empty;
            txtRef.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            txtStartDate.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACCPostPayableStatementEntity aCCPostPayableStatementEntity = CurrentACCPostPayableStatementEntity;


            if (!aCCPostPayableStatementEntity.IsNew)
            {
                txtPostPayableStatementID.Text = aCCPostPayableStatementEntity.PostPayableStatementID.ToString();
                if (ddlPrePayableStatementID.Items.Count > 0 && aCCPostPayableStatementEntity.PrePayableStatementID != null)
                {
                    ddlPrePayableStatementID.SelectedValue = aCCPostPayableStatementEntity.PrePayableStatementID.ToString();
                }

                txtRef.Text = aCCPostPayableStatementEntity.Ref.ToString();
                txtCreateDate.Text = aCCPostPayableStatementEntity.CreateDate.ToStringDefault();
                txtEndDate.Text = aCCPostPayableStatementEntity.EndDate.ToStringDefault();
                txtStartDate.Text = aCCPostPayableStatementEntity.StartDate.ToStringDefault();
                chkIsRemoved.Checked = aCCPostPayableStatementEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACCPostPayableStatementList();
        }

        private void BindACCPostPayableStatementList()
        {
            lvACCPostPayableStatement.DataBind();
        }

        private ACCPostPayableStatementEntity BuildACCPostPayableStatementEntity()
        {
            ACCPostPayableStatementEntity aCCPostPayableStatementEntity = CurrentACCPostPayableStatementEntity;

            if (!txtPostPayableStatementID.Text.Trim().IsNullOrEmpty())
            {
                aCCPostPayableStatementEntity.PostPayableStatementID = Int64.Parse(txtPostPayableStatementID.Text.Trim());
            }

            if (ddlPrePayableStatementID.Items.Count > 0)
            {
                if (ddlPrePayableStatementID.SelectedValue == "0")
                {
                    aCCPostPayableStatementEntity.PrePayableStatementID = null;
                }
                else
                {
                    aCCPostPayableStatementEntity.PrePayableStatementID = Int64.Parse(ddlPrePayableStatementID.SelectedValue);
                }
            }

            aCCPostPayableStatementEntity.Ref = txtRef.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCCPostPayableStatementEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCCPostPayableStatementEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }

            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCCPostPayableStatementEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }

            aCCPostPayableStatementEntity.IsRemoved = chkIsRemoved.Checked;


            return aCCPostPayableStatementEntity;
        }

        private void SaveACCPostPayableStatementEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACCPostPayableStatementEntity aCCPostPayableStatementEntity = BuildACCPostPayableStatementEntity();

                    Int64 result = -1;

                    if (aCCPostPayableStatementEntity.IsNew)
                    {
                        result = FCCACCPostPayableStatement.GetFacadeCreate().Add(aCCPostPayableStatementEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementEntity.FLD_NAME_PostPayableStatementID, aCCPostPayableStatementEntity.PostPayableStatementID.ToString(), SQLMatchType.Equal);
                        result = FCCACCPostPayableStatement.GetFacadeCreate().Update(aCCPostPayableStatementEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PostPayableStatementID = 0;
                        _ACCPostPayableStatementEntity = new ACCPostPayableStatementEntity();
                        PrepareInitialView();
                        BindACCPostPayableStatementList();

                        if (aCCPostPayableStatementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCPost Payable Statement Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCPost Payable Statement Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCCPostPayableStatementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CCPost Payable Statement Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CCPost Payable Statement Information.", false);
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

        protected void lvACCPostPayableStatement_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPostPayableStatementEntity ent = (ACCPostPayableStatementEntity)dataItem.DataItem;

                LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                if (ent.PrePayableStatementID == MasterDataConstants.ACCPayableDefault.ACC_POST_PAYABLE_STATEMENT_DEFAULT)
                {
                    lnkBtnEdit.Visible = false;
                    lnkBtnDelete.Visible = false;
                }

                HyperLink hypPayableRef = (HyperLink)e.Item.FindControl("hypPayableRef");
                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.POST_PAYABLE_REPORT, UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID, ent.PostPayableStatementID.ToString()).ToString();
                hypPayableRef.NavigateUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPostPayableStatementDetail.aspx", string.Empty, UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID, ent.PostPayableStatementID.ToString()).ToString();

                hypReport.Target = "_blank";
            }
        }

        protected void lvACCPostPayableStatement_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PostPayableStatementID;

            Int64.TryParse(e.CommandArgument.ToString(), out PostPayableStatementID);

            if (PostPayableStatementID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PostPayableStatementID = PostPayableStatementID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementEntity.FLD_NAME_PostPayableStatementID, PostPayableStatementID.ToString(), SQLMatchType.Equal);

                        ACCPostPayableStatementEntity aCCPostPayableStatementEntity = new ACCPostPayableStatementEntity();


                        result = FCCACCPostPayableStatement.GetFacadeCreate().Delete(aCCPostPayableStatementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PostPayableStatementID = 0;
                            _ACCPostPayableStatementEntity = new ACCPostPayableStatementEntity();
                            PrepareInitialView();
                            BindACCPostPayableStatementList();

                            MiscUtil.ShowMessage(lblMessage, "Payable Statement has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payable Statement.", true);
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

        protected void odsACCPostPayableStatement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACCPostPayableStatementEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PostPayableStatementID = 0;
            _ACCPostPayableStatementEntity = new ACCPostPayableStatementEntity();
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
