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
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    [DataObject(true)]
    public partial class MDEmployeeLoanApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDEmployeeLoanApprovalStatusDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEmployeeLoanApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDEmployeeLoanApprovalStatusEntity> mDEmployeeLoanApprovalStatusEntityList = new List<MDEmployeeLoanApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEmployeeLoanApprovalStatusEntity.FLD_NAME_EmployeeLoanApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDEmployeeLoanApprovalStatusEntityList = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDEmployeeLoanApprovalStatusEntityList != null && mDEmployeeLoanApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDEmployeeLoanApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEmployeeLoanApprovalStatusEntityList ?? new List<MDEmployeeLoanApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEmployeeLoanApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDEmployeeLoanApprovalStatusEntity> mDEmployeeLoanApprovalStatusEntityList = new List<MDEmployeeLoanApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEmployeeLoanApprovalStatusEntity.FLD_NAME_EmployeeLoanApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEmployeeLoanApprovalStatusEntityList =  FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDEmployeeLoanApprovalStatusEntityList =  FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEmployeeLoanApprovalStatusEntityList =  FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDEmployeeLoanApprovalStatusEntityList =  FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDEmployeeLoanApprovalStatusEntityList != null && mDEmployeeLoanApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDEmployeeLoanApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEmployeeLoanApprovalStatusEntityList ?? new List<MDEmployeeLoanApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEmployeeLoanApprovalStatusEntity> GetData()
        {
            IList<MDEmployeeLoanApprovalStatusEntity> mDEmployeeLoanApprovalStatusEntityList = new List<MDEmployeeLoanApprovalStatusEntity>();
            
            try
            {
                mDEmployeeLoanApprovalStatusEntityList = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDEmployeeLoanApprovalStatusEntityList != null && mDEmployeeLoanApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDEmployeeLoanApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDEmployeeLoanApprovalStatusEntityList ?? new List<MDEmployeeLoanApprovalStatusEntity>();
        }
    }
}
