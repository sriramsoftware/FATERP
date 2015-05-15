// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDFamilyRelationTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _FamilyRelationTypeID
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

        public MDFamilyRelationTypeEntity _MDFamilyRelationTypeEntity
        {
            get
            {
                MDFamilyRelationTypeEntity entity = new MDFamilyRelationTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDFamilyRelationTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDFamilyRelationTypeEntity CurrentMDFamilyRelationTypeEntity
        {
            get
            {
                if (_FamilyRelationTypeID > 0)
                {
                    if (_MDFamilyRelationTypeEntity.FamilyRelationTypeID != _FamilyRelationTypeID)
                    {
                        _MDFamilyRelationTypeEntity = FCCMDFamilyRelationType.GetFacadeCreate().GetByID(_FamilyRelationTypeID);
                    }
                }

                return _MDFamilyRelationTypeEntity;
            }
            set
            {
                _MDFamilyRelationTypeEntity = value;
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

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDFamilyRelationTypeEntity mDFamilyRelationTypeEntity = CurrentMDFamilyRelationTypeEntity;


            if (!mDFamilyRelationTypeEntity.IsNew)
            {
                txtName.Text = mDFamilyRelationTypeEntity.Name.ToString();
                txtDescription.Text = mDFamilyRelationTypeEntity.Description.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDFamilyRelationTypeList();
        }

        private void BindMDFamilyRelationTypeList()
        {
            lvMDFamilyRelationType.DataBind();
        }

        private MDFamilyRelationTypeEntity BuildMDFamilyRelationTypeEntity()
        {
            MDFamilyRelationTypeEntity mDFamilyRelationTypeEntity = CurrentMDFamilyRelationTypeEntity;

            mDFamilyRelationTypeEntity.Name = txtName.Text.Trim();
            mDFamilyRelationTypeEntity.Description = txtDescription.Text.Trim();

            return mDFamilyRelationTypeEntity;
        }

        private void SaveMDFamilyRelationTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDFamilyRelationTypeEntity mDFamilyRelationTypeEntity = BuildMDFamilyRelationTypeEntity();

                    Int64 result = -1;

                    if (mDFamilyRelationTypeEntity.IsNew)
                    {
                        result = FCCMDFamilyRelationType.GetFacadeCreate().Add(mDFamilyRelationTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDFamilyRelationTypeEntity.FLD_NAME_FamilyRelationTypeID, mDFamilyRelationTypeEntity.FamilyRelationTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDFamilyRelationType.GetFacadeCreate().Update(mDFamilyRelationTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FamilyRelationTypeID = 0;
                        _MDFamilyRelationTypeEntity = new MDFamilyRelationTypeEntity();
                        PrepareInitialView();
                        BindMDFamilyRelationTypeList();

                        if (mDFamilyRelationTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Family Relation Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Family Relation Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDFamilyRelationTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Family Relation Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Family Relation Type Information.", false);
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

        protected void lvMDFamilyRelationType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 FamilyRelationTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out FamilyRelationTypeID);

            if (FamilyRelationTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _FamilyRelationTypeID = FamilyRelationTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDFamilyRelationTypeEntity.FLD_NAME_FamilyRelationTypeID, FamilyRelationTypeID.ToString(), SQLMatchType.Equal);

                        MDFamilyRelationTypeEntity mDFamilyRelationTypeEntity = new MDFamilyRelationTypeEntity();


                        result = FCCMDFamilyRelationType.GetFacadeCreate().Delete(mDFamilyRelationTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _FamilyRelationTypeID = 0;
                            _MDFamilyRelationTypeEntity = new MDFamilyRelationTypeEntity();
                            PrepareInitialView();
                            BindMDFamilyRelationTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Family Relation Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Family Relation Type.", true);
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

        protected void odsMDFamilyRelationType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDFamilyRelationTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _FamilyRelationTypeID = 0;
            _MDFamilyRelationTypeEntity = new MDFamilyRelationTypeEntity();
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
