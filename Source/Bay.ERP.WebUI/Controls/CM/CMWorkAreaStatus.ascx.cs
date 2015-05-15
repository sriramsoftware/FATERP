// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class CMWorkAreaStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkAreaStatusID
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

        public CMWorkAreaStatusEntity _CMWorkAreaStatusEntity
        {
            get
            {
                CMWorkAreaStatusEntity entity = new CMWorkAreaStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMWorkAreaStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMWorkAreaStatusEntity CurrentCMWorkAreaStatusEntity
        {
            get
            {
                if (_WorkAreaStatusID > 0)
                {
                    if (_CMWorkAreaStatusEntity.WorkAreaStatusID != _WorkAreaStatusID)
                    {
                        _CMWorkAreaStatusEntity = FCCCMWorkAreaStatus.GetFacadeCreate().GetByID(_WorkAreaStatusID);
                    }
                }

                return _CMWorkAreaStatusEntity;
            }
            set
            {
                _CMWorkAreaStatusEntity = value;
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
            CMWorkAreaStatusEntity cMWorkAreaStatusEntity = CurrentCMWorkAreaStatusEntity;


            if (!cMWorkAreaStatusEntity.IsNew)
            {
                txtName.Text = cMWorkAreaStatusEntity.Name.ToString();
                chkIsRemoved.Checked = cMWorkAreaStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMWorkAreaStatusList();
        }

        private void BindCMWorkAreaStatusList()
        {
            lvCMWorkAreaStatus.DataBind();
        }

        private CMWorkAreaStatusEntity BuildCMWorkAreaStatusEntity()
        {
            CMWorkAreaStatusEntity cMWorkAreaStatusEntity = CurrentCMWorkAreaStatusEntity;

            cMWorkAreaStatusEntity.Name = txtName.Text.Trim();
            cMWorkAreaStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return cMWorkAreaStatusEntity;
        }

        private void SaveCMWorkAreaStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMWorkAreaStatusEntity cMWorkAreaStatusEntity = BuildCMWorkAreaStatusEntity();

                    Int64 result = -1;

                    if (cMWorkAreaStatusEntity.IsNew)
                    {
                        result = FCCCMWorkAreaStatus.GetFacadeCreate().Add(cMWorkAreaStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMWorkAreaStatusEntity.FLD_NAME_WorkAreaStatusID, cMWorkAreaStatusEntity.WorkAreaStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCMWorkAreaStatus.GetFacadeCreate().Update(cMWorkAreaStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkAreaStatusID = 0;
                        _CMWorkAreaStatusEntity = new CMWorkAreaStatusEntity();
                        PrepareInitialView();
                        BindCMWorkAreaStatusList();

                        if (cMWorkAreaStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MWork Area Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MWork Area Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMWorkAreaStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MWork Area Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MWork Area Status Information.", false);
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

        protected void lvCMWorkAreaStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkAreaStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkAreaStatusID);

            if (WorkAreaStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkAreaStatusID = WorkAreaStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMWorkAreaStatusEntity.FLD_NAME_WorkAreaStatusID, WorkAreaStatusID.ToString(), SQLMatchType.Equal);

                        CMWorkAreaStatusEntity cMWorkAreaStatusEntity = new CMWorkAreaStatusEntity();


                        result = FCCCMWorkAreaStatus.GetFacadeCreate().Delete(cMWorkAreaStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkAreaStatusID = 0;
                            _CMWorkAreaStatusEntity = new CMWorkAreaStatusEntity();
                            PrepareInitialView();
                            BindCMWorkAreaStatusList();

                            MiscUtil.ShowMessage(lblMessage, "C MWork Area Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MWork Area Status.", true);
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

        protected void odsCMWorkAreaStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMWorkAreaStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkAreaStatusID = 0;
            _CMWorkAreaStatusEntity = new CMWorkAreaStatusEntity();
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
