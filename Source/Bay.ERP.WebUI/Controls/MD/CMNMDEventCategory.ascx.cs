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
    public partial class CMNMDEventCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EventCategoryID
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

        public CMNMDEventCategoryEntity _CMNMDEventCategoryEntity
        {
            get
            {
                CMNMDEventCategoryEntity entity = new CMNMDEventCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNMDEventCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNMDEventCategoryEntity CurrentCMNMDEventCategoryEntity
        {
            get
            {
                if (_EventCategoryID > 0)
                {
                    if (_CMNMDEventCategoryEntity.EventCategoryID != _EventCategoryID)
                    {
                        _CMNMDEventCategoryEntity = FCCCMNMDEventCategory.GetFacadeCreate().GetByID(_EventCategoryID);
                    }
                }

                return _CMNMDEventCategoryEntity;
            }
            set
            {
                _CMNMDEventCategoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNMDEventIdentityCategory(ddlEventIdentityCategoryID, false);
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
            CMNMDEventCategoryEntity cMNMDEventCategoryEntity = CurrentCMNMDEventCategoryEntity;


            if (!cMNMDEventCategoryEntity.IsNew)
            {
                if (ddlEventIdentityCategoryID.Items.Count > 0 && cMNMDEventCategoryEntity.EventIdentityCategoryID != null)
                {
                    ddlEventIdentityCategoryID.SelectedValue = cMNMDEventCategoryEntity.EventIdentityCategoryID.ToString();
                }

                txtName.Text = cMNMDEventCategoryEntity.Name.ToString();
                txtDescription.Text = cMNMDEventCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = cMNMDEventCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNMDEventCategoryList();
        }

        private void BindCMNMDEventCategoryList()
        {
            lvCMNMDEventCategory.DataBind();
        }

        private CMNMDEventCategoryEntity BuildCMNMDEventCategoryEntity()
        {
            CMNMDEventCategoryEntity cMNMDEventCategoryEntity = CurrentCMNMDEventCategoryEntity;

            if (ddlEventIdentityCategoryID.Items.Count > 0)
            {
                if (ddlEventIdentityCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNMDEventCategoryEntity.EventIdentityCategoryID = Int64.Parse(ddlEventIdentityCategoryID.SelectedValue);
                }
            }

            cMNMDEventCategoryEntity.Name = txtName.Text.Trim();
            cMNMDEventCategoryEntity.Description = txtDescription.Text.Trim();
            cMNMDEventCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNMDEventCategoryEntity;
        }

        private void SaveCMNMDEventCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNMDEventCategoryEntity cMNMDEventCategoryEntity = BuildCMNMDEventCategoryEntity();

                    Int64 result = -1;

                    if (cMNMDEventCategoryEntity.IsNew)
                    {
                        result = FCCCMNMDEventCategory.GetFacadeCreate().Add(cMNMDEventCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventCategoryEntity.FLD_NAME_EventCategoryID, cMNMDEventCategoryEntity.EventCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNMDEventCategory.GetFacadeCreate().Update(cMNMDEventCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventCategoryID = 0;
                        _CMNMDEventCategoryEntity = new CMNMDEventCategoryEntity();
                        PrepareInitialView();
                        BindCMNMDEventCategoryList();

                        if (cMNMDEventCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNMDEventCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNEvent Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNEvent Category Information.", false);
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

        protected void lvCMNMDEventCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventCategoryID);

            if (EventCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventCategoryID = EventCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventCategoryEntity.FLD_NAME_EventCategoryID, EventCategoryID.ToString(), SQLMatchType.Equal);

                        CMNMDEventCategoryEntity cMNMDEventCategoryEntity = new CMNMDEventCategoryEntity();


                        result = FCCCMNMDEventCategory.GetFacadeCreate().Delete(cMNMDEventCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventCategoryID = 0;
                            _CMNMDEventCategoryEntity = new CMNMDEventCategoryEntity();
                            PrepareInitialView();
                            BindCMNMDEventCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNEvent Category.", true);
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

        protected void odsCMNMDEventCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNMDEventCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventCategoryID = 0;
            _CMNMDEventCategoryEntity = new CMNMDEventCategoryEntity();
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
