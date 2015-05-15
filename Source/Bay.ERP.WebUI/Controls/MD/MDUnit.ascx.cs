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
    public partial class MDUnitControl : BaseControl
    {       
        #region Properties

        public Int64 _UnitID
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

        public MDUnitEntity _MDUnitEntity
        {
            get
            {
                MDUnitEntity entity = new MDUnitEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDUnitEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDUnitEntity CurrentMDUnitEntity
        {
            get
            {
                if (_UnitID > 0)
                {
                    if (_MDUnitEntity.UnitID != _UnitID)
                    {
                        _MDUnitEntity = FCCMDUnit.GetFacadeCreate().GetByID(_UnitID);
                    }
                }

                return _MDUnitEntity;
            }
            set
            {
                _MDUnitEntity = value;
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

            txtUnitCode.Text = String.Empty;
            txtUnitName.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDUnitEntity mDUnitEntity = CurrentMDUnitEntity;


            if (!mDUnitEntity.IsNew)
            {
                txtUnitCode.Text = mDUnitEntity.UnitCode.ToString();
                txtUnitName.Text = mDUnitEntity.UnitName.ToString();
                chkIsRemoved.Checked = mDUnitEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDUnitList();
        }

        private void BindMDUnitList()
        {
            lvMDUnit.DataBind();
        }

        private MDUnitEntity BuildMDUnitEntity()
        {
            MDUnitEntity mDUnitEntity = CurrentMDUnitEntity;

            mDUnitEntity.UnitCode = txtUnitCode.Text.Trim();
            mDUnitEntity.UnitName = txtUnitName.Text.Trim();
            mDUnitEntity.IsRemoved = chkIsRemoved.Checked;


            return mDUnitEntity;
        }

        private void SaveMDUnitEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDUnitEntity mDUnitEntity = BuildMDUnitEntity();

                    Int64 result = -1;

                    if (mDUnitEntity.IsNew)
                    {
                        result = FCCMDUnit.GetFacadeCreate().Add(mDUnitEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDUnitEntity.FLD_NAME_UnitID, mDUnitEntity.UnitID.ToString(), SQLMatchType.Equal);
                        result = FCCMDUnit.GetFacadeCreate().Update(mDUnitEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UnitID = 0;
                        _MDUnitEntity = new MDUnitEntity();
                        PrepareInitialView();
                        BindMDUnitList();

                        if (mDUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Unit Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Unit Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Unit Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Unit Information.", false);
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

        protected void lvMDUnit_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UnitID;

            Int64.TryParse(e.CommandArgument.ToString(), out UnitID);

            if (UnitID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UnitID = UnitID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDUnitEntity.FLD_NAME_UnitID, UnitID.ToString(), SQLMatchType.Equal);

                        MDUnitEntity mDUnitEntity = new MDUnitEntity();


                        result = FCCMDUnit.GetFacadeCreate().Delete(mDUnitEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UnitID = 0;
                            _MDUnitEntity = new MDUnitEntity();
                            PrepareInitialView();
                            BindMDUnitList();

                            MiscUtil.ShowMessage(lblMessage, "Unit has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Unit.", true);
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

        protected void odsMDUnit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDUnitEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UnitID = 0;
            _MDUnitEntity = new MDUnitEntity();
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
