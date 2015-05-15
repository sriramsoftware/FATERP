// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




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
    public partial class MDDivisionControl : BaseControl
    {       
        #region Properties

        public Int64 _DivisionID
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

        public MDDivisionEntity _MDDivisionEntity
        {
            get
            {
                MDDivisionEntity entity = new MDDivisionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDivisionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDivisionEntity CurrentMDDivisionEntity
        {
            get
            {
                if (_DivisionID > 0)
                {
                    if (_MDDivisionEntity.DivisionID != _DivisionID)
                    {
                        _MDDivisionEntity = FCCMDDivision.GetFacadeCreate().GetByID(_DivisionID);
                    }
                }

                return _MDDivisionEntity;
            }
            set
            {
                _MDDivisionEntity = value;
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

            txtDivisionName.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDDivisionEntity mDDivisionEntity = CurrentMDDivisionEntity;


            if (!mDDivisionEntity.IsNew)
            {
                txtDivisionName.Text = mDDivisionEntity.DivisionName.ToString();
                txtRemarks.Text = mDDivisionEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDDivisionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDivisionList();
        }

        private void BindMDDivisionList()
        {
            lvMDDivision.DataBind();
        }

        private MDDivisionEntity BuildMDDivisionEntity()
        {
            MDDivisionEntity mDDivisionEntity = CurrentMDDivisionEntity;

            mDDivisionEntity.DivisionName = txtDivisionName.Text.Trim();
            mDDivisionEntity.Remarks = txtRemarks.Text.Trim();
            mDDivisionEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDivisionEntity;
        }

        private void SaveMDDivisionEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDivisionEntity mDDivisionEntity = BuildMDDivisionEntity();

                    Int64 result = -1;

                    if (mDDivisionEntity.IsNew)
                    {
                        result = FCCMDDivision.GetFacadeCreate().Add(mDDivisionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDivisionEntity.FLD_NAME_DivisionID, mDDivisionEntity.DivisionID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDivision.GetFacadeCreate().Update(mDDivisionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DivisionID = 0;
                        _MDDivisionEntity = new MDDivisionEntity();
                        PrepareInitialView();
                        BindMDDivisionList();

                        if (mDDivisionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Division Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Division Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDivisionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Division Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Division Information.", false);
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

        protected void lvMDDivision_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DivisionID;

            Int64.TryParse(e.CommandArgument.ToString(), out DivisionID);

            if (DivisionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DivisionID = DivisionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDivisionEntity.FLD_NAME_DivisionID, DivisionID.ToString(), SQLMatchType.Equal);

                        MDDivisionEntity mDDivisionEntity = new MDDivisionEntity();


                        result = FCCMDDivision.GetFacadeCreate().Delete(mDDivisionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DivisionID = 0;
                            _MDDivisionEntity = new MDDivisionEntity();
                            PrepareInitialView();
                            BindMDDivisionList();

                            MiscUtil.ShowMessage(lblMessage, "Division has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Division.", true);
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

        protected void odsMDDivision_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDivisionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DivisionID = 0;
            _MDDivisionEntity = new MDDivisionEntity();
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
