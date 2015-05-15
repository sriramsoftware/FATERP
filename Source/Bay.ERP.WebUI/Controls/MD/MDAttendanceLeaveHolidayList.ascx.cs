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
    public partial class MDAttendanceLeaveHolidayListControl : BaseControl
    {       
        #region Properties

        public Int64 _AttendanceLeaveHolidayListID
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

        public MDAttendanceLeaveHolidayListEntity _MDAttendanceLeaveHolidayListEntity
        {
            get
            {
                MDAttendanceLeaveHolidayListEntity entity = new MDAttendanceLeaveHolidayListEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAttendanceLeaveHolidayListEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAttendanceLeaveHolidayListEntity CurrentMDAttendanceLeaveHolidayListEntity
        {
            get
            {
                if (_AttendanceLeaveHolidayListID > 0)
                {
                    if (_MDAttendanceLeaveHolidayListEntity.AttendanceLeaveHolidayListID != _AttendanceLeaveHolidayListID)
                    {
                        _MDAttendanceLeaveHolidayListEntity = FCCMDAttendanceLeaveHolidayList.GetFacadeCreate().GetByID(_AttendanceLeaveHolidayListID);
                    }
                }

                return _MDAttendanceLeaveHolidayListEntity;
            }
            set
            {
                _MDAttendanceLeaveHolidayListEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //MiscUtil.PopulateMDAttendanceLeaveAndHolidayCategory(ddlAttendanceLeaveAndHolidayCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCode.Text = String.Empty;
            txtColor.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity = CurrentMDAttendanceLeaveHolidayListEntity;


            if (!mDAttendanceLeaveHolidayListEntity.IsNew)
            {
                if (ddlAttendanceLeaveAndHolidayCategoryID.Items.Count > 0 && mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID != null)
                {
                    ddlAttendanceLeaveAndHolidayCategoryID.SelectedValue = mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID.ToString();
                }

                txtName.Text = mDAttendanceLeaveHolidayListEntity.Name.ToString();
                txtDescription.Text = mDAttendanceLeaveHolidayListEntity.Description.ToString();
                txtCode.Text = mDAttendanceLeaveHolidayListEntity.Code.ToString();
                txtColor.Text = mDAttendanceLeaveHolidayListEntity.Color.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAttendanceLeaveHolidayListList();
        }

        private void BindMDAttendanceLeaveHolidayListList()
        {
            lvMDAttendanceLeaveHolidayList.DataBind();
        }

        private MDAttendanceLeaveHolidayListEntity BuildMDAttendanceLeaveHolidayListEntity()
        {
            MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity = CurrentMDAttendanceLeaveHolidayListEntity;

            if (ddlAttendanceLeaveAndHolidayCategoryID.Items.Count > 0)
            {
                if (ddlAttendanceLeaveAndHolidayCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID = Int64.Parse(ddlAttendanceLeaveAndHolidayCategoryID.SelectedValue);
                }
            }

            mDAttendanceLeaveHolidayListEntity.Name = txtName.Text.Trim();
            mDAttendanceLeaveHolidayListEntity.Description = txtDescription.Text.Trim();
            mDAttendanceLeaveHolidayListEntity.Code = txtCode.Text.Trim();
            mDAttendanceLeaveHolidayListEntity.Color = txtColor.Text.Trim();

            return mDAttendanceLeaveHolidayListEntity;
        }

        private void SaveMDAttendanceLeaveHolidayListEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity = BuildMDAttendanceLeaveHolidayListEntity();

                    Int64 result = -1;

                    if (mDAttendanceLeaveHolidayListEntity.IsNew)
                    {
                        result = FCCMDAttendanceLeaveHolidayList.GetFacadeCreate().Add(mDAttendanceLeaveHolidayListEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAttendanceLeaveHolidayListEntity.FLD_NAME_AttendanceLeaveHolidayListID, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveHolidayListID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAttendanceLeaveHolidayList.GetFacadeCreate().Update(mDAttendanceLeaveHolidayListEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AttendanceLeaveHolidayListID = 0;
                        _MDAttendanceLeaveHolidayListEntity = new MDAttendanceLeaveHolidayListEntity();
                        PrepareInitialView();
                        BindMDAttendanceLeaveHolidayListList();

                        if (mDAttendanceLeaveHolidayListEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Attendance Leave Holiday Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Attendance Leave Holiday Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAttendanceLeaveHolidayListEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Attendance Leave Holiday Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Attendance Leave Holiday Information.", false);
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

        protected void lvMDAttendanceLeaveHolidayList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AttendanceLeaveHolidayListID;

            Int64.TryParse(e.CommandArgument.ToString(), out AttendanceLeaveHolidayListID);

            if (AttendanceLeaveHolidayListID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AttendanceLeaveHolidayListID = AttendanceLeaveHolidayListID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAttendanceLeaveHolidayListEntity.FLD_NAME_AttendanceLeaveHolidayListID, AttendanceLeaveHolidayListID.ToString(), SQLMatchType.Equal);

                        MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity = new MDAttendanceLeaveHolidayListEntity();


                        result = FCCMDAttendanceLeaveHolidayList.GetFacadeCreate().Delete(mDAttendanceLeaveHolidayListEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AttendanceLeaveHolidayListID = 0;
                            _MDAttendanceLeaveHolidayListEntity = new MDAttendanceLeaveHolidayListEntity();
                            PrepareInitialView();
                            BindMDAttendanceLeaveHolidayListList();

                            MiscUtil.ShowMessage(lblMessage, "Attendance Leave Holiday has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Attendance Leave Holiday.", true);
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

        protected void odsMDAttendanceLeaveHolidayList_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAttendanceLeaveHolidayListEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AttendanceLeaveHolidayListID = 0;
            _MDAttendanceLeaveHolidayListEntity = new MDAttendanceLeaveHolidayListEntity();
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
