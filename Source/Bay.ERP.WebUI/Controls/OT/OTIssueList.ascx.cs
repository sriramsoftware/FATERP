// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Mar-2013, 12:48:18




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
    public partial class OTIssueListControl : BaseControl
    {       
        #region Properties

        public Int64 _IssueID
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

        public OTIssueEntity _OTIssueEntity
        {
            get
            {
                OTIssueEntity entity = new OTIssueEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTIssueEntity CurrentOTIssueEntity
        {
            get
            {
                if (_IssueID > 0)
                {
                    if (_OTIssueEntity.IssueID != _IssueID)
                    {
                        _OTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(_IssueID);
                    }
                }

                return _OTIssueEntity;
            }
            set
            {
                _OTIssueEntity = value;
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
        }

        private void PrepareEditView()
        {
            OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;


            if (!oTIssueEntity.IsNew)
            {
            }
        }

        private void BindList()
        {
            BindOTIssueList();
        }

        private void BindOTIssueList()
        {
            lvOTIssue.DataBind();
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

        protected void lvOTIssue_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueID);

            if (IssueID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssueID = IssueID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, IssueID.ToString(), SQLMatchType.Equal);

                        OTIssueEntity oTIssueEntity = new OTIssueEntity();


                        result = FCCOTIssue.GetFacadeCreate().Delete(oTIssueEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();
                            BindOTIssueList();

                            MiscUtil.ShowMessage(lblMessage, "O TIssue has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete O TIssue.", true);
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

        protected void odsOTIssue_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueID = 0;
            _OTIssueEntity = new OTIssueEntity();
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
