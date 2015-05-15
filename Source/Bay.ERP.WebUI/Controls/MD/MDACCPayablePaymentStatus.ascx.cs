// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public partial class MDACCPayablePaymentStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ACCPayablePaymentStatusID
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

        public MDACCPayablePaymentStatusEntity _MDACCPayablePaymentStatusEntity
        {
            get
            {
                MDACCPayablePaymentStatusEntity entity = new MDACCPayablePaymentStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDACCPayablePaymentStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDACCPayablePaymentStatusEntity CurrentMDACCPayablePaymentStatusEntity
        {
            get
            {
                if (_ACCPayablePaymentStatusID > 0)
                {
                    if (_MDACCPayablePaymentStatusEntity.ACCPayablePaymentStatusID != _ACCPayablePaymentStatusID)
                    {
                        _MDACCPayablePaymentStatusEntity = FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetByID(_ACCPayablePaymentStatusID);
                    }
                }

                return _MDACCPayablePaymentStatusEntity;
            }
            set
            {
                _MDACCPayablePaymentStatusEntity = value;
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
            MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity = CurrentMDACCPayablePaymentStatusEntity;


            if (!mDACCPayablePaymentStatusEntity.IsNew)
            {
                txtName.Text = mDACCPayablePaymentStatusEntity.Name.ToString();
                txtDescription.Text = mDACCPayablePaymentStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDACCPayablePaymentStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDACCPayablePaymentStatusList();
        }

        private void BindMDACCPayablePaymentStatusList()
        {
            lvMDACCPayablePaymentStatus.DataBind();
        }

        private MDACCPayablePaymentStatusEntity BuildMDACCPayablePaymentStatusEntity()
        {
            MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity = CurrentMDACCPayablePaymentStatusEntity;

            mDACCPayablePaymentStatusEntity.Name = txtName.Text.Trim();
            mDACCPayablePaymentStatusEntity.Description = txtDescription.Text.Trim();
            mDACCPayablePaymentStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDACCPayablePaymentStatusEntity;
        }

        private void SaveMDACCPayablePaymentStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity = BuildMDACCPayablePaymentStatusEntity();

                    Int64 result = -1;

                    if (mDACCPayablePaymentStatusEntity.IsNew)
                    {
                        result = FCCMDACCPayablePaymentStatus.GetFacadeCreate().Add(mDACCPayablePaymentStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDACCPayablePaymentStatusEntity.FLD_NAME_ACCPayablePaymentStatusID, mDACCPayablePaymentStatusEntity.ACCPayablePaymentStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDACCPayablePaymentStatus.GetFacadeCreate().Update(mDACCPayablePaymentStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ACCPayablePaymentStatusID = 0;
                        _MDACCPayablePaymentStatusEntity = new MDACCPayablePaymentStatusEntity();
                        PrepareInitialView();
                        BindMDACCPayablePaymentStatusList();

                        if (mDACCPayablePaymentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCPayable Payment Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCPayable Payment Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDACCPayablePaymentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CCPayable Payment Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CCPayable Payment Status Information.", false);
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

        protected void lvMDACCPayablePaymentStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ACCPayablePaymentStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ACCPayablePaymentStatusID);

            if (ACCPayablePaymentStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ACCPayablePaymentStatusID = ACCPayablePaymentStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDACCPayablePaymentStatusEntity.FLD_NAME_ACCPayablePaymentStatusID, ACCPayablePaymentStatusID.ToString(), SQLMatchType.Equal);

                        MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity = new MDACCPayablePaymentStatusEntity();


                        result = FCCMDACCPayablePaymentStatus.GetFacadeCreate().Delete(mDACCPayablePaymentStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ACCPayablePaymentStatusID = 0;
                            _MDACCPayablePaymentStatusEntity = new MDACCPayablePaymentStatusEntity();
                            PrepareInitialView();
                            BindMDACCPayablePaymentStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CCPayable Payment Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CCPayable Payment Status.", true);
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

        protected void odsMDACCPayablePaymentStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDACCPayablePaymentStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ACCPayablePaymentStatusID = 0;
            _MDACCPayablePaymentStatusEntity = new MDACCPayablePaymentStatusEntity();
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
