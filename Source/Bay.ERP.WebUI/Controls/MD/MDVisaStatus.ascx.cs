// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDVisaStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _VisaStatusID
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

        public MDVisaStatusEntity _MDVisaStatusEntity
        {
            get
            {
                MDVisaStatusEntity entity = new MDVisaStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDVisaStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDVisaStatusEntity CurrentMDVisaStatusEntity
        {
            get
            {
                if (_VisaStatusID > 0)
                {
                    if (_MDVisaStatusEntity.VisaStatusID != _VisaStatusID)
                    {
                        _MDVisaStatusEntity = FCCMDVisaStatus.GetFacadeCreate().GetByID(_VisaStatusID);
                    }
                }

                return _MDVisaStatusEntity;
            }
            set
            {
                _MDVisaStatusEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDVisaStatusEntity mDVisaStatusEntity = CurrentMDVisaStatusEntity;


            if (!mDVisaStatusEntity.IsNew)
            {
                txtName.Text = mDVisaStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDVisaStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDVisaStatusList();
        }

        private void BindMDVisaStatusList()
        {
            lvMDVisaStatus.DataBind();
        }

        private MDVisaStatusEntity BuildMDVisaStatusEntity()
        {
            MDVisaStatusEntity mDVisaStatusEntity = CurrentMDVisaStatusEntity;

            mDVisaStatusEntity.Name = txtName.Text.Trim();
            mDVisaStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDVisaStatusEntity;
        }

        private void SaveMDVisaStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDVisaStatusEntity mDVisaStatusEntity = BuildMDVisaStatusEntity();

                    Int64 result = -1;

                    if (mDVisaStatusEntity.IsNew)
                    {
                        result = FCCMDVisaStatus.GetFacadeCreate().Add(mDVisaStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDVisaStatusEntity.FLD_NAME_VisaStatusID, mDVisaStatusEntity.VisaStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDVisaStatus.GetFacadeCreate().Update(mDVisaStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _VisaStatusID = 0;
                        _MDVisaStatusEntity = new MDVisaStatusEntity();
                        PrepareInitialView();
                        BindMDVisaStatusList();

                        if (mDVisaStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Visa Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Visa Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDVisaStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Visa Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Visa Status Information.", false);
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

        protected void lvMDVisaStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 VisaStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out VisaStatusID);

            if (VisaStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _VisaStatusID = VisaStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDVisaStatusEntity.FLD_NAME_VisaStatusID, VisaStatusID.ToString(), SQLMatchType.Equal);

                        MDVisaStatusEntity mDVisaStatusEntity = new MDVisaStatusEntity();


                        result = FCCMDVisaStatus.GetFacadeCreate().Delete(mDVisaStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _VisaStatusID = 0;
                            _MDVisaStatusEntity = new MDVisaStatusEntity();
                            PrepareInitialView();
                            BindMDVisaStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Visa Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Visa Status.", true);
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

        protected void odsMDVisaStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDVisaStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _VisaStatusID = 0;
            _MDVisaStatusEntity = new MDVisaStatusEntity();
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
