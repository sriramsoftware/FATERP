// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




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
    public partial class INVTRFStoreIssueNoteMapControl : BaseControl
    {       
        #region Properties

        public Int64 _TRFStoreIssueNoteMapID
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

        public INVTRFStoreIssueNoteMapEntity _INVTRFStoreIssueNoteMapEntity
        {
            get
            {
                INVTRFStoreIssueNoteMapEntity entity = new INVTRFStoreIssueNoteMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVTRFStoreIssueNoteMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVTRFStoreIssueNoteMapEntity CurrentINVTRFStoreIssueNoteMapEntity
        {
            get
            {
                if (_TRFStoreIssueNoteMapID > 0)
                {
                    if (_INVTRFStoreIssueNoteMapEntity.TRFStoreIssueNoteMapID != _TRFStoreIssueNoteMapID)
                    {
                        _INVTRFStoreIssueNoteMapEntity = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetByID(_TRFStoreIssueNoteMapID);
                    }
                }

                return _INVTRFStoreIssueNoteMapEntity;
            }
            set
            {
                _INVTRFStoreIssueNoteMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateINVStoreIssueNote(ddlStoreIssueNoteID, false);
            MiscUtil.PopulateINVTransfer(ddlTransferID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity = CurrentINVTRFStoreIssueNoteMapEntity;


            if (!iNVTRFStoreIssueNoteMapEntity.IsNew)
            {
                if (ddlStoreIssueNoteID.Items.Count > 0 && iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID != null)
                {
                    ddlStoreIssueNoteID.SelectedValue = iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID.ToString();
                }

                if (ddlTransferID.Items.Count > 0 && iNVTRFStoreIssueNoteMapEntity.TransferID != null)
                {
                    ddlTransferID.SelectedValue = iNVTRFStoreIssueNoteMapEntity.TransferID.ToString();
                }

                txtRemarks.Text = iNVTRFStoreIssueNoteMapEntity.Remarks.ToString();
                chkIsRemoved.Checked = iNVTRFStoreIssueNoteMapEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindINVTRFStoreIssueNoteMapList();
        }

        private void BindINVTRFStoreIssueNoteMapList()
        {
            lvINVTRFStoreIssueNoteMap.DataBind();
        }

        private INVTRFStoreIssueNoteMapEntity BuildINVTRFStoreIssueNoteMapEntity()
        {
            INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity = CurrentINVTRFStoreIssueNoteMapEntity;

            if (ddlStoreIssueNoteID.Items.Count > 0)
            {
                if (ddlStoreIssueNoteID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID = Int64.Parse(ddlStoreIssueNoteID.SelectedValue);
                }
            }

            if (ddlTransferID.Items.Count > 0)
            {
                if (ddlTransferID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTRFStoreIssueNoteMapEntity.TransferID = Int64.Parse(ddlTransferID.SelectedValue);
                }
            }

            iNVTRFStoreIssueNoteMapEntity.Remarks = txtRemarks.Text.Trim();
            iNVTRFStoreIssueNoteMapEntity.IsRemoved = chkIsRemoved.Checked;


            return iNVTRFStoreIssueNoteMapEntity;
        }

        private void SaveINVTRFStoreIssueNoteMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity = BuildINVTRFStoreIssueNoteMapEntity();

                    Int64 result = -1;

                    if (iNVTRFStoreIssueNoteMapEntity.IsNew)
                    {
                        result = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().Add(iNVTRFStoreIssueNoteMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVTRFStoreIssueNoteMapEntity.FLD_NAME_TRFStoreIssueNoteMapID, iNVTRFStoreIssueNoteMapEntity.TRFStoreIssueNoteMapID.ToString(), SQLMatchType.Equal);
                        result = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().Update(iNVTRFStoreIssueNoteMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TRFStoreIssueNoteMapID = 0;
                        _INVTRFStoreIssueNoteMapEntity = new INVTRFStoreIssueNoteMapEntity();
                        PrepareInitialView();
                        BindINVTRFStoreIssueNoteMapList();

                        if (iNVTRFStoreIssueNoteMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "I NVTRFStore Issue Note Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "I NVTRFStore Issue Note Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (iNVTRFStoreIssueNoteMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add I NVTRFStore Issue Note Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update I NVTRFStore Issue Note Map Information.", false);
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

        protected void lvINVTRFStoreIssueNoteMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TRFStoreIssueNoteMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out TRFStoreIssueNoteMapID);

            if (TRFStoreIssueNoteMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TRFStoreIssueNoteMapID = TRFStoreIssueNoteMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTRFStoreIssueNoteMapEntity.FLD_NAME_TRFStoreIssueNoteMapID, TRFStoreIssueNoteMapID.ToString(), SQLMatchType.Equal);

                        INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity = new INVTRFStoreIssueNoteMapEntity();


                        result = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().Delete(iNVTRFStoreIssueNoteMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TRFStoreIssueNoteMapID = 0;
                            _INVTRFStoreIssueNoteMapEntity = new INVTRFStoreIssueNoteMapEntity();
                            PrepareInitialView();
                            BindINVTRFStoreIssueNoteMapList();

                            MiscUtil.ShowMessage(lblMessage, "I NVTRFStore Issue Note Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVTRFStore Issue Note Map.", true);
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

        protected void odsINVTRFStoreIssueNoteMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveINVTRFStoreIssueNoteMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TRFStoreIssueNoteMapID = 0;
            _INVTRFStoreIssueNoteMapEntity = new INVTRFStoreIssueNoteMapEntity();
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
