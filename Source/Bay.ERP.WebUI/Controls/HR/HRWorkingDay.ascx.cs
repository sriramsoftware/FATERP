// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 03:14:39




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Linq;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace Bay.ERP.Web.UI
{
    public partial class HRWorkingDayControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkingDayID
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

        public HRWorkingDayEntity _HRWorkingDayEntity
        {
            get
            {
                HRWorkingDayEntity entity = new HRWorkingDayEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRWorkingDayEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRWorkingDayEntity CurrentHRWorkingDayEntity
        {
            get
            {
                if (_WorkingDayID > 0)
                {
                    if (_HRWorkingDayEntity.WorkingDayID != _WorkingDayID)
                    {
                        _HRWorkingDayEntity = FCCHRWorkingDay.GetFacadeCreate().GetByID(_WorkingDayID);
                    }
                }

                return _HRWorkingDayEntity;
            }
            set
            {
                _HRWorkingDayEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateMDSalarySession(ddlSalarySessionID, false);
        }

        private void PrepareValidator()
        {
        }

        private void BuildAttendanceLeaveAndHolidayCategoryDropDownList()
        {
            IList<ListViewDataItem> list = lvHRWorkingDay.Items;

            if (list != null && list.Count > 0)
            {
                foreach (ListViewDataItem lvdi in list)
                {
                    HRWorkingDayEntity hRWorkingDayEntity = new HRWorkingDayEntity();
                    DropDownList ddlAttendanceLeaveAndHolidayCategoryID = (DropDownList)lvdi.FindControl("ddlAttendanceLeaveAndHolidayCategoryID");
                    Label lblAttendanceLeaveAndHolidayCategoryIDLV = (Label)lvdi.FindControl("lblAttendanceLeaveAndHolidayCategoryIDLV");
                    TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                    Label lblWorkingDayLV = (Label)lvdi.FindControl("lblWorkingDayLV");
                    //HtmlTableCell abc = (HtmlTableCell)lvdi.FindControl("_itemrow");
                    HtmlTableRow abc = (HtmlTableRow)lvdi.FindControl("_itemrow") as HtmlTableRow;
                    
                    hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID = Int64.Parse(lblAttendanceLeaveAndHolidayCategoryIDLV.Text);
                    if (hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID == 3)
                    {
                        abc.BgColor = "Red";
                    }
                    else if (hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID == 1)
                    {
                        abc.BgColor = "Green";
                    }
                    MiscUtil.PopulateMDAttendanceLeaveAndHolidayCategory(ddlAttendanceLeaveAndHolidayCategoryID, false, hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID);
                }
            }
        }

        private void GenerateWorkingDays()
        {
            if (ddlSalarySessionID!=null && ddlSalarySessionID.Items.Count>0)
            {
                MDSalarySessionEntity mDSalarySessionEntity = FCCMDSalarySession.GetFacadeCreate().GetByID(Int64.Parse(ddlSalarySessionID.SelectedValue));

                if (mDSalarySessionEntity != null && mDSalarySessionEntity.SalarySessionID > 0)
                {
                    TimeSpan dt = mDSalarySessionEntity.SessionEndDate - mDSalarySessionEntity.SessionStartDate;
                    Double totalDays = dt.TotalDays + 1;
                    Double holiDay = 0.0;
                    Double workDay = 0.0;

                    IList<HRWorkingDayEntity> lst = new List<HRWorkingDayEntity>();  

                    for (Int32 i = 0; i < totalDays; i++)
                    {
                        HRWorkingDayEntity ent = new HRWorkingDayEntity();

                        ent.Date = mDSalarySessionEntity.SessionStartDate.AddDays(i);
                        ent.FiscalYearID=mDSalarySessionEntity.FiscalYearID;
                        ent.SalarySessionID=mDSalarySessionEntity.SalarySessionID;
                        ent.WorkingDay =mDSalarySessionEntity.SessionStartDate.AddDays(i);

                        switch(ent.Date.DayOfWeek)
                        {
                                //Default Weekend
                            case DayOfWeek.Friday:
                                ent.AttendanceLeaveAndHolidayCategoryID = MasterDataConstants.MDAttendanceLeaveAndHolidayCategory.HOLIDAY;
                                holiDay++;
                                break;

                                //Others Holiday will come here.
                            default:
                                ent.AttendanceLeaveAndHolidayCategoryID = MasterDataConstants.MDAttendanceLeaveAndHolidayCategory.WORK_DAY;
                                workDay++;
                                break;

                        }
                        
                        ent.Note = String.Empty;
                        ent.Year =ent.Date.Year;
                        ent.Month = ent.Date.Month;
                        ent.Day = ent.Date.Day;
                        ent.IsRemoved = false;
                        
                        lst.Add(ent);
                    }

                    btnReGenerate.Enabled = false;

                    #region HasList
                    
                     String fe = "FiscalYearID = " + Int64.Parse(ddlFiscalYearID.SelectedValue) + " and SalarySessionID=" + Int64.Parse(ddlSalarySessionID.SelectedValue)+"";
                    IList<HRWorkingDayEntity> hRWorkingDayList = FCCHRWorkingDay.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    if (hRWorkingDayList != null && hRWorkingDayList.Count > 0)
                    {
                        lst = hRWorkingDayList;
                        holiDay = 0.0;
                        workDay = 0.0;
                        foreach (HRWorkingDayEntity entity in hRWorkingDayList)
                        {
                            if (entity.AttendanceLeaveAndHolidayCategoryID == MasterDataConstants.MDAttendanceLeaveAndHolidayCategory.HOLIDAY)
                            {
                                holiDay++;
                            }
                            else if (entity.AttendanceLeaveAndHolidayCategoryID == MasterDataConstants.MDAttendanceLeaveAndHolidayCategory.WORK_DAY)
                            {
                                workDay++;
                            }
                        }

                        btnSubmit.Text = "Update";
                        btnReGenerate.Enabled = true;
                    }

                    #endregion
                    lblTotalDay.Text = totalDays.ToString().Trim();
                    lblHoliday.Text = holiDay.ToString().Trim();
                    lblWorkingDay.Text = workDay.ToString().Trim();
                    

                    lvHRWorkingDay.DataSource=lst;
                    lvHRWorkingDay.DataBind();
                    BuildAttendanceLeaveAndHolidayCategoryDropDownList();
                }
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            btnReGenerate.Enabled = false; 

            btnSubmit.Text = "Save";
        }

        private void PrepareEditView()
        {
            HRWorkingDayEntity hRWorkingDayEntity = CurrentHRWorkingDayEntity;


            if (!hRWorkingDayEntity.IsNew)
            {
                if (ddlFiscalYearID.Items.Count > 0 && hRWorkingDayEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = hRWorkingDayEntity.FiscalYearID.ToString();
                }

                if (ddlSalarySessionID.Items.Count > 0 && hRWorkingDayEntity.SalarySessionID != null)
                {
                    ddlSalarySessionID.SelectedValue = hRWorkingDayEntity.SalarySessionID.ToString();
                }

                btnSubmit.Text = "Save";
            }
        }

        private void BindList()
        {
            BindHRWorkingDayList();
        }

        private void BindHRWorkingDayList()
        {
            lvHRWorkingDay.DataBind();
        }

        private void ReGenerateWorkingDays()
        {
            if (ddlSalarySessionID != null && ddlSalarySessionID.Items.Count > 0)
            {
                MDSalarySessionEntity mDSalarySessionEntity = FCCMDSalarySession.GetFacadeCreate().GetByID(Int64.Parse(ddlSalarySessionID.SelectedValue));

                if (mDSalarySessionEntity != null && mDSalarySessionEntity.SalarySessionID > 0)
                {
                    TimeSpan dt = mDSalarySessionEntity.SessionEndDate - mDSalarySessionEntity.SessionStartDate;
                    Double totalDays = dt.TotalDays+1;
                    Double holiDay = 0.0;
                    Double workDay = 0.0;

                    IList<HRWorkingDayEntity> lst = new List<HRWorkingDayEntity>();

                    for (Int32 i = 0; i < totalDays; i++)
                    {
                        HRWorkingDayEntity ent = new HRWorkingDayEntity();

                        ent.Date = mDSalarySessionEntity.SessionStartDate.AddDays(i);
                        ent.FiscalYearID = mDSalarySessionEntity.FiscalYearID;
                        ent.SalarySessionID = mDSalarySessionEntity.SalarySessionID;
                        ent.WorkingDay = mDSalarySessionEntity.SessionStartDate.AddDays(i);

                        switch (ent.Date.DayOfWeek)
                        {
                            //Default Weekend
                            case DayOfWeek.Friday:
                                ent.AttendanceLeaveAndHolidayCategoryID = MasterDataConstants.MDAttendanceLeaveAndHolidayCategory.HOLIDAY;
                                holiDay++;
                                break;

                            //Others Holiday will come here.
                            default:
                                ent.AttendanceLeaveAndHolidayCategoryID = MasterDataConstants.MDAttendanceLeaveAndHolidayCategory.WORK_DAY;
                                workDay++;
                                break;

                        }

                        ent.Note = String.Empty;
                        ent.Year = ent.Date.Year;
                        ent.Month = ent.Date.Month;
                        ent.Day = ent.Date.Day;
                        ent.IsRemoved = false;

                        lst.Add(ent);
                    }

                    lblTotalDay.Text = totalDays.ToString().Trim();
                    lblHoliday.Text = holiDay.ToString().Trim();
                    lblWorkingDay.Text = workDay.ToString().Trim();


                    lvHRWorkingDay.DataSource = lst;
                    lvHRWorkingDay.DataBind();
                    BuildAttendanceLeaveAndHolidayCategoryDropDownList();
                }
            }
        }

        private HRWorkingDayEntity BuildHRWorkingDayEntity()
        {
            HRWorkingDayEntity hRWorkingDayEntity = CurrentHRWorkingDayEntity;

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    hRWorkingDayEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlSalarySessionID.Items.Count > 0)
            {
                if (ddlSalarySessionID.SelectedValue == "0")
                {
                }
                else
                {
                    hRWorkingDayEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                }
            }

            return hRWorkingDayEntity;
        }

        private void UpdateBOQInfo()
        {
            try
            {
                IList<ListViewDataItem> list = lvHRWorkingDay.Items;

                if (list != null && list.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in list)
                    {
                        HRWorkingDayEntity hRWorkingDayEntity = new HRWorkingDayEntity();
                        Label lblFiscalYearIDLV = (Label)lvdi.FindControl("lblFiscalYearIDLV");
                        Label lblSalarySessionIDLV = (Label)lvdi.FindControl("lblSalarySessionIDLV");
                        Label lblYearLV = (Label)lvdi.FindControl("lblYearLV");
                        Label lblMonthLV = (Label)lvdi.FindControl("lblMonthLV");
                        Label lblDayLV = (Label)lvdi.FindControl("lblDayLV");
                        Label lblDateLV = (Label)lvdi.FindControl("lblDateLV");
                        Label lblNoteIDLV = (Label)lvdi.FindControl("lblNoteIDLV");
                        Label lblAttendanceLeaveAndHolidayCategoryIDLV = (Label)lvdi.FindControl("lblAttendanceLeaveAndHolidayCategoryIDLV");
                        Label lblWorkingDayLV = (Label)lvdi.FindControl("lblWorkingDayLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                        DropDownList ddlAttendanceLeaveAndHolidayCategoryID = (DropDownList)lvdi.FindControl("ddlAttendanceLeaveAndHolidayCategoryID");
                                

                        hRWorkingDayEntity.FiscalYearID = Int64.Parse(lblFiscalYearIDLV.Text);
                        hRWorkingDayEntity.SalarySessionID = Int64.Parse(lblSalarySessionIDLV.Text);
                        hRWorkingDayEntity.SalarySessionID = Int64.Parse(lblSalarySessionIDLV.Text);
                        hRWorkingDayEntity.Date = MiscUtil.ParseToDateTime(lblDateLV.Text);
                        hRWorkingDayEntity.WorkingDay = MiscUtil.ParseToDateTime(lblWorkingDayLV.Text);
                        //hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID = Int64.Parse(lblAttendanceLeaveAndHolidayCategoryIDLV.Text);
                        hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID = Int64.Parse(ddlAttendanceLeaveAndHolidayCategoryID.SelectedValue);
                        hRWorkingDayEntity.Note = String.Empty;
                        hRWorkingDayEntity.Year = Int32.Parse(lblYearLV.Text);
                        hRWorkingDayEntity.Month = Int32.Parse(lblMonthLV.Text);
                        hRWorkingDayEntity.Day = Int32.Parse(lblDayLV.Text);
                        hRWorkingDayEntity.Remarks = txtRemarksLV.Text;
                        hRWorkingDayEntity.IsRemoved = false;

                        #region Check for update 
                        Boolean isSaveFlag = true;

                        String fe = "FiscalYearID = " + hRWorkingDayEntity.FiscalYearID + " and SalarySessionID=" + hRWorkingDayEntity.SalarySessionID + " and WorkingDay='"+hRWorkingDayEntity.WorkingDay+"'";
                        IList<HRWorkingDayEntity> hRWorkingDayList = FCCHRWorkingDay.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        if (hRWorkingDayList != null && hRWorkingDayList.Count > 0)
                        {
                            isSaveFlag = false;
                        }

                        #endregion
                        if (isSaveFlag)
                        {
                            FCCHRWorkingDay.GetFacadeCreate().Add(hRWorkingDayEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRWorkingDayEntity.FLD_NAME_WorkingDayID, hRWorkingDayList[0].WorkingDayID.ToString(), SQLMatchType.Equal);
                            FCCHRWorkingDay.GetFacadeCreate().Update(hRWorkingDayEntity, filterExpression,DatabaseOperationType.Update, TransactionRequired.No);
                        }
                    }

                    MiscUtil.ShowMessage(lblMessage, "Working Day has been saved successfully.", false);
                    GenerateWorkingDays();
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Save Project Cost Information.", true);
            }
        }

        private void SaveHRWorkingDayEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRWorkingDayEntity hRWorkingDayEntity = BuildHRWorkingDayEntity();

                    Int64 result = -1;

                    if (hRWorkingDayEntity.IsNew)
                    {
                        result = FCCHRWorkingDay.GetFacadeCreate().Add(hRWorkingDayEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRWorkingDayEntity.FLD_NAME_WorkingDayID, hRWorkingDayEntity.WorkingDayID.ToString(), SQLMatchType.Equal);
                        result = FCCHRWorkingDay.GetFacadeCreate().Update(hRWorkingDayEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkingDayID = 0;
                        _HRWorkingDayEntity = new HRWorkingDayEntity();
                        PrepareInitialView();
                        BindHRWorkingDayList();

                        if (hRWorkingDayEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Working Day Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Working Day Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRWorkingDayEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Working Day Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Working Day Information.", false);
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

        protected void lvHRWorkingDay_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkingDayID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkingDayID);

            if (WorkingDayID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkingDayID = WorkingDayID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRWorkingDayEntity.FLD_NAME_WorkingDayID, WorkingDayID.ToString(), SQLMatchType.Equal);

                        HRWorkingDayEntity hRWorkingDayEntity = new HRWorkingDayEntity();


                        result = FCCHRWorkingDay.GetFacadeCreate().Delete(hRWorkingDayEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkingDayID = 0;
                            _HRWorkingDayEntity = new HRWorkingDayEntity();
                            PrepareInitialView();
                            BindHRWorkingDayList();

                            MiscUtil.ShowMessage(lblMessage, "Working Day has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Working Day.", true);
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

        protected void odsHRWorkingDay_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnGet_Click(object sender, EventArgs e)
        {
            GenerateWorkingDays();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            UpdateBOQInfo();
        }

        protected void btnbtnReGenerate_Click(object sender, EventArgs e)
        {
            ReGenerateWorkingDays();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkingDayID = 0;
            _HRWorkingDayEntity = new HRWorkingDayEntity();
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
