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
    public partial class CRMMDBuyerTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _BuyerTypeID
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

        public CRMMDBuyerTypeEntity _CRMMDBuyerTypeEntity
        {
            get
            {
                CRMMDBuyerTypeEntity entity = new CRMMDBuyerTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDBuyerTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDBuyerTypeEntity CurrentCRMMDBuyerTypeEntity
        {
            get
            {
                if (_BuyerTypeID > 0)
                {
                    if (_CRMMDBuyerTypeEntity.BuyerTypeID != _BuyerTypeID)
                    {
                        _CRMMDBuyerTypeEntity = FCCCRMMDBuyerType.GetFacadeCreate().GetByID(_BuyerTypeID);
                    }
                }

                return _CRMMDBuyerTypeEntity;
            }
            set
            {
                _CRMMDBuyerTypeEntity = value;
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
            CRMMDBuyerTypeEntity cRMMDBuyerTypeEntity = CurrentCRMMDBuyerTypeEntity;


            if (!cRMMDBuyerTypeEntity.IsNew)
            {
                txtName.Text = cRMMDBuyerTypeEntity.Name.ToString();
                txtDescription.Text = cRMMDBuyerTypeEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDBuyerTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDBuyerTypeList();
        }

        private void BindCRMMDBuyerTypeList()
        {
            lvCRMMDBuyerType.DataBind();
        }

        private CRMMDBuyerTypeEntity BuildCRMMDBuyerTypeEntity()
        {
            CRMMDBuyerTypeEntity cRMMDBuyerTypeEntity = CurrentCRMMDBuyerTypeEntity;

            cRMMDBuyerTypeEntity.Name = txtName.Text.Trim();
            cRMMDBuyerTypeEntity.Description = txtDescription.Text.Trim();
            cRMMDBuyerTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDBuyerTypeEntity;
        }

        private void SaveCRMMDBuyerTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDBuyerTypeEntity cRMMDBuyerTypeEntity = BuildCRMMDBuyerTypeEntity();

                    Int64 result = -1;

                    if (cRMMDBuyerTypeEntity.IsNew)
                    {
                        result = FCCCRMMDBuyerType.GetFacadeCreate().Add(cRMMDBuyerTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBuyerTypeEntity.FLD_NAME_BuyerTypeID, cRMMDBuyerTypeEntity.BuyerTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDBuyerType.GetFacadeCreate().Update(cRMMDBuyerTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BuyerTypeID = 0;
                        _CRMMDBuyerTypeEntity = new CRMMDBuyerTypeEntity();
                        PrepareInitialView();
                        BindCRMMDBuyerTypeList();

                        if (cRMMDBuyerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDBuyerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMBuyer Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMBuyer Type Information.", false);
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

        protected void lvCRMMDBuyerType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerTypeID);

            if (BuyerTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerTypeID = BuyerTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBuyerTypeEntity.FLD_NAME_BuyerTypeID, BuyerTypeID.ToString(), SQLMatchType.Equal);

                        CRMMDBuyerTypeEntity cRMMDBuyerTypeEntity = new CRMMDBuyerTypeEntity();


                        result = FCCCRMMDBuyerType.GetFacadeCreate().Delete(cRMMDBuyerTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerTypeID = 0;
                            _CRMMDBuyerTypeEntity = new CRMMDBuyerTypeEntity();
                            PrepareInitialView();
                            BindCRMMDBuyerTypeList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBuyer Type.", true);
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

        protected void odsCRMMDBuyerType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDBuyerTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerTypeID = 0;
            _CRMMDBuyerTypeEntity = new CRMMDBuyerTypeEntity();
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
