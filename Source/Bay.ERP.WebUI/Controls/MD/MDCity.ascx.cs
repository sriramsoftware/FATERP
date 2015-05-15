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
    public partial class MDCityControl : BaseControl
    {       
        #region Properties

        public Int64 _CityID
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

        public MDCityEntity _MDCityEntity
        {
            get
            {
                MDCityEntity entity = new MDCityEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDCityEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDCityEntity CurrentMDCityEntity
        {
            get
            {
                if (_CityID > 0)
                {
                    if (_MDCityEntity.CityID != _CityID)
                    {
                        _MDCityEntity = FCCMDCity.GetFacadeCreate().GetByID(_CityID);
                    }
                }

                return _MDCityEntity;
            }
            set
            {
                _MDCityEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCountry(ddlCountryID, false);
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
            MDCityEntity mDCityEntity = CurrentMDCityEntity;


            if (!mDCityEntity.IsNew)
            {
                if (ddlCountryID.Items.Count > 0 && mDCityEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = mDCityEntity.CountryID.ToString();
                }

                txtName.Text = mDCityEntity.Name.ToString();
                chkIsRemoved.Checked = mDCityEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDCityList();
        }

        private void BindMDCityList()
        {
            lvMDCity.DataBind();
        }

        private MDCityEntity BuildMDCityEntity()
        {
            MDCityEntity mDCityEntity = CurrentMDCityEntity;

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDCityEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            mDCityEntity.Name = txtName.Text.Trim();
            mDCityEntity.IsRemoved = chkIsRemoved.Checked;


            return mDCityEntity;
        }

        private void SaveMDCityEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDCityEntity mDCityEntity = BuildMDCityEntity();

                    Int64 result = -1;

                    if (mDCityEntity.IsNew)
                    {
                        result = FCCMDCity.GetFacadeCreate().Add(mDCityEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDCityEntity.FLD_NAME_CityID, mDCityEntity.CityID.ToString(), SQLMatchType.Equal);
                        result = FCCMDCity.GetFacadeCreate().Update(mDCityEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CityID = 0;
                        _MDCityEntity = new MDCityEntity();
                        PrepareInitialView();
                        BindMDCityList();

                        if (mDCityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "City Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "City Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDCityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add City Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update City Information.", false);
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

        protected void lvMDCity_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CityID;

            Int64.TryParse(e.CommandArgument.ToString(), out CityID);

            if (CityID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CityID = CityID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDCityEntity.FLD_NAME_CityID, CityID.ToString(), SQLMatchType.Equal);

                        MDCityEntity mDCityEntity = new MDCityEntity();


                        result = FCCMDCity.GetFacadeCreate().Delete(mDCityEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CityID = 0;
                            _MDCityEntity = new MDCityEntity();
                            PrepareInitialView();
                            BindMDCityList();

                            MiscUtil.ShowMessage(lblMessage, "City has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete City.", true);
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

        protected void odsMDCity_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {  
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDCityEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CityID = 0;
            _MDCityEntity = new MDCityEntity();
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
