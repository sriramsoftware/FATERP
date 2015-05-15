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
    public partial class HREmployeeSalaryInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryInfoID
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

        public HREmployeeSalaryInfoEntity _HREmployeeSalaryInfoEntity
        {
            get
            {
                HREmployeeSalaryInfoEntity entity = new HREmployeeSalaryInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryInfoEntity CurrentHREmployeeSalaryInfoEntity
        {
            get
            {
                if (_EmployeeSalaryInfoID > 0)
                {
                    if (_HREmployeeSalaryInfoEntity.EmployeeSalaryInfoID != _EmployeeSalaryInfoID)
                    {
                        _HREmployeeSalaryInfoEntity = FCCHREmployeeSalaryInfo.GetFacadeCreate().GetByID(_EmployeeSalaryInfoID);
                    }
                }

                return _HREmployeeSalaryInfoEntity;
            }
            set
            {
                _HREmployeeSalaryInfoEntity = value;
            }
        }

        public Int64 OverViewEmployeeSalaryInfoID
        {
            get
            {
                Int64 OverViewEmployeeSalaryInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID], out OverViewEmployeeSalaryInfoID);
                }

                return OverViewEmployeeSalaryInfoID;
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
            HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity = CurrentHREmployeeSalaryInfoEntity;


            if (!hREmployeeSalaryInfoEntity.IsNew)
            {
                
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryInfoList();
        }

        private void BindHREmployeeSalaryInfoList()
        {
            lvHREmployeeSalaryInfo.DataBind();
        }

        private HREmployee_DetailedEntity GetHREmployeeInfo(Int64 employeeID)
        {
            IList<HREmployee_DetailedEntity> list = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, String.Empty);

            HREmployee_DetailedEntity ent = list.Single(x => x.EmployeeID == employeeID);
            return ent;
        }

        private HREmployeeSalaryInfoEntity BuildHREmployeeSalaryInfoEntity()
        {
            HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity = CurrentHREmployeeSalaryInfoEntity;

            
            return hREmployeeSalaryInfoEntity;
        }

        private void SaveHREmployeeSalaryInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity = BuildHREmployeeSalaryInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeSalaryInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeSalaryInfo.GetFacadeCreate().Add(hREmployeeSalaryInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoEntity.FLD_NAME_EmployeeSalaryInfoID, hREmployeeSalaryInfoEntity.EmployeeSalaryInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalaryInfo.GetFacadeCreate().Update(hREmployeeSalaryInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryInfoID = 0;
                        _HREmployeeSalaryInfoEntity = new HREmployeeSalaryInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeSalaryInfoList();

                        if (hREmployeeSalaryInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Info Information has been added successfully.", false);
                            //String NavigationUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeSalaryBreakDown.aspx", string.Empty, UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID, result.ToString()).ToString();
                            //Response.Redirect(NavigationUrl);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Info Information has been updated successfully.", false);
                            //String NavigationUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeSalaryBreakDown.aspx", string.Empty, UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID, result.ToString()).ToString();
                            //Response.Redirect(NavigationUrl);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalaryInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Info Information.", false);
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

        protected void lvHREmployeeSalaryInfo_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployeeSalaryInfoEntity ent = (HREmployeeSalaryInfoEntity)dataItem.DataItem;

                HyperLink hypEmployee = (HyperLink)e.Item.FindControl("hypEmployee");

                //hypEmployee.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeSalaryBreakDown.aspx", string.Empty, UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID, ent.EmployeeSalaryInfoID.ToString()).ToString();

                //hypEmployee.Target = "_blank";
            }
        }

        protected void lvHREmployeeSalaryInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryInfoID);

            if (EmployeeSalaryInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryInfoID = EmployeeSalaryInfoID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoEntity.FLD_NAME_EmployeeSalaryInfoID, EmployeeSalaryInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity = new HREmployeeSalaryInfoEntity();


                        result = FCCHREmployeeSalaryInfo.GetFacadeCreate().Delete(hREmployeeSalaryInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryInfoID = 0;
                            _HREmployeeSalaryInfoEntity = new HREmployeeSalaryInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Info.", true);
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

        protected void odsHREmployeeSalaryInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression( HREmployeeSalaryInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.LikeWithBothMath);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
