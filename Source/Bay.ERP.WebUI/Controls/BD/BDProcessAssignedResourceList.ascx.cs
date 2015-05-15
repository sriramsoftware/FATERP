// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-May-2013, 10:40:06




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
    public partial class BDProcessAssignedResourceListControl : BaseControl
    {       
        #region Properties

        public Int64 _ProcessAssignedResourceID
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

        public BDProcessAssignedResourceEntity _BDProcessAssignedResourceEntity
        {
            get
            {
                BDProcessAssignedResourceEntity entity = new BDProcessAssignedResourceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProcessAssignedResourceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProcessAssignedResourceEntity CurrentBDProcessAssignedResourceEntity
        {
            get
            {
                if (_ProcessAssignedResourceID > 0)
                {
                    if (_BDProcessAssignedResourceEntity.ProcessAssignedResourceID != _ProcessAssignedResourceID)
                    {
                        _BDProcessAssignedResourceEntity = FCCBDProcessAssignedResource.GetFacadeCreate().GetByID(_ProcessAssignedResourceID);
                    }
                }

                return _BDProcessAssignedResourceEntity;
            }
            set
            {
                _BDProcessAssignedResourceEntity = value;
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
            
        }

        private void BindList()
        {
            BindBDProcessAssignedResourceList();
        }

        private void BindBDProcessAssignedResourceList()
        {
            lvBDProcessAssignedResource.DataBind();
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

        protected void lvBDProcessAssignedResource_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDProcessAssignedResource_DetailedEntity ent = (BDProcessAssignedResource_DetailedEntity)dataItem.DataItem;

                HyperLink hypTitle = (HyperLink)e.Item.FindControl("hypTitle");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.CONTACT_LIST, ent.ProcessAssignedResourceID);
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

                hypTitle.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProcessAssignedResourceMap.aspx", string.Empty, UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID, ent.ProcessAssignedResourceID.ToString()).ToString();
                hypTitle.Target = "_blank";
            }
        }


        protected void lvBDProcessAssignedResource_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessAssignedResourceID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessAssignedResourceID);

            if (ProcessAssignedResourceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessAssignedResourceID = ProcessAssignedResourceID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, ProcessAssignedResourceID.ToString(), SQLMatchType.Equal);

                        BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();


                        result = FCCBDProcessAssignedResource.GetFacadeCreate().Delete(bDProcessAssignedResourceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessAssignedResourceID = 0;
                            _BDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
                            PrepareInitialView();
                            BindBDProcessAssignedResourceList();

                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Process Assigned Resource.", true);
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

        protected void odsBDProcessAssignedResource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #endregion Event
    }
}
