// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class HREmployeeMultiSelectionControl : BaseControl
    {       
        #region Properties

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
          
        }

        private void BindList()
        {
            BindHREmployeeList();
        }

        private void BindHREmployeeList()
        {
          
        }

        private void SaveHREmployeeEntity()
        {
            //if (IsValid)
            //{
            //    try
            //    {
            //        #region Member

            //        HRMemberEntity hRMemberEntity = BuildHRMemberEntity();

            //        Int64 result = -1;

            //        if (hRMemberEntity.IsNew)
            //        {
            //            result = FCCHRMember.GetFacadeCreate().Add(hRMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //        }
            //        else
            //        {
            //            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, hRMemberEntity.MemberID.ToString(), SQLMatchType.Equal);
            //            result = FCCHRMember.GetFacadeCreate().Update(hRMemberEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //        }

            //        #endregion

            //        if (result > 0)
            //        {
            //            _MemberID = 0;
            //            _HRMemberEntity = new HRMemberEntity();
            //        }

            //        if (result > 0)
            //        {

            //            HREmployeeEntity hREmployeeEntity = BuildHREmployeeEntity();

            //            Int64 resultC = -1;

            //            if (hREmployeeEntity.IsNew)
            //            {
            //                hREmployeeEntity.MemberID = result;

            //                resultC = FCCHREmployee.GetFacadeCreate().Add(hREmployeeEntity, DatabaseOperationType.Add, TransactionRequired.No);


            //            }
            //            else
            //            {
            //                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_EmployeeID, hREmployeeEntity.EmployeeID.ToString(), SQLMatchType.Equal);
            //                resultC = FCCHREmployee.GetFacadeCreate().Update(hREmployeeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            //            }



            //            if (resultC > 0)
            //            {
            //                _EmployeeID = 0;
            //                _HREmployeeEntity = new HREmployeeEntity();
            //                PrepareInitialView();
            //                BindHREmployeeList();

            //                if (hREmployeeEntity.IsNew)
            //                {
            //                    ResourceEntity resourceEntity = new ResourceEntity();

            //                    resourceEntity.ReferenceID = resultC; // means new contractor id
            //                    resourceEntity.ResourceCategoryID = MasterDataConstants.ResourceCategory.EMPLOYEE;

            //                    FCCResource.GetFacadeCreate().Add(resourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
            //                }

            //                if (hREmployeeEntity.IsNew)
            //                {
            //                    MiscUtil.ShowMessage(lblMessage, "Employee Information has been added successfully.", false);
            //                }
            //                else
            //                {
            //                    MiscUtil.ShowMessage(lblMessage, "Employee Information has been updated successfully.", false);
            //                }
            //            }
            //            else
            //            {
            //                if (hREmployeeEntity.IsNew)
            //                {
            //                    MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Information.", false);
            //                }
            //                else
            //                {
            //                    MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Information.", false);
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (hRMemberEntity.IsNew)
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Failed to add Member Information.", false);
            //            }
            //            else
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Failed to update Member Information.", false);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            //    }
            //}
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

        #endregion Event
    }
}
