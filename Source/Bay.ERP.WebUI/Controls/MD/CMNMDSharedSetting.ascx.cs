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
    public partial class CMNMDSharedSettingControl : BaseControl
    {       
        #region Properties

        public Int64 _SharedSettingID
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

        public CMNMDSharedSettingEntity _CMNMDSharedSettingEntity
        {
            get
            {
                CMNMDSharedSettingEntity entity = new CMNMDSharedSettingEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNMDSharedSettingEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNMDSharedSettingEntity CurrentCMNMDSharedSettingEntity
        {
            get
            {
                if (_SharedSettingID > 0)
                {
                    if (_CMNMDSharedSettingEntity.SharedSettingID != _SharedSettingID)
                    {
                        _CMNMDSharedSettingEntity = FCCCMNMDSharedSetting.GetFacadeCreate().GetByID(_SharedSettingID);
                    }
                }

                return _CMNMDSharedSettingEntity;
            }
            set
            {
                _CMNMDSharedSettingEntity = value;
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
            CMNMDSharedSettingEntity cMNMDSharedSettingEntity = CurrentCMNMDSharedSettingEntity;


            if (!cMNMDSharedSettingEntity.IsNew)
            {
                txtName.Text = cMNMDSharedSettingEntity.Name.ToString();
                txtDescription.Text = cMNMDSharedSettingEntity.Description.ToString();
                chkIsRemoved.Checked = cMNMDSharedSettingEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNMDSharedSettingList();
        }

        private void BindCMNMDSharedSettingList()
        {
            lvCMNMDSharedSetting.DataBind();
        }

        private CMNMDSharedSettingEntity BuildCMNMDSharedSettingEntity()
        {
            CMNMDSharedSettingEntity cMNMDSharedSettingEntity = CurrentCMNMDSharedSettingEntity;

            cMNMDSharedSettingEntity.Name = txtName.Text.Trim();
            cMNMDSharedSettingEntity.Description = txtDescription.Text.Trim();
            cMNMDSharedSettingEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNMDSharedSettingEntity;
        }

        private void SaveCMNMDSharedSettingEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNMDSharedSettingEntity cMNMDSharedSettingEntity = BuildCMNMDSharedSettingEntity();

                    Int64 result = -1;

                    if (cMNMDSharedSettingEntity.IsNew)
                    {
                        result = FCCCMNMDSharedSetting.GetFacadeCreate().Add(cMNMDSharedSettingEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNMDSharedSettingEntity.FLD_NAME_SharedSettingID, cMNMDSharedSettingEntity.SharedSettingID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNMDSharedSetting.GetFacadeCreate().Update(cMNMDSharedSettingEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SharedSettingID = 0;
                        _CMNMDSharedSettingEntity = new CMNMDSharedSettingEntity();
                        PrepareInitialView();
                        BindCMNMDSharedSettingList();

                        if (cMNMDSharedSettingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNShared Setting Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNShared Setting Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNMDSharedSettingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNShared Setting Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNShared Setting Information.", false);
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

        protected void lvCMNMDSharedSetting_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SharedSettingID;

            Int64.TryParse(e.CommandArgument.ToString(), out SharedSettingID);

            if (SharedSettingID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SharedSettingID = SharedSettingID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDSharedSettingEntity.FLD_NAME_SharedSettingID, SharedSettingID.ToString(), SQLMatchType.Equal);

                        CMNMDSharedSettingEntity cMNMDSharedSettingEntity = new CMNMDSharedSettingEntity();


                        result = FCCCMNMDSharedSetting.GetFacadeCreate().Delete(cMNMDSharedSettingEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SharedSettingID = 0;
                            _CMNMDSharedSettingEntity = new CMNMDSharedSettingEntity();
                            PrepareInitialView();
                            BindCMNMDSharedSettingList();

                            MiscUtil.ShowMessage(lblMessage, "C MNShared Setting has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNShared Setting.", true);
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

        protected void odsCMNMDSharedSetting_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNMDSharedSettingEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SharedSettingID = 0;
            _CMNMDSharedSettingEntity = new CMNMDSharedSettingEntity();
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
