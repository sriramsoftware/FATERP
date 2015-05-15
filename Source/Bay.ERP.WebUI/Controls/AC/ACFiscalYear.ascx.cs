// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public partial class ACFiscalYearControl : BaseControl
    {       
        #region Properties

        public Int64 _FiscalYearID
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

        public ACFiscalYearEntity _ACFiscalYearEntity
        {
            get
            {
                ACFiscalYearEntity entity = new ACFiscalYearEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACFiscalYearEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACFiscalYearEntity CurrentACFiscalYearEntity
        {
            get
            {
                if (_FiscalYearID > 0)
                {
                    if (_ACFiscalYearEntity.FiscalYearID != _FiscalYearID)
                    {
                        _ACFiscalYearEntity = FCCACFiscalYear.GetFacadeCreate().GetByID(_FiscalYearID);
                    }
                }

                return _ACFiscalYearEntity;
            }
            set
            {
                _ACFiscalYearEntity = value;
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
            BuildDropDownList();

            txtBeginDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            chkIsClosed.Checked = false;
            chkIsLocked.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACFiscalYearEntity aCFiscalYearEntity = CurrentACFiscalYearEntity;


            if (!aCFiscalYearEntity.IsNew)
            {
                txtBeginDate.Text = aCFiscalYearEntity.BeginDate.ToStringDefault();
                txtEndDate.Text = aCFiscalYearEntity.EndDate.ToStringDefault();
                chkIsClosed.Checked = aCFiscalYearEntity.IsClosed;
                chkIsLocked.Checked = aCFiscalYearEntity.IsLocked;
                chkIsRemoved.Checked = aCFiscalYearEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACFiscalYearList();
        }

        private void BindACFiscalYearList()
        {
            lvACFiscalYear.DataBind();
        }

        private ACFiscalYearEntity BuildACFiscalYearEntity()
        {
            ACFiscalYearEntity aCFiscalYearEntity = CurrentACFiscalYearEntity;

            if (txtBeginDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCFiscalYearEntity.BeginDate = MiscUtil.ParseToDateTime(txtBeginDate.Text);
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCFiscalYearEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }

            aCFiscalYearEntity.IsClosed = chkIsClosed.Checked;

            aCFiscalYearEntity.IsLocked = chkIsLocked.Checked;

            aCFiscalYearEntity.IsRemoved = chkIsRemoved.Checked;


            return aCFiscalYearEntity;
        }

        private void SaveACFiscalYearEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACFiscalYearEntity aCFiscalYearEntity = BuildACFiscalYearEntity();

                    Int64 result = -1;

                    if (aCFiscalYearEntity.IsNew)
                    {
                        result = FCCACFiscalYear.GetFacadeCreate().Add(aCFiscalYearEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_FiscalYearID, aCFiscalYearEntity.FiscalYearID.ToString(), SQLMatchType.Equal);
                        result = FCCACFiscalYear.GetFacadeCreate().Update(aCFiscalYearEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FiscalYearID = 0;
                        _ACFiscalYearEntity = new ACFiscalYearEntity();
                        PrepareInitialView();
                        BindACFiscalYearList();

                        if (aCFiscalYearEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CFiscal Year Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CFiscal Year Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCFiscalYearEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CFiscal Year Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CFiscal Year Information.", false);
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

        protected void lvACFiscalYear_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACFiscalYearEntity ent = (ACFiscalYearEntity)dataItem.DataItem;

                HyperLink hypLeaveStatusReport = (HyperLink)e.Item.FindControl("hypLeaveStatusReport");
                

                String NavigationUrl = String.Empty;

                hypLeaveStatusReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_LEAVE_STATUS_REPORT, UrlConstants.OVERVIEW_FISCALYEAR_ID, ent.FiscalYearID.ToString()).ToString();
                hypLeaveStatusReport.Target = "_blank";

            }
        }

        protected void lvACFiscalYear_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FiscalYearID;

            Int64.TryParse(e.CommandArgument.ToString(), out FiscalYearID);

            if (FiscalYearID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FiscalYearID = FiscalYearID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_FiscalYearID, FiscalYearID.ToString(), SQLMatchType.Equal);

                        ACFiscalYearEntity aCFiscalYearEntity = new ACFiscalYearEntity();


                        result = FCCACFiscalYear.GetFacadeCreate().Delete(aCFiscalYearEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FiscalYearID = 0;
                            _ACFiscalYearEntity = new ACFiscalYearEntity();
                            PrepareInitialView();
                            BindACFiscalYearList();

                            MiscUtil.ShowMessage(lblMessage, "A CFiscal Year has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CFiscal Year.", true);
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

        protected void odsACFiscalYear_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACFiscalYearEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FiscalYearID = 0;
            _ACFiscalYearEntity = new ACFiscalYearEntity();
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
