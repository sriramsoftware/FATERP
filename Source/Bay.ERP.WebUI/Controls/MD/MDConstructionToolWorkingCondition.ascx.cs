// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




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
    public partial class MDConstructionToolWorkingConditionControl : BaseControl
    {       
        #region Properties

        public Int64 _ConstructionToolWorkingConditionID
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

        public MDConstructionToolWorkingConditionEntity _MDConstructionToolWorkingConditionEntity
        {
            get
            {
                MDConstructionToolWorkingConditionEntity entity = new MDConstructionToolWorkingConditionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDConstructionToolWorkingConditionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDConstructionToolWorkingConditionEntity CurrentMDConstructionToolWorkingConditionEntity
        {
            get
            {
                if (_ConstructionToolWorkingConditionID > 0)
                {
                    if (_MDConstructionToolWorkingConditionEntity.ConstructionToolWorkingConditionID != _ConstructionToolWorkingConditionID)
                    {
                        _MDConstructionToolWorkingConditionEntity = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetByID(_ConstructionToolWorkingConditionID);
                    }
                }

                return _MDConstructionToolWorkingConditionEntity;
            }
            set
            {
                _MDConstructionToolWorkingConditionEntity = value;
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
            MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity = CurrentMDConstructionToolWorkingConditionEntity;


            if (!mDConstructionToolWorkingConditionEntity.IsNew)
            {
                txtName.Text = mDConstructionToolWorkingConditionEntity.Name.ToString();
                txtDescription.Text = mDConstructionToolWorkingConditionEntity.Description.ToString();
                chkIsRemoved.Checked = mDConstructionToolWorkingConditionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDConstructionToolWorkingConditionList();
        }

        private void BindMDConstructionToolWorkingConditionList()
        {
            lvMDConstructionToolWorkingCondition.DataBind();
        }

        private MDConstructionToolWorkingConditionEntity BuildMDConstructionToolWorkingConditionEntity()
        {
            MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity = CurrentMDConstructionToolWorkingConditionEntity;

            mDConstructionToolWorkingConditionEntity.Name = txtName.Text.Trim();
            mDConstructionToolWorkingConditionEntity.Description = txtDescription.Text.Trim();
            mDConstructionToolWorkingConditionEntity.IsRemoved = chkIsRemoved.Checked;


            return mDConstructionToolWorkingConditionEntity;
        }

        private void SaveMDConstructionToolWorkingConditionEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity = BuildMDConstructionToolWorkingConditionEntity();

                    Int64 result = -1;

                    if (mDConstructionToolWorkingConditionEntity.IsNew)
                    {
                        result = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().Add(mDConstructionToolWorkingConditionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDConstructionToolWorkingConditionEntity.FLD_NAME_ConstructionToolWorkingConditionID, mDConstructionToolWorkingConditionEntity.ConstructionToolWorkingConditionID.ToString(), SQLMatchType.Equal);
                        result = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().Update(mDConstructionToolWorkingConditionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConstructionToolWorkingConditionID = 0;
                        _MDConstructionToolWorkingConditionEntity = new MDConstructionToolWorkingConditionEntity();
                        PrepareInitialView();
                        BindMDConstructionToolWorkingConditionList();

                        if (mDConstructionToolWorkingConditionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Working Condition Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Working Condition Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDConstructionToolWorkingConditionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Construction Tool Working Condition Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Construction Tool Working Condition Information.", false);
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

        protected void lvMDConstructionToolWorkingCondition_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConstructionToolWorkingConditionID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConstructionToolWorkingConditionID);

            if (ConstructionToolWorkingConditionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConstructionToolWorkingConditionID = ConstructionToolWorkingConditionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDConstructionToolWorkingConditionEntity.FLD_NAME_ConstructionToolWorkingConditionID, ConstructionToolWorkingConditionID.ToString(), SQLMatchType.Equal);

                        MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity = new MDConstructionToolWorkingConditionEntity();


                        result = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().Delete(mDConstructionToolWorkingConditionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConstructionToolWorkingConditionID = 0;
                            _MDConstructionToolWorkingConditionEntity = new MDConstructionToolWorkingConditionEntity();
                            PrepareInitialView();
                            BindMDConstructionToolWorkingConditionList();

                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Working Condition has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Construction Tool Working Condition.", true);
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

        protected void odsMDConstructionToolWorkingCondition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDConstructionToolWorkingConditionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConstructionToolWorkingConditionID = 0;
            _MDConstructionToolWorkingConditionEntity = new MDConstructionToolWorkingConditionEntity();
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
