// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




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
    public partial class INVApprovedTransferListControl : BaseControl
    {       
        #region Properties

        public Int64 _TransferID
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

        public INVTransferEntity _INVTransferEntity
        {
            get
            {
                INVTransferEntity entity = new INVTransferEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVTransferEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVTransferEntity CurrentINVTransferEntity
        {
            get
            {
                if (_TransferID > 0)
                {
                    if (_INVTransferEntity.TransferID != _TransferID)
                    {
                        _INVTransferEntity = FCCINVTransfer.GetFacadeCreate().GetByID(_TransferID);
                    }
                }

                return _INVTransferEntity;
            }
            set
            {
                _INVTransferEntity = value;
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
            INVTransferEntity iNVTransferEntity = CurrentINVTransferEntity;
            

            if (!iNVTransferEntity.IsNew)
            {
               
            }
        }

        private void BindList()
        {
            BindINVTransferList();
        }

        private void BindINVTransferList()
        {
            lvINVTransfer.DataBind();
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

        protected void lvINVTransfer_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                INVTransfer_DetailedEntity ent = (INVTransfer_DetailedEntity)dataItem.DataItem;

                HyperLink hypTRFNo = (HyperLink)e.Item.FindControl("hypTRFNo");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                hypTRFNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransferItem.aspx", string.Empty, UrlConstants.OVERVIEW_TRANSFER_ID, ent.TransferID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.TRF, ent.TransferID);
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

                hypTRFNo.Target = "_blank";
            }
        }

        protected void lvINVTransfer_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TransferID;

            Int64.TryParse(e.CommandArgument.ToString(), out TransferID);

            if (TransferID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TransferID = TransferID;
                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferEntity.FLD_NAME_TransferID, TransferID.ToString(), SQLMatchType.Equal);

                        INVTransferEntity iNVTransferEntity = new INVTransferEntity();

                        result = FCCINVTransfer.GetFacadeCreate().Delete(iNVTransferEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TransferID = 0;
                            _INVTransferEntity = new INVTransferEntity();
                            PrepareInitialView();
                            BindINVTransferList();

                            MiscUtil.ShowMessage(lblMessage, "I NVTransfer has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVTransfer.", true);
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

        protected void odsINVTransfer_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("INVTransfer." + INVTransferEntity.FLD_NAME_InventoryTransferStatusID, MasterDataConstants.INVTransferApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
