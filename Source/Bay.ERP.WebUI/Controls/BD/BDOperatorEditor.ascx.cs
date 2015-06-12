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
    public partial class BDOperatorEditorControl : OperatorBaseControl
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
                if (this.OverviewOperatorID > 0)
                {
                        _BDOperatorEntity = FCCBDOperator.GetFacadeCreate().GetByID(this.OverviewOperatorID);
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
            bDOperatorEntity.CreateDate = System.DateTime.Now ;

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
