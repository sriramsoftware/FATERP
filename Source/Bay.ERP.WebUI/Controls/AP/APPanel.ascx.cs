// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APPanelControl : BaseControl
    {       
        #region Properties

        public Int64 _APPanelID
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

        public APPanelEntity _APPanelEntity
        {
            get
            {
                APPanelEntity entity = new APPanelEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APPanelEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APPanelEntity CurrentAPPanelEntity
        {
            get
            {
                if (_APPanelID > 0)
                {
                    if (_APPanelEntity.APPanelID != _APPanelID)
                    {
                        _APPanelEntity = FCCAPPanel.GetFacadeCreate().GetByID(_APPanelID);
                    }
                }

                return _APPanelEntity;
            }
            set
            {
                _APPanelEntity = value;
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
            APPanelEntity aPPanelEntity = CurrentAPPanelEntity;


            if (!aPPanelEntity.IsNew)
            {
                txtName.Text = aPPanelEntity.Name.ToString();
                txtDescription.Text = aPPanelEntity.Description.ToString();
                chkIsRemoved.Checked = aPPanelEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPPanelList();
        }

        private void BindAPPanelList()
        {
            lvAPPanel.DataBind();
        }

        private APPanelEntity BuildAPPanelEntity()
        {
            APPanelEntity aPPanelEntity = CurrentAPPanelEntity;

            aPPanelEntity.Name = txtName.Text.Trim();
            aPPanelEntity.Description = txtDescription.Text.Trim();
            aPPanelEntity.IsRemoved = chkIsRemoved.Checked;


            return aPPanelEntity;
        }

        private void SaveAPPanelEntity()
        {
            if (IsValid)
            {
                try
                {
                    APPanelEntity aPPanelEntity = BuildAPPanelEntity();

                    Int64 result = -1;

                    if (aPPanelEntity.IsNew)
                    {
                        result = FCCAPPanel.GetFacadeCreate().Add(aPPanelEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APPanelEntity.FLD_NAME_APPanelID, aPPanelEntity.APPanelID.ToString(), SQLMatchType.Equal);
                        result = FCCAPPanel.GetFacadeCreate().Update(aPPanelEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APPanelID = 0;
                        _APPanelEntity = new APPanelEntity();
                        PrepareInitialView();
                        BindAPPanelList();

                        if (aPPanelEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PPanel Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PPanel Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPPanelEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PPanel Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PPanel Information.", false);
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

        protected void lvAPPanel_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APPanelID;

            Int64.TryParse(e.CommandArgument.ToString(), out APPanelID);

            if (APPanelID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APPanelID = APPanelID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelEntity.FLD_NAME_APPanelID, APPanelID.ToString(), SQLMatchType.Equal);

                        APPanelEntity aPPanelEntity = new APPanelEntity();


                        result = FCCAPPanel.GetFacadeCreate().Delete(aPPanelEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APPanelID = 0;
                            _APPanelEntity = new APPanelEntity();
                            PrepareInitialView();
                            BindAPPanelList();

                            MiscUtil.ShowMessage(lblMessage, "A PPanel has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PPanel.", true);
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

        protected void odsAPPanel_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPPanelEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APPanelID = 0;
            _APPanelEntity = new APPanelEntity();
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
