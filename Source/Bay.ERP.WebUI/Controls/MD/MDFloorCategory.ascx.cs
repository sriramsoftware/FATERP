// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 02:43:38




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
    public partial class MDFloorCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _FloorCategoryID
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

        public MDFloorCategoryEntity _MDFloorCategoryEntity
        {
            get
            {
                MDFloorCategoryEntity entity = new MDFloorCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDFloorCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDFloorCategoryEntity CurrentMDFloorCategoryEntity
        {
            get
            {
                if (_FloorCategoryID > 0)
                {
                    if (_MDFloorCategoryEntity.FloorCategoryID != _FloorCategoryID)
                    {
                        _MDFloorCategoryEntity = FCCMDFloorCategory.GetFacadeCreate().GetByID(_FloorCategoryID);
                    }
                }

                return _MDFloorCategoryEntity;
            }
            set
            {
                _MDFloorCategoryEntity = value;
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
            MDFloorCategoryEntity mDFloorCategoryEntity = CurrentMDFloorCategoryEntity;


            if (!mDFloorCategoryEntity.IsNew)
            {
                txtName.Text = mDFloorCategoryEntity.Name.ToString();
                txtDescription.Text = mDFloorCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDFloorCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDFloorCategoryList();
        }

        private void BindMDFloorCategoryList()
        {
            lvMDFloorCategory.DataBind();
        }

        private MDFloorCategoryEntity BuildMDFloorCategoryEntity()
        {
            MDFloorCategoryEntity mDFloorCategoryEntity = CurrentMDFloorCategoryEntity;

            mDFloorCategoryEntity.Name = txtName.Text.Trim();
            mDFloorCategoryEntity.Description = txtDescription.Text.Trim();
            mDFloorCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDFloorCategoryEntity;
        }

        private void SaveMDFloorCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDFloorCategoryEntity mDFloorCategoryEntity = BuildMDFloorCategoryEntity();

                    Int64 result = -1;

                    if (mDFloorCategoryEntity.IsNew)
                    {
                        result = FCCMDFloorCategory.GetFacadeCreate().Add(mDFloorCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDFloorCategoryEntity.FLD_NAME_FloorCategoryID, mDFloorCategoryEntity.FloorCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDFloorCategory.GetFacadeCreate().Update(mDFloorCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FloorCategoryID = 0;
                        _MDFloorCategoryEntity = new MDFloorCategoryEntity();
                        PrepareInitialView();
                        BindMDFloorCategoryList();

                        if (mDFloorCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Floor Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Floor Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDFloorCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Floor Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Floor Category Information.", false);
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

        protected void lvMDFloorCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FloorCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out FloorCategoryID);

            if (FloorCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FloorCategoryID = FloorCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDFloorCategoryEntity.FLD_NAME_FloorCategoryID, FloorCategoryID.ToString(), SQLMatchType.Equal);

                        MDFloorCategoryEntity mDFloorCategoryEntity = new MDFloorCategoryEntity();


                        result = FCCMDFloorCategory.GetFacadeCreate().Delete(mDFloorCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FloorCategoryID = 0;
                            _MDFloorCategoryEntity = new MDFloorCategoryEntity();
                            PrepareInitialView();
                            BindMDFloorCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Floor Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Floor Category.", true);
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

        protected void odsMDFloorCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDFloorCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FloorCategoryID = 0;
            _MDFloorCategoryEntity = new MDFloorCategoryEntity();
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
