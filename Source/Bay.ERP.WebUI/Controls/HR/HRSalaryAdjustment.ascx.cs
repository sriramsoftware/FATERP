// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HRSalaryAdjustmentControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _SalaryAdjustmentID
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

        public HRSalaryAdjustmentEntity _HRSalaryAdjustmentEntity
        {
            get
            {
                HRSalaryAdjustmentEntity entity = new HRSalaryAdjustmentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRSalaryAdjustmentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRSalaryAdjustmentEntity CurrentHRSalaryAdjustmentEntity
        {
            get
            {
                if (_SalaryAdjustmentID > 0)
                {
                    if (_HRSalaryAdjustmentEntity.SalaryAdjustmentID != _SalaryAdjustmentID)
                    {
                        _HRSalaryAdjustmentEntity = FCCHRSalaryAdjustment.GetFacadeCreate().GetByID(_SalaryAdjustmentID);
                    }
                }

                return _HRSalaryAdjustmentEntity;
            }
            set
            {
                _HRSalaryAdjustmentEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {

        }

        private HREmployee_DetailedEntity GetHREmployeeInfo(Int64 employeeID)
        {
            IList<HREmployee_DetailedEntity> list = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, String.Empty);

            HREmployee_DetailedEntity ent = list.Single(x => x.EmployeeID == employeeID);


            return ent;
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void BuildEmployeeInformation(Int64 employeeID)
        {
            //HREmployee_DetailedEntity ent = GetHREmployeeInfo(employeeID);
            //txtEmployeeCode.Text = ent.EmployeeCode.ToString();
            //txtSalaryLevel.Text = ent.SalaryLevel.ToString();
            //txtEmployeeJobTypeID.Text = ent.EmployeeJobTypeID.ToString();
            //MiscUtil.PopulateMDDesignationByEmployeeID(ddlDesignationID, false, employeeID);
        }

        private void PrepareEditView()
        {
            HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = CurrentHRSalaryAdjustmentEntity;


            if (!hRSalaryAdjustmentEntity.IsNew)
            {
            }
        }

        private void BindList()
        {
            BindHRSalaryAdjustmentList();
        }

        private void BindHRSalaryAdjustmentList()
        {
            lvHRSalaryAdjustment.DataBind();
        }

        private HRSalaryAdjustmentEntity BuildHRSalaryAdjustmentEntity()
        {
            HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = CurrentHRSalaryAdjustmentEntity;

            //if (!txtSalaryAdjustmentID.Text.Trim().IsNullOrEmpty())
            //{
            //    hRSalaryAdjustmentEntity.SalaryAdjustmentID = Int64.Parse(txtSalaryAdjustmentID.Text.Trim());
            //}

            return hRSalaryAdjustmentEntity;
        }

        private void SaveHRSalaryAdjustmentEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = BuildHRSalaryAdjustmentEntity();

                    Int64 result = -1;

                    if (hRSalaryAdjustmentEntity.IsNew)
                    {
                        result = FCCHRSalaryAdjustment.GetFacadeCreate().Add(hRSalaryAdjustmentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalaryAdjustmentID, hRSalaryAdjustmentEntity.SalaryAdjustmentID.ToString(), SQLMatchType.Equal);
                        result = FCCHRSalaryAdjustment.GetFacadeCreate().Update(hRSalaryAdjustmentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalaryAdjustmentID = 0;
                        _HRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();
                        PrepareInitialView();
                        BindHRSalaryAdjustmentList();

                        //if (hRSalaryAdjustmentEntity.IsNew)
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Salary Adjustment Information has been added successfully.", false);
                        //}
                        //else
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Salary Adjustment Information has been updated successfully.", false);
                        //}
                    }
                    else
                    {
                        //if (hRSalaryAdjustmentEntity.IsNew)
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Adjustment Information.", false);
                        //}
                        //else
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Adjustment Information.", false);
                        //}
                    }
                }
                catch (Exception ex)
                {
                    //MiscUtil.ShowMessage(lblMessage, ex.Message, true);
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

        protected void lvHRSalaryAdjustment_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalaryAdjustmentID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalaryAdjustmentID);

            if (SalaryAdjustmentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalaryAdjustmentID = SalaryAdjustmentID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalaryAdjustmentID, SalaryAdjustmentID.ToString(), SQLMatchType.Equal);

                        HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();


                        result = FCCHRSalaryAdjustment.GetFacadeCreate().Delete(hRSalaryAdjustmentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalaryAdjustmentID = 0;
                            _HRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();
                            PrepareInitialView();
                            BindHRSalaryAdjustmentList();

                            //MiscUtil.ShowMessage(lblMessage, "Salary Adjustment has been successfully deleted.", true);
                        }
                        else
                        {
                            //MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Adjustment.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHRSalaryAdjustment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
