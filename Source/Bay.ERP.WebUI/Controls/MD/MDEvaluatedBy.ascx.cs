// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public partial class MDEvaluatedByControl : BaseControl
    {       
        #region Properties

        public Int64 _EvaluatedByID
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

        public MDEvaluatedByEntity _MDEvaluatedByEntity
        {
            get
            {
                MDEvaluatedByEntity entity = new MDEvaluatedByEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEvaluatedByEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEvaluatedByEntity CurrentMDEvaluatedByEntity
        {
            get
            {
                if (_EvaluatedByID > 0)
                {
                    if (_MDEvaluatedByEntity.EvaluatedByID != _EvaluatedByID)
                    {
                        _MDEvaluatedByEntity = FCCMDEvaluatedBy.GetFacadeCreate().GetByID(_EvaluatedByID);
                    }
                }

                return _MDEvaluatedByEntity;
            }
            set
            {
                _MDEvaluatedByEntity = value;
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
            MDEvaluatedByEntity mDEvaluatedByEntity = CurrentMDEvaluatedByEntity;


            if (!mDEvaluatedByEntity.IsNew)
            {
                txtName.Text = mDEvaluatedByEntity.Name.ToString();
                txtDescription.Text = mDEvaluatedByEntity.Description.ToString();
                chkIsRemoved.Checked = mDEvaluatedByEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEvaluatedByList();
        }

        private void BindMDEvaluatedByList()
        {
            lvMDEvaluatedBy.DataBind();
        }

        private MDEvaluatedByEntity BuildMDEvaluatedByEntity()
        {
            MDEvaluatedByEntity mDEvaluatedByEntity = CurrentMDEvaluatedByEntity;

            mDEvaluatedByEntity.Name = txtName.Text.Trim();
            mDEvaluatedByEntity.Description = txtDescription.Text.Trim();
            mDEvaluatedByEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEvaluatedByEntity;
        }

        private void SaveMDEvaluatedByEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEvaluatedByEntity mDEvaluatedByEntity = BuildMDEvaluatedByEntity();

                    Int64 result = -1;

                    if (mDEvaluatedByEntity.IsNew)
                    {
                        result = FCCMDEvaluatedBy.GetFacadeCreate().Add(mDEvaluatedByEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluatedByEntity.FLD_NAME_EvaluatedByID, mDEvaluatedByEntity.EvaluatedByID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEvaluatedBy.GetFacadeCreate().Update(mDEvaluatedByEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EvaluatedByID = 0;
                        _MDEvaluatedByEntity = new MDEvaluatedByEntity();
                        PrepareInitialView();
                        BindMDEvaluatedByList();

                        if (mDEvaluatedByEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluated By Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluated By Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEvaluatedByEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Evaluated By Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Evaluated By Information.", false);
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

        protected void lvMDEvaluatedBy_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EvaluatedByID;

            Int64.TryParse(e.CommandArgument.ToString(), out EvaluatedByID);

            if (EvaluatedByID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EvaluatedByID = EvaluatedByID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluatedByEntity.FLD_NAME_EvaluatedByID, EvaluatedByID.ToString(), SQLMatchType.Equal);

                        MDEvaluatedByEntity mDEvaluatedByEntity = new MDEvaluatedByEntity();


                        result = FCCMDEvaluatedBy.GetFacadeCreate().Delete(mDEvaluatedByEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EvaluatedByID = 0;
                            _MDEvaluatedByEntity = new MDEvaluatedByEntity();
                            PrepareInitialView();
                            BindMDEvaluatedByList();

                            MiscUtil.ShowMessage(lblMessage, "Evaluated By has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Evaluated By.", true);
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

        protected void odsMDEvaluatedBy_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEvaluatedByEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EvaluatedByID = 0;
            _MDEvaluatedByEntity = new MDEvaluatedByEntity();
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
