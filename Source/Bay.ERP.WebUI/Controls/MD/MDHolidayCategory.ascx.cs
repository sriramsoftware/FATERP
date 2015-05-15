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
    public partial class MDHolidayCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _HolidayCategoryID
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

        public MDHolidayCategoryEntity _MDHolidayCategoryEntity
        {
            get
            {
                MDHolidayCategoryEntity entity = new MDHolidayCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDHolidayCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDHolidayCategoryEntity CurrentMDHolidayCategoryEntity
        {
            get
            {
                if (_HolidayCategoryID > 0)
                {
                    if (_MDHolidayCategoryEntity.HolidayCategoryID != _HolidayCategoryID)
                    {
                        _MDHolidayCategoryEntity = FCCMDHolidayCategory.GetFacadeCreate().GetByID(_HolidayCategoryID);
                    }
                }

                return _MDHolidayCategoryEntity;
            }
            set
            {
                _MDHolidayCategoryEntity = value;
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
            txtColorName.Text = String.Empty;
            txtColorCode.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDHolidayCategoryEntity mDHolidayCategoryEntity = CurrentMDHolidayCategoryEntity;


            if (!mDHolidayCategoryEntity.IsNew)
            {
                txtName.Text = mDHolidayCategoryEntity.Name.ToString();
                txtDescription.Text = mDHolidayCategoryEntity.Description.ToString();
                txtColorName.Text = mDHolidayCategoryEntity.ColorName.ToString();
                txtColorCode.Text = mDHolidayCategoryEntity.ColorCode.ToString();
                txtRemarks.Text = mDHolidayCategoryEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDHolidayCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDHolidayCategoryList();
        }

        private void BindMDHolidayCategoryList()
        {
            lvMDHolidayCategory.DataBind();
        }

        private MDHolidayCategoryEntity BuildMDHolidayCategoryEntity()
        {
            MDHolidayCategoryEntity mDHolidayCategoryEntity = CurrentMDHolidayCategoryEntity;

            mDHolidayCategoryEntity.Name = txtName.Text.Trim();
            mDHolidayCategoryEntity.Description = txtDescription.Text.Trim();
            mDHolidayCategoryEntity.ColorName = txtColorName.Text.Trim();
            mDHolidayCategoryEntity.ColorCode = txtColorCode.Text.Trim();
            mDHolidayCategoryEntity.Remarks = txtRemarks.Text.Trim();
            mDHolidayCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDHolidayCategoryEntity;
        }

        private void SaveMDHolidayCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDHolidayCategoryEntity mDHolidayCategoryEntity = BuildMDHolidayCategoryEntity();

                    Int64 result = -1;

                    if (mDHolidayCategoryEntity.IsNew)
                    {
                        result = FCCMDHolidayCategory.GetFacadeCreate().Add(mDHolidayCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDHolidayCategoryEntity.FLD_NAME_HolidayCategoryID, mDHolidayCategoryEntity.HolidayCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDHolidayCategory.GetFacadeCreate().Update(mDHolidayCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _HolidayCategoryID = 0;
                        _MDHolidayCategoryEntity = new MDHolidayCategoryEntity();
                        PrepareInitialView();
                        BindMDHolidayCategoryList();

                        if (mDHolidayCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Holiday Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Holiday Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDHolidayCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Holiday Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Holiday Category Information.", false);
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

        protected void lvMDHolidayCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 HolidayCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out HolidayCategoryID);

            if (HolidayCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _HolidayCategoryID = HolidayCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDHolidayCategoryEntity.FLD_NAME_HolidayCategoryID, HolidayCategoryID.ToString(), SQLMatchType.Equal);

                        MDHolidayCategoryEntity mDHolidayCategoryEntity = new MDHolidayCategoryEntity();


                        result = FCCMDHolidayCategory.GetFacadeCreate().Delete(mDHolidayCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _HolidayCategoryID = 0;
                            _MDHolidayCategoryEntity = new MDHolidayCategoryEntity();
                            PrepareInitialView();
                            BindMDHolidayCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Holiday Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Holiday Category.", true);
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

        protected void odsMDHolidayCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDHolidayCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _HolidayCategoryID = 0;
            _MDHolidayCategoryEntity = new MDHolidayCategoryEntity();
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
