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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeSalaryDeducationInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryDeducationInfoID
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

        public HREmployeeSalaryDeducationInfoEntity _HREmployeeSalaryDeducationInfoEntity
        {
            get
            {
                HREmployeeSalaryDeducationInfoEntity entity = new HREmployeeSalaryDeducationInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryDeducationInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryDeducationInfoEntity CurrentHREmployeeSalaryDeducationInfoEntity
        {
            get
            {
                if (_EmployeeSalaryDeducationInfoID > 0)
                {
                    if (_HREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID != _EmployeeSalaryDeducationInfoID)
                    {
                        _HREmployeeSalaryDeducationInfoEntity = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetByID(_EmployeeSalaryDeducationInfoID);
                    }
                }

                return _HREmployeeSalaryDeducationInfoEntity;
            }
            set
            {
                _HREmployeeSalaryDeducationInfoEntity = value;
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
        }

        private void PrepareEditView()
        {
            HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = CurrentHREmployeeSalaryDeducationInfoEntity;


            if (!hREmployeeSalaryDeducationInfoEntity.IsNew)
            {
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryDeducationInfoList();
        }

        private void BindHREmployeeSalaryDeducationInfoList()
        {
            lvHREmployeeSalaryDeducationInfo.DataBind();
        }

        private HREmployeeSalaryDeducationInfoEntity BuildHREmployeeSalaryDeducationInfoEntity()
        {
            HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = CurrentHREmployeeSalaryDeducationInfoEntity;


            return hREmployeeSalaryDeducationInfoEntity;
        }

        private void SaveHREmployeeSalaryDeducationInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = BuildHREmployeeSalaryDeducationInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeSalaryDeducationInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Add(hREmployeeSalaryDeducationInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID, hREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Update(hREmployeeSalaryDeducationInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryDeducationInfoID = 0;
                        _HREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeSalaryDeducationInfoList();

                        if (hREmployeeSalaryDeducationInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Deducation Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Deducation Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalaryDeducationInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Deducation Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Deducation Info Information.", false);
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

        protected void lvHREmployeeSalaryDeducationInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryDeducationInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryDeducationInfoID);

            if (EmployeeSalaryDeducationInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryDeducationInfoID = EmployeeSalaryDeducationInfoID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID, EmployeeSalaryDeducationInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();


                        result = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Delete(hREmployeeSalaryDeducationInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryDeducationInfoID = 0;
                            _HREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryDeducationInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Deducation Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Deducation Info.", true);
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

        protected void odsHREmployeeSalaryDeducationInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
