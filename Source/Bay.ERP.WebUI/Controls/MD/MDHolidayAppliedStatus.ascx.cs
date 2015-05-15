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
    public partial class MDHolidayAppliedStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _HolidayAppliedStatusID
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

        public MDHolidayAppliedStatusEntity _MDHolidayAppliedStatusEntity
        {
            get
            {
                MDHolidayAppliedStatusEntity entity = new MDHolidayAppliedStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDHolidayAppliedStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDHolidayAppliedStatusEntity CurrentMDHolidayAppliedStatusEntity
        {
            get
            {
                if (_HolidayAppliedStatusID > 0)
                {
                    if (_MDHolidayAppliedStatusEntity.HolidayAppliedStatusID != _HolidayAppliedStatusID)
                    {
                        _MDHolidayAppliedStatusEntity = FCCMDHolidayAppliedStatus.GetFacadeCreate().GetByID(_HolidayAppliedStatusID);
                    }
                }

                return _MDHolidayAppliedStatusEntity;
            }
            set
            {
                _MDHolidayAppliedStatusEntity = value;
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
            MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity = CurrentMDHolidayAppliedStatusEntity;


            if (!mDHolidayAppliedStatusEntity.IsNew)
            {
                txtName.Text = mDHolidayAppliedStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDHolidayAppliedStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDHolidayAppliedStatusList();
        }

        private void BindMDHolidayAppliedStatusList()
        {
            lvMDHolidayAppliedStatus.DataBind();
        }

        private MDHolidayAppliedStatusEntity BuildMDHolidayAppliedStatusEntity()
        {
            MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity = CurrentMDHolidayAppliedStatusEntity;

            mDHolidayAppliedStatusEntity.Name = txtName.Text.Trim();
            mDHolidayAppliedStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDHolidayAppliedStatusEntity;
        }

        private void SaveMDHolidayAppliedStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity = BuildMDHolidayAppliedStatusEntity();

                    Int64 result = -1;

                    if (mDHolidayAppliedStatusEntity.IsNew)
                    {
                        result = FCCMDHolidayAppliedStatus.GetFacadeCreate().Add(mDHolidayAppliedStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDHolidayAppliedStatusEntity.FLD_NAME_HolidayAppliedStatusID, mDHolidayAppliedStatusEntity.HolidayAppliedStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDHolidayAppliedStatus.GetFacadeCreate().Update(mDHolidayAppliedStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _HolidayAppliedStatusID = 0;
                        _MDHolidayAppliedStatusEntity = new MDHolidayAppliedStatusEntity();
                        PrepareInitialView();
                        BindMDHolidayAppliedStatusList();

                        if (mDHolidayAppliedStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Holiday Applied Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Holiday Applied Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDHolidayAppliedStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Holiday Applied Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Holiday Applied Status Information.", false);
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

        protected void lvMDHolidayAppliedStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 HolidayAppliedStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out HolidayAppliedStatusID);

            if (HolidayAppliedStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _HolidayAppliedStatusID = HolidayAppliedStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDHolidayAppliedStatusEntity.FLD_NAME_HolidayAppliedStatusID, HolidayAppliedStatusID.ToString(), SQLMatchType.Equal);

                        MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity = new MDHolidayAppliedStatusEntity();


                        result = FCCMDHolidayAppliedStatus.GetFacadeCreate().Delete(mDHolidayAppliedStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _HolidayAppliedStatusID = 0;
                            _MDHolidayAppliedStatusEntity = new MDHolidayAppliedStatusEntity();
                            PrepareInitialView();
                            BindMDHolidayAppliedStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Holiday Applied Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Holiday Applied Status.", true);
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

        protected void odsMDHolidayAppliedStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDHolidayAppliedStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _HolidayAppliedStatusID = 0;
            _MDHolidayAppliedStatusEntity = new MDHolidayAppliedStatusEntity();
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
