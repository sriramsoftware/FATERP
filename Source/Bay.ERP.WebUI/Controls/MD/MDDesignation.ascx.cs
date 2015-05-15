// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public partial class MDDesignationControl : BaseControl
    {       
        #region Properties

        public Int64 _DesignationID
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

        public MDDesignationEntity _MDDesignationEntity
        {
            get
            {
                MDDesignationEntity entity = new MDDesignationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDesignationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDesignationEntity CurrentMDDesignationEntity
        {
            get
            {
                if (_DesignationID > 0)
                {
                    if (_MDDesignationEntity.DesignationID != _DesignationID)
                    {
                        _MDDesignationEntity = FCCMDDesignation.GetFacadeCreate().GetByID(_DesignationID);
                    }
                }

                return _MDDesignationEntity;
            }
            set
            {
                _MDDesignationEntity = value;
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
            MDDesignationEntity mDDesignationEntity = CurrentMDDesignationEntity;


            if (!mDDesignationEntity.IsNew)
            {
                txtName.Text = mDDesignationEntity.Name.ToString();
                txtDescription.Text = mDDesignationEntity.Description.ToString();
                chkIsRemoved.Checked = mDDesignationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void LoadTreeView()
        {
            treeDesignation.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeDesignation.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Department.", true);
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeDesignation.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Category.", true);
            }

            return validationResult;
        }

        private MDDesignationEntity BuildMDDesignationEntity()
        {
            MDDesignationEntity mDDesignationEntity = CurrentMDDesignationEntity;

            mDDesignationEntity.Name = txtName.Text.Trim();
            mDDesignationEntity.Description = txtDescription.Text.Trim();
            mDDesignationEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDesignationEntity;
        }

        private void SaveMDDesignationEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDesignationEntity mDDesignationEntity = BuildMDDesignationEntity();

                    Int64 result = -1;

                    if (mDDesignationEntity.IsNew)
                    {
                        result = FCCMDDesignation.GetFacadeCreate().Add(mDDesignationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDesignationEntity.FLD_NAME_DesignationID, mDDesignationEntity.DesignationID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDesignation.GetFacadeCreate().Update(mDDesignationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DesignationID = 0;
                        _MDDesignationEntity = new MDDesignationEntity();
                        PrepareInitialView();

                        if (mDDesignationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Designation Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Designation Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDesignationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Designation Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Designation Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EditDesignation()
        {
            Int64 DesignationID;

            Int64.TryParse(treeDesignation.SelectedValue, out DesignationID);

            if (DesignationID > 0)
            {
                _DesignationID = DesignationID;

                PrepareEditView();
            }
        }

        private void DeleteDesignation()
        {
            Int64 DesignationID;

            Int64.TryParse(treeDesignation.SelectedValue, out DesignationID);

            if (DesignationID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDesignationEntity.FLD_NAME_DesignationID, DesignationID.ToString(), SQLMatchType.Equal);

                    MDDesignationEntity mDDesignationEntity = new MDDesignationEntity();


                    result = FCCMDDesignation.GetFacadeCreate().Delete(mDDesignationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _DesignationID = 0;
                        _MDDesignationEntity = new MDDesignationEntity();

                        // clearing cache
                        FCCMDDesignation.GetFacadeCreate().RemoveCache();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Designation has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Designation.", true);
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

        protected void lvMDDesignation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DesignationID;

            Int64.TryParse(e.CommandArgument.ToString(), out DesignationID);

            if (DesignationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DesignationID = DesignationID;

                    PrepareEditView();

                    
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDesignationEntity.FLD_NAME_DesignationID, DesignationID.ToString(), SQLMatchType.Equal);

                        MDDesignationEntity mDDesignationEntity = new MDDesignationEntity();


                        result = FCCMDDesignation.GetFacadeCreate().Delete(mDDesignationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DesignationID = 0;
                            _MDDesignationEntity = new MDDesignationEntity();
                            PrepareInitialView();
                            

                            MiscUtil.ShowMessage(lblMessage, "Designation has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Designation.", true);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveMDDesignationEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DesignationID = 0;
            _MDDesignationEntity = new MDDesignationEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void lnkBtnEditDesignation_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditDesignation();
            }
        }

        protected void lnkBtnRemoveDesignation_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteDesignation();
            }
        }

        #endregion

        #endregion Event
    }
}
