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
    public partial class CMNMDEventOptionControl : BaseControl
    {       
        #region Properties

        public Int64 _EventOptionID
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

        public CMNMDEventOptionEntity _CMNMDEventOptionEntity
        {
            get
            {
                CMNMDEventOptionEntity entity = new CMNMDEventOptionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNMDEventOptionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNMDEventOptionEntity CurrentCMNMDEventOptionEntity
        {
            get
            {
                if (_EventOptionID > 0)
                {
                    if (_CMNMDEventOptionEntity.EventOptionID != _EventOptionID)
                    {
                        _CMNMDEventOptionEntity = FCCCMNMDEventOption.GetFacadeCreate().GetByID(_EventOptionID);
                    }
                }

                return _CMNMDEventOptionEntity;
            }
            set
            {
                _CMNMDEventOptionEntity = value;
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
            CMNMDEventOptionEntity cMNMDEventOptionEntity = CurrentCMNMDEventOptionEntity;


            if (!cMNMDEventOptionEntity.IsNew)
            {
                txtName.Text = cMNMDEventOptionEntity.Name.ToString();
                txtDescription.Text = cMNMDEventOptionEntity.Description.ToString();
                chkIsRemoved.Checked = cMNMDEventOptionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNMDEventOptionList();
        }

        private void BindCMNMDEventOptionList()
        {
            lvCMNMDEventOption.DataBind();
        }

        private CMNMDEventOptionEntity BuildCMNMDEventOptionEntity()
        {
            CMNMDEventOptionEntity cMNMDEventOptionEntity = CurrentCMNMDEventOptionEntity;

            cMNMDEventOptionEntity.Name = txtName.Text.Trim();
            cMNMDEventOptionEntity.Description = txtDescription.Text.Trim();
            cMNMDEventOptionEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNMDEventOptionEntity;
        }

        private void SaveCMNMDEventOptionEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNMDEventOptionEntity cMNMDEventOptionEntity = BuildCMNMDEventOptionEntity();

                    Int64 result = -1;

                    if (cMNMDEventOptionEntity.IsNew)
                    {
                        result = FCCCMNMDEventOption.GetFacadeCreate().Add(cMNMDEventOptionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventOptionEntity.FLD_NAME_EventOptionID, cMNMDEventOptionEntity.EventOptionID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNMDEventOption.GetFacadeCreate().Update(cMNMDEventOptionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventOptionID = 0;
                        _CMNMDEventOptionEntity = new CMNMDEventOptionEntity();
                        PrepareInitialView();
                        BindCMNMDEventOptionList();

                        if (cMNMDEventOptionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Option Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Option Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNMDEventOptionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNEvent Option Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNEvent Option Information.", false);
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

        protected void lvCMNMDEventOption_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventOptionID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventOptionID);

            if (EventOptionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventOptionID = EventOptionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventOptionEntity.FLD_NAME_EventOptionID, EventOptionID.ToString(), SQLMatchType.Equal);

                        CMNMDEventOptionEntity cMNMDEventOptionEntity = new CMNMDEventOptionEntity();


                        result = FCCCMNMDEventOption.GetFacadeCreate().Delete(cMNMDEventOptionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventOptionID = 0;
                            _CMNMDEventOptionEntity = new CMNMDEventOptionEntity();
                            PrepareInitialView();
                            BindCMNMDEventOptionList();

                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Option has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNEvent Option.", true);
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

        protected void odsCMNMDEventOption_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNMDEventOptionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventOptionID = 0;
            _CMNMDEventOptionEntity = new CMNMDEventOptionEntity();
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
