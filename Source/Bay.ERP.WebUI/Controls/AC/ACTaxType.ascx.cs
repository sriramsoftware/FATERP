// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    public partial class ACTaxTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _TaxTypeID
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

        public ACTaxTypeEntity _ACTaxTypeEntity
        {
            get
            {
                ACTaxTypeEntity entity = new ACTaxTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTaxTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTaxTypeEntity CurrentACTaxTypeEntity
        {
            get
            {
                if (_TaxTypeID > 0)
                {
                    if (_ACTaxTypeEntity.TaxTypeID != _TaxTypeID)
                    {
                        _ACTaxTypeEntity = FCCACTaxType.GetFacadeCreate().GetByID(_TaxTypeID);
                    }
                }

                return _ACTaxTypeEntity;
            }
            set
            {
                _ACTaxTypeEntity = value;
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

            txtName.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACTaxTypeEntity aCTaxTypeEntity = CurrentACTaxTypeEntity;


            if (!aCTaxTypeEntity.IsNew)
            {
                txtName.Text = aCTaxTypeEntity.Name.ToString();
                txtRate.Text = aCTaxTypeEntity.Rate.ToString();
                txtDescription.Text = aCTaxTypeEntity.Description.ToString();
                chkIsRemoved.Checked = aCTaxTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACTaxTypeList();
        }

        private void BindACTaxTypeList()
        {
            lvACTaxType.DataBind();
        }

        private ACTaxTypeEntity BuildACTaxTypeEntity()
        {
            ACTaxTypeEntity aCTaxTypeEntity = CurrentACTaxTypeEntity;

            aCTaxTypeEntity.Name = txtName.Text.Trim();
            if (!txtRate.Text.Trim().IsNullOrEmpty())
            {
                aCTaxTypeEntity.Rate = Decimal.Parse(txtRate.Text.Trim());
            }

            aCTaxTypeEntity.Description = txtDescription.Text.Trim();
            aCTaxTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return aCTaxTypeEntity;
        }

        private void SaveACTaxTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACTaxTypeEntity aCTaxTypeEntity = BuildACTaxTypeEntity();

                    Int64 result = -1;

                    if (aCTaxTypeEntity.IsNew)
                    {
                        result = FCCACTaxType.GetFacadeCreate().Add(aCTaxTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACTaxTypeEntity.FLD_NAME_TaxTypeID, aCTaxTypeEntity.TaxTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCACTaxType.GetFacadeCreate().Update(aCTaxTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TaxTypeID = 0;
                        _ACTaxTypeEntity = new ACTaxTypeEntity();
                        PrepareInitialView();
                        BindACTaxTypeList();

                        if (aCTaxTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTax Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTax Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCTaxTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CTax Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CTax Type Information.", false);
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

        protected void lvACTaxType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TaxTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out TaxTypeID);

            if (TaxTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TaxTypeID = TaxTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTaxTypeEntity.FLD_NAME_TaxTypeID, TaxTypeID.ToString(), SQLMatchType.Equal);

                        ACTaxTypeEntity aCTaxTypeEntity = new ACTaxTypeEntity();


                        result = FCCACTaxType.GetFacadeCreate().Delete(aCTaxTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TaxTypeID = 0;
                            _ACTaxTypeEntity = new ACTaxTypeEntity();
                            PrepareInitialView();
                            BindACTaxTypeList();

                            MiscUtil.ShowMessage(lblMessage, "A CTax Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CTax Type.", true);
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

        protected void odsACTaxType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACTaxTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TaxTypeID = 0;
            _ACTaxTypeEntity = new ACTaxTypeEntity();
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
