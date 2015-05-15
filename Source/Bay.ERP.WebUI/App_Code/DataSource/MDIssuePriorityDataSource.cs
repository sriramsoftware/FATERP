// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class MDIssuePriorityDataSource
    {
        public Int32 totalRowCount = 0;

        public MDIssuePriorityDataSource()
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
        public IList<MDIssuePriorityEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDIssuePriorityEntity> mDIssuePriorityEntityList = new List<MDIssuePriorityEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDIssuePriorityEntity.FLD_NAME_IssuePriorityID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDIssuePriorityEntityList = FCCMDIssuePriority.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDIssuePriorityEntityList != null && mDIssuePriorityEntityList.Count > 0)
                {
                    totalRowCount = mDIssuePriorityEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDIssuePriorityEntityList ?? new List<MDIssuePriorityEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDIssuePriorityEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDIssuePriorityEntity> mDIssuePriorityEntityList = new List<MDIssuePriorityEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDIssuePriorityEntity.FLD_NAME_IssuePriorityID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDIssuePriorityEntityList =  FCCMDIssuePriority.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDIssuePriorityEntityList =  FCCMDIssuePriority.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDIssuePriorityEntityList =  FCCMDIssuePriority.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDIssuePriorityEntityList =  FCCMDIssuePriority.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDIssuePriorityEntityList != null && mDIssuePriorityEntityList.Count > 0)
                {
                    totalRowCount = mDIssuePriorityEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDIssuePriorityEntityList ?? new List<MDIssuePriorityEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDIssuePriorityEntity> GetData()
        {
            IList<MDIssuePriorityEntity> mDIssuePriorityEntityList = new List<MDIssuePriorityEntity>();
            
            try
            {
                mDIssuePriorityEntityList = FCCMDIssuePriority.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDIssuePriorityEntityList != null && mDIssuePriorityEntityList.Count > 0)
                {
                    totalRowCount = mDIssuePriorityEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDIssuePriorityEntityList ?? new List<MDIssuePriorityEntity>();
        }
    }
}
