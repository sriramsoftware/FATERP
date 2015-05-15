// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class OTIssueWatchListControl : IssueBaseControl
    {       
        #region Properties

        public Int64 _IssueWatchListID
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

        public OTIssueWatchListEntity _OTIssueWatchListEntity
        {
            get
            {
                OTIssueWatchListEntity entity = new OTIssueWatchListEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueWatchListEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTIssueWatchListEntity CurrentOTIssueWatchListEntity
        {
            get
            {
                if (_IssueWatchListID > 0)
                {
                    if (_OTIssueWatchListEntity.IssueWatchListID != _IssueWatchListID)
                    {
                        _OTIssueWatchListEntity = FCCOTIssueWatchList.GetFacadeCreate().GetByID(_IssueWatchListID);
                    }
                }

                return _OTIssueWatchListEntity;
            }
            set
            {
                _OTIssueWatchListEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateOTIssue(ddlIssueID, false);
            MiscUtil.PopulateResource(ddlResourceID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();


            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            OTIssueWatchListEntity oTIssueWatchListEntity = CurrentOTIssueWatchListEntity;


            if (!oTIssueWatchListEntity.IsNew)
            {
                if (ddlIssueID.Items.Count > 0 && oTIssueWatchListEntity.IssueID != null)
                {
                    ddlIssueID.SelectedValue = oTIssueWatchListEntity.IssueID.ToString();
                }

                if (ddlResourceID.Items.Count > 0 && oTIssueWatchListEntity.ResourceID != null)
                {
                    ddlResourceID.SelectedValue = oTIssueWatchListEntity.ResourceID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindOTIssueWatchListList();
        }

        private void BindOTIssueWatchListList()
        {
            lvOTIssueWatchList.DataBind();
        }

        private OTIssueWatchListEntity BuildOTIssueWatchListEntity()
        {
            OTIssueWatchListEntity oTIssueWatchListEntity = CurrentOTIssueWatchListEntity;

            if (ddlIssueID.Items.Count > 0)
            {
                if (ddlIssueID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueWatchListEntity.IssueID = Int64.Parse(ddlIssueID.SelectedValue);
                }
            }

            if (ddlResourceID.Items.Count > 0)
            {
                if (ddlResourceID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueWatchListEntity.ResourceID = Int64.Parse(ddlResourceID.SelectedValue);
                }
            }


            return oTIssueWatchListEntity;
        }

        private void SaveOTIssueWatchListEntity()
        {
            if (IsValid)
            {
                try
                {
                    OTIssueWatchListEntity oTIssueWatchListEntity = BuildOTIssueWatchListEntity();

                    Int64 result = -1;

                    if (oTIssueWatchListEntity.IsNew)
                    {
                        result = FCCOTIssueWatchList.GetFacadeCreate().Add(oTIssueWatchListEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(OTIssueWatchListEntity.FLD_NAME_IssueWatchListID, oTIssueWatchListEntity.IssueWatchListID.ToString(), SQLMatchType.Equal);
                        result = FCCOTIssueWatchList.GetFacadeCreate().Update(oTIssueWatchListEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _IssueWatchListID = 0;
                        _OTIssueWatchListEntity = new OTIssueWatchListEntity();
                        PrepareInitialView();
                        BindOTIssueWatchListList();

                        if (oTIssueWatchListEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TIssue Watch Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TIssue Watch Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (oTIssueWatchListEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add O TIssue Watch Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update O TIssue Watch Information.", false);
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

        protected void lvOTIssueWatchList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueWatchListID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueWatchListID);

            if (IssueWatchListID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssueWatchListID = IssueWatchListID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueWatchListEntity.FLD_NAME_IssueWatchListID, IssueWatchListID.ToString(), SQLMatchType.Equal);

                        OTIssueWatchListEntity oTIssueWatchListEntity = new OTIssueWatchListEntity();


                        result = FCCOTIssueWatchList.GetFacadeCreate().Delete(oTIssueWatchListEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueWatchListID = 0;
                            _OTIssueWatchListEntity = new OTIssueWatchListEntity();
                            PrepareInitialView();
                            BindOTIssueWatchListList();

                            MiscUtil.ShowMessage(lblMessage, "O TIssue Watch has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete O TIssue Watch.", true);
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

        protected void odsOTIssueWatchList_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveOTIssueWatchListEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueWatchListID = 0;
            _OTIssueWatchListEntity = new OTIssueWatchListEntity();
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
