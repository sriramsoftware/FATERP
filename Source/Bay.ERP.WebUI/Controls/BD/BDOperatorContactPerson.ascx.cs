// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




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
    public partial class BDOperatorContactPersonControl : OperatorBaseControl
    {       
        #region Properties

        public Int64 _OperatorContactPersonID
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

        public BDOperatorContactPersonEntity _BDOperatorContactPersonEntity
        {
            get
            {
                BDOperatorContactPersonEntity entity = new BDOperatorContactPersonEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDOperatorContactPersonEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDOperatorContactPersonEntity CurrentBDOperatorContactPersonEntity
        {
            get
            {
                if (OverviewOperatorID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorContactPersonEntity.FLD_NAME_OperatorID, this.OverviewOperatorID.ToString(), SQLMatchType.Equal);
                    IList<BDOperatorContactPersonEntity> BDOperatorContactPersonList = FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDOperatorContactPersonList != null && BDOperatorContactPersonList.Count > 0)
                    {
                        _BDOperatorContactPersonEntity = BDOperatorContactPersonList[0];
                    }
                    else
                    {
                        _BDOperatorContactPersonEntity = new BDOperatorContactPersonEntity();
                    }
                }

                //return _BDProjectAdditionalInfoEntity;


                //if (OverviewOperatorID > 0)
                //{

                //    _BDOperatorContactPersonEntity = FCCBDOperatorContactPerson.GetFacadeCreate().GetByID(_OperatorContactPersonID);

                //}

                return _BDOperatorContactPersonEntity;
            }
            set
            {
                _BDOperatorContactPersonEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDOperator(ddlOperatorID, false);
            MiscUtil.PopulateMDZone(ddlZoneID, false);
            //MiscUtil.PopulateMDZoneDesignation(ddlZoneDesignationID, true);
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

            txtName.Text = String.Empty;
            txtID.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtWebLink.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDOperatorContactPersonEntity bDOperatorContactPersonEntity = CurrentBDOperatorContactPersonEntity;


            if (!bDOperatorContactPersonEntity.IsNew)
            {
                if (ddlOperatorID.Items.Count > 0 && bDOperatorContactPersonEntity.OperatorID != null)
                {
                    ddlOperatorID.SelectedValue = bDOperatorContactPersonEntity.OperatorID.ToString();
                }

                if (ddlZoneID.Items.Count > 0 && bDOperatorContactPersonEntity.ZoneID != null)
                {
                    ddlZoneID.SelectedValue = bDOperatorContactPersonEntity.ZoneID.ToString();
                }

                txtName.Text = bDOperatorContactPersonEntity.Name.ToString();
                if (ddlZoneDesignationID.Items.Count > 0 && bDOperatorContactPersonEntity.ZoneDesignationID != null)
                {
                    ddlZoneDesignationID.SelectedValue = bDOperatorContactPersonEntity.ZoneDesignationID.ToString();
                }

                txtID.Text = bDOperatorContactPersonEntity.ID.ToString();
                txtPhone.Text = bDOperatorContactPersonEntity.Phone.ToString();
                txtMobileNo.Text = bDOperatorContactPersonEntity.MobileNo.ToString();
                txtFax.Text = bDOperatorContactPersonEntity.Fax.ToString();
                txtEmail.Text = bDOperatorContactPersonEntity.Email.ToString();
                txtWebLink.Text = bDOperatorContactPersonEntity.WebLink.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDOperatorContactPersonList();
        }

        private void BindBDOperatorContactPersonList()
        {
            lvBDOperatorContactPerson.DataBind();
        }

        private BDOperatorContactPersonEntity BuildBDOperatorContactPersonEntity()
        {
            BDOperatorContactPersonEntity bDOperatorContactPersonEntity = CurrentBDOperatorContactPersonEntity;

            if (ddlOperatorID.Items.Count > 0)
            {
                if (ddlOperatorID.SelectedValue == "0")
                {
                }
                else
                {
                    bDOperatorContactPersonEntity.OperatorID = Int64.Parse(ddlOperatorID.SelectedValue);
                }
            }

            if (ddlZoneID.Items.Count > 0)
            {
                if (ddlZoneID.SelectedValue == "0")
                {
                }
                else
                {
                    bDOperatorContactPersonEntity.ZoneID = Int64.Parse(ddlZoneID.SelectedValue);
                }
            }

            bDOperatorContactPersonEntity.Name = txtName.Text.Trim();
            if (ddlZoneDesignationID.Items.Count > 0)
            {
                if (ddlZoneDesignationID.SelectedValue == "0")
                {
                    bDOperatorContactPersonEntity.ZoneDesignationID = null;
                }
                else
                {
                    bDOperatorContactPersonEntity.ZoneDesignationID = Int64.Parse(ddlZoneDesignationID.SelectedValue);
                }
            }

            bDOperatorContactPersonEntity.ID = txtID.Text.Trim();
            bDOperatorContactPersonEntity.Phone = txtPhone.Text.Trim();
            bDOperatorContactPersonEntity.MobileNo = txtMobileNo.Text.Trim();
            bDOperatorContactPersonEntity.Fax = txtFax.Text.Trim();
            bDOperatorContactPersonEntity.Email = txtEmail.Text.Trim();
            bDOperatorContactPersonEntity.WebLink = txtWebLink.Text.Trim();

            return bDOperatorContactPersonEntity;
        }

        private void SaveBDOperatorContactPersonEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDOperatorContactPersonEntity bDOperatorContactPersonEntity = BuildBDOperatorContactPersonEntity();

                    Int64 result = -1;

                    if (bDOperatorContactPersonEntity.IsNew)
                    {
                        result = FCCBDOperatorContactPerson.GetFacadeCreate().Add(bDOperatorContactPersonEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorContactPersonEntity.FLD_NAME_OperatorContactPersonID, bDOperatorContactPersonEntity.OperatorContactPersonID.ToString(), SQLMatchType.Equal);
                        result = FCCBDOperatorContactPerson.GetFacadeCreate().Update(bDOperatorContactPersonEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OperatorContactPersonID = 0;
                        _BDOperatorContactPersonEntity = new BDOperatorContactPersonEntity();
                        PrepareInitialView();
                        BindBDOperatorContactPersonList();

                        if (bDOperatorContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Contact Person Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Contact Person Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDOperatorContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Operator Contact Person Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Operator Contact Person Information.", false);
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

        protected void lvBDOperatorContactPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OperatorContactPersonID;

            Int64.TryParse(e.CommandArgument.ToString(), out OperatorContactPersonID);

            if (OperatorContactPersonID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OperatorContactPersonID = OperatorContactPersonID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorContactPersonEntity.FLD_NAME_OperatorContactPersonID, OperatorContactPersonID.ToString(), SQLMatchType.Equal);

                        BDOperatorContactPersonEntity bDOperatorContactPersonEntity = new BDOperatorContactPersonEntity();


                        result = FCCBDOperatorContactPerson.GetFacadeCreate().Delete(bDOperatorContactPersonEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OperatorContactPersonID = 0;
                            _BDOperatorContactPersonEntity = new BDOperatorContactPersonEntity();
                            PrepareInitialView();
                            BindBDOperatorContactPersonList();

                            MiscUtil.ShowMessage(lblMessage, "Operator Contact Person has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Operator Contact Person.", true);
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

        protected void odsBDOperatorContactPerson_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorContactPersonEntity.FLD_NAME_OperatorID, this.OverviewOperatorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDOperatorContactPersonEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OperatorContactPersonID = 0;
            _BDOperatorContactPersonEntity = new BDOperatorContactPersonEntity();
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
