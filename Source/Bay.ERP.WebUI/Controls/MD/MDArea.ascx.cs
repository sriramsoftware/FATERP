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
    public partial class MDAreaControl : BaseControl
    {       
        #region Properties

        public Int64 _AreaID
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

        public MDAreaEntity _MDAreaEntity
        {
            get
            {
                MDAreaEntity entity = new MDAreaEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAreaEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAreaEntity CurrentMDAreaEntity
        {
            get
            {
                if (_AreaID > 0)
                {
                    if (_MDAreaEntity.AreaID != _AreaID)
                    {
                        _MDAreaEntity = FCCMDArea.GetFacadeCreate().GetByID(_AreaID);
                    }
                }

                return _MDAreaEntity;
            }
            set
            {
                _MDAreaEntity = value;
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
            //BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDAreaEntity mDAreaEntity = CurrentMDAreaEntity;


            if (!mDAreaEntity.IsNew)
            {

                txtName.Text = mDAreaEntity.Name.ToString();
                txtDescription.Text = mDAreaEntity.Description.ToString();
                chkIsRemoved.Checked = mDAreaEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAreaList();
        }

        private void BindMDAreaList()
        {
            lvMDArea.DataBind();
        }

        private MDAreaEntity BuildMDAreaEntity()
        {
            MDAreaEntity mDAreaEntity = CurrentMDAreaEntity;

            mDAreaEntity.Name = txtName.Text.Trim();
            mDAreaEntity.Description = txtDescription.Text.Trim();
            mDAreaEntity.IsRemoved = chkIsRemoved.Checked;


            return mDAreaEntity;
        }

        private void SaveMDAreaEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAreaEntity mDAreaEntity = BuildMDAreaEntity();

                    Int64 result = -1;

                    if (mDAreaEntity.IsNew)
                    {
                        result = FCCMDArea.GetFacadeCreate().Add(mDAreaEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAreaEntity.FLD_NAME_AreaID, mDAreaEntity.AreaID.ToString(), SQLMatchType.Equal);
                        result = FCCMDArea.GetFacadeCreate().Update(mDAreaEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AreaID = 0;
                        _MDAreaEntity = new MDAreaEntity();
                        PrepareInitialView();
                        BindMDAreaList();

                        if (mDAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Area Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Area Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Area Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Area Information.", false);
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

        protected void lvMDArea_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AreaID;

            Int64.TryParse(e.CommandArgument.ToString(), out AreaID);

            if (AreaID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AreaID = AreaID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAreaEntity.FLD_NAME_AreaID, AreaID.ToString(), SQLMatchType.Equal);

                        MDAreaEntity mDAreaEntity = new MDAreaEntity();


                        result = FCCMDArea.GetFacadeCreate().Delete(mDAreaEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AreaID = 0;
                            _MDAreaEntity = new MDAreaEntity();
                            PrepareInitialView();
                            BindMDAreaList();

                            MiscUtil.ShowMessage(lblMessage, "Area has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Area.", true);
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

        protected void odsMDArea_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {  
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAreaEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AreaID = 0;
            _MDAreaEntity = new MDAreaEntity();
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
