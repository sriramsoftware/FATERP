// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 11:33:13




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
    public partial class BDOperatorControl : BaseControl
    {       
        #region Properties

        public Int64 _OperatorID
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

        public BDOperatorEntity _BDOperatorEntity
        {
            get
            {
                BDOperatorEntity entity = new BDOperatorEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDOperatorEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDOperatorEntity CurrentBDOperatorEntity
        {
            get
            {
                if (_OperatorID > 0)
                {
                    if (_BDOperatorEntity.OperatorID != _OperatorID)
                    {
                        _BDOperatorEntity = FCCBDOperator.GetFacadeCreate().GetByID(_OperatorID);
                    }
                }

                return _BDOperatorEntity;
            }
            set
            {
                _BDOperatorEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDOperatorStatus(ddlOperatorStatusID, false);
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

            txtOperatorCode.Text = String.Empty;
            txtOperatorName.Text = String.Empty;
            txtRelationship.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtWebLink.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtReason.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDOperatorEntity bDOperatorEntity = CurrentBDOperatorEntity;


            if (!bDOperatorEntity.IsNew)
            {
                txtOperatorCode.Text = bDOperatorEntity.OperatorCode.ToString();
                txtOperatorName.Text = bDOperatorEntity.OperatorName.ToString();
                txtRelationship.Text = bDOperatorEntity.Relationship.ToString();
                txtPhone.Text = bDOperatorEntity.Phone.ToString();
                txtMobileNo.Text = bDOperatorEntity.MobileNo.ToString();
                txtFax.Text = bDOperatorEntity.Fax.ToString();
                txtEmail.Text = bDOperatorEntity.Email.ToString();
                txtWebLink.Text = bDOperatorEntity.WebLink.ToString();
                txtCreateDate.Text = bDOperatorEntity.CreateDate.ToStringDefault();
                txtRemarks.Text = bDOperatorEntity.Remarks.ToString();
                txtReason.Text = bDOperatorEntity.Reason.ToString();
                if (ddlOperatorStatusID.Items.Count > 0 && bDOperatorEntity.OperatorStatusID != null)
                {
                    ddlOperatorStatusID.SelectedValue = bDOperatorEntity.OperatorStatusID.ToString();
                }

                chkIsRemoved.Checked = bDOperatorEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDOperatorList();
        }

        private void BindBDOperatorList()
        {
            lvBDOperator.DataBind();
        }

        private BDOperatorEntity BuildBDOperatorEntity()
        {
            BDOperatorEntity bDOperatorEntity = CurrentBDOperatorEntity;

            bDOperatorEntity.OperatorCode = txtOperatorCode.Text.Trim();
            bDOperatorEntity.OperatorName = txtOperatorName.Text.Trim();
            bDOperatorEntity.Relationship = txtRelationship.Text.Trim();
            bDOperatorEntity.Phone = txtPhone.Text.Trim();
            bDOperatorEntity.MobileNo = txtMobileNo.Text.Trim();
            bDOperatorEntity.Fax = txtFax.Text.Trim();
            bDOperatorEntity.Email = txtEmail.Text.Trim();
            bDOperatorEntity.WebLink = txtWebLink.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDOperatorEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            bDOperatorEntity.Remarks = txtRemarks.Text.Trim();
            bDOperatorEntity.Reason = txtReason.Text.Trim();
            if (ddlOperatorStatusID.Items.Count > 0)
            {
                if (ddlOperatorStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    bDOperatorEntity.OperatorStatusID = Int64.Parse(ddlOperatorStatusID.SelectedValue);
                }
            }

            bDOperatorEntity.IsRemoved = chkIsRemoved.Checked;


            return bDOperatorEntity;
        }

        private void SaveBDOperatorEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDOperatorEntity bDOperatorEntity = BuildBDOperatorEntity();

                    Int64 result = -1;

                    if (bDOperatorEntity.IsNew)
                    {
                        result = FCCBDOperator.GetFacadeCreate().Add(bDOperatorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorEntity.FLD_NAME_OperatorID, bDOperatorEntity.OperatorID.ToString(), SQLMatchType.Equal);
                        result = FCCBDOperator.GetFacadeCreate().Update(bDOperatorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OperatorID = 0;
                        _BDOperatorEntity = new BDOperatorEntity();
                        PrepareInitialView();
                        BindBDOperatorList();

                        if (bDOperatorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDOperatorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Operator Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Operator Information.", false);
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

        protected void lvBDOperator_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDOperatorEntity ent = (BDOperatorEntity)dataItem.DataItem;

                HyperLink hypOperatorName = (HyperLink)e.Item.FindControl("hypOperatorName");

                hypOperatorName.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_OPERATOR_ID, ent.OperatorID.ToString()).ToString();
                
            }
        }
      

        protected void lvBDOperator_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OperatorID;

            Int64.TryParse(e.CommandArgument.ToString(), out OperatorID);

            if (OperatorID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OperatorID = OperatorID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorEntity.FLD_NAME_OperatorID, OperatorID.ToString(), SQLMatchType.Equal);

                        BDOperatorEntity bDOperatorEntity = new BDOperatorEntity();


                        result = FCCBDOperator.GetFacadeCreate().Delete(bDOperatorEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OperatorID = 0;
                            _BDOperatorEntity = new BDOperatorEntity();
                            PrepareInitialView();
                            BindBDOperatorList();

                            MiscUtil.ShowMessage(lblMessage, "Operator has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Operator.", true);
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

        protected void odsBDOperator_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDOperatorEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OperatorID = 0;
            _BDOperatorEntity = new BDOperatorEntity();
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
