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
    public partial class MDResumeCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ResumeCategoryID
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

        public MDResumeCategoryEntity _MDResumeCategoryEntity
        {
            get
            {
                MDResumeCategoryEntity entity = new MDResumeCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDResumeCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDResumeCategoryEntity CurrentMDResumeCategoryEntity
        {
            get
            {
                if (_ResumeCategoryID > 0)
                {
                    if (_MDResumeCategoryEntity.ResumeCategoryID != _ResumeCategoryID)
                    {
                        _MDResumeCategoryEntity = FCCMDResumeCategory.GetFacadeCreate().GetByID(_ResumeCategoryID);
                    }
                }

                return _MDResumeCategoryEntity;
            }
            set
            {
                _MDResumeCategoryEntity = value;
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
            MDResumeCategoryEntity mDResumeCategoryEntity = CurrentMDResumeCategoryEntity;


            if (!mDResumeCategoryEntity.IsNew)
            {
                txtName.Text = mDResumeCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = mDResumeCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDResumeCategoryList();
        }

        private void BindMDResumeCategoryList()
        {
            lvMDResumeCategory.DataBind();
        }

        private MDResumeCategoryEntity BuildMDResumeCategoryEntity()
        {
            MDResumeCategoryEntity mDResumeCategoryEntity = CurrentMDResumeCategoryEntity;

            mDResumeCategoryEntity.Name = txtName.Text.Trim();
            mDResumeCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDResumeCategoryEntity;
        }

        private void SaveMDResumeCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDResumeCategoryEntity mDResumeCategoryEntity = BuildMDResumeCategoryEntity();

                    Int64 result = -1;

                    if (mDResumeCategoryEntity.IsNew)
                    {
                        result = FCCMDResumeCategory.GetFacadeCreate().Add(mDResumeCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDResumeCategoryEntity.FLD_NAME_ResumeCategoryID, mDResumeCategoryEntity.ResumeCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDResumeCategory.GetFacadeCreate().Update(mDResumeCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ResumeCategoryID = 0;
                        _MDResumeCategoryEntity = new MDResumeCategoryEntity();
                        PrepareInitialView();
                        BindMDResumeCategoryList();

                        if (mDResumeCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resume Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resume Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDResumeCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Resume Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Resume Category Information.", false);
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

        protected void lvMDResumeCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ResumeCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ResumeCategoryID);

            if (ResumeCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ResumeCategoryID = ResumeCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDResumeCategoryEntity.FLD_NAME_ResumeCategoryID, ResumeCategoryID.ToString(), SQLMatchType.Equal);

                        MDResumeCategoryEntity mDResumeCategoryEntity = new MDResumeCategoryEntity();


                        result = FCCMDResumeCategory.GetFacadeCreate().Delete(mDResumeCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ResumeCategoryID = 0;
                            _MDResumeCategoryEntity = new MDResumeCategoryEntity();
                            PrepareInitialView();
                            BindMDResumeCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Resume Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Resume Category.", true);
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

        protected void odsMDResumeCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDResumeCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ResumeCategoryID = 0;
            _MDResumeCategoryEntity = new MDResumeCategoryEntity();
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
