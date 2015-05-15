// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2013, 10:57:26




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
    public partial class CMNMDEventIdentityCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EventIdentityCategoryID
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

        public CMNMDEventIdentityCategoryEntity _CMNMDEventIdentityCategoryEntity
        {
            get
            {
                CMNMDEventIdentityCategoryEntity entity = new CMNMDEventIdentityCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNMDEventIdentityCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNMDEventIdentityCategoryEntity CurrentCMNMDEventIdentityCategoryEntity
        {
            get
            {
                if (_EventIdentityCategoryID > 0)
                {
                    if (_CMNMDEventIdentityCategoryEntity.EventIdentityCategoryID != _EventIdentityCategoryID)
                    {
                        _CMNMDEventIdentityCategoryEntity = FCCCMNMDEventIdentityCategory.GetFacadeCreate().GetByID(_EventIdentityCategoryID);
                    }
                }

                return _CMNMDEventIdentityCategoryEntity;
            }
            set
            {
                _CMNMDEventIdentityCategoryEntity = value;
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
            CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity = CurrentCMNMDEventIdentityCategoryEntity;


            if (!cMNMDEventIdentityCategoryEntity.IsNew)
            {
                txtName.Text = cMNMDEventIdentityCategoryEntity.Name.ToString();
                txtDescription.Text = cMNMDEventIdentityCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = cMNMDEventIdentityCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNMDEventIdentityCategoryList();
        }

        private void BindCMNMDEventIdentityCategoryList()
        {
            lvCMNMDEventIdentityCategory.DataBind();
        }

        private CMNMDEventIdentityCategoryEntity BuildCMNMDEventIdentityCategoryEntity()
        {
            CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity = CurrentCMNMDEventIdentityCategoryEntity;

            cMNMDEventIdentityCategoryEntity.Name = txtName.Text.Trim();
            cMNMDEventIdentityCategoryEntity.Description = txtDescription.Text.Trim();
            cMNMDEventIdentityCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNMDEventIdentityCategoryEntity;
        }

        private void SaveCMNMDEventIdentityCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity = BuildCMNMDEventIdentityCategoryEntity();

                    Int64 result = -1;

                    if (cMNMDEventIdentityCategoryEntity.IsNew)
                    {
                        result = FCCCMNMDEventIdentityCategory.GetFacadeCreate().Add(cMNMDEventIdentityCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventIdentityCategoryEntity.FLD_NAME_EventIdentityCategoryID, cMNMDEventIdentityCategoryEntity.EventIdentityCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNMDEventIdentityCategory.GetFacadeCreate().Update(cMNMDEventIdentityCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventIdentityCategoryID = 0;
                        _CMNMDEventIdentityCategoryEntity = new CMNMDEventIdentityCategoryEntity();
                        PrepareInitialView();
                        BindCMNMDEventIdentityCategoryList();

                        if (cMNMDEventIdentityCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Identity Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Identity Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNMDEventIdentityCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNEvent Identity Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNEvent Identity Category Information.", false);
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

        protected void lvCMNMDEventIdentityCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventIdentityCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventIdentityCategoryID);

            if (EventIdentityCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventIdentityCategoryID = EventIdentityCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventIdentityCategoryEntity.FLD_NAME_EventIdentityCategoryID, EventIdentityCategoryID.ToString(), SQLMatchType.Equal);

                        CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity = new CMNMDEventIdentityCategoryEntity();


                        result = FCCCMNMDEventIdentityCategory.GetFacadeCreate().Delete(cMNMDEventIdentityCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventIdentityCategoryID = 0;
                            _CMNMDEventIdentityCategoryEntity = new CMNMDEventIdentityCategoryEntity();
                            PrepareInitialView();
                            BindCMNMDEventIdentityCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Identity Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNEvent Identity Category.", true);
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

        protected void odsCMNMDEventIdentityCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNMDEventIdentityCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventIdentityCategoryID = 0;
            _CMNMDEventIdentityCategoryEntity = new CMNMDEventIdentityCategoryEntity();
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
