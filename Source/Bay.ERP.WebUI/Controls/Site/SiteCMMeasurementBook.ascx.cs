// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 04:24:33




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
    public partial class SiteCMMeasurementBookControl : BaseControl
    {       
        #region Properties

        public Int64 _MeasurementBookID
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

        public CMMeasurementBookEntity _CMMeasurementBookEntity
        {
            get
            {
                CMMeasurementBookEntity entity = new CMMeasurementBookEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMMeasurementBookEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMMeasurementBookEntity CurrentCMMeasurementBookEntity
        {
            get
            {
                if (_MeasurementBookID > 0)
                {
                    if (_CMMeasurementBookEntity.MeasurementBookID != _MeasurementBookID)
                    {
                        _CMMeasurementBookEntity = FCCCMMeasurementBook.GetFacadeCreate().GetByID(_MeasurementBookID);
                    }
                }

                return _CMMeasurementBookEntity;
            }
            set
            {
                _CMMeasurementBookEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, false);
            MiscUtil.PopulatePRMWorkOrder(ddlWorkOrderID, true);
            MiscUtil.PopulateMDItem(ddlItemID, false);

            BuildProjectCodeByProjectID();
        }

        private void BuildProjectCodeByProjectID()
        {
            if (ddlProjectID != null && ddlProjectID.SelectedValue != "0")
            {
                BDProjectEntity lstProject = FCCBDProject.GetFacadeCreate().GetByID(Int64.Parse(ddlProjectID.SelectedValue.ToString()));
                txtProjectCode.Text = lstProject.ProjectCode.ToString();
                MiscUtil.PopulateCMBillByProject(ddlBillID,true,Int64.Parse(ddlProjectID.SelectedValue.ToString()));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        
            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMMeasurementBookEntity cMMeasurementBookEntity = CurrentCMMeasurementBookEntity;


            if (!cMMeasurementBookEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && cMMeasurementBookEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cMMeasurementBookEntity.ProjectID.ToString();
                }

                txtProjectCode.Text = cMMeasurementBookEntity.ProjectCode.ToString();

                if (ddlSupplierID.Items.Count > 0 && cMMeasurementBookEntity.ReferenceID != null)
                {
                    ddlSupplierID.SelectedValue = cMMeasurementBookEntity.ReferenceID.ToString();
                }
                if (ddlBillID.Items.Count > 0 && cMMeasurementBookEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = cMMeasurementBookEntity.BillID.ToString();
                }
                else
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlWorkOrderID.Items.Count > 0 && cMMeasurementBookEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = cMMeasurementBookEntity.WorkOrderID.ToString();
                }
                else
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                if (ddlItemID.Items.Count > 0 && cMMeasurementBookEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = cMMeasurementBookEntity.ItemID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMMeasurementBookList();
        }

        private void BindCMMeasurementBookList()
        {
            lvCMMeasurementBook.DataBind();
        }

        private CMMeasurementBookEntity BuildCMMeasurementBookEntity()
        {
            CMMeasurementBookEntity cMMeasurementBookEntity = CurrentCMMeasurementBookEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cMMeasurementBookEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            cMMeasurementBookEntity.ProjectCode = txtProjectCode.Text.Trim();
            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    cMMeasurementBookEntity.ReferenceID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlBillID.Items.Count > 0)
            {
                if (ddlBillID.SelectedValue == "0")
                {
                    cMMeasurementBookEntity.BillID = null;
                }
                else
                {
                    cMMeasurementBookEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                }
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
                    cMMeasurementBookEntity.WorkOrderID = null;
                }
                else
                {
                    cMMeasurementBookEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                }
            }

            if (ddlItemID.Items.Count > 0)
            {
                if (ddlItemID.SelectedValue == "0")
                {
                }
                else
                {
                    cMMeasurementBookEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                }
            }

            cMMeasurementBookEntity.CreateDate = MiscUtil.ParseToDateTime(System.DateTime.Now.ToStringDefault());

            return cMMeasurementBookEntity;
        }

        private void SaveCMMeasurementBookEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMMeasurementBookEntity cMMeasurementBookEntity = BuildCMMeasurementBookEntity();

                    Int64 result = -1;

                    if (cMMeasurementBookEntity.IsNew)
                    {
                        result = FCCCMMeasurementBook.GetFacadeCreate().Add(cMMeasurementBookEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookEntity.FLD_NAME_MeasurementBookID, cMMeasurementBookEntity.MeasurementBookID.ToString(), SQLMatchType.Equal);
                        result = FCCCMMeasurementBook.GetFacadeCreate().Update(cMMeasurementBookEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MeasurementBookID = 0;
                        _CMMeasurementBookEntity = new CMMeasurementBookEntity();
                        PrepareInitialView();
                        BindCMMeasurementBookList();

                        if (cMMeasurementBookEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MMeasurement Book Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MMeasurement Book Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMMeasurementBookEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Measurement Book Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Measurement Book Information.", false);
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

        protected void lvCMMeasurementBook_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMMeasurementBook_DetailedEntity ent = (CMMeasurementBook_DetailedEntity)dataItem.DataItem;
                HyperLink hypItem = (HyperLink)e.Item.FindControl("hypItem");

                hypItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/Site/SiteCMMeasurementBookDetail.aspx", string.Empty, UrlConstants.OVERVIEW_CM_MEASUREMENT_BOOK_ID, ent.MeasurementBookID.ToString(),UrlConstants.OVERVIEW_CM_BILL_NO,ent.BillNo,UrlConstants.OVERVIEW_PRM_WORK_ORDER_NO,ent.WorkOrderNo,UrlConstants.OVERVIEW_MD_ITEM_NAME,ent.ItemName).ToString();
                hypItem.Target = "_blank";
            }
        }

        protected void lvCMMeasurementBook_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MeasurementBookID;

            Int64.TryParse(e.CommandArgument.ToString(), out MeasurementBookID);

            if (MeasurementBookID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MeasurementBookID = MeasurementBookID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookEntity.FLD_NAME_MeasurementBookID, MeasurementBookID.ToString(), SQLMatchType.Equal);

                        CMMeasurementBookEntity cMMeasurementBookEntity = new CMMeasurementBookEntity();


                        result = FCCCMMeasurementBook.GetFacadeCreate().Delete(cMMeasurementBookEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MeasurementBookID = 0;
                            _CMMeasurementBookEntity = new CMMeasurementBookEntity();
                            PrepareInitialView();
                            BindCMMeasurementBookList();

                            MiscUtil.ShowMessage(lblMessage, "C MMeasurement Book has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MMeasurement Book.", true);
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

        protected void odsCMMeasurementBook_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMMeasurementBookEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MeasurementBookID = 0;
            _CMMeasurementBookEntity = new CMMeasurementBookEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Drop down Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectCodeByProjectID();
        }

        #endregion

        #endregion Event

    }
}
