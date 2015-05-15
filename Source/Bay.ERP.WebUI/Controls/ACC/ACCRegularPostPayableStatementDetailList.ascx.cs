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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class ACCRegularPostPayableStatementDetailListControl : BaseControl
    {       
        #region Properties

        public Int64 _PostPayableStatementDetailID
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

        public ACCPostPayableStatementDetailEntity _ACCPostPayableStatementDetailEntity
        {
            get
            {
                ACCPostPayableStatementDetailEntity entity = new ACCPostPayableStatementDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCPostPayableStatementDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCPostPayableStatementDetailEntity CurrentACCPostPayableStatementDetailEntity
        {
            get
            {
                if (_PostPayableStatementDetailID > 0)
                {
                    if (_ACCPostPayableStatementDetailEntity.PostPayableStatementDetailID != _PostPayableStatementDetailID)
                    {
                        _ACCPostPayableStatementDetailEntity = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(_PostPayableStatementDetailID);
                    }
                }

                return _ACCPostPayableStatementDetailEntity;
            }
            set
            {
                _ACCPostPayableStatementDetailEntity = value;
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
          
        }

        private void PrepareEditView()
        {
           
        }

        private void BindList()
        {
            BindACCPostPayableStatementDetailList();
        }

        private void BindACCPostPayableStatementDetailList()
        {
            lvACCPostPayableStatementDetail.DataBind();
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

        protected void lvACCPostPayableStatementDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPostPayableStatementDetail_DetailedEntity ent = (ACCPostPayableStatementDetail_DetailedEntity)dataItem.DataItem;

                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.PAYABLE_STATEMENT, ent.PostPayableStatementDetailID);
                if (aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/AP/APView.aspx",
                               string.Empty,
                               APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                               aPApprovalProcessEntity.APApprovalProcessID.ToString()
                               ).ToString();

                    lnkShowApprovalStatus.Target = "_blank";
                }
                else
                {
                    lnkShowApprovalStatus.NavigateUrl = String.Empty;
                    lnkShowApprovalStatus.Enabled = false;
                }
            }
        }

        protected void lvACCPostPayableStatementDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PostPayableStatementDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out PostPayableStatementDetailID);

            if (PostPayableStatementDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PostPayableStatementDetailID = PostPayableStatementDetailID;

                    PrepareEditView();


                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, PostPayableStatementDetailID.ToString(), SQLMatchType.Equal);

                        ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();


                        result = FCCACCPostPayableStatementDetail.GetFacadeCreate().Delete(aCCPostPayableStatementDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PostPayableStatementDetailID = 0;
                            _ACCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();
                            PrepareInitialView();
                            BindACCPostPayableStatementDetailList();

                            MiscUtil.ShowMessage(lblMessage, "A CCPost Payable Statement Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CCPost Payable Statement Detail.", true);
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

        protected void odsACCPostPayableStatementDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail." + ACCPostPayableStatementDetailEntity.FLD_NAME_AccountPaybleStatementDetailCategoryID, MasterDataConstants.MDAccountPaybleStatementDetailCategory.REGULAR.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail.WorkOrderNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail.BillNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier.SupplierName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("MDACCPayableApprovalStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                String fe7 = SqlExpressionBuilder.PrepareFilterExpression(fe5, SQLJoinType.OR, fe6);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe7);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
