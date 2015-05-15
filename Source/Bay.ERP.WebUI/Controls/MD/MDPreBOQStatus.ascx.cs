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
    public partial class MDPreBOQStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _PreBOQStatusID
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

        public MDPreBOQStatusEntity _MDPreBOQStatusEntity
        {
            get
            {
                MDPreBOQStatusEntity entity = new MDPreBOQStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDPreBOQStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDPreBOQStatusEntity CurrentMDPreBOQStatusEntity
        {
            get
            {
                if (_PreBOQStatusID > 0)
                {
                    if (_MDPreBOQStatusEntity.PreBOQStatusID != _PreBOQStatusID)
                    {
                        _MDPreBOQStatusEntity = FCCMDPreBOQStatus.GetFacadeCreate().GetByID(_PreBOQStatusID);
                    }
                }

                return _MDPreBOQStatusEntity;
            }
            set
            {
                _MDPreBOQStatusEntity = value;
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
            MDPreBOQStatusEntity mDPreBOQStatusEntity = CurrentMDPreBOQStatusEntity;


            if (!mDPreBOQStatusEntity.IsNew)
            {
                txtName.Text = mDPreBOQStatusEntity.Name.ToString();
                txtDescription.Text = mDPreBOQStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDPreBOQStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDPreBOQStatusList();
        }

        private void BindMDPreBOQStatusList()
        {
            lvMDPreBOQStatus.DataBind();
        }

        private MDPreBOQStatusEntity BuildMDPreBOQStatusEntity()
        {
            MDPreBOQStatusEntity mDPreBOQStatusEntity = CurrentMDPreBOQStatusEntity;

            mDPreBOQStatusEntity.Name = txtName.Text.Trim();
            mDPreBOQStatusEntity.Description = txtDescription.Text.Trim();
            mDPreBOQStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDPreBOQStatusEntity;
        }

        private void SaveMDPreBOQStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDPreBOQStatusEntity mDPreBOQStatusEntity = BuildMDPreBOQStatusEntity();

                    Int64 result = -1;

                    if (mDPreBOQStatusEntity.IsNew)
                    {
                        result = FCCMDPreBOQStatus.GetFacadeCreate().Add(mDPreBOQStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDPreBOQStatusEntity.FLD_NAME_PreBOQStatusID, mDPreBOQStatusEntity.PreBOQStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDPreBOQStatus.GetFacadeCreate().Update(mDPreBOQStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PreBOQStatusID = 0;
                        _MDPreBOQStatusEntity = new MDPreBOQStatusEntity();
                        PrepareInitialView();
                        BindMDPreBOQStatusList();

                        if (mDPreBOQStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pre BOQStatus Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pre BOQStatus Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDPreBOQStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Pre BOQStatus Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Pre BOQStatus Information.", false);
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

        protected void lvMDPreBOQStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PreBOQStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out PreBOQStatusID);

            if (PreBOQStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PreBOQStatusID = PreBOQStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDPreBOQStatusEntity.FLD_NAME_PreBOQStatusID, PreBOQStatusID.ToString(), SQLMatchType.Equal);

                        MDPreBOQStatusEntity mDPreBOQStatusEntity = new MDPreBOQStatusEntity();


                        result = FCCMDPreBOQStatus.GetFacadeCreate().Delete(mDPreBOQStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PreBOQStatusID = 0;
                            _MDPreBOQStatusEntity = new MDPreBOQStatusEntity();
                            PrepareInitialView();
                            BindMDPreBOQStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Pre BOQStatus has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Pre BOQStatus.", true);
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

        protected void odsMDPreBOQStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDPreBOQStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PreBOQStatusID = 0;
            _MDPreBOQStatusEntity = new MDPreBOQStatusEntity();
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
