// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




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
    public partial class MDDistrictControl : BaseControl
    {       
        #region Properties

        public Int64 _DistrictID
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

        public MDDistrictEntity _MDDistrictEntity
        {
            get
            {
                MDDistrictEntity entity = new MDDistrictEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDistrictEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDistrictEntity CurrentMDDistrictEntity
        {
            get
            {
                if (_DistrictID > 0)
                {
                    if (_MDDistrictEntity.DistrictID != _DistrictID)
                    {
                        _MDDistrictEntity = FCCMDDistrict.GetFacadeCreate().GetByID(_DistrictID);
                    }
                }

                return _MDDistrictEntity;
            }
            set
            {
                _MDDistrictEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDivision(ddlDivisionID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDistrictName.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDDistrictEntity mDDistrictEntity = CurrentMDDistrictEntity;


            if (!mDDistrictEntity.IsNew)
            {
                txtDistrictName.Text = mDDistrictEntity.DistrictName.ToString();
                txtRemarks.Text = mDDistrictEntity.Remarks.ToString();
                if (ddlDivisionID.Items.Count > 0 && mDDistrictEntity.DivisionID != null)
                {
                    ddlDivisionID.SelectedValue = mDDistrictEntity.DivisionID.ToString();
                }

                chkIsRemoved.Checked = mDDistrictEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDistrictList();
        }

        private void BindMDDistrictList()
        {
            lvMDDistrict.DataBind();
        }

        private MDDistrictEntity BuildMDDistrictEntity()
        {
            MDDistrictEntity mDDistrictEntity = CurrentMDDistrictEntity;

            mDDistrictEntity.DistrictName = txtDistrictName.Text.Trim();
            mDDistrictEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlDivisionID.Items.Count > 0)
            {
                if (ddlDivisionID.SelectedValue == "0")
                {
                }
                else
                {
                    mDDistrictEntity.DivisionID = Int64.Parse(ddlDivisionID.SelectedValue);
                }
            }

            mDDistrictEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDistrictEntity;
        }

        private void SaveMDDistrictEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDistrictEntity mDDistrictEntity = BuildMDDistrictEntity();

                    Int64 result = -1;

                    if (mDDistrictEntity.IsNew)
                    {
                        result = FCCMDDistrict.GetFacadeCreate().Add(mDDistrictEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDistrictEntity.FLD_NAME_DistrictID, mDDistrictEntity.DistrictID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDistrict.GetFacadeCreate().Update(mDDistrictEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DistrictID = 0;
                        _MDDistrictEntity = new MDDistrictEntity();
                        PrepareInitialView();
                        BindMDDistrictList();

                        if (mDDistrictEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "District Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "District Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDistrictEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add District Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update District Information.", false);
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

        protected void lvMDDistrict_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DistrictID;

            Int64.TryParse(e.CommandArgument.ToString(), out DistrictID);

            if (DistrictID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DistrictID = DistrictID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDistrictEntity.FLD_NAME_DistrictID, DistrictID.ToString(), SQLMatchType.Equal);

                        MDDistrictEntity mDDistrictEntity = new MDDistrictEntity();


                        result = FCCMDDistrict.GetFacadeCreate().Delete(mDDistrictEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DistrictID = 0;
                            _MDDistrictEntity = new MDDistrictEntity();
                            PrepareInitialView();
                            BindMDDistrictList();

                            MiscUtil.ShowMessage(lblMessage, "District has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete District.", true);
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

        protected void odsMDDistrict_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDistrictEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DistrictID = 0;
            _MDDistrictEntity = new MDDistrictEntity();
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
