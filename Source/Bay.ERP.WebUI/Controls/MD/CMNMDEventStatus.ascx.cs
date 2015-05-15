// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




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
    public partial class CMNMDEventStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _EventStatusID
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

        public CMNMDEventStatusEntity _CMNMDEventStatusEntity
        {
            get
            {
                CMNMDEventStatusEntity entity = new CMNMDEventStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNMDEventStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNMDEventStatusEntity CurrentCMNMDEventStatusEntity
        {
            get
            {
                if (_EventStatusID > 0)
                {
                    if (_CMNMDEventStatusEntity.EventStatusID != _EventStatusID)
                    {
                        _CMNMDEventStatusEntity = FCCCMNMDEventStatus.GetFacadeCreate().GetByID(_EventStatusID);
                    }
                }

                return _CMNMDEventStatusEntity;
            }
            set
            {
                _CMNMDEventStatusEntity = value;
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
            CMNMDEventStatusEntity cMNMDEventStatusEntity = CurrentCMNMDEventStatusEntity;


            if (!cMNMDEventStatusEntity.IsNew)
            {
                txtName.Text = cMNMDEventStatusEntity.Name.ToString();
                txtDescription.Text = cMNMDEventStatusEntity.Description.ToString();
                chkIsRemoved.Checked = cMNMDEventStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNMDEventStatusList();
        }

        private void BindCMNMDEventStatusList()
        {
            lvCMNMDEventStatus.DataBind();
        }

        private CMNMDEventStatusEntity BuildCMNMDEventStatusEntity()
        {
            CMNMDEventStatusEntity cMNMDEventStatusEntity = CurrentCMNMDEventStatusEntity;

            cMNMDEventStatusEntity.Name = txtName.Text.Trim();
            cMNMDEventStatusEntity.Description = txtDescription.Text.Trim();
            cMNMDEventStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNMDEventStatusEntity;
        }

        private void SaveCMNMDEventStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNMDEventStatusEntity cMNMDEventStatusEntity = BuildCMNMDEventStatusEntity();

                    Int64 result = -1;

                    if (cMNMDEventStatusEntity.IsNew)
                    {
                        result = FCCCMNMDEventStatus.GetFacadeCreate().Add(cMNMDEventStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventStatusEntity.FLD_NAME_EventStatusID, cMNMDEventStatusEntity.EventStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNMDEventStatus.GetFacadeCreate().Update(cMNMDEventStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventStatusID = 0;
                        _CMNMDEventStatusEntity = new CMNMDEventStatusEntity();
                        PrepareInitialView();
                        BindCMNMDEventStatusList();

                        if (cMNMDEventStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNMDEventStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNEvent Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNEvent Status Information.", false);
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

        protected void lvCMNMDEventStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventStatusID);

            if (EventStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventStatusID = EventStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventStatusEntity.FLD_NAME_EventStatusID, EventStatusID.ToString(), SQLMatchType.Equal);

                        CMNMDEventStatusEntity cMNMDEventStatusEntity = new CMNMDEventStatusEntity();


                        result = FCCCMNMDEventStatus.GetFacadeCreate().Delete(cMNMDEventStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventStatusID = 0;
                            _CMNMDEventStatusEntity = new CMNMDEventStatusEntity();
                            PrepareInitialView();
                            BindCMNMDEventStatusList();

                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNEvent Status.", true);
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

        protected void odsCMNMDEventStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNMDEventStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventStatusID = 0;
            _CMNMDEventStatusEntity = new CMNMDEventStatusEntity();
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
