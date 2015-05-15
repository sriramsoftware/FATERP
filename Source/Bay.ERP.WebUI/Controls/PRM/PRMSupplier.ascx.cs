// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    public partial class PRMSupplierControl : SupplierBaseControl
    {       
        #region Properties

        public Int64 _SupplierID
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

        public PRMSupplierEntity _PRMSupplierEntity
        {
            get
            {
                PRMSupplierEntity entity = new PRMSupplierEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierEntity CurrentPRMSupplierEntity
        {
            get
            {
                if (_SupplierID > 0)
                {
                    if (_PRMSupplierEntity.SupplierID != _SupplierID)
                    {
                        _PRMSupplierEntity = FCCPRMSupplier.GetFacadeCreate().GetByID(_SupplierID);
                    }
                }

                return _PRMSupplierEntity;
            }
            set
            {
                _PRMSupplierEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDSupplierType(ddlSupplierTypeID, false);
            MiscUtil.PopulateMDSupplierStatus(ddlSupplierStatusID, false);
        }

        private void PrepareValidator()
        {
            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revFax.ValidationExpression = ValidationConstants.RegularExpression.FaxNo;
            revFax.ErrorMessage = ValidationConstants.ErrorMessage.FaxNo;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revWebLink.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebLink.ErrorMessage = ValidationConstants.ErrorMessage.Web;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtSupplierCode.Text = String.Empty;
            txtSupplierName.Text = String.Empty;
            txtRelationship.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtWebLink.Text = String.Empty;
            txtCreateDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtReason.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            txtReason.Visible = false;
            lblReason.Visible = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMSupplierEntity pRMSupplierEntity = CurrentPRMSupplierEntity;


            if (!pRMSupplierEntity.IsNew)
            {
                txtSupplierCode.Text = pRMSupplierEntity.SupplierCode.ToString();
                txtSupplierName.Text = pRMSupplierEntity.SupplierName.ToString();
                txtRelationship.Text = pRMSupplierEntity.Relationship.ToString();
                txtPhone.Text = pRMSupplierEntity.Phone.ToString();
                txtMobileNo.Text = pRMSupplierEntity.MobileNo.ToString();
                txtFax.Text = pRMSupplierEntity.Fax.ToString();
                txtEmail.Text = pRMSupplierEntity.Email.ToString();
                txtWebLink.Text = pRMSupplierEntity.WebLink.ToString();
                txtCreateDate.Text = pRMSupplierEntity.CreateDate.ToString(UIConstants.SHORT_DATE_FORMAT);

                if (ddlSupplierTypeID.Items.Count > 0 && pRMSupplierEntity.SupplierTypeID != null)
                {
                    ddlSupplierTypeID.SelectedValue = pRMSupplierEntity.SupplierTypeID.ToString();
                }

                if (ddlSupplierStatusID.Items.Count > 0 && pRMSupplierEntity.SupplierStatusID != null)
                {
                    ddlSupplierStatusID.SelectedValue = pRMSupplierEntity.SupplierStatusID.ToString();
                }

                txtRemarks.Text = pRMSupplierEntity.Remarks.ToString();
                txtReason.Text = pRMSupplierEntity.Reason.ToString();
                chkIsRemoved.Checked = pRMSupplierEntity.IsRemoved;

                BuildSupplierStatus();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMSupplierList();
        }

        private void BindPRMSupplierList()
        {
            lvPRMSupplier.DataBind();
        }

        private PRMSupplierEntity BuildPRMSupplierEntity()
        {
            PRMSupplierEntity pRMSupplierEntity = CurrentPRMSupplierEntity;

            pRMSupplierEntity.SupplierCode = txtSupplierCode.Text.Trim();
            pRMSupplierEntity.SupplierName = txtSupplierName.Text.Trim();
            pRMSupplierEntity.Relationship = txtRelationship.Text.Trim();
            pRMSupplierEntity.Phone = txtPhone.Text.Trim();
            pRMSupplierEntity.MobileNo = txtMobileNo.Text.Trim();
            pRMSupplierEntity.Fax = txtFax.Text.Trim();
            pRMSupplierEntity.Email = txtEmail.Text.Trim();
            pRMSupplierEntity.WebLink = txtWebLink.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMSupplierEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (ddlSupplierTypeID.Items.Count > 0)
            {
                if (ddlSupplierTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMSupplierEntity.SupplierTypeID = Int64.Parse(ddlSupplierTypeID.SelectedValue);
                }
            }

            if (ddlSupplierStatusID.Items.Count > 0)
            {
                if (ddlSupplierStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMSupplierEntity.SupplierStatusID = Int64.Parse(ddlSupplierStatusID.SelectedValue);
                }
            }

            pRMSupplierEntity.Remarks = txtRemarks.Text.Trim();
            pRMSupplierEntity.Reason = txtReason.Text.Trim();
            pRMSupplierEntity.IsRemoved = chkIsRemoved.Checked;

            return pRMSupplierEntity;
        }

        private void SavePRMSupplierEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMSupplierEntity pRMSupplierEntity = BuildPRMSupplierEntity();

                    Int64 result = -1;

                    if (pRMSupplierEntity.IsNew)
                    {
                        result = FCCPRMSupplier.GetFacadeCreate().Add(pRMSupplierEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierEntity.FLD_NAME_SupplierID, pRMSupplierEntity.SupplierID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMSupplier.GetFacadeCreate().Update(pRMSupplierEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        String NavUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierEditor.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, result.ToString()).ToString();

                        Response.Redirect(NavUrl);

                        _SupplierID = 0;
                        _PRMSupplierEntity = new PRMSupplierEntity();
                        PrepareInitialView();
                        BindPRMSupplierList();

                        if (pRMSupplierEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMSupplierEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BuildSupplierStatus()
        {
            if (ddlSupplierStatusID.Text == "2")
            {
                txtReason.Visible = true;
                lblReason.Visible = true;
            }
            else if (ddlSupplierStatusID.Text == "1")
            {
                txtReason.Text = null;
                txtReason.Visible = false;
                lblReason.Visible = false;
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

        protected void lvPRMSupplier_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMSupplier_DetailedEntity ent = (PRMSupplier_DetailedEntity)dataItem.DataItem;

                HyperLink hypSupplier = (HyperLink)e.Item.FindControl("hypSupplier");

                hypSupplier.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierEditor.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, ent.SupplierID.ToString()).ToString();
                hypSupplier.Target = "_blank";
            }
        }

        protected void lvPRMSupplier_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierID);

            if (SupplierID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierID = SupplierID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierEntity.FLD_NAME_SupplierID, SupplierID.ToString(), SQLMatchType.Equal);

                        PRMSupplierEntity pRMSupplierEntity = new PRMSupplierEntity();


                        result = FCCPRMSupplier.GetFacadeCreate().Delete(pRMSupplierEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierID = 0;
                            _PRMSupplierEntity = new PRMSupplierEntity();
                            PrepareInitialView();
                            BindPRMSupplierList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor.", true);
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

        protected void odsPRMSupplier_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMSupplierEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierID = 0;
            _PRMSupplierEntity = new PRMSupplierEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlSupplierStatusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildSupplierStatus();
        }

        #endregion

        #endregion Event
    }
}
