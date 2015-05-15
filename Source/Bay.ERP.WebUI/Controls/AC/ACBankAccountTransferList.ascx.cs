// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class ACBankAccountTransferListControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountTransferID
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

        public ACBankAccountTransferEntity _ACBankAccountTransferEntity
        {
            get
            {
                ACBankAccountTransferEntity entity = new ACBankAccountTransferEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountTransferEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountTransferEntity CurrentACBankAccountTransferEntity
        {
            get
            {
                if (_BankAccountTransferID > 0)
                {
                    if (_ACBankAccountTransferEntity.BankAccountTransferID != _BankAccountTransferID)
                    {
                        _ACBankAccountTransferEntity = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(_BankAccountTransferID);
                    }
                }

                return _ACBankAccountTransferEntity;
            }
            set
            {
                _ACBankAccountTransferEntity = value;
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
            ACBankAccountTransferEntity aCBankAccountTransferEntity = CurrentACBankAccountTransferEntity;


            if (!aCBankAccountTransferEntity.IsNew)
            {
               
            }
        }

        private void BindList()
        {
            BindACBankAccountTransferList();
        }

        private void BindACBankAccountTransferList()
        {
            lvACBankAccountTransfer.DataBind();
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

        protected void lvACBankAccountTransfer_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACBankAccountTransfer_DetailedEntity ent = (ACBankAccountTransfer_DetailedEntity)dataItem.DataItem;
               
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER, ent.BankAccountTransferID);

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

        protected void lvACBankAccountTransfer_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountTransferID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountTransferID);

            if (BankAccountTransferID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountTransferID = BankAccountTransferID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountTransferEntity.FLD_NAME_BankAccountTransferID, BankAccountTransferID.ToString(), SQLMatchType.Equal);

                        ACBankAccountTransferEntity aCBankAccountTransferEntity = new ACBankAccountTransferEntity();


                        result = FCCACBankAccountTransfer.GetFacadeCreate().Delete(aCBankAccountTransferEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountTransferID = 0;
                            _ACBankAccountTransferEntity = new ACBankAccountTransferEntity();
                            PrepareInitialView();
                            BindACBankAccountTransferList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Transfer has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account Transfer.", true);
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

        protected void odsACBankAccountTransfer_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
