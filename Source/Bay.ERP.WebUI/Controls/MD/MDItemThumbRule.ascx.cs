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
    public partial class MDItemThumbRuleControl : BaseControl
    {       
        #region Properties

        public Int64 _MDItemThumbRuleID
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

        public MDItemThumbRuleEntity _MDItemThumbRuleEntity
        {
            get
            {
                MDItemThumbRuleEntity entity = new MDItemThumbRuleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDItemThumbRuleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDItemThumbRuleEntity CurrentMDItemThumbRuleEntity
        {
            get
            {
                if (_MDItemThumbRuleID > 0)
                {
                    if (_MDItemThumbRuleEntity.MDItemThumbRuleID != _MDItemThumbRuleID)
                    {
                        _MDItemThumbRuleEntity = FCCMDItemThumbRule.GetFacadeCreate().GetByID(_MDItemThumbRuleID);
                    }
                }

                return _MDItemThumbRuleEntity;
            }
            set
            {
                _MDItemThumbRuleEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItem(ddlItemID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFloorRuleVariable.Text = String.Empty;
            txtFloorQuantity.Text = String.Empty;
            txtBasementRuleVariable.Text = String.Empty;
            txtBasementQuantity.Text = String.Empty;
            txtOverallRuleVariable.Text = String.Empty;
            txtOverallQuantity.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDItemThumbRuleEntity mDItemThumbRuleEntity = CurrentMDItemThumbRuleEntity;


            if (!mDItemThumbRuleEntity.IsNew)
            {
                if (ddlItemID.Items.Count > 0 && mDItemThumbRuleEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = mDItemThumbRuleEntity.ItemID.ToString();
                }

                txtFloorRuleVariable.Text = mDItemThumbRuleEntity.FloorRuleVariable.ToString();
                txtFloorQuantity.Text = mDItemThumbRuleEntity.FloorQuantity.ToString();
                txtBasementRuleVariable.Text = mDItemThumbRuleEntity.BasementRuleVariable.ToString();
                txtBasementQuantity.Text = mDItemThumbRuleEntity.BasementQuantity.ToString();
                txtOverallRuleVariable.Text = mDItemThumbRuleEntity.OverallRuleVariable.ToString();
                txtOverallQuantity.Text = mDItemThumbRuleEntity.OverallQuantity.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDItemThumbRuleList();
        }

        private void BindMDItemThumbRuleList()
        {
            lvMDItemThumbRule.DataBind();
        }

        private MDItemThumbRuleEntity BuildMDItemThumbRuleEntity()
        {
            MDItemThumbRuleEntity mDItemThumbRuleEntity = CurrentMDItemThumbRuleEntity;

            if (ddlItemID.Items.Count > 0)
            {
                if (ddlItemID.SelectedValue == "0")
                {
                }
                else
                {
                    mDItemThumbRuleEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                }
            }

            if (!txtFloorRuleVariable.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.FloorRuleVariable = Decimal.Parse(txtFloorRuleVariable.Text.Trim());
            }

            if (!txtFloorQuantity.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.FloorQuantity = Decimal.Parse(txtFloorQuantity.Text.Trim());
            }

            if (!txtBasementRuleVariable.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.BasementRuleVariable = Decimal.Parse(txtBasementRuleVariable.Text.Trim());
            }

            if (!txtBasementQuantity.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.BasementQuantity = Decimal.Parse(txtBasementQuantity.Text.Trim());
            }

            if (!txtOverallRuleVariable.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.OverallRuleVariable = Decimal.Parse(txtOverallRuleVariable.Text.Trim());
            }

            if (!txtOverallQuantity.Text.Trim().IsNullOrEmpty())
            {
                mDItemThumbRuleEntity.OverallQuantity = Decimal.Parse(txtOverallQuantity.Text.Trim());
            }


            return mDItemThumbRuleEntity;
        }

        private void SaveMDItemThumbRuleEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDItemThumbRuleEntity mDItemThumbRuleEntity = BuildMDItemThumbRuleEntity();

                    Int64 result = -1;

                    if (mDItemThumbRuleEntity.IsNew)
                    {
                        result = FCCMDItemThumbRule.GetFacadeCreate().Add(mDItemThumbRuleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_MDItemThumbRuleID, mDItemThumbRuleEntity.MDItemThumbRuleID.ToString(), SQLMatchType.Equal);
                        result = FCCMDItemThumbRule.GetFacadeCreate().Update(mDItemThumbRuleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MDItemThumbRuleID = 0;
                        _MDItemThumbRuleEntity = new MDItemThumbRuleEntity();
                        PrepareInitialView();
                        BindMDItemThumbRuleList();

                        if (mDItemThumbRuleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Thumb Rule Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Thumb Rule Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDItemThumbRuleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Item Thumb Rule Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Item Thumb Rule Information.", false);
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

        protected void lvMDItemThumbRule_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MDItemThumbRuleID;

            Int64.TryParse(e.CommandArgument.ToString(), out MDItemThumbRuleID);

            if (MDItemThumbRuleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MDItemThumbRuleID = MDItemThumbRuleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemThumbRuleEntity.FLD_NAME_MDItemThumbRuleID, MDItemThumbRuleID.ToString(), SQLMatchType.Equal);

                        MDItemThumbRuleEntity mDItemThumbRuleEntity = new MDItemThumbRuleEntity();


                        result = FCCMDItemThumbRule.GetFacadeCreate().Delete(mDItemThumbRuleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MDItemThumbRuleID = 0;
                            _MDItemThumbRuleEntity = new MDItemThumbRuleEntity();
                            PrepareInitialView();
                            BindMDItemThumbRuleList();

                            MiscUtil.ShowMessage(lblMessage, "Item Thumb Rule has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Item Thumb Rule.", true);
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

        protected void odsMDItemThumbRule_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDItemThumbRuleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MDItemThumbRuleID = 0;
            _MDItemThumbRuleEntity = new MDItemThumbRuleEntity();
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
