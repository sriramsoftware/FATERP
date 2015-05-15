// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2013, 01:39:59




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
    public partial class MDArtGalleriaLocationControl : BaseControl
    {       
        #region Properties

        public Int64 _ArtGalleriaLocationID
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

        public MDArtGalleriaLocationEntity _MDArtGalleriaLocationEntity
        {
            get
            {
                MDArtGalleriaLocationEntity entity = new MDArtGalleriaLocationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDArtGalleriaLocationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDArtGalleriaLocationEntity CurrentMDArtGalleriaLocationEntity
        {
            get
            {
                if (_ArtGalleriaLocationID > 0)
                {
                    if (_MDArtGalleriaLocationEntity.ArtGalleriaLocationID != _ArtGalleriaLocationID)
                    {
                        _MDArtGalleriaLocationEntity = FCCMDArtGalleriaLocation.GetFacadeCreate().GetByID(_ArtGalleriaLocationID);
                    }
                }

                return _MDArtGalleriaLocationEntity;
            }
            set
            {
                _MDArtGalleriaLocationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDArtGalleriaLocation(ddlParentArtGalleriaLocationID, true);
            MiscUtil.PopulateMDCountry(ddlCountryID, false);

            BindCityByCountry();
        }

        private void BindCityByCountry()
        {
            if (ddlCountryID!=null && ddlCountryID.Items.Count>0)
            {
                MiscUtil.PopulateMDCityByCountryID(ddlCityID, false, Int64.Parse(ddlCountryID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity = CurrentMDArtGalleriaLocationEntity;


            if (!mDArtGalleriaLocationEntity.IsNew)
            {
                if (ddlParentArtGalleriaLocationID.Items.Count > 0 && mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID != null)
                {
                    ddlParentArtGalleriaLocationID.SelectedValue = mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID.ToString();
                }

                if (ddlCountryID.Items.Count > 0 && mDArtGalleriaLocationEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = mDArtGalleriaLocationEntity.CountryID.ToString();
                }

                BindCityByCountry();

                if (ddlCityID.Items.Count > 0 && mDArtGalleriaLocationEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = mDArtGalleriaLocationEntity.CityID.ToString();
                }

                txtName.Text = mDArtGalleriaLocationEntity.Name.ToString();
                txtDescription.Text = mDArtGalleriaLocationEntity.Description.ToString();
                chkIsRemoved.Checked = mDArtGalleriaLocationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDArtGalleriaLocationList();
        }

        private void BindMDArtGalleriaLocationList()
        {
            lvMDArtGalleriaLocation.DataBind();
        }

        private MDArtGalleriaLocationEntity BuildMDArtGalleriaLocationEntity()
        {
            MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity = CurrentMDArtGalleriaLocationEntity;

            if (ddlParentArtGalleriaLocationID.Items.Count > 0)
            {
                if (ddlParentArtGalleriaLocationID.SelectedValue == "0")
                {
                    mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID = null;
                }
                else
                {
                    mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID = Int64.Parse(ddlParentArtGalleriaLocationID.SelectedValue);
                }
            }

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDArtGalleriaLocationEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                }
                else
                {
                    mDArtGalleriaLocationEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            mDArtGalleriaLocationEntity.Name = txtName.Text.Trim();
            mDArtGalleriaLocationEntity.Description = txtDescription.Text.Trim();
            mDArtGalleriaLocationEntity.IsRemoved = chkIsRemoved.Checked;


            return mDArtGalleriaLocationEntity;
        }

        private void SaveMDArtGalleriaLocationEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity = BuildMDArtGalleriaLocationEntity();

                    Int64 result = -1;

                    if (mDArtGalleriaLocationEntity.IsNew)
                    {
                        result = FCCMDArtGalleriaLocation.GetFacadeCreate().Add(mDArtGalleriaLocationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDArtGalleriaLocationEntity.FLD_NAME_ArtGalleriaLocationID, mDArtGalleriaLocationEntity.ArtGalleriaLocationID.ToString(), SQLMatchType.Equal);
                        result = FCCMDArtGalleriaLocation.GetFacadeCreate().Update(mDArtGalleriaLocationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ArtGalleriaLocationID = 0;
                        _MDArtGalleriaLocationEntity = new MDArtGalleriaLocationEntity();
                        PrepareInitialView();
                        BindMDArtGalleriaLocationList();

                        if (mDArtGalleriaLocationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Art Galleria Location Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Art Galleria Location Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDArtGalleriaLocationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Art Galleria Location Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Art Galleria Location Information.", false);
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

        protected void lvMDArtGalleriaLocation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ArtGalleriaLocationID;

            Int64.TryParse(e.CommandArgument.ToString(), out ArtGalleriaLocationID);

            if (ArtGalleriaLocationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ArtGalleriaLocationID = ArtGalleriaLocationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDArtGalleriaLocationEntity.FLD_NAME_ArtGalleriaLocationID, ArtGalleriaLocationID.ToString(), SQLMatchType.Equal);

                        MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity = new MDArtGalleriaLocationEntity();


                        result = FCCMDArtGalleriaLocation.GetFacadeCreate().Delete(mDArtGalleriaLocationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ArtGalleriaLocationID = 0;
                            _MDArtGalleriaLocationEntity = new MDArtGalleriaLocationEntity();
                            PrepareInitialView();
                            BindMDArtGalleriaLocationList();

                            MiscUtil.ShowMessage(lblMessage, "Art Galleria Location has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Art Galleria Location.", true);
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

        protected void odsMDArtGalleriaLocation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDArtGalleriaLocationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ArtGalleriaLocationID = 0;
            _MDArtGalleriaLocationEntity = new MDArtGalleriaLocationEntity();
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
            BindCityByCountry();
        }

        #endregion

        #endregion Event
    }
}
