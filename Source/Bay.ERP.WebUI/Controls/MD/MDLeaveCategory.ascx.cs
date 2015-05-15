// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 02:53:23




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
    public partial class MDLeaveCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _LeaveCategoryID
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

        public MDLeaveCategoryEntity _MDLeaveCategoryEntity
        {
            get
            {
                MDLeaveCategoryEntity entity = new MDLeaveCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDLeaveCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDLeaveCategoryEntity CurrentMDLeaveCategoryEntity
        {
            get
            {
                if (_LeaveCategoryID > 0)
                {
                    if (_MDLeaveCategoryEntity.LeaveCategoryID != _LeaveCategoryID)
                    {
                        _MDLeaveCategoryEntity = FCCMDLeaveCategory.GetFacadeCreate().GetByID(_LeaveCategoryID);
                    }
                }

                return _MDLeaveCategoryEntity;
            }
            set
            {
                _MDLeaveCategoryEntity = value;
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
            MDLeaveCategoryEntity mDLeaveCategoryEntity = CurrentMDLeaveCategoryEntity;


            if (!mDLeaveCategoryEntity.IsNew)
            {
                txtName.Text = mDLeaveCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = mDLeaveCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDLeaveCategoryList();
        }

        private void BindMDLeaveCategoryList()
        {
            lvMDLeaveCategory.DataBind();
        }

        private MDLeaveCategoryEntity BuildMDLeaveCategoryEntity()
        {
            MDLeaveCategoryEntity mDLeaveCategoryEntity = CurrentMDLeaveCategoryEntity;

            mDLeaveCategoryEntity.Name = txtName.Text.Trim();
            mDLeaveCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDLeaveCategoryEntity;
        }

        private void SaveMDLeaveCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDLeaveCategoryEntity mDLeaveCategoryEntity = BuildMDLeaveCategoryEntity();

                    Int64 result = -1;

                    if (mDLeaveCategoryEntity.IsNew)
                    {
                        result = FCCMDLeaveCategory.GetFacadeCreate().Add(mDLeaveCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDLeaveCategoryEntity.FLD_NAME_LeaveCategoryID, mDLeaveCategoryEntity.LeaveCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDLeaveCategory.GetFacadeCreate().Update(mDLeaveCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LeaveCategoryID = 0;
                        _MDLeaveCategoryEntity = new MDLeaveCategoryEntity();
                        PrepareInitialView();
                        BindMDLeaveCategoryList();

                        if (mDLeaveCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Leave Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Leave Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDLeaveCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Leave Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Leave Category Information.", false);
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

        protected void lvMDLeaveCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LeaveCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out LeaveCategoryID);

            if (LeaveCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LeaveCategoryID = LeaveCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDLeaveCategoryEntity.FLD_NAME_LeaveCategoryID, LeaveCategoryID.ToString(), SQLMatchType.Equal);

                        MDLeaveCategoryEntity mDLeaveCategoryEntity = new MDLeaveCategoryEntity();


                        result = FCCMDLeaveCategory.GetFacadeCreate().Delete(mDLeaveCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LeaveCategoryID = 0;
                            _MDLeaveCategoryEntity = new MDLeaveCategoryEntity();
                            PrepareInitialView();
                            BindMDLeaveCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Leave Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Leave Category.", true);
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

        protected void odsMDLeaveCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDLeaveCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LeaveCategoryID = 0;
            _MDLeaveCategoryEntity = new MDLeaveCategoryEntity();
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
