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
    public partial class MDApprovalProcessPriorityDataSource
    {
        public Int32 totalRowCount = 0;

        public MDApprovalProcessPriorityDataSource()
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
        public IList<MDApprovalProcessPriorityEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDApprovalProcessPriorityEntity> mDApprovalProcessPriorityEntityList = new List<MDApprovalProcessPriorityEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalProcessPriorityEntity.FLD_NAME_ApprovalProcessPriorityID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDApprovalProcessPriorityEntityList = FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDApprovalProcessPriorityEntityList != null && mDApprovalProcessPriorityEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessPriorityEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalProcessPriorityEntityList ?? new List<MDApprovalProcessPriorityEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalProcessPriorityEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDApprovalProcessPriorityEntity> mDApprovalProcessPriorityEntityList = new List<MDApprovalProcessPriorityEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalProcessPriorityEntity.FLD_NAME_ApprovalProcessPriorityID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalProcessPriorityEntityList =  FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDApprovalProcessPriorityEntityList =  FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalProcessPriorityEntityList =  FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDApprovalProcessPriorityEntityList =  FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDApprovalProcessPriorityEntityList != null && mDApprovalProcessPriorityEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessPriorityEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalProcessPriorityEntityList ?? new List<MDApprovalProcessPriorityEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalProcessPriorityEntity> GetData()
        {
            IList<MDApprovalProcessPriorityEntity> mDApprovalProcessPriorityEntityList = new List<MDApprovalProcessPriorityEntity>();
            
            try
            {
                mDApprovalProcessPriorityEntityList = FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDApprovalProcessPriorityEntityList != null && mDApprovalProcessPriorityEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessPriorityEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDApprovalProcessPriorityEntityList ?? new List<MDApprovalProcessPriorityEntity>();
        }
    }
}
