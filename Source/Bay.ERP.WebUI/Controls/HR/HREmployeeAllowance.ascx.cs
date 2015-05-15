// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 12:08:49




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
    public partial class HREmployeeAllowanceControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeAllowanceID
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

        public HREmployeeAllowanceEntity _HREmployeeAllowanceEntity
        {
            get
            {
                HREmployeeAllowanceEntity entity = new HREmployeeAllowanceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeAllowanceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeAllowanceEntity CurrentHREmployeeAllowanceEntity
        {
            get
            {
                if (_EmployeeAllowanceID > 0)
                {
                    if (_HREmployeeAllowanceEntity.EmployeeAllowanceID != _EmployeeAllowanceID)
                    {
                        _HREmployeeAllowanceEntity = FCCHREmployeeAllowance.GetFacadeCreate().GetByID(_EmployeeAllowanceID);
                    }
                }

                return _HREmployeeAllowanceEntity;
            }
            set
            {
                _HREmployeeAllowanceEntity = value;
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
            HREmployeeAllowanceEntity hREmployeeAllowanceEntity = CurrentHREmployeeAllowanceEntity;


            if (!hREmployeeAllowanceEntity.IsNew)
            {  
             
            }
        }

        private void BindList()
        {
            BindHREmployeeAllowanceList();
        }

        private void BindHREmployeeAllowanceList()
        {
            lvHREmployeeAllowance.DataBind();
        }

        private HREmployeeAllowanceEntity BuildHREmployeeAllowanceEntity()
        {
            HREmployeeAllowanceEntity hREmployeeAllowanceEntity = CurrentHREmployeeAllowanceEntity;

          

            return hREmployeeAllowanceEntity;
        }

        private void SaveHREmployeeAllowanceEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeAllowanceEntity hREmployeeAllowanceEntity = BuildHREmployeeAllowanceEntity();

                    Int64 result = -1;

                    if (hREmployeeAllowanceEntity.IsNew)
                    {
                        result = FCCHREmployeeAllowance.GetFacadeCreate().Add(hREmployeeAllowanceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAllowanceEntity.FLD_NAME_EmployeeAllowanceID, hREmployeeAllowanceEntity.EmployeeAllowanceID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeAllowance.GetFacadeCreate().Update(hREmployeeAllowanceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeAllowanceID = 0;
                        _HREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();
                        PrepareInitialView();
                        BindHREmployeeAllowanceList();

                        if (hREmployeeAllowanceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Allowance Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Allowance Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeAllowanceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Allowance Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Allowance Information.", false);
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

        protected void lvHREmployeeAllowance_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeAllowanceID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeAllowanceID);

            if (EmployeeAllowanceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeAllowanceID = EmployeeAllowanceID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAllowanceEntity.FLD_NAME_EmployeeAllowanceID, EmployeeAllowanceID.ToString(), SQLMatchType.Equal);

                        HREmployeeAllowanceEntity hREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();


                        result = FCCHREmployeeAllowance.GetFacadeCreate().Delete(hREmployeeAllowanceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeAllowanceID = 0;
                            _HREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();
                            PrepareInitialView();
                            BindHREmployeeAllowanceList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Allowance has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Allowance.", true);
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

        protected void odsHREmployeeAllowance_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAllowanceEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
