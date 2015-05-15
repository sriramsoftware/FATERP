// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMMDCustomerAddressTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _CustomerAddressTypeID
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

        public CRMMDCustomerAddressTypeEntity _CRMMDCustomerAddressTypeEntity
        {
            get
            {
                CRMMDCustomerAddressTypeEntity entity = new CRMMDCustomerAddressTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDCustomerAddressTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDCustomerAddressTypeEntity CurrentCRMMDCustomerAddressTypeEntity
        {
            get
            {
                if (_CustomerAddressTypeID > 0)
                {
                    if (_CRMMDCustomerAddressTypeEntity.CustomerAddressTypeID != _CustomerAddressTypeID)
                    {
                        _CRMMDCustomerAddressTypeEntity = FCCCRMMDCustomerAddressType.GetFacadeCreate().GetByID(_CustomerAddressTypeID);
                    }
                }

                return _CRMMDCustomerAddressTypeEntity;
            }
            set
            {
                _CRMMDCustomerAddressTypeEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity = CurrentCRMMDCustomerAddressTypeEntity;


            if (!cRMMDCustomerAddressTypeEntity.IsNew)
            {
                txtName.Text = cRMMDCustomerAddressTypeEntity.Name.ToString();
                txtDescription.Text = cRMMDCustomerAddressTypeEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDCustomerAddressTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDCustomerAddressTypeList();
        }

        private void BindCRMMDCustomerAddressTypeList()
        {
            lvCRMMDCustomerAddressType.DataBind();
        }

        private CRMMDCustomerAddressTypeEntity BuildCRMMDCustomerAddressTypeEntity()
        {
            CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity = CurrentCRMMDCustomerAddressTypeEntity;

            cRMMDCustomerAddressTypeEntity.Name = txtName.Text.Trim();
            cRMMDCustomerAddressTypeEntity.Description = txtDescription.Text.Trim();
            cRMMDCustomerAddressTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDCustomerAddressTypeEntity;
        }

        private void SaveCRMMDCustomerAddressTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity = BuildCRMMDCustomerAddressTypeEntity();

                    Int64 result = -1;

                    if (cRMMDCustomerAddressTypeEntity.IsNew)
                    {
                        result = FCCCRMMDCustomerAddressType.GetFacadeCreate().Add(cRMMDCustomerAddressTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCustomerAddressTypeEntity.FLD_NAME_CustomerAddressTypeID, cRMMDCustomerAddressTypeEntity.CustomerAddressTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDCustomerAddressType.GetFacadeCreate().Update(cRMMDCustomerAddressTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CustomerAddressTypeID = 0;
                        _CRMMDCustomerAddressTypeEntity = new CRMMDCustomerAddressTypeEntity();
                        PrepareInitialView();
                        BindCRMMDCustomerAddressTypeList();

                        if (cRMMDCustomerAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Address Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Address Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDCustomerAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMCustomer Address Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMCustomer Address Type Information.", false);
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

        protected void lvCRMMDCustomerAddressType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CustomerAddressTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out CustomerAddressTypeID);

            if (CustomerAddressTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CustomerAddressTypeID = CustomerAddressTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCustomerAddressTypeEntity.FLD_NAME_CustomerAddressTypeID, CustomerAddressTypeID.ToString(), SQLMatchType.Equal);

                        CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity = new CRMMDCustomerAddressTypeEntity();


                        result = FCCCRMMDCustomerAddressType.GetFacadeCreate().Delete(cRMMDCustomerAddressTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CustomerAddressTypeID = 0;
                            _CRMMDCustomerAddressTypeEntity = new CRMMDCustomerAddressTypeEntity();
                            PrepareInitialView();
                            BindCRMMDCustomerAddressTypeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Address Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMCustomer Address Type.", true);
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

        protected void odsCRMMDCustomerAddressType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDCustomerAddressTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CustomerAddressTypeID = 0;
            _CRMMDCustomerAddressTypeEntity = new CRMMDCustomerAddressTypeEntity();
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
