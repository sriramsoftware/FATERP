// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 07:14:37




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
    public partial class MDZoneControl : BaseControl
    {       
        #region Properties

        public Int64 _ZoneID
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

        public MDZoneEntity _MDZoneEntity
        {
            get
            {
                MDZoneEntity entity = new MDZoneEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDZoneEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDZoneEntity CurrentMDZoneEntity
        {
            get
            {
                if (_ZoneID > 0)
                {
                    if (_MDZoneEntity.ZoneID != _ZoneID)
                    {
                        _MDZoneEntity = FCCMDZone.GetFacadeCreate().GetByID(_ZoneID);
                    }
                }

                return _MDZoneEntity;
            }
            set
            {
                _MDZoneEntity = value;
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

            txtZoneCode.Text = String.Empty;
            txtZoneName.Text = String.Empty;
            txtDescripton.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDZoneEntity mDZoneEntity = CurrentMDZoneEntity;


            if (!mDZoneEntity.IsNew)
            {
                txtZoneCode.Text = mDZoneEntity.ZoneCode.ToString();
                txtZoneName.Text = mDZoneEntity.ZoneName.ToString();
                txtDescripton.Text = mDZoneEntity.Descripton.ToString();
                chkIsRemoved.Checked = mDZoneEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDZoneList();
        }

        private void BindMDZoneList()
        {
            lvMDZone.DataBind();
        }

        private MDZoneEntity BuildMDZoneEntity()
        {
            MDZoneEntity mDZoneEntity = CurrentMDZoneEntity;

            mDZoneEntity.ZoneCode = txtZoneCode.Text.Trim();
            mDZoneEntity.ZoneName = txtZoneName.Text.Trim();
            mDZoneEntity.Descripton = txtDescripton.Text.Trim();
            mDZoneEntity.IsRemoved = chkIsRemoved.Checked;


            return mDZoneEntity;
        }

        private void SaveMDZoneEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDZoneEntity mDZoneEntity = BuildMDZoneEntity();

                    Int64 result = -1;

                    if (mDZoneEntity.IsNew)
                    {
                        result = FCCMDZone.GetFacadeCreate().Add(mDZoneEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDZoneEntity.FLD_NAME_ZoneID, mDZoneEntity.ZoneID.ToString(), SQLMatchType.Equal);
                        result = FCCMDZone.GetFacadeCreate().Update(mDZoneEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ZoneID = 0;
                        _MDZoneEntity = new MDZoneEntity();
                        PrepareInitialView();
                        BindMDZoneList();

                        if (mDZoneEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Zone Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Zone Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDZoneEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Zone Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Zone Information.", false);
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

        protected void lvMDZone_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ZoneID;

            Int64.TryParse(e.CommandArgument.ToString(), out ZoneID);

            if (ZoneID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ZoneID = ZoneID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDZoneEntity.FLD_NAME_ZoneID, ZoneID.ToString(), SQLMatchType.Equal);

                        MDZoneEntity mDZoneEntity = new MDZoneEntity();


                        result = FCCMDZone.GetFacadeCreate().Delete(mDZoneEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ZoneID = 0;
                            _MDZoneEntity = new MDZoneEntity();
                            PrepareInitialView();
                            BindMDZoneList();

                            MiscUtil.ShowMessage(lblMessage, "Zone has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Zone.", true);
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

        protected void odsMDZone_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDZoneEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ZoneID = 0;
            _MDZoneEntity = new MDZoneEntity();
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
