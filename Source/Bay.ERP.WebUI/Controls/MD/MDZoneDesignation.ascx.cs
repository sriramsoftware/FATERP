// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2015, 10:30:28




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
    public partial class MDZoneDesignationControl : BaseControl
    {       
        #region Properties

        public Int64 _ZoneDesignationID
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

        public MDZoneDesignationEntity _MDZoneDesignationEntity
        {
            get
            {
                MDZoneDesignationEntity entity = new MDZoneDesignationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDZoneDesignationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDZoneDesignationEntity CurrentMDZoneDesignationEntity
        {
            get
            {
                if (_ZoneDesignationID > 0)
                {
                    if (_MDZoneDesignationEntity.ZoneDesignationID != _ZoneDesignationID)
                    {
                        _MDZoneDesignationEntity = FCCMDZoneDesignation.GetFacadeCreate().GetByID(_ZoneDesignationID);
                    }
                }

                return _MDZoneDesignationEntity;
            }
            set
            {
                _MDZoneDesignationEntity = value;
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

            txtName.Text = String.Empty;
            txtDesignation.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDZoneDesignationEntity mDZoneDesignationEntity = CurrentMDZoneDesignationEntity;


            if (!mDZoneDesignationEntity.IsNew)
            {
                txtName.Text = mDZoneDesignationEntity.Name.ToString();
                txtDesignation.Text = mDZoneDesignationEntity.Designation.ToString();
                chkIsRemoved.Checked = mDZoneDesignationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDZoneDesignationList();
        }

        private void BindMDZoneDesignationList()
        {
            lvMDZoneDesignation.DataBind();
        }

        private MDZoneDesignationEntity BuildMDZoneDesignationEntity()
        {
            MDZoneDesignationEntity mDZoneDesignationEntity = CurrentMDZoneDesignationEntity;

            mDZoneDesignationEntity.Name = txtName.Text.Trim();
            mDZoneDesignationEntity.Designation = txtDesignation.Text.Trim();
            mDZoneDesignationEntity.IsRemoved = chkIsRemoved.Checked;


            return mDZoneDesignationEntity;
        }

        private void SaveMDZoneDesignationEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDZoneDesignationEntity mDZoneDesignationEntity = BuildMDZoneDesignationEntity();

                    Int64 result = -1;

                    if (mDZoneDesignationEntity.IsNew)
                    {
                        result = FCCMDZoneDesignation.GetFacadeCreate().Add(mDZoneDesignationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDZoneDesignationEntity.FLD_NAME_ZoneDesignationID, mDZoneDesignationEntity.ZoneDesignationID.ToString(), SQLMatchType.Equal);
                        result = FCCMDZoneDesignation.GetFacadeCreate().Update(mDZoneDesignationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ZoneDesignationID = 0;
                        _MDZoneDesignationEntity = new MDZoneDesignationEntity();
                        PrepareInitialView();
                        BindMDZoneDesignationList();

                        if (mDZoneDesignationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Zone Designation Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Zone Designation Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDZoneDesignationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Zone Designation Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Zone Designation Information.", false);
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

        protected void lvMDZoneDesignation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ZoneDesignationID;

            Int64.TryParse(e.CommandArgument.ToString(), out ZoneDesignationID);

            if (ZoneDesignationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ZoneDesignationID = ZoneDesignationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDZoneDesignationEntity.FLD_NAME_ZoneDesignationID, ZoneDesignationID.ToString(), SQLMatchType.Equal);

                        MDZoneDesignationEntity mDZoneDesignationEntity = new MDZoneDesignationEntity();


                        result = FCCMDZoneDesignation.GetFacadeCreate().Delete(mDZoneDesignationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ZoneDesignationID = 0;
                            _MDZoneDesignationEntity = new MDZoneDesignationEntity();
                            PrepareInitialView();
                            BindMDZoneDesignationList();

                            MiscUtil.ShowMessage(lblMessage, "Zone Designation has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Zone Designation.", true);
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

        protected void odsMDZoneDesignation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDZoneDesignationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ZoneDesignationID = 0;
            _MDZoneDesignationEntity = new MDZoneDesignationEntity();
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
