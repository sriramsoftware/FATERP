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
    public partial class MDScheduleIdentityCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDScheduleIdentityCategoryDataSource()
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
        public IList<MDScheduleIdentityCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList = new List<MDScheduleIdentityCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDScheduleIdentityCategoryEntity.FLD_NAME_ScheduleIdentityCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDScheduleIdentityCategoryEntityList = FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDScheduleIdentityCategoryEntityList != null && mDScheduleIdentityCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDScheduleIdentityCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDScheduleIdentityCategoryEntityList ?? new List<MDScheduleIdentityCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDScheduleIdentityCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList = new List<MDScheduleIdentityCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDScheduleIdentityCategoryEntity.FLD_NAME_ScheduleIdentityCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDScheduleIdentityCategoryEntityList =  FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDScheduleIdentityCategoryEntityList =  FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDScheduleIdentityCategoryEntityList =  FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDScheduleIdentityCategoryEntityList =  FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDScheduleIdentityCategoryEntityList != null && mDScheduleIdentityCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDScheduleIdentityCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDScheduleIdentityCategoryEntityList ?? new List<MDScheduleIdentityCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDScheduleIdentityCategoryEntity> GetData()
        {
            IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList = new List<MDScheduleIdentityCategoryEntity>();
            
            try
            {
                mDScheduleIdentityCategoryEntityList = FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDScheduleIdentityCategoryEntityList != null && mDScheduleIdentityCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDScheduleIdentityCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDScheduleIdentityCategoryEntityList ?? new List<MDScheduleIdentityCategoryEntity>();
        }
    }
}
