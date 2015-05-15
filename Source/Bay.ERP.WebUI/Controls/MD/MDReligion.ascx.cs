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
    public partial class MDReligionControl : BaseControl
    {       
        #region Properties

        public Int64 _ReligionID
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

        public MDReligionEntity _MDReligionEntity
        {
            get
            {
                MDReligionEntity entity = new MDReligionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDReligionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDReligionEntity CurrentMDReligionEntity
        {
            get
            {
                if (_ReligionID > 0)
                {
                    if (_MDReligionEntity.ReligionID != _ReligionID)
                    {
                        _MDReligionEntity = FCCMDReligion.GetFacadeCreate().GetByID(_ReligionID);
                    }
                }

                return _MDReligionEntity;
            }
            set
            {
                _MDReligionEntity = value;
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
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDReligionEntity mDReligionEntity = CurrentMDReligionEntity;


            if (!mDReligionEntity.IsNew)
            {
                txtName.Text = mDReligionEntity.Name.ToString();
                txtRemarks.Text = mDReligionEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDReligionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDReligionList();
        }

        private void BindMDReligionList()
        {
            lvMDReligion.DataBind();
        }

        private MDReligionEntity BuildMDReligionEntity()
        {
            MDReligionEntity mDReligionEntity = CurrentMDReligionEntity;

            mDReligionEntity.Name = txtName.Text.Trim();
            mDReligionEntity.Remarks = txtRemarks.Text.Trim();
            mDReligionEntity.IsRemoved = chkIsRemoved.Checked;


            return mDReligionEntity;
        }

        private void SaveMDReligionEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDReligionEntity mDReligionEntity = BuildMDReligionEntity();

                    Int64 result = -1;

                    if (mDReligionEntity.IsNew)
                    {
                        result = FCCMDReligion.GetFacadeCreate().Add(mDReligionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDReligionEntity.FLD_NAME_ReligionID, mDReligionEntity.ReligionID.ToString(), SQLMatchType.Equal);
                        result = FCCMDReligion.GetFacadeCreate().Update(mDReligionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ReligionID = 0;
                        _MDReligionEntity = new MDReligionEntity();
                        PrepareInitialView();
                        BindMDReligionList();

                        if (mDReligionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Religion Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Religion Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDReligionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Religion Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Religion Information.", false);
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

        protected void lvMDReligion_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ReligionID;

            Int64.TryParse(e.CommandArgument.ToString(), out ReligionID);

            if (ReligionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ReligionID = ReligionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDReligionEntity.FLD_NAME_ReligionID, ReligionID.ToString(), SQLMatchType.Equal);

                        MDReligionEntity mDReligionEntity = new MDReligionEntity();


                        result = FCCMDReligion.GetFacadeCreate().Delete(mDReligionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ReligionID = 0;
                            _MDReligionEntity = new MDReligionEntity();
                            PrepareInitialView();
                            BindMDReligionList();

                            MiscUtil.ShowMessage(lblMessage, "Religion has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Religion.", true);
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

        protected void odsMDReligion_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDReligionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ReligionID = 0;
            _MDReligionEntity = new MDReligionEntity();
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
