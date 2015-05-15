// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class ACCPostPayableStatementListControl : BaseControl
    {       
        #region Properties

        public Int64 _PostPayableStatementID
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

        public ACCPostPayableStatementEntity _ACCPostPayableStatementEntity
        {
            get
            {
                ACCPostPayableStatementEntity entity = new ACCPostPayableStatementEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCPostPayableStatementEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCPostPayableStatementEntity CurrentACCPostPayableStatementEntity
        {
            get
            {
                if (_PostPayableStatementID > 0)
                {
                    if (_ACCPostPayableStatementEntity.PostPayableStatementID != _PostPayableStatementID)
                    {
                        _ACCPostPayableStatementEntity = FCCACCPostPayableStatement.GetFacadeCreate().GetByID(_PostPayableStatementID);
                    }
                }

                return _ACCPostPayableStatementEntity;
            }
            set
            {
                _ACCPostPayableStatementEntity = value;
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
            ACCPostPayableStatementEntity aCCPostPayableStatementEntity = CurrentACCPostPayableStatementEntity;
        }

        private void BindList()
        {
            BindACCPostPayableStatementList();
        }

        private void BindACCPostPayableStatementList()
        {
            lvACCPostPayableStatement.DataBind();
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

        protected void lvACCPostPayableStatement_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPostPayableStatementEntity ent = (ACCPostPayableStatementEntity)dataItem.DataItem;

                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.POST_PAYABLE_REPORT, UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID, ent.PostPayableStatementID.ToString()).ToString();
                hypReport.Target = "_blank";
            }
        }

        protected void lvACCPostPayableStatement_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PostPayableStatementID;

            Int64.TryParse(e.CommandArgument.ToString(), out PostPayableStatementID);

            if (PostPayableStatementID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PostPayableStatementID = PostPayableStatementID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementEntity.FLD_NAME_PostPayableStatementID, PostPayableStatementID.ToString(), SQLMatchType.Equal);

                        ACCPostPayableStatementEntity aCCPostPayableStatementEntity = new ACCPostPayableStatementEntity();


                        result = FCCACCPostPayableStatement.GetFacadeCreate().Delete(aCCPostPayableStatementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PostPayableStatementID = 0;
                            _ACCPostPayableStatementEntity = new ACCPostPayableStatementEntity();
                            PrepareInitialView();
                            BindACCPostPayableStatementList();

                            //MiscUtil.ShowMessage(lblMessage, "Payable Statement has been successfully deleted.", true);
                        }
                        else
                        {
                           // MiscUtil.ShowMessage(lblMessage, "Failed to delete Payable Statement.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                       // MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACCPostPayableStatement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #endregion Event
    }
}
