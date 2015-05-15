// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class MDCriterionCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _CriterionCategoryID
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

        public MDCriterionCategoryEntity _MDCriterionCategoryEntity
        {
            get
            {
                MDCriterionCategoryEntity entity = new MDCriterionCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDCriterionCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDCriterionCategoryEntity CurrentMDCriterionCategoryEntity
        {
            get
            {
                if (_CriterionCategoryID > 0)
                {
                    if (_MDCriterionCategoryEntity.CriterionCategoryID != _CriterionCategoryID)
                    {
                        _MDCriterionCategoryEntity = FCCMDCriterionCategory.GetFacadeCreate().GetByID(_CriterionCategoryID);
                    }
                }

                return _MDCriterionCategoryEntity;
            }
            set
            {
                _MDCriterionCategoryEntity = value;
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
            MDCriterionCategoryEntity mDCriterionCategoryEntity = CurrentMDCriterionCategoryEntity;


            if (!mDCriterionCategoryEntity.IsNew)
            {
                txtName.Text = mDCriterionCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = mDCriterionCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDCriterionCategoryList();
        }

        private void BindMDCriterionCategoryList()
        {
            lvMDCriterionCategory.DataBind();
        }

        private MDCriterionCategoryEntity BuildMDCriterionCategoryEntity()
        {
            MDCriterionCategoryEntity mDCriterionCategoryEntity = CurrentMDCriterionCategoryEntity;

            mDCriterionCategoryEntity.Name = txtName.Text.Trim();
            mDCriterionCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDCriterionCategoryEntity;
        }

        private void SaveMDCriterionCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDCriterionCategoryEntity mDCriterionCategoryEntity = BuildMDCriterionCategoryEntity();

                    Int64 result = -1;

                    if (mDCriterionCategoryEntity.IsNew)
                    {
                        result = FCCMDCriterionCategory.GetFacadeCreate().Add(mDCriterionCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDCriterionCategoryEntity.FLD_NAME_CriterionCategoryID, mDCriterionCategoryEntity.CriterionCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDCriterionCategory.GetFacadeCreate().Update(mDCriterionCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CriterionCategoryID = 0;
                        _MDCriterionCategoryEntity = new MDCriterionCategoryEntity();
                        PrepareInitialView();
                        BindMDCriterionCategoryList();

                        if (mDCriterionCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Criterion Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Criterion Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDCriterionCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Criterion Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Criterion Category Information.", false);
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

        protected void lvMDCriterionCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CriterionCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out CriterionCategoryID);

            if (CriterionCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CriterionCategoryID = CriterionCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDCriterionCategoryEntity.FLD_NAME_CriterionCategoryID, CriterionCategoryID.ToString(), SQLMatchType.Equal);

                        MDCriterionCategoryEntity mDCriterionCategoryEntity = new MDCriterionCategoryEntity();


                        result = FCCMDCriterionCategory.GetFacadeCreate().Delete(mDCriterionCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CriterionCategoryID = 0;
                            _MDCriterionCategoryEntity = new MDCriterionCategoryEntity();
                            PrepareInitialView();
                            BindMDCriterionCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Criterion Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Criterion Category.", true);
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

        protected void odsMDCriterionCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDCriterionCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CriterionCategoryID = 0;
            _MDCriterionCategoryEntity = new MDCriterionCategoryEntity();
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
