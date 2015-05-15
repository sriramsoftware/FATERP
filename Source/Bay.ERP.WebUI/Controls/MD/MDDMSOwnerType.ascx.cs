// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




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
    public partial class MDDMSOwnerTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _OwnerTypeID
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

        public MDDMSOwnerTypeEntity _MDDMSOwnerTypeEntity
        {
            get
            {
                MDDMSOwnerTypeEntity entity = new MDDMSOwnerTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDMSOwnerTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDMSOwnerTypeEntity CurrentMDDMSOwnerTypeEntity
        {
            get
            {
                if (_OwnerTypeID > 0)
                {
                    if (_MDDMSOwnerTypeEntity.OwnerTypeID != _OwnerTypeID)
                    {
                        _MDDMSOwnerTypeEntity = FCCMDDMSOwnerType.GetFacadeCreate().GetByID(_OwnerTypeID);
                    }
                }

                return _MDDMSOwnerTypeEntity;
            }
            set
            {
                _MDDMSOwnerTypeEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDDMSOwnerTypeEntity mDDMSOwnerTypeEntity = CurrentMDDMSOwnerTypeEntity;


            if (!mDDMSOwnerTypeEntity.IsNew)
            {
                txtName.Text = mDDMSOwnerTypeEntity.Name.ToString();
                txtDescription.Text = mDDMSOwnerTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDDMSOwnerTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDMSOwnerTypeList();
        }

        private void BindMDDMSOwnerTypeList()
        {
            lvMDDMSOwnerType.DataBind();
        }

        private MDDMSOwnerTypeEntity BuildMDDMSOwnerTypeEntity()
        {
            MDDMSOwnerTypeEntity mDDMSOwnerTypeEntity = CurrentMDDMSOwnerTypeEntity;

            mDDMSOwnerTypeEntity.Name = txtName.Text.Trim();
            mDDMSOwnerTypeEntity.Description = txtDescription.Text.Trim();
            mDDMSOwnerTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDMSOwnerTypeEntity;
        }

        private void SaveMDDMSOwnerTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDMSOwnerTypeEntity mDDMSOwnerTypeEntity = BuildMDDMSOwnerTypeEntity();

                    Int64 result = -1;

                    if (mDDMSOwnerTypeEntity.IsNew)
                    {
                        result = FCCMDDMSOwnerType.GetFacadeCreate().Add(mDDMSOwnerTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDMSOwnerTypeEntity.FLD_NAME_OwnerTypeID, mDDMSOwnerTypeEntity.OwnerTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDMSOwnerType.GetFacadeCreate().Update(mDDMSOwnerTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OwnerTypeID = 0;
                        _MDDMSOwnerTypeEntity = new MDDMSOwnerTypeEntity();
                        PrepareInitialView();
                        BindMDDMSOwnerTypeList();

                        if (mDDMSOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "D MSOwner Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "D MSOwner Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDMSOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add D MSOwner Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update D MSOwner Type Information.", false);
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

        protected void lvMDDMSOwnerType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OwnerTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out OwnerTypeID);

            if (OwnerTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OwnerTypeID = OwnerTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDMSOwnerTypeEntity.FLD_NAME_OwnerTypeID, OwnerTypeID.ToString(), SQLMatchType.Equal);

                        MDDMSOwnerTypeEntity mDDMSOwnerTypeEntity = new MDDMSOwnerTypeEntity();


                        result = FCCMDDMSOwnerType.GetFacadeCreate().Delete(mDDMSOwnerTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OwnerTypeID = 0;
                            _MDDMSOwnerTypeEntity = new MDDMSOwnerTypeEntity();
                            PrepareInitialView();
                            BindMDDMSOwnerTypeList();

                            MiscUtil.ShowMessage(lblMessage, "D MSOwner Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete D MSOwner Type.", true);
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

        protected void odsMDDMSOwnerType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDMSOwnerTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OwnerTypeID = 0;
            _MDDMSOwnerTypeEntity = new MDDMSOwnerTypeEntity();
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
