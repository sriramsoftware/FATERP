// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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

namespace Bay.ERP.Web.UI
{
    public partial class HRHolidayControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _HolidayID
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

        public HRHolidayEntity _HRHolidayEntity
        {
            get
            {
                HRHolidayEntity entity = new HRHolidayEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRHolidayEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRHolidayEntity CurrentHRHolidayEntity
        {
            get
            {
                if (_HolidayID > 0)
                {
                    if (_HRHolidayEntity.HolidayID != _HolidayID)
                    {
                        _HRHolidayEntity = FCCHRHoliday.GetFacadeCreate().GetByID(_HolidayID);
                    }
                }

                return _HRHolidayEntity;
            }
            set
            {
                _HRHolidayEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDHolidayCategory(ddlHolidayCategoryID, false);
            MiscUtil.PopulateMDHolidayAppliedStatus(ddlHolidayAppliedStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtHolidayDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRHolidayEntity hRHolidayEntity = CurrentHRHolidayEntity;


            if (!hRHolidayEntity.IsNew)
            {
                if (ddlHolidayCategoryID.Items.Count > 0 && hRHolidayEntity.HolidayCategoryID != null)
                {
                    ddlHolidayCategoryID.SelectedValue = hRHolidayEntity.HolidayCategoryID.ToString();
                }

                txtName.Text = hRHolidayEntity.Name.ToString();
                txtHolidayDate.Text = hRHolidayEntity.HolidayDate.ToStringDefault();
                txtRemarks.Text = hRHolidayEntity.Remarks.ToString();
                if (ddlHolidayAppliedStatusID.Items.Count > 0 && hRHolidayEntity.HolidayAppliedStatusID != null)
                {
                    ddlHolidayAppliedStatusID.SelectedValue = hRHolidayEntity.HolidayAppliedStatusID.ToString();
                }

                hRHolidayEntity.FiscalYearID = CurrentHRHolidayEntity.FiscalYearID;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRHolidayList();
        }

        private Int64 GetFiscalYear()
        {
            Int64 fiscalyearID = 0;
            IList<ACFiscalYearEntity> lst = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            ACFiscalYearEntity ent = lst.Where(x => x.IsClosed == false).Single();
            return fiscalyearID = ent.FiscalYearID;
        }

        private void BindHRHolidayList()
        {
            lvHRHoliday.DataBind();
        }

        private HRHolidayEntity BuildHRHolidayEntity()
        {
            HRHolidayEntity hRHolidayEntity = CurrentHRHolidayEntity;

            if (ddlHolidayCategoryID.Items.Count > 0)
            {
                if (ddlHolidayCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hRHolidayEntity.HolidayCategoryID = Int64.Parse(ddlHolidayCategoryID.SelectedValue);
                }
            }

            hRHolidayEntity.Name = txtName.Text.Trim();
            if (txtHolidayDate.Text.Trim().IsNotNullOrEmpty())
            {
                hRHolidayEntity.HolidayDate = MiscUtil.ParseToDateTime(txtHolidayDate.Text);
            }

            hRHolidayEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlHolidayAppliedStatusID.Items.Count > 0)
            {
                if (ddlHolidayAppliedStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    hRHolidayEntity.HolidayAppliedStatusID = Int64.Parse(ddlHolidayAppliedStatusID.SelectedValue);
                }
            }

            hRHolidayEntity.FiscalYearID = GetFiscalYear();

            return hRHolidayEntity;
        }

        private void SaveHRHolidayEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRHolidayEntity hRHolidayEntity = BuildHRHolidayEntity();

                    Int64 result = -1;

                    if (hRHolidayEntity.IsNew)
                    {
                        result = FCCHRHoliday.GetFacadeCreate().Add(hRHolidayEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRHolidayEntity.FLD_NAME_HolidayID, hRHolidayEntity.HolidayID.ToString(), SQLMatchType.Equal);
                        result = FCCHRHoliday.GetFacadeCreate().Update(hRHolidayEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _HolidayID = 0;
                        _HRHolidayEntity = new HRHolidayEntity();
                        PrepareInitialView();
                        BindHRHolidayList();

                        if (hRHolidayEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Holiday Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Holiday Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRHolidayEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Holiday Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Holiday Information.", false);
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

        protected void lvHRHoliday_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 HolidayID;

            Int64.TryParse(e.CommandArgument.ToString(), out HolidayID);

            if (HolidayID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _HolidayID = HolidayID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRHolidayEntity.FLD_NAME_HolidayID, HolidayID.ToString(), SQLMatchType.Equal);

                        HRHolidayEntity hRHolidayEntity = new HRHolidayEntity();


                        result = FCCHRHoliday.GetFacadeCreate().Delete(hRHolidayEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _HolidayID = 0;
                            _HRHolidayEntity = new HRHolidayEntity();
                            PrepareInitialView();
                            BindHRHolidayList();

                            MiscUtil.ShowMessage(lblMessage, "Holiday has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Holiday.", true);
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

        protected void odsHRHoliday_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRHolidayEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _HolidayID = 0;
            _HRHolidayEntity = new HRHolidayEntity();
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
