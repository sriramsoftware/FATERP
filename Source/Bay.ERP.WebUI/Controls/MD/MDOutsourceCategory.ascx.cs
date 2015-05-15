// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




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
    public partial class MDOutsourceCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _OutsourceCategoryID
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

        public MDOutsourceCategoryEntity _MDOutsourceCategoryEntity
        {
            get
            {
                MDOutsourceCategoryEntity entity = new MDOutsourceCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDOutsourceCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDOutsourceCategoryEntity CurrentMDOutsourceCategoryEntity
        {
            get
            {
                if (_OutsourceCategoryID > 0)
                {
                    if (_MDOutsourceCategoryEntity.OutsourceCategoryID != _OutsourceCategoryID)
                    {
                        _MDOutsourceCategoryEntity = FCCMDOutsourceCategory.GetFacadeCreate().GetByID(_OutsourceCategoryID);
                    }
                }

                return _MDOutsourceCategoryEntity;
            }
            set
            {
                _MDOutsourceCategoryEntity = value;
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
            MDOutsourceCategoryEntity mDOutsourceCategoryEntity = CurrentMDOutsourceCategoryEntity;


            if (!mDOutsourceCategoryEntity.IsNew)
            {
                txtName.Text = mDOutsourceCategoryEntity.Name.ToString();
                txtDescription.Text = mDOutsourceCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDOutsourceCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDOutsourceCategoryList();
        }

        private void BindMDOutsourceCategoryList()
        {
            lvMDOutsourceCategory.DataBind();
        }

        private MDOutsourceCategoryEntity BuildMDOutsourceCategoryEntity()
        {
            MDOutsourceCategoryEntity mDOutsourceCategoryEntity = CurrentMDOutsourceCategoryEntity;

            mDOutsourceCategoryEntity.Name = txtName.Text.Trim();
            mDOutsourceCategoryEntity.Description = txtDescription.Text.Trim();
            mDOutsourceCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDOutsourceCategoryEntity;
        }

        private void SaveMDOutsourceCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDOutsourceCategoryEntity mDOutsourceCategoryEntity = BuildMDOutsourceCategoryEntity();

                    Int64 result = -1;

                    if (mDOutsourceCategoryEntity.IsNew)
                    {
                        result = FCCMDOutsourceCategory.GetFacadeCreate().Add(mDOutsourceCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDOutsourceCategoryEntity.FLD_NAME_OutsourceCategoryID, mDOutsourceCategoryEntity.OutsourceCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDOutsourceCategory.GetFacadeCreate().Update(mDOutsourceCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OutsourceCategoryID = 0;
                        _MDOutsourceCategoryEntity = new MDOutsourceCategoryEntity();
                        PrepareInitialView();
                        BindMDOutsourceCategoryList();

                        if (mDOutsourceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Outsource Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Outsource Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDOutsourceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Outsource Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Outsource Category Information.", false);
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

        protected void lvMDOutsourceCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OutsourceCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out OutsourceCategoryID);

            if (OutsourceCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OutsourceCategoryID = OutsourceCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDOutsourceCategoryEntity.FLD_NAME_OutsourceCategoryID, OutsourceCategoryID.ToString(), SQLMatchType.Equal);

                        MDOutsourceCategoryEntity mDOutsourceCategoryEntity = new MDOutsourceCategoryEntity();


                        result = FCCMDOutsourceCategory.GetFacadeCreate().Delete(mDOutsourceCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OutsourceCategoryID = 0;
                            _MDOutsourceCategoryEntity = new MDOutsourceCategoryEntity();
                            PrepareInitialView();
                            BindMDOutsourceCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Outsource Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Outsource Category.", true);
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

        protected void odsMDOutsourceCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDOutsourceCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OutsourceCategoryID = 0;
            _MDOutsourceCategoryEntity = new MDOutsourceCategoryEntity();
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
