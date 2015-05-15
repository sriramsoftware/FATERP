// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public partial class MDApprovalRuleDataSource
    {
        public Int32 totalRowCount = 0;

        public MDApprovalRuleDataSource()
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
        public IList<MDApprovalRuleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDApprovalRuleEntity> mDApprovalRuleEntityList = new List<MDApprovalRuleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDApprovalRuleEntityList = FCCMDApprovalRule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDApprovalRuleEntityList != null && mDApprovalRuleEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalRuleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalRuleEntityList ?? new List<MDApprovalRuleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalRuleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDApprovalRuleEntity> mDApprovalRuleEntityList = new List<MDApprovalRuleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalRuleEntityList =  FCCMDApprovalRule.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDApprovalRuleEntityList =  FCCMDApprovalRule.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalRuleEntityList =  FCCMDApprovalRule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDApprovalRuleEntityList =  FCCMDApprovalRule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDApprovalRuleEntityList != null && mDApprovalRuleEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalRuleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalRuleEntityList ?? new List<MDApprovalRuleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalRuleEntity> GetData()
        {
            IList<MDApprovalRuleEntity> mDApprovalRuleEntityList = new List<MDApprovalRuleEntity>();
            
            try
            {
                mDApprovalRuleEntityList = FCCMDApprovalRule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDApprovalRuleEntityList != null && mDApprovalRuleEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalRuleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDApprovalRuleEntityList ?? new List<MDApprovalRuleEntity>();
        }
    }
}
