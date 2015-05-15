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
    public partial class MDPayCycleControl : BaseControl
    {       
        #region Properties

        public Int64 _PayCycleID
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

        public MDPayCycleEntity _MDPayCycleEntity
        {
            get
            {
                MDPayCycleEntity entity = new MDPayCycleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDPayCycleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDPayCycleEntity CurrentMDPayCycleEntity
        {
            get
            {
                if (_PayCycleID > 0)
                {
                    if (_MDPayCycleEntity.PayCycleID != _PayCycleID)
                    {
                        _MDPayCycleEntity = FCCMDPayCycle.GetFacadeCreate().GetByID(_PayCycleID);
                    }
                }

                return _MDPayCycleEntity;
            }
            set
            {
                _MDPayCycleEntity = value;
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
            MDPayCycleEntity mDPayCycleEntity = CurrentMDPayCycleEntity;


            if (!mDPayCycleEntity.IsNew)
            {
                txtName.Text = mDPayCycleEntity.Name.ToString();
                chkIsRemoved.Checked = mDPayCycleEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDPayCycleList();
        }

        private void BindMDPayCycleList()
        {
            lvMDPayCycle.DataBind();
        }

        private MDPayCycleEntity BuildMDPayCycleEntity()
        {
            MDPayCycleEntity mDPayCycleEntity = CurrentMDPayCycleEntity;

            mDPayCycleEntity.Name = txtName.Text.Trim();
            mDPayCycleEntity.IsRemoved = chkIsRemoved.Checked;


            return mDPayCycleEntity;
        }

        private void SaveMDPayCycleEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDPayCycleEntity mDPayCycleEntity = BuildMDPayCycleEntity();

                    Int64 result = -1;

                    if (mDPayCycleEntity.IsNew)
                    {
                        result = FCCMDPayCycle.GetFacadeCreate().Add(mDPayCycleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDPayCycleEntity.FLD_NAME_PayCycleID, mDPayCycleEntity.PayCycleID.ToString(), SQLMatchType.Equal);
                        result = FCCMDPayCycle.GetFacadeCreate().Update(mDPayCycleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PayCycleID = 0;
                        _MDPayCycleEntity = new MDPayCycleEntity();
                        PrepareInitialView();
                        BindMDPayCycleList();

                        if (mDPayCycleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pay Cycle Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pay Cycle Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDPayCycleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Pay Cycle Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Pay Cycle Information.", false);
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

        protected void lvMDPayCycle_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PayCycleID;

            Int64.TryParse(e.CommandArgument.ToString(), out PayCycleID);

            if (PayCycleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PayCycleID = PayCycleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDPayCycleEntity.FLD_NAME_PayCycleID, PayCycleID.ToString(), SQLMatchType.Equal);

                        MDPayCycleEntity mDPayCycleEntity = new MDPayCycleEntity();


                        result = FCCMDPayCycle.GetFacadeCreate().Delete(mDPayCycleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PayCycleID = 0;
                            _MDPayCycleEntity = new MDPayCycleEntity();
                            PrepareInitialView();
                            BindMDPayCycleList();

                            MiscUtil.ShowMessage(lblMessage, "Pay Cycle has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Pay Cycle.", true);
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

        protected void odsMDPayCycle_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDPayCycleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PayCycleID = 0;
            _MDPayCycleEntity = new MDPayCycleEntity();
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
