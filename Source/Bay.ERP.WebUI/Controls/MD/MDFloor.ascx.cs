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
    public partial class MDFloorControl : BaseControl
    {       
        #region Properties

        public Int64 _FloorID
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

        public MDFloorEntity _MDFloorEntity
        {
            get
            {
                MDFloorEntity entity = new MDFloorEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDFloorEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDFloorEntity CurrentMDFloorEntity
        {
            get
            {
                if (_FloorID > 0)
                {
                    if (_MDFloorEntity.FloorID != _FloorID)
                    {
                        _MDFloorEntity = FCCMDFloor.GetFacadeCreate().GetByID(_FloorID);
                    }
                }

                return _MDFloorEntity;
            }
            set
            {
                _MDFloorEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDFloorCategory(ddlFloorCategoryID, false);
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
            MDFloorEntity mDFloorEntity = CurrentMDFloorEntity;


            if (!mDFloorEntity.IsNew)
            {
                if (ddlFloorCategoryID.Items.Count > 0 && mDFloorEntity.FloorCategoryID != null)
                {
                    ddlFloorCategoryID.SelectedValue = mDFloorEntity.FloorCategoryID.ToString();
                }

                txtName.Text = mDFloorEntity.Name.ToString();
                txtDescription.Text = mDFloorEntity.Description.ToString();
                chkIsRemoved.Checked = mDFloorEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDFloorList();
        }

        private void BindMDFloorList()
        {
            lvMDFloor.DataBind();
        }

        private MDFloorEntity BuildMDFloorEntity()
        {
            MDFloorEntity mDFloorEntity = CurrentMDFloorEntity;

            if (ddlFloorCategoryID.Items.Count > 0)
            {
                if (ddlFloorCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDFloorEntity.FloorCategoryID = Int64.Parse(ddlFloorCategoryID.SelectedValue);
                }
            }

            mDFloorEntity.Name = txtName.Text.Trim();
            mDFloorEntity.Description = txtDescription.Text.Trim();
            mDFloorEntity.IsRemoved = chkIsRemoved.Checked;


            return mDFloorEntity;
        }

        private void SaveMDFloorEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDFloorEntity mDFloorEntity = BuildMDFloorEntity();

                    Int64 result = -1;

                    if (mDFloorEntity.IsNew)
                    {
                        result = FCCMDFloor.GetFacadeCreate().Add(mDFloorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDFloorEntity.FLD_NAME_FloorID, mDFloorEntity.FloorID.ToString(), SQLMatchType.Equal);
                        result = FCCMDFloor.GetFacadeCreate().Update(mDFloorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FloorID = 0;
                        _MDFloorEntity = new MDFloorEntity();
                        PrepareInitialView();
                        BindMDFloorList();

                        if (mDFloorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Floor Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Floor Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDFloorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Floor Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Floor Information.", false);
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

        protected void lvMDFloor_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FloorID;

            Int64.TryParse(e.CommandArgument.ToString(), out FloorID);

            if (FloorID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FloorID = FloorID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDFloorEntity.FLD_NAME_FloorID, FloorID.ToString(), SQLMatchType.Equal);

                        MDFloorEntity mDFloorEntity = new MDFloorEntity();


                        result = FCCMDFloor.GetFacadeCreate().Delete(mDFloorEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FloorID = 0;
                            _MDFloorEntity = new MDFloorEntity();
                            PrepareInitialView();
                            BindMDFloorList();

                            MiscUtil.ShowMessage(lblMessage, "Floor has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Floor.", true);
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

        protected void odsMDFloor_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDFloorEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FloorID = 0;
            _MDFloorEntity = new MDFloorEntity();
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
