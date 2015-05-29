// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 10:46:54




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
    public partial class MDOperatorAddressTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _OperatorAddressTypeID
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

        public MDOperatorAddressTypeEntity _MDOperatorAddressTypeEntity
        {
            get
            {
                MDOperatorAddressTypeEntity entity = new MDOperatorAddressTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDOperatorAddressTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDOperatorAddressTypeEntity CurrentMDOperatorAddressTypeEntity
        {
            get
            {
                if (_OperatorAddressTypeID > 0)
                {
                    if (_MDOperatorAddressTypeEntity.OperatorAddressTypeID != _OperatorAddressTypeID)
                    {
                        _MDOperatorAddressTypeEntity = FCCMDOperatorAddressType.GetFacadeCreate().GetByID(_OperatorAddressTypeID);
                    }
                }

                return _MDOperatorAddressTypeEntity;
            }
            set
            {
                _MDOperatorAddressTypeEntity = value;
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

            txtOperatorAddressTypeID.Text = String.Empty;
            txtName.Text = String.Empty;
            txtDescripton.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity = CurrentMDOperatorAddressTypeEntity;


            if (!mDOperatorAddressTypeEntity.IsNew)
            {
                txtOperatorAddressTypeID.Text = mDOperatorAddressTypeEntity.OperatorAddressTypeID.ToString();
                txtName.Text = mDOperatorAddressTypeEntity.Name.ToString();
                txtDescripton.Text = mDOperatorAddressTypeEntity.Descripton.ToString();
                chkIsRemoved.Checked = mDOperatorAddressTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDOperatorAddressTypeList();
        }

        private void BindMDOperatorAddressTypeList()
        {
            lvMDOperatorAddressType.DataBind();
        }

        private MDOperatorAddressTypeEntity BuildMDOperatorAddressTypeEntity()
        {
            MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity = CurrentMDOperatorAddressTypeEntity;

            if (!txtOperatorAddressTypeID.Text.Trim().IsNullOrEmpty())
            {
                mDOperatorAddressTypeEntity.OperatorAddressTypeID = Int64.Parse(txtOperatorAddressTypeID.Text.Trim());
            }

            mDOperatorAddressTypeEntity.Name = txtName.Text.Trim();
            mDOperatorAddressTypeEntity.Descripton = txtDescripton.Text.Trim();
            mDOperatorAddressTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDOperatorAddressTypeEntity;
        }

        private void SaveMDOperatorAddressTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity = BuildMDOperatorAddressTypeEntity();

                    Int64 result = -1;

                    if (mDOperatorAddressTypeEntity.IsNew)
                    {
                        result = FCCMDOperatorAddressType.GetFacadeCreate().Add(mDOperatorAddressTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDOperatorAddressTypeEntity.FLD_NAME_OperatorAddressTypeID, mDOperatorAddressTypeEntity.OperatorAddressTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDOperatorAddressType.GetFacadeCreate().Update(mDOperatorAddressTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OperatorAddressTypeID = 0;
                        _MDOperatorAddressTypeEntity = new MDOperatorAddressTypeEntity();
                        PrepareInitialView();
                        BindMDOperatorAddressTypeList();

                        if (mDOperatorAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Address Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Address Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDOperatorAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Operator Address Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Operator Address Type Information.", false);
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

        protected void lvMDOperatorAddressType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OperatorAddressTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out OperatorAddressTypeID);

            if (OperatorAddressTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OperatorAddressTypeID = OperatorAddressTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDOperatorAddressTypeEntity.FLD_NAME_OperatorAddressTypeID, OperatorAddressTypeID.ToString(), SQLMatchType.Equal);

                        MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity = new MDOperatorAddressTypeEntity();


                        result = FCCMDOperatorAddressType.GetFacadeCreate().Delete(mDOperatorAddressTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OperatorAddressTypeID = 0;
                            _MDOperatorAddressTypeEntity = new MDOperatorAddressTypeEntity();
                            PrepareInitialView();
                            BindMDOperatorAddressTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Operator Address Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Operator Address Type.", true);
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

        protected void odsMDOperatorAddressType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDOperatorAddressTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OperatorAddressTypeID = 0;
            _MDOperatorAddressTypeEntity = new MDOperatorAddressTypeEntity();
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
