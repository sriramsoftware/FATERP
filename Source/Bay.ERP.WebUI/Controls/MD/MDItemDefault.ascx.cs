// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class MDItemDefaultControl : BaseControl
    {       
        #region Properties

        public Int64 _ItemDefaultID
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

        public MDItemDefaultEntity _MDItemDefaultEntity
        {
            get
            {
                MDItemDefaultEntity entity = new MDItemDefaultEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDItemDefaultEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDItemDefaultEntity CurrentMDItemDefaultEntity
        {
            get
            {
                if (_ItemDefaultID > 0)
                {
                    if (_MDItemDefaultEntity.ItemDefaultID != _ItemDefaultID)
                    {
                        _MDItemDefaultEntity = FCCMDItemDefault.GetFacadeCreate().GetByID(_ItemDefaultID);
                    }
                }

                return _MDItemDefaultEntity;
            }
            set
            {
                _MDItemDefaultEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItem(ddlItemID, false);
            MiscUtil.PopulateMDBrand(ddlBrandID, false);
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, false);
            MiscUtil.PopulateMDRegion(ddlRegionID, false);
            MiscUtil.PopulateMDCountry(ddlCountryID, false);
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
            MDItemDefaultEntity mDItemDefaultEntity = CurrentMDItemDefaultEntity;


            if (!mDItemDefaultEntity.IsNew)
            {
                if (ddlItemID.Items.Count > 0 && mDItemDefaultEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = mDItemDefaultEntity.ItemID.ToString();
                }

                if (ddlBrandID.Items.Count > 0 && mDItemDefaultEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = mDItemDefaultEntity.BrandID.ToString();
                }

                if (ddlSupplierID.Items.Count > 0 && mDItemDefaultEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = mDItemDefaultEntity.SupplierID.ToString();
                }

                if (ddlRegionID.Items.Count > 0 && mDItemDefaultEntity.RegionID != null)
                {
                    ddlRegionID.SelectedValue = mDItemDefaultEntity.RegionID.ToString();
                }

                if (ddlCountryID.Items.Count > 0 && mDItemDefaultEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = mDItemDefaultEntity.CountryID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDItemDefaultList();
        }

        private void BindMDItemDefaultList()
        {
            lvMDItemDefault.DataBind();
        }

        private MDItemDefaultEntity BuildMDItemDefaultEntity()
        {
            MDItemDefaultEntity mDItemDefaultEntity = CurrentMDItemDefaultEntity;

            if (ddlItemID.Items.Count > 0)
            {
                if (ddlItemID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                }
            }

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlRegionID.Items.Count > 0)
            {
                if (ddlRegionID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.RegionID = Int64.Parse(ddlRegionID.SelectedValue);
                }
            }

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemDefaultEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }


            return mDItemDefaultEntity;
        }

        private void SaveMDItemDefaultEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDItemDefaultEntity mDItemDefaultEntity = BuildMDItemDefaultEntity();

                    Int64 result = -1;

                    if (mDItemDefaultEntity.IsNew)
                    {
                        result = FCCMDItemDefault.GetFacadeCreate().Add(mDItemDefaultEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemDefaultID, mDItemDefaultEntity.ItemDefaultID.ToString(), SQLMatchType.Equal);
                        result = FCCMDItemDefault.GetFacadeCreate().Update(mDItemDefaultEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ItemDefaultID = 0;
                        _MDItemDefaultEntity = new MDItemDefaultEntity();
                        PrepareInitialView();
                        BindMDItemDefaultList();

                        if (mDItemDefaultEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Default Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Default Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDItemDefaultEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Item Default Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Item Default Information.", false);
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

        protected void lvMDItemDefault_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ItemDefaultID;

            Int64.TryParse(e.CommandArgument.ToString(), out ItemDefaultID);

            if (ItemDefaultID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ItemDefaultID = ItemDefaultID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemDefaultEntity.FLD_NAME_ItemDefaultID, ItemDefaultID.ToString(), SQLMatchType.Equal);

                        MDItemDefaultEntity mDItemDefaultEntity = new MDItemDefaultEntity();


                        result = FCCMDItemDefault.GetFacadeCreate().Delete(mDItemDefaultEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ItemDefaultID = 0;
                            _MDItemDefaultEntity = new MDItemDefaultEntity();
                            PrepareInitialView();
                            BindMDItemDefaultList();

                            MiscUtil.ShowMessage(lblMessage, "Item Default has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Item Default.", true);
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

        protected void odsMDItemDefault_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDItemDefaultEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ItemDefaultID = 0;
            _MDItemDefaultEntity = new MDItemDefaultEntity();
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
