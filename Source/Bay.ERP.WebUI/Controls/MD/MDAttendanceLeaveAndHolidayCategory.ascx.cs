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
    public partial class MDAttendanceLeaveAndHolidayCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _AttendanceLeaveAndHolidayCategoryID
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

        public MDAttendanceLeaveAndHolidayCategoryEntity _MDAttendanceLeaveAndHolidayCategoryEntity
        {
            get
            {
                MDAttendanceLeaveAndHolidayCategoryEntity entity = new MDAttendanceLeaveAndHolidayCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAttendanceLeaveAndHolidayCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAttendanceLeaveAndHolidayCategoryEntity CurrentMDAttendanceLeaveAndHolidayCategoryEntity
        {
            get
            {
                if (_AttendanceLeaveAndHolidayCategoryID > 0)
                {
                    if (_MDAttendanceLeaveAndHolidayCategoryEntity.AttendanceLeaveAndHolidayCategoryID != _AttendanceLeaveAndHolidayCategoryID)
                    {
                        _MDAttendanceLeaveAndHolidayCategoryEntity = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetByID(_AttendanceLeaveAndHolidayCategoryID);
                    }
                }

                return _MDAttendanceLeaveAndHolidayCategoryEntity;
            }
            set
            {
                _MDAttendanceLeaveAndHolidayCategoryEntity = value;
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
            MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity = CurrentMDAttendanceLeaveAndHolidayCategoryEntity;


            if (!mDAttendanceLeaveAndHolidayCategoryEntity.IsNew)
            {
                txtName.Text = mDAttendanceLeaveAndHolidayCategoryEntity.Name.ToString();
                txtDescription.Text = mDAttendanceLeaveAndHolidayCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDAttendanceLeaveAndHolidayCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAttendanceLeaveAndHolidayCategoryList();
        }

        private void BindMDAttendanceLeaveAndHolidayCategoryList()
        {
            lvMDAttendanceLeaveAndHolidayCategory.DataBind();
        }

        private MDAttendanceLeaveAndHolidayCategoryEntity BuildMDAttendanceLeaveAndHolidayCategoryEntity()
        {
            MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity = CurrentMDAttendanceLeaveAndHolidayCategoryEntity;

            mDAttendanceLeaveAndHolidayCategoryEntity.Name = txtName.Text.Trim();
            mDAttendanceLeaveAndHolidayCategoryEntity.Description = txtDescription.Text.Trim();
            mDAttendanceLeaveAndHolidayCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDAttendanceLeaveAndHolidayCategoryEntity;
        }

        private void SaveMDAttendanceLeaveAndHolidayCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity = BuildMDAttendanceLeaveAndHolidayCategoryEntity();

                    Int64 result = -1;

                    if (mDAttendanceLeaveAndHolidayCategoryEntity.IsNew)
                    {
                        result = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().Add(mDAttendanceLeaveAndHolidayCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAttendanceLeaveAndHolidayCategoryEntity.FLD_NAME_AttendanceLeaveAndHolidayCategoryID, mDAttendanceLeaveAndHolidayCategoryEntity.AttendanceLeaveAndHolidayCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().Update(mDAttendanceLeaveAndHolidayCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AttendanceLeaveAndHolidayCategoryID = 0;
                        _MDAttendanceLeaveAndHolidayCategoryEntity = new MDAttendanceLeaveAndHolidayCategoryEntity();
                        PrepareInitialView();
                        BindMDAttendanceLeaveAndHolidayCategoryList();

                        if (mDAttendanceLeaveAndHolidayCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Attendance Leave And Holiday Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Attendance Leave And Holiday Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAttendanceLeaveAndHolidayCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Attendance Leave And Holiday Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Attendance Leave And Holiday Category Information.", false);
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

        protected void lvMDAttendanceLeaveAndHolidayCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AttendanceLeaveAndHolidayCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out AttendanceLeaveAndHolidayCategoryID);

            if (AttendanceLeaveAndHolidayCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AttendanceLeaveAndHolidayCategoryID = AttendanceLeaveAndHolidayCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAttendanceLeaveAndHolidayCategoryEntity.FLD_NAME_AttendanceLeaveAndHolidayCategoryID, AttendanceLeaveAndHolidayCategoryID.ToString(), SQLMatchType.Equal);

                        MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity = new MDAttendanceLeaveAndHolidayCategoryEntity();


                        result = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().Delete(mDAttendanceLeaveAndHolidayCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AttendanceLeaveAndHolidayCategoryID = 0;
                            _MDAttendanceLeaveAndHolidayCategoryEntity = new MDAttendanceLeaveAndHolidayCategoryEntity();
                            PrepareInitialView();
                            BindMDAttendanceLeaveAndHolidayCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Attendance Leave And Holiday Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Attendance Leave And Holiday Category.", true);
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

        protected void odsMDAttendanceLeaveAndHolidayCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAttendanceLeaveAndHolidayCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AttendanceLeaveAndHolidayCategoryID = 0;
            _MDAttendanceLeaveAndHolidayCategoryEntity = new MDAttendanceLeaveAndHolidayCategoryEntity();
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
