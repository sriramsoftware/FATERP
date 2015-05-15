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
    public partial class MDGenderControl : BaseControl
    {       
        #region Properties

        public Int64 _GenderID
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

        public MDGenderEntity _MDGenderEntity
        {
            get
            {
                MDGenderEntity entity = new MDGenderEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDGenderEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDGenderEntity CurrentMDGenderEntity
        {
            get
            {
                if (_GenderID > 0)
                {
                    if (_MDGenderEntity.GenderID != _GenderID)
                    {
                        _MDGenderEntity = FCCMDGender.GetFacadeCreate().GetByID(_GenderID);
                    }
                }

                return _MDGenderEntity;
            }
            set
            {
                _MDGenderEntity = value;
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
            MDGenderEntity mDGenderEntity = CurrentMDGenderEntity;


            if (!mDGenderEntity.IsNew)
            {
                txtName.Text = mDGenderEntity.Name.ToString();
                txtRemarks.Text = mDGenderEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDGenderEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDGenderList();
        }

        private void BindMDGenderList()
        {
            lvMDGender.DataBind();
        }

        private MDGenderEntity BuildMDGenderEntity()
        {
            MDGenderEntity mDGenderEntity = CurrentMDGenderEntity;

            mDGenderEntity.Name = txtName.Text.Trim();
            mDGenderEntity.Remarks = txtRemarks.Text.Trim();
            mDGenderEntity.IsRemoved = chkIsRemoved.Checked;


            return mDGenderEntity;
        }

        private void SaveMDGenderEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDGenderEntity mDGenderEntity = BuildMDGenderEntity();

                    Int64 result = -1;

                    if (mDGenderEntity.IsNew)
                    {
                        result = FCCMDGender.GetFacadeCreate().Add(mDGenderEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDGenderEntity.FLD_NAME_GenderID, mDGenderEntity.GenderID.ToString(), SQLMatchType.Equal);
                        result = FCCMDGender.GetFacadeCreate().Update(mDGenderEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _GenderID = 0;
                        _MDGenderEntity = new MDGenderEntity();
                        PrepareInitialView();
                        BindMDGenderList();

                        if (mDGenderEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Gender Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Gender Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDGenderEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Gender Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Gender Information.", false);
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

        protected void lvMDGender_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 GenderID;

            Int64.TryParse(e.CommandArgument.ToString(), out GenderID);

            if (GenderID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _GenderID = GenderID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDGenderEntity.FLD_NAME_GenderID, GenderID.ToString(), SQLMatchType.Equal);

                        MDGenderEntity mDGenderEntity = new MDGenderEntity();


                        result = FCCMDGender.GetFacadeCreate().Delete(mDGenderEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _GenderID = 0;
                            _MDGenderEntity = new MDGenderEntity();
                            PrepareInitialView();
                            BindMDGenderList();

                            MiscUtil.ShowMessage(lblMessage, "Gender has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Gender.", true);
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

        protected void odsMDGender_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDGenderEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _GenderID = 0;
            _MDGenderEntity = new MDGenderEntity();
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
