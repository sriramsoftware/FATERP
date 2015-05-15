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
    public partial class MDBloodGroupControl : BaseControl
    {       
        #region Properties

        public Int64 _BloodGroupID
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

        public MDBloodGroupEntity _MDBloodGroupEntity
        {
            get
            {
                MDBloodGroupEntity entity = new MDBloodGroupEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDBloodGroupEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDBloodGroupEntity CurrentMDBloodGroupEntity
        {
            get
            {
                if (_BloodGroupID > 0)
                {
                    if (_MDBloodGroupEntity.BloodGroupID != _BloodGroupID)
                    {
                        _MDBloodGroupEntity = FCCMDBloodGroup.GetFacadeCreate().GetByID(_BloodGroupID);
                    }
                }

                return _MDBloodGroupEntity;
            }
            set
            {
                _MDBloodGroupEntity = value;
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
            MDBloodGroupEntity mDBloodGroupEntity = CurrentMDBloodGroupEntity;


            if (!mDBloodGroupEntity.IsNew)
            {
                txtName.Text = mDBloodGroupEntity.Name.ToString();
                chkIsRemoved.Checked = mDBloodGroupEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDBloodGroupList();
        }

        private void BindMDBloodGroupList()
        {
            lvMDBloodGroup.DataBind();
        }

        private MDBloodGroupEntity BuildMDBloodGroupEntity()
        {
            MDBloodGroupEntity mDBloodGroupEntity = CurrentMDBloodGroupEntity;

            mDBloodGroupEntity.Name = txtName.Text.Trim();
            mDBloodGroupEntity.IsRemoved = chkIsRemoved.Checked;


            return mDBloodGroupEntity;
        }

        private void SaveMDBloodGroupEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDBloodGroupEntity mDBloodGroupEntity = BuildMDBloodGroupEntity();

                    Int64 result = -1;

                    if (mDBloodGroupEntity.IsNew)
                    {
                        result = FCCMDBloodGroup.GetFacadeCreate().Add(mDBloodGroupEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDBloodGroupEntity.FLD_NAME_BloodGroupID, mDBloodGroupEntity.BloodGroupID.ToString(), SQLMatchType.Equal);
                        result = FCCMDBloodGroup.GetFacadeCreate().Update(mDBloodGroupEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BloodGroupID = 0;
                        _MDBloodGroupEntity = new MDBloodGroupEntity();
                        PrepareInitialView();
                        BindMDBloodGroupList();

                        if (mDBloodGroupEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Blood Group Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Blood Group Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDBloodGroupEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Blood Group Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Blood Group Information.", false);
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

        protected void lvMDBloodGroup_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BloodGroupID;

            Int64.TryParse(e.CommandArgument.ToString(), out BloodGroupID);

            if (BloodGroupID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BloodGroupID = BloodGroupID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDBloodGroupEntity.FLD_NAME_BloodGroupID, BloodGroupID.ToString(), SQLMatchType.Equal);

                        MDBloodGroupEntity mDBloodGroupEntity = new MDBloodGroupEntity();


                        result = FCCMDBloodGroup.GetFacadeCreate().Delete(mDBloodGroupEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BloodGroupID = 0;
                            _MDBloodGroupEntity = new MDBloodGroupEntity();
                            PrepareInitialView();
                            BindMDBloodGroupList();

                            MiscUtil.ShowMessage(lblMessage, "Blood Group has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Blood Group.", true);
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

        protected void odsMDBloodGroup_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDBloodGroupEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BloodGroupID = 0;
            _MDBloodGroupEntity = new MDBloodGroupEntity();
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
