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
    public partial class CRMMDCommunicationStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _CommunicationStatusID
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

        public CRMMDCommunicationStatusEntity _CRMMDCommunicationStatusEntity
        {
            get
            {
                CRMMDCommunicationStatusEntity entity = new CRMMDCommunicationStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDCommunicationStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDCommunicationStatusEntity CurrentCRMMDCommunicationStatusEntity
        {
            get
            {
                if (_CommunicationStatusID > 0)
                {
                    if (_CRMMDCommunicationStatusEntity.CommunicationStatusID != _CommunicationStatusID)
                    {
                        _CRMMDCommunicationStatusEntity = FCCCRMMDCommunicationStatus.GetFacadeCreate().GetByID(_CommunicationStatusID);
                    }
                }

                return _CRMMDCommunicationStatusEntity;
            }
            set
            {
                _CRMMDCommunicationStatusEntity = value;
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
            CRMMDCommunicationStatusEntity cRMMDCommunicationStatusEntity = CurrentCRMMDCommunicationStatusEntity;


            if (!cRMMDCommunicationStatusEntity.IsNew)
            {
                txtName.Text = cRMMDCommunicationStatusEntity.Name.ToString();
                txtDescription.Text = cRMMDCommunicationStatusEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDCommunicationStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDCommunicationStatusList();
        }

        private void BindCRMMDCommunicationStatusList()
        {
            lvCRMMDCommunicationStatus.DataBind();
        }

        private CRMMDCommunicationStatusEntity BuildCRMMDCommunicationStatusEntity()
        {
            CRMMDCommunicationStatusEntity cRMMDCommunicationStatusEntity = CurrentCRMMDCommunicationStatusEntity;

            cRMMDCommunicationStatusEntity.Name = txtName.Text.Trim();
            cRMMDCommunicationStatusEntity.Description = txtDescription.Text.Trim();
            cRMMDCommunicationStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDCommunicationStatusEntity;
        }

        private void SaveCRMMDCommunicationStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDCommunicationStatusEntity cRMMDCommunicationStatusEntity = BuildCRMMDCommunicationStatusEntity();

                    Int64 result = -1;

                    if (cRMMDCommunicationStatusEntity.IsNew)
                    {
                        result = FCCCRMMDCommunicationStatus.GetFacadeCreate().Add(cRMMDCommunicationStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCommunicationStatusEntity.FLD_NAME_CommunicationStatusID, cRMMDCommunicationStatusEntity.CommunicationStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDCommunicationStatus.GetFacadeCreate().Update(cRMMDCommunicationStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CommunicationStatusID = 0;
                        _CRMMDCommunicationStatusEntity = new CRMMDCommunicationStatusEntity();
                        PrepareInitialView();
                        BindCRMMDCommunicationStatusList();

                        if (cRMMDCommunicationStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCommunication Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCommunication Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDCommunicationStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMCommunication Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMCommunication Status Information.", false);
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

        protected void lvCRMMDCommunicationStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CommunicationStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out CommunicationStatusID);

            if (CommunicationStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CommunicationStatusID = CommunicationStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCommunicationStatusEntity.FLD_NAME_CommunicationStatusID, CommunicationStatusID.ToString(), SQLMatchType.Equal);

                        CRMMDCommunicationStatusEntity cRMMDCommunicationStatusEntity = new CRMMDCommunicationStatusEntity();


                        result = FCCCRMMDCommunicationStatus.GetFacadeCreate().Delete(cRMMDCommunicationStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CommunicationStatusID = 0;
                            _CRMMDCommunicationStatusEntity = new CRMMDCommunicationStatusEntity();
                            PrepareInitialView();
                            BindCRMMDCommunicationStatusList();

                            MiscUtil.ShowMessage(lblMessage, "C RMCommunication Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMCommunication Status.", true);
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

        protected void odsCRMMDCommunicationStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDCommunicationStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CommunicationStatusID = 0;
            _CRMMDCommunicationStatusEntity = new CRMMDCommunicationStatusEntity();
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
