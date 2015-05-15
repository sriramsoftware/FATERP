// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    public partial class MDEventLocationCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EventLocationCategoryID
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

        public MDEventLocationCategoryEntity _MDEventLocationCategoryEntity
        {
            get
            {
                MDEventLocationCategoryEntity entity = new MDEventLocationCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEventLocationCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEventLocationCategoryEntity CurrentMDEventLocationCategoryEntity
        {
            get
            {
                if (_EventLocationCategoryID > 0)
                {
                    if (_MDEventLocationCategoryEntity.EventLocationCategoryID != _EventLocationCategoryID)
                    {
                        _MDEventLocationCategoryEntity = FCCMDEventLocationCategory.GetFacadeCreate().GetByID(_EventLocationCategoryID);
                    }
                }

                return _MDEventLocationCategoryEntity;
            }
            set
            {
                _MDEventLocationCategoryEntity = value;
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
            MDEventLocationCategoryEntity mDEventLocationCategoryEntity = CurrentMDEventLocationCategoryEntity;


            if (!mDEventLocationCategoryEntity.IsNew)
            {
                txtName.Text = mDEventLocationCategoryEntity.Name.ToString();
                txtDescription.Text = mDEventLocationCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDEventLocationCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEventLocationCategoryList();
        }

        private void BindMDEventLocationCategoryList()
        {
            lvMDEventLocationCategory.DataBind();
        }

        private MDEventLocationCategoryEntity BuildMDEventLocationCategoryEntity()
        {
            MDEventLocationCategoryEntity mDEventLocationCategoryEntity = CurrentMDEventLocationCategoryEntity;

            mDEventLocationCategoryEntity.Name = txtName.Text.Trim();
            mDEventLocationCategoryEntity.Description = txtDescription.Text.Trim();
            mDEventLocationCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEventLocationCategoryEntity;
        }

        private void SaveMDEventLocationCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEventLocationCategoryEntity mDEventLocationCategoryEntity = BuildMDEventLocationCategoryEntity();

                    Int64 result = -1;

                    if (mDEventLocationCategoryEntity.IsNew)
                    {
                        result = FCCMDEventLocationCategory.GetFacadeCreate().Add(mDEventLocationCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEventLocationCategoryEntity.FLD_NAME_EventLocationCategoryID, mDEventLocationCategoryEntity.EventLocationCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEventLocationCategory.GetFacadeCreate().Update(mDEventLocationCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventLocationCategoryID = 0;
                        _MDEventLocationCategoryEntity = new MDEventLocationCategoryEntity();
                        PrepareInitialView();
                        BindMDEventLocationCategoryList();

                        if (mDEventLocationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Location Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Location Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEventLocationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Event Location Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Event Location Category Information.", false);
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

        protected void lvMDEventLocationCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventLocationCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventLocationCategoryID);

            if (EventLocationCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventLocationCategoryID = EventLocationCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEventLocationCategoryEntity.FLD_NAME_EventLocationCategoryID, EventLocationCategoryID.ToString(), SQLMatchType.Equal);

                        MDEventLocationCategoryEntity mDEventLocationCategoryEntity = new MDEventLocationCategoryEntity();


                        result = FCCMDEventLocationCategory.GetFacadeCreate().Delete(mDEventLocationCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventLocationCategoryID = 0;
                            _MDEventLocationCategoryEntity = new MDEventLocationCategoryEntity();
                            PrepareInitialView();
                            BindMDEventLocationCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Event Location Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Event Location Category.", true);
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

        protected void odsMDEventLocationCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEventLocationCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventLocationCategoryID = 0;
            _MDEventLocationCategoryEntity = new MDEventLocationCategoryEntity();
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
