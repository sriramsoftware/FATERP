// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 11:45:48




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
    public partial class CMNDashboardItemQuicklinkControl : BaseControl
    {       
        #region Properties

        public Int64 _DashboardItemQuicklinkID
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

        public CMNDashboardItemQuicklinkEntity _CMNDashboardItemQuicklinkEntity
        {
            get
            {
                CMNDashboardItemQuicklinkEntity entity = new CMNDashboardItemQuicklinkEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNDashboardItemQuicklinkEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNDashboardItemQuicklinkEntity CurrentCMNDashboardItemQuicklinkEntity
        {
            get
            {
                if (_DashboardItemQuicklinkID > 0)
                {
                    if (_CMNDashboardItemQuicklinkEntity.DashboardItemQuicklinkID != _DashboardItemQuicklinkID)
                    {
                        _CMNDashboardItemQuicklinkEntity = FCCCMNDashboardItemQuicklink.GetFacadeCreate().GetByID(_DashboardItemQuicklinkID);
                    }
                }

                return _CMNDashboardItemQuicklinkEntity;
            }
            set
            {
                _CMNDashboardItemQuicklinkEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNDashboardItem(ddlDashboardItemID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtNavigationUrl.Text = String.Empty;
            txtHoverMessage.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity = CurrentCMNDashboardItemQuicklinkEntity;


            if (!cMNDashboardItemQuicklinkEntity.IsNew)
            {
                if (ddlDashboardItemID.Items.Count > 0 && cMNDashboardItemQuicklinkEntity.DashboardItemID != null)
                {
                    ddlDashboardItemID.SelectedValue = cMNDashboardItemQuicklinkEntity.DashboardItemID.ToString();
                }

                txtName.Text = cMNDashboardItemQuicklinkEntity.Name.ToString();
                txtNavigationUrl.Text = cMNDashboardItemQuicklinkEntity.NavigationUrl.ToString();
                txtHoverMessage.Text = cMNDashboardItemQuicklinkEntity.HoverMessage.ToString();
                chkIsRemoved.Checked = cMNDashboardItemQuicklinkEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNDashboardItemQuicklinkList();
        }

        private void BindCMNDashboardItemQuicklinkList()
        {
            lvCMNDashboardItemQuicklink.DataBind();
        }

        private CMNDashboardItemQuicklinkEntity BuildCMNDashboardItemQuicklinkEntity()
        {
            CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity = CurrentCMNDashboardItemQuicklinkEntity;

            if (ddlDashboardItemID.Items.Count > 0)
            {
                if (ddlDashboardItemID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNDashboardItemQuicklinkEntity.DashboardItemID = Int64.Parse(ddlDashboardItemID.SelectedValue);
                }
            }

            cMNDashboardItemQuicklinkEntity.Name = txtName.Text.Trim();
            cMNDashboardItemQuicklinkEntity.NavigationUrl = txtNavigationUrl.Text.Trim();
            cMNDashboardItemQuicklinkEntity.HoverMessage = txtHoverMessage.Text.Trim();
            cMNDashboardItemQuicklinkEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNDashboardItemQuicklinkEntity;
        }

        private void SaveCMNDashboardItemQuicklinkEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity = BuildCMNDashboardItemQuicklinkEntity();

                    Int64 result = -1;

                    if (cMNDashboardItemQuicklinkEntity.IsNew)
                    {
                        result = FCCCMNDashboardItemQuicklink.GetFacadeCreate().Add(cMNDashboardItemQuicklinkEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemQuicklinkEntity.FLD_NAME_DashboardItemQuicklinkID, cMNDashboardItemQuicklinkEntity.DashboardItemQuicklinkID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNDashboardItemQuicklink.GetFacadeCreate().Update(cMNDashboardItemQuicklinkEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DashboardItemQuicklinkID = 0;
                        _CMNDashboardItemQuicklinkEntity = new CMNDashboardItemQuicklinkEntity();
                        PrepareInitialView();
                        BindCMNDashboardItemQuicklinkList();

                        if (cMNDashboardItemQuicklinkEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Dashboard Item Quicklink Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Dashboard Item Quicklink Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNDashboardItemQuicklinkEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Dashboard Item Quicklink Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Dashboard Item Quicklink Information.", false);
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

        protected void lvCMNDashboardItemQuicklink_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DashboardItemQuicklinkID;

            Int64.TryParse(e.CommandArgument.ToString(), out DashboardItemQuicklinkID);

            if (DashboardItemQuicklinkID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DashboardItemQuicklinkID = DashboardItemQuicklinkID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemQuicklinkEntity.FLD_NAME_DashboardItemQuicklinkID, DashboardItemQuicklinkID.ToString(), SQLMatchType.Equal);

                        CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity = new CMNDashboardItemQuicklinkEntity();


                        result = FCCCMNDashboardItemQuicklink.GetFacadeCreate().Delete(cMNDashboardItemQuicklinkEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DashboardItemQuicklinkID = 0;
                            _CMNDashboardItemQuicklinkEntity = new CMNDashboardItemQuicklinkEntity();
                            PrepareInitialView();
                            BindCMNDashboardItemQuicklinkList();

                            MiscUtil.ShowMessage(lblMessage, "Dashboard Item Quicklink has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Dashboard Item Quicklink.", true);
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

        protected void odsCMNDashboardItemQuicklink_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNDashboardItemQuicklinkEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DashboardItemQuicklinkID = 0;
            _CMNDashboardItemQuicklinkEntity = new CMNDashboardItemQuicklinkEntity();
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
