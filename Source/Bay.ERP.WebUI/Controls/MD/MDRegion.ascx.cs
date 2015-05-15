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
    public partial class MDRegionControl : BaseControl
    {       
        #region Properties

        public Int64 _RegionID
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

        public MDRegionEntity _MDRegionEntity
        {
            get
            {
                MDRegionEntity entity = new MDRegionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDRegionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDRegionEntity CurrentMDRegionEntity
        {
            get
            {
                if (_RegionID > 0)
                {
                    if (_MDRegionEntity.RegionID != _RegionID)
                    {
                        _MDRegionEntity = FCCMDRegion.GetFacadeCreate().GetByID(_RegionID);
                    }
                }

                return _MDRegionEntity;
            }
            set
            {
                _MDRegionEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDRegionEntity mDRegionEntity = CurrentMDRegionEntity;


            if (!mDRegionEntity.IsNew)
            {
                txtName.Text = mDRegionEntity.Name.ToString();
                chkIsRemoved.Checked = mDRegionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDRegionList();
        }

        private void BindMDRegionList()
        {
            lvMDRegion.DataBind();
        }

        private MDRegionEntity BuildMDRegionEntity()
        {
            MDRegionEntity mDRegionEntity = CurrentMDRegionEntity;

            mDRegionEntity.Name = txtName.Text.Trim();
            mDRegionEntity.IsRemoved = chkIsRemoved.Checked;


            return mDRegionEntity;
        }

        private void SaveMDRegionEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDRegionEntity mDRegionEntity = BuildMDRegionEntity();

                    Int64 result = -1;

                    if (mDRegionEntity.IsNew)
                    {
                        result = FCCMDRegion.GetFacadeCreate().Add(mDRegionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDRegionEntity.FLD_NAME_RegionID, mDRegionEntity.RegionID.ToString(), SQLMatchType.Equal);
                        result = FCCMDRegion.GetFacadeCreate().Update(mDRegionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _RegionID = 0;
                        _MDRegionEntity = new MDRegionEntity();
                        PrepareInitialView();
                        BindMDRegionList();

                        if (mDRegionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Region Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Region Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDRegionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Region Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Region Information.", false);
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

        protected void lvMDRegion_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RegionID;

            Int64.TryParse(e.CommandArgument.ToString(), out RegionID);

            if (RegionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RegionID = RegionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDRegionEntity.FLD_NAME_RegionID, RegionID.ToString(), SQLMatchType.Equal);

                        MDRegionEntity mDRegionEntity = new MDRegionEntity();


                        result = FCCMDRegion.GetFacadeCreate().Delete(mDRegionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RegionID = 0;
                            _MDRegionEntity = new MDRegionEntity();
                            PrepareInitialView();
                            BindMDRegionList();

                            MiscUtil.ShowMessage(lblMessage, "Region has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Region.", true);
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

        protected void odsMDRegion_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDRegionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _RegionID = 0;
            _MDRegionEntity = new MDRegionEntity();
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
