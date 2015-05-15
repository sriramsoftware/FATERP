// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




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
    public partial class BDProjectAddressInfoControl : ProjectBaseControl
    {
        #region Properties

        public Int64 _ProjectAddressInfoID
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

        public BDProjectAddressInfoEntity _BDProjectAddressInfoEntity
        {
            get
            {
                BDProjectAddressInfoEntity entity = new BDProjectAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectAddressInfoEntity CurrentBDProjectAddressInfoEntity
        {
            get
            {
                if (_ProjectAddressInfoID > 0)
                {
                    if (_BDProjectAddressInfoEntity.ProjectAddressInfoID != _ProjectAddressInfoID)
                    {
                        _BDProjectAddressInfoEntity = FCCBDProjectAddressInfo.GetFacadeCreate().GetByID(_ProjectAddressInfoID);
                    }
                }

                return _BDProjectAddressInfoEntity;
            }
            set
            {
                _BDProjectAddressInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCountry(ddlCountryID, true);


            // Select 'Bangladesh' By Default
            if (ddlCountryID != null && ddlCountryID.Items.Count > 0)
            {
                ListItem lstCountryItem = ddlCountryID.Items.FindByText("Bangladesh");

                if (lstCountryItem != null)
                {
                    ddlCountryID.SelectedValue = lstCountryItem.Value.ToString();
                }
            }

            BuildDropDownListByCountry();
        }

        private void BuildDropDownListByCountry()
        {
            if (ddlCountryID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));

                if (ddlCityID != null && ddlCityID.Items.Count > 0)
                {
                    ListItem lstCityItem = ddlCityID.Items.FindByText("Dhaka");

                    if (lstCityItem != null)
                    {
                        ddlCityID.SelectedValue = lstCityItem.Value.ToString();
                    }
                }
            }
            else
            {
                ddlCityID.Items.Clear();
            }
        }

        private void PrepareValidator()
        {
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtZipCode.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectAddressInfoEntity bDProjectAddressInfoEntity = CurrentBDProjectAddressInfoEntity;


            if (!bDProjectAddressInfoEntity.IsNew)
            {
                txtAddressLine1.Text = bDProjectAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = bDProjectAddressInfoEntity.AddressLine2.ToString();
                if (ddlCountryID.Items.Count > 0 && bDProjectAddressInfoEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = bDProjectAddressInfoEntity.CountryID.ToString();
                    MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));
                }

                if (ddlCityID.Items.Count > 0 && bDProjectAddressInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = bDProjectAddressInfoEntity.CityID.ToString();
                }

                txtZipCode.Text = bDProjectAddressInfoEntity.ZipCode.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectAddressInfoList();
        }

        private void BindBDProjectAddressInfoList()
        {
            lvBDProjectAddressInfo.DataBind();
        }

        private BDProjectAddressInfoEntity BuildBDProjectAddressInfoEntity()
        {
            BDProjectAddressInfoEntity bDProjectAddressInfoEntity = CurrentBDProjectAddressInfoEntity;

            bDProjectAddressInfoEntity.ProjectID = this.OverviewProjectID;
            bDProjectAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            bDProjectAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                    bDProjectAddressInfoEntity.CountryID = null;
                }
                else
                {
                    bDProjectAddressInfoEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    bDProjectAddressInfoEntity.CityID = null;
                }
                else
                {
                    bDProjectAddressInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            bDProjectAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();

            return bDProjectAddressInfoEntity;
        }

        private void SaveBDProjectAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectAddressInfoEntity bDProjectAddressInfoEntity = BuildBDProjectAddressInfoEntity();

                    Int64 result = -1;

                    if (bDProjectAddressInfoEntity.IsNew)
                    {
                        result = FCCBDProjectAddressInfo.GetFacadeCreate().Add(bDProjectAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAddressInfoEntity.FLD_NAME_ProjectAddressInfoID, bDProjectAddressInfoEntity.ProjectAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectAddressInfo.GetFacadeCreate().Update(bDProjectAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectAddressInfoID = 0;
                        _BDProjectAddressInfoEntity = new BDProjectAddressInfoEntity();
                        PrepareInitialView();
                        BindBDProjectAddressInfoList();

                        if (bDProjectAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Address Info Information.", false);
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

        protected void lvBDProjectAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectAddressInfoID);

            if (ProjectAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectAddressInfoID = ProjectAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAddressInfoEntity.FLD_NAME_ProjectAddressInfoID, ProjectAddressInfoID.ToString(), SQLMatchType.Equal);

                        BDProjectAddressInfoEntity bDProjectAddressInfoEntity = new BDProjectAddressInfoEntity();


                        result = FCCBDProjectAddressInfo.GetFacadeCreate().Delete(bDProjectAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectAddressInfoID = 0;
                            _BDProjectAddressInfoEntity = new BDProjectAddressInfoEntity();
                            PrepareInitialView();
                            BindBDProjectAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Project Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Address Info.", true);
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

        protected void odsBDProjectAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("BDProjectAddressInfo." + BDProjectAddressInfoEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectAddressInfoID = 0;
            _BDProjectAddressInfoEntity = new BDProjectAddressInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildDropDownListByCountry();
        }

        #endregion

        #endregion Event

    }
}
