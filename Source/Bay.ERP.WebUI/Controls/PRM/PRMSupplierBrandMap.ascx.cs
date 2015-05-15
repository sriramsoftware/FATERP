// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




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
    public partial class PRMSupplierBrandMapControl : SupplierBaseControl
    {       
        #region Properties

        public Int64 _SupplierBrandMapID
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

        public PRMSupplierBrandMapEntity _PRMSupplierBrandMapEntity
        {
            get
            {
                PRMSupplierBrandMapEntity entity = new PRMSupplierBrandMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierBrandMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierBrandMapEntity CurrentPRMSupplierBrandMapEntity
        {
            get
            {
                if (_SupplierBrandMapID > 0)
                {
                    if (_PRMSupplierBrandMapEntity.SupplierBrandMapID != _SupplierBrandMapID)
                    {
                        _PRMSupplierBrandMapEntity = FCCPRMSupplierBrandMap.GetFacadeCreate().GetByID(_SupplierBrandMapID);
                    }
                }

                return _PRMSupplierBrandMapEntity;
            }
            set
            {
                _PRMSupplierBrandMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDBrandExceptNotAvailable(ddlBrandID, false);
            MiscUtil.PopulateMDRegion(ddlOriginRegionID, false);
            BuildDropdownByRegionID();
        }

        private void BuildDropdownByRegionID()
        {
            if (ddlOriginRegionID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlOriginCountryID, false, Int64.Parse(ddlOriginRegionID.SelectedValue));
            }
            else
            {
                ddlOriginCountryID.Items.Clear();
            }
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
            PRMSupplierBrandMapEntity pRMSupplierBrandMapEntity = CurrentPRMSupplierBrandMapEntity;

            if (!pRMSupplierBrandMapEntity.IsNew)
            { 

                if (ddlBrandID.Items.Count > 0 && pRMSupplierBrandMapEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = pRMSupplierBrandMapEntity.BrandID.ToString();
                }

                if (ddlOriginRegionID.Items.Count > 0 && pRMSupplierBrandMapEntity.OriginRegionID != null)
                {
                    ddlOriginRegionID.SelectedValue = pRMSupplierBrandMapEntity.OriginRegionID.ToString();
                }
                if (ddlOriginRegionID.SelectedValue != "0")
                {
                    MiscUtil.PopulateMDCountryByRegionID(ddlOriginCountryID, true, Int64.Parse(ddlOriginRegionID.SelectedValue));
                }
                if (ddlOriginCountryID.Items.Count > 0 && pRMSupplierBrandMapEntity.OriginCountryID != null)
                {
                    ddlOriginCountryID.SelectedValue = pRMSupplierBrandMapEntity.OriginCountryID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMSupplierBrandMapList();
        }

        private void BindPRMSupplierBrandMapList()
        {
            lvPRMSupplierBrandMap.DataBind();
        }

        private PRMSupplierBrandMapEntity BuildPRMSupplierBrandMapEntity()
        {
            PRMSupplierBrandMapEntity pRMSupplierBrandMapEntity = CurrentPRMSupplierBrandMapEntity;

            pRMSupplierBrandMapEntity.SupplierID = this.OverviewSupplierID;

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMSupplierBrandMapEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlOriginRegionID.Items.Count > 0)
            {
                if (ddlOriginRegionID.SelectedValue == "0")
                {
                    pRMSupplierBrandMapEntity.OriginRegionID = null;
                }
                else
                {
                    pRMSupplierBrandMapEntity.OriginRegionID = Int64.Parse(ddlOriginRegionID.SelectedValue);
                }
            }

            if (ddlOriginCountryID.Items.Count > 0)
            {
                if (ddlOriginCountryID.SelectedValue == "0")
                {
                    pRMSupplierBrandMapEntity.OriginCountryID = null;
                }
                else
                {
                    pRMSupplierBrandMapEntity.OriginCountryID = Int64.Parse(ddlOriginCountryID.SelectedValue);
                }
            }


            return pRMSupplierBrandMapEntity;
        }

        private void SavePRMSupplierBrandMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMSupplierBrandMapEntity pRMSupplierBrandMapEntity = BuildPRMSupplierBrandMapEntity();

                    Int64 result = -1;

                    if (pRMSupplierBrandMapEntity.IsNew)
                    {
                        result = FCCPRMSupplierBrandMap.GetFacadeCreate().Add(pRMSupplierBrandMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierBrandMapEntity.FLD_NAME_SupplierBrandMapID, pRMSupplierBrandMapEntity.SupplierBrandMapID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMSupplierBrandMap.GetFacadeCreate().Update(pRMSupplierBrandMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierBrandMapID = 0;
                        _PRMSupplierBrandMapEntity = new PRMSupplierBrandMapEntity();
                        PrepareInitialView();
                        BindPRMSupplierBrandMapList();

                        if (pRMSupplierBrandMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Brand Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Brand Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMSupplierBrandMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Brand Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Brand Map Information.", false);
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

        protected void lvPRMSupplierBrandMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierBrandMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierBrandMapID);

            if (SupplierBrandMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierBrandMapID = SupplierBrandMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierBrandMapEntity.FLD_NAME_SupplierBrandMapID, SupplierBrandMapID.ToString(), SQLMatchType.Equal);

                        PRMSupplierBrandMapEntity pRMSupplierBrandMapEntity = new PRMSupplierBrandMapEntity();


                        result = FCCPRMSupplierBrandMap.GetFacadeCreate().Delete(pRMSupplierBrandMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierBrandMapID = 0;
                            _PRMSupplierBrandMapEntity = new PRMSupplierBrandMapEntity();
                            PrepareInitialView();
                            BindPRMSupplierBrandMapList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Brand Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Brand Map.", true);
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

        protected void odsPRMSupplierBrandMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierBrandMap." + PRMSupplierBrandMapEntity.FLD_NAME_SupplierID, this.OverviewSupplierID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMSupplierBrandMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierBrandMapID = 0;
            _PRMSupplierBrandMapEntity = new PRMSupplierBrandMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlOriginRegionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildDropdownByRegionID();
        }

        #endregion

        #endregion Event
    }
}
