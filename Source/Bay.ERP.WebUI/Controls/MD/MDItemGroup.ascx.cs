// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class MDItemGroupControl : BaseControl
    {       
        #region Properties

        public Int64 _ItemGroupID
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

        public MDItemGroupEntity _MDItemGroupEntity
        {
            get
            {
                MDItemGroupEntity entity = new MDItemGroupEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDItemGroupEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDItemGroupEntity CurrentMDItemGroupEntity
        {
            get
            {
                if (_ItemGroupID > 0)
                {
                    if (_MDItemGroupEntity.ItemGroupID != _ItemGroupID)
                    {
                        _MDItemGroupEntity = FCCMDItemGroup.GetFacadeCreate().GetByID(_ItemGroupID);
                    }
                }

                return _MDItemGroupEntity;
            }
            set
            {
                _MDItemGroupEntity = value;
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

            txtGroupName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDItemGroupEntity mDItemGroupEntity = CurrentMDItemGroupEntity;


            if (!mDItemGroupEntity.IsNew)
            {
                txtGroupName.Text = mDItemGroupEntity.GroupName.ToString();
                txtDescription.Text = mDItemGroupEntity.Description.ToString();
                chkIsRemoved.Checked = mDItemGroupEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDItemGroupList();
        }

        private void BindMDItemGroupList()
        {
            lvMDItemGroup.DataBind();
        }

        private MDItemGroupEntity BuildMDItemGroupEntity()
        {
            MDItemGroupEntity mDItemGroupEntity = CurrentMDItemGroupEntity;

            mDItemGroupEntity.GroupName = txtGroupName.Text.Trim();
            mDItemGroupEntity.Description = txtDescription.Text.Trim();
            mDItemGroupEntity.IsRemoved = chkIsRemoved.Checked;


            return mDItemGroupEntity;
        }

        private void SaveMDItemGroupEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDItemGroupEntity mDItemGroupEntity = BuildMDItemGroupEntity();

                    Int64 result = -1;

                    if (mDItemGroupEntity.IsNew)
                    {
                        result = FCCMDItemGroup.GetFacadeCreate().Add(mDItemGroupEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemGroupEntity.FLD_NAME_ItemGroupID, mDItemGroupEntity.ItemGroupID.ToString(), SQLMatchType.Equal);
                        result = FCCMDItemGroup.GetFacadeCreate().Update(mDItemGroupEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ItemGroupID = 0;
                        _MDItemGroupEntity = new MDItemGroupEntity();
                        PrepareInitialView();
                        BindMDItemGroupList();

                        if (mDItemGroupEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Group Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Group Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDItemGroupEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Item Group Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Item Group Information.", false);
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

        protected void lvMDItemGroup_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ItemGroupID;

            Int64.TryParse(e.CommandArgument.ToString(), out ItemGroupID);

            if (ItemGroupID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ItemGroupID = ItemGroupID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemGroupEntity.FLD_NAME_ItemGroupID, ItemGroupID.ToString(), SQLMatchType.Equal);

                        MDItemGroupEntity mDItemGroupEntity = new MDItemGroupEntity();


                        result = FCCMDItemGroup.GetFacadeCreate().Delete(mDItemGroupEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ItemGroupID = 0;
                            _MDItemGroupEntity = new MDItemGroupEntity();
                            PrepareInitialView();
                            BindMDItemGroupList();

                            MiscUtil.ShowMessage(lblMessage, "Item Group has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Item Group.", true);
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

        protected void odsMDItemGroup_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDItemGroupEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ItemGroupID = 0;
            _MDItemGroupEntity = new MDItemGroupEntity();
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
