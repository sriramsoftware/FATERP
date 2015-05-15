// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMBuyerInterestedRoomMapControl : BaseControl
    {       
        #region Properties

        public Int64 _BuyerInterestedRoomMapID
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

        public CRMBuyerInterestedRoomMapEntity _CRMBuyerInterestedRoomMapEntity
        {
            get
            {
                CRMBuyerInterestedRoomMapEntity entity = new CRMBuyerInterestedRoomMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMBuyerInterestedRoomMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMBuyerInterestedRoomMapEntity CurrentCRMBuyerInterestedRoomMapEntity
        {
            get
            {
                if (_BuyerInterestedRoomMapID > 0)
                {
                    if (_CRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomMapID != _BuyerInterestedRoomMapID)
                    {
                        _CRMBuyerInterestedRoomMapEntity = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetByID(_BuyerInterestedRoomMapID);
                    }
                }

                return _CRMBuyerInterestedRoomMapEntity;
            }
            set
            {
                _CRMBuyerInterestedRoomMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false);
            MiscUtil.PopulateCRMMDBuyerInterestedRoomCategory(ddlBuyerInterestedRoomCategoryID, false);
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
            CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity = CurrentCRMBuyerInterestedRoomMapEntity;


            if (!cRMBuyerInterestedRoomMapEntity.IsNew)
            {
                if (ddlBuyerBasicInfoID.Items.Count > 0 && cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID != null)
                {
                    ddlBuyerBasicInfoID.SelectedValue = cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID.ToString();
                }

                if (ddlBuyerInterestedRoomCategoryID.Items.Count > 0 && cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID != null)
                {
                    ddlBuyerInterestedRoomCategoryID.SelectedValue = cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMBuyerInterestedRoomMapList();
        }

        private void BindCRMBuyerInterestedRoomMapList()
        {
            lvCRMBuyerInterestedRoomMap.DataBind();
        }

        private CRMBuyerInterestedRoomMapEntity BuildCRMBuyerInterestedRoomMapEntity()
        {
            CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity = CurrentCRMBuyerInterestedRoomMapEntity;

            if (ddlBuyerBasicInfoID.Items.Count > 0)
            {
                if (ddlBuyerBasicInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID = Int64.Parse(ddlBuyerBasicInfoID.SelectedValue);
                }
            }

            if (ddlBuyerInterestedRoomCategoryID.Items.Count > 0)
            {
                if (ddlBuyerInterestedRoomCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID = Int64.Parse(ddlBuyerInterestedRoomCategoryID.SelectedValue);
                }
            }


            return cRMBuyerInterestedRoomMapEntity;
        }

        private void SaveCRMBuyerInterestedRoomMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity = BuildCRMBuyerInterestedRoomMapEntity();

                    Int64 result = -1;

                    if (cRMBuyerInterestedRoomMapEntity.IsNew)
                    {
                        result = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().Add(cRMBuyerInterestedRoomMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerInterestedRoomMapID, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomMapID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().Update(cRMBuyerInterestedRoomMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BuyerInterestedRoomMapID = 0;
                        _CRMBuyerInterestedRoomMapEntity = new CRMBuyerInterestedRoomMapEntity();
                        PrepareInitialView();
                        BindCRMBuyerInterestedRoomMapList();

                        if (cRMBuyerInterestedRoomMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Interested Room Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Interested Room Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMBuyerInterestedRoomMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMBuyer Interested Room Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMBuyer Interested Room Map Information.", false);
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

        protected void lvCRMBuyerInterestedRoomMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerInterestedRoomMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerInterestedRoomMapID);

            if (BuyerInterestedRoomMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerInterestedRoomMapID = BuyerInterestedRoomMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerInterestedRoomMapID, BuyerInterestedRoomMapID.ToString(), SQLMatchType.Equal);

                        CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity = new CRMBuyerInterestedRoomMapEntity();


                        result = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().Delete(cRMBuyerInterestedRoomMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerInterestedRoomMapID = 0;
                            _CRMBuyerInterestedRoomMapEntity = new CRMBuyerInterestedRoomMapEntity();
                            PrepareInitialView();
                            BindCRMBuyerInterestedRoomMapList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Interested Room Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBuyer Interested Room Map.", true);
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

        protected void odsCRMBuyerInterestedRoomMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMBuyerInterestedRoomMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerInterestedRoomMapID = 0;
            _CRMBuyerInterestedRoomMapEntity = new CRMBuyerInterestedRoomMapEntity();
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
