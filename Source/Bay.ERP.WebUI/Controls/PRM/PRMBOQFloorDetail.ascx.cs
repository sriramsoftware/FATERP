// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 01:00:46




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
    public partial class PRMBOQFloorDetailControl : BaseControl
    {       
        #region Properties

        public Int64 _BOQFloorDetailID
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

        public PRMBOQFloorDetailEntity _PRMBOQFloorDetailEntity
        {
            get
            {
                PRMBOQFloorDetailEntity entity = new PRMBOQFloorDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMBOQFloorDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMBOQFloorDetailEntity CurrentPRMBOQFloorDetailEntity
        {
            get
            {
                if (_BOQFloorDetailID > 0)
                {
                    if (_PRMBOQFloorDetailEntity.BOQFloorDetailID != _BOQFloorDetailID)
                    {
                        _PRMBOQFloorDetailEntity = FCCPRMBOQFloorDetail.GetFacadeCreate().GetByID(_BOQFloorDetailID);
                    }
                }

                return _PRMBOQFloorDetailEntity;
            }
            set
            {
                _PRMBOQFloorDetailEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulatePRMBOQDetail(ddlBOQDetailID, false);
            MiscUtil.PopulateBDProjectFloor(ddlProjectFloorID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtQty.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtEntryDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity = CurrentPRMBOQFloorDetailEntity;


            if (!pRMBOQFloorDetailEntity.IsNew)
            {
                if (ddlBOQDetailID.Items.Count > 0 && pRMBOQFloorDetailEntity.BOQDetailID != null)
                {
                    ddlBOQDetailID.SelectedValue = pRMBOQFloorDetailEntity.BOQDetailID.ToString();
                }

                if (ddlProjectFloorID.Items.Count > 0 && pRMBOQFloorDetailEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = pRMBOQFloorDetailEntity.ProjectFloorID.ToString();
                }

                txtQty.Text = pRMBOQFloorDetailEntity.Qty.ToString();
                txtRemarks.Text = pRMBOQFloorDetailEntity.Remarks.ToString();
                txtEntryDate.Text = pRMBOQFloorDetailEntity.EntryDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMBOQFloorDetailList();
        }

        private void BindPRMBOQFloorDetailList()
        {
            lvPRMBOQFloorDetail.DataBind();
        }

        private PRMBOQFloorDetailEntity BuildPRMBOQFloorDetailEntity()
        {
            PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity = CurrentPRMBOQFloorDetailEntity;

            if (ddlBOQDetailID.Items.Count > 0)
            {
                if (ddlBOQDetailID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMBOQFloorDetailEntity.BOQDetailID = Int64.Parse(ddlBOQDetailID.SelectedValue);
                }
            }

            if (ddlProjectFloorID.Items.Count > 0)
            {
                if (ddlProjectFloorID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMBOQFloorDetailEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                }
            }

            if (!txtQty.Text.Trim().IsNullOrEmpty())
            {
                pRMBOQFloorDetailEntity.Qty = Decimal.Parse(txtQty.Text.Trim());
            }
            else
            {
                pRMBOQFloorDetailEntity.Qty = null;
            }

            pRMBOQFloorDetailEntity.Remarks = txtRemarks.Text.Trim();
            if (txtEntryDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMBOQFloorDetailEntity.EntryDate = MiscUtil.ParseToDateTime(txtEntryDate.Text);
            }


            return pRMBOQFloorDetailEntity;
        }

        private void SavePRMBOQFloorDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity = BuildPRMBOQFloorDetailEntity();

                    Int64 result = -1;

                    if (pRMBOQFloorDetailEntity.IsNew)
                    {
                        result = FCCPRMBOQFloorDetail.GetFacadeCreate().Add(pRMBOQFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID, pRMBOQFloorDetailEntity.BOQFloorDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMBOQFloorDetail.GetFacadeCreate().Update(pRMBOQFloorDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BOQFloorDetailID = 0;
                        _PRMBOQFloorDetailEntity = new PRMBOQFloorDetailEntity();
                        PrepareInitialView();
                        BindPRMBOQFloorDetailList();

                        if (pRMBOQFloorDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Cost Floor Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Cost Floor Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMBOQFloorDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Cost Floor Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Cost Floor Detail Information.", false);
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

        protected void lvPRMBOQFloorDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BOQFloorDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out BOQFloorDetailID);

            if (BOQFloorDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BOQFloorDetailID = BOQFloorDetailID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID, BOQFloorDetailID.ToString(), SQLMatchType.Equal);

                        PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity = new PRMBOQFloorDetailEntity();


                        result = FCCPRMBOQFloorDetail.GetFacadeCreate().Delete(pRMBOQFloorDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BOQFloorDetailID = 0;
                            _PRMBOQFloorDetailEntity = new PRMBOQFloorDetailEntity();
                            PrepareInitialView();
                            BindPRMBOQFloorDetailList();

                            MiscUtil.ShowMessage(lblMessage, "Project Cost Floor Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Cost Floor Detail.", true);
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

        protected void odsPRMBOQFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMBOQFloorDetailEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BOQFloorDetailID = 0;
            _PRMBOQFloorDetailEntity = new PRMBOQFloorDetailEntity();
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
