// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class MDCountryControl : BaseControl
    {       
        #region Properties

        public Int64 _CountryID
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

        public MDCountryEntity _MDCountryEntity
        {
            get
            {
                MDCountryEntity entity = new MDCountryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDCountryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDCountryEntity CurrentMDCountryEntity
        {
            get
            {
                if (_CountryID > 0)
                {
                    if (_MDCountryEntity.CountryID != _CountryID)
                    {
                        _MDCountryEntity = FCCMDCountry.GetFacadeCreate().GetByID(_CountryID);
                    }
                }

                return _MDCountryEntity;
            }
            set
            {
                _MDCountryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDRegion(ddlRegionID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDCountryEntity mDCountryEntity = CurrentMDCountryEntity;


            if (!mDCountryEntity.IsNew)
            {
                if (ddlRegionID.Items.Count > 0 && mDCountryEntity.RegionID != null)
                {
                    ddlRegionID.SelectedValue = mDCountryEntity.RegionID.ToString();
                }

                txtName.Text = mDCountryEntity.Name.ToString();
                chkIsRemoved.Checked = mDCountryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDCountryList();
        }

        private void BindMDCountryList()
        {
            lvMDCountry.DataBind();
        }

        private MDCountryEntity BuildMDCountryEntity()
        {
            MDCountryEntity mDCountryEntity = CurrentMDCountryEntity;

            if (ddlRegionID.Items.Count > 0)
            {
                if (ddlRegionID.SelectedValue == "0")
                {
                }
                else
                {
                    mDCountryEntity.RegionID = Int64.Parse(ddlRegionID.SelectedValue);
                }
            }

            mDCountryEntity.Name = txtName.Text.Trim();
            mDCountryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDCountryEntity;
        }

        private void SaveMDCountryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDCountryEntity mDCountryEntity = BuildMDCountryEntity();

                    Int64 result = -1;

                    if (mDCountryEntity.IsNew)
                    {
                        result = FCCMDCountry.GetFacadeCreate().Add(mDCountryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDCountryEntity.FLD_NAME_CountryID, mDCountryEntity.CountryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDCountry.GetFacadeCreate().Update(mDCountryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CountryID = 0;
                        _MDCountryEntity = new MDCountryEntity();
                        PrepareInitialView();
                        BindMDCountryList();

                        if (mDCountryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Country Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Country Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDCountryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Country Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Country Information.", false);
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

        protected void lvMDCountry_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CountryID;

            Int64.TryParse(e.CommandArgument.ToString(), out CountryID);

            if (CountryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CountryID = CountryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDCountryEntity.FLD_NAME_CountryID, CountryID.ToString(), SQLMatchType.Equal);

                        MDCountryEntity mDCountryEntity = new MDCountryEntity();


                        result = FCCMDCountry.GetFacadeCreate().Delete(mDCountryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CountryID = 0;
                            _MDCountryEntity = new MDCountryEntity();
                            PrepareInitialView();
                            BindMDCountryList();

                            MiscUtil.ShowMessage(lblMessage, "Country has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Country.", true);
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

        protected void odsMDCountry_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDCountryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CountryID = 0;
            _MDCountryEntity = new MDCountryEntity();
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
