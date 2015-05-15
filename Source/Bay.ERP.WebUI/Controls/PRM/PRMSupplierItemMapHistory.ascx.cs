// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class PRMSupplierItemMapHistoryControl : BaseControl
    {       
        #region Properties

        public Int64 _SupplierItemMapHistoryID
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

        public PRMSupplierItemMapHistoryEntity _PRMSupplierItemMapHistoryEntity
        {
            get
            {
                PRMSupplierItemMapHistoryEntity entity = new PRMSupplierItemMapHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierItemMapHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierItemMapHistoryEntity CurrentPRMSupplierItemMapHistoryEntity
        {
            get
            {
                if (_SupplierItemMapHistoryID > 0)
                {
                    if (_PRMSupplierItemMapHistoryEntity.SupplierItemMapHistoryID != _SupplierItemMapHistoryID)
                    {
                        _PRMSupplierItemMapHistoryEntity = FCCPRMSupplierItemMapHistory.GetFacadeCreate().GetByID(_SupplierItemMapHistoryID);
                    }
                }

                return _PRMSupplierItemMapHistoryEntity;
            }
            set
            {
                _PRMSupplierItemMapHistoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
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
            PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity = CurrentPRMSupplierItemMapHistoryEntity;
        }

        private void BindList()
        {
            BindPRMSupplierItemMapHistoryList();
        }

        private void BindPRMSupplierItemMapHistoryList()
        {
            lvPRMSupplierItemMapHistory.DataBind();
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

        protected void lvPRMSupplierItemMapHistory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierItemMapHistoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierItemMapHistoryID);

            if (SupplierItemMapHistoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierItemMapHistoryID = SupplierItemMapHistoryID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapHistoryEntity.FLD_NAME_SupplierItemMapHistoryID, SupplierItemMapHistoryID.ToString(), SQLMatchType.Equal);

                        PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity = new PRMSupplierItemMapHistoryEntity();


                        result = FCCPRMSupplierItemMapHistory.GetFacadeCreate().Delete(pRMSupplierItemMapHistoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierItemMapHistoryID = 0;
                            _PRMSupplierItemMapHistoryEntity = new PRMSupplierItemMapHistoryEntity();
                            PrepareInitialView();
                            BindPRMSupplierItemMapHistoryList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Map History has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Item Map History.", true);
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

        protected void odsPRMSupplierItemMapHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ddlSupplierID.SelectedValue != "0" && ddlItemID.SelectedValue=="0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemMap." + PRMSupplierItemMapHistory_CustomEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlItemID.SelectedValue != "0" && ddlSupplierID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemMap." + PRMSupplierItemMapHistory_CustomEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlItemID.SelectedValue != "0" && ddlSupplierID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemMap." + PRMSupplierItemMapHistory_CustomEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemMap." + PRMSupplierItemMapHistory_CustomEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (txtFromDate.Text.Trim().IsNotNullOrEmpty() && txtToDate.Text.IsNotNullOrEmpty())
            {
                String fe1 = "PRMSupplierItemMap." + PRMSupplierItemMapHistoryEntity.FLD_NAME_EntryDate + " between '" + MiscUtil.ParseToDateTime(txtFromDate.Text.ToString()) + "' AND '" + MiscUtil.ParseToDateTime(txtToDate.Text.ToString()) + "'";

                if(fe.IsNotNullOrEmpty())
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }

                else if (fe == String.Empty)
                {
                    fe = fe1;
                }
            }
            
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
