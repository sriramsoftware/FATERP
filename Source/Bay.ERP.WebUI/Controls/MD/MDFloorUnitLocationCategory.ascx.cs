// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    public partial class MDFloorUnitLocationCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _FloorUnitLocationCategoryID
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

        public MDFloorUnitLocationCategoryEntity _MDFloorUnitLocationCategoryEntity
        {
            get
            {
                MDFloorUnitLocationCategoryEntity entity = new MDFloorUnitLocationCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDFloorUnitLocationCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDFloorUnitLocationCategoryEntity CurrentMDFloorUnitLocationCategoryEntity
        {
            get
            {
                if (_FloorUnitLocationCategoryID > 0)
                {
                    if (_MDFloorUnitLocationCategoryEntity.FloorUnitLocationCategoryID != _FloorUnitLocationCategoryID)
                    {
                        _MDFloorUnitLocationCategoryEntity = FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetByID(_FloorUnitLocationCategoryID);
                    }
                }

                return _MDFloorUnitLocationCategoryEntity;
            }
            set
            {
                _MDFloorUnitLocationCategoryEntity = value;
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
            MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity = CurrentMDFloorUnitLocationCategoryEntity;


            if (!mDFloorUnitLocationCategoryEntity.IsNew)
            {
                txtName.Text = mDFloorUnitLocationCategoryEntity.Name.ToString();
                txtDescription.Text = mDFloorUnitLocationCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDFloorUnitLocationCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDFloorUnitLocationCategoryList();
        }

        private void BindMDFloorUnitLocationCategoryList()
        {
            lvMDFloorUnitLocationCategory.DataBind();
        }

        private MDFloorUnitLocationCategoryEntity BuildMDFloorUnitLocationCategoryEntity()
        {
            MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity = CurrentMDFloorUnitLocationCategoryEntity;

            mDFloorUnitLocationCategoryEntity.Name = txtName.Text.Trim();
            mDFloorUnitLocationCategoryEntity.Description = txtDescription.Text.Trim();
            mDFloorUnitLocationCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDFloorUnitLocationCategoryEntity;
        }

        private void SaveMDFloorUnitLocationCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity = BuildMDFloorUnitLocationCategoryEntity();

                    Int64 result = -1;

                    if (mDFloorUnitLocationCategoryEntity.IsNew)
                    {
                        result = FCCMDFloorUnitLocationCategory.GetFacadeCreate().Add(mDFloorUnitLocationCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDFloorUnitLocationCategoryEntity.FLD_NAME_FloorUnitLocationCategoryID, mDFloorUnitLocationCategoryEntity.FloorUnitLocationCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDFloorUnitLocationCategory.GetFacadeCreate().Update(mDFloorUnitLocationCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FloorUnitLocationCategoryID = 0;
                        _MDFloorUnitLocationCategoryEntity = new MDFloorUnitLocationCategoryEntity();
                        PrepareInitialView();
                        BindMDFloorUnitLocationCategoryList();

                        if (mDFloorUnitLocationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Floor Unit Location Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Floor Unit Location Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDFloorUnitLocationCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Floor Unit Location Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Floor Unit Location Category Information.", false);
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

        protected void lvMDFloorUnitLocationCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FloorUnitLocationCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out FloorUnitLocationCategoryID);

            if (FloorUnitLocationCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FloorUnitLocationCategoryID = FloorUnitLocationCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDFloorUnitLocationCategoryEntity.FLD_NAME_FloorUnitLocationCategoryID, FloorUnitLocationCategoryID.ToString(), SQLMatchType.Equal);

                        MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity = new MDFloorUnitLocationCategoryEntity();


                        result = FCCMDFloorUnitLocationCategory.GetFacadeCreate().Delete(mDFloorUnitLocationCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FloorUnitLocationCategoryID = 0;
                            _MDFloorUnitLocationCategoryEntity = new MDFloorUnitLocationCategoryEntity();
                            PrepareInitialView();
                            BindMDFloorUnitLocationCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Floor Unit Location Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Floor Unit Location Category.", true);
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

        protected void odsMDFloorUnitLocationCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDFloorUnitLocationCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FloorUnitLocationCategoryID = 0;
            _MDFloorUnitLocationCategoryEntity = new MDFloorUnitLocationCategoryEntity();
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
