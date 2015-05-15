// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 02-Jul-2013, 10:18:14




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
    public partial class ActivityLogDataSource
    {
        public Int32 totalRowCount = 0;

        public ActivityLogDataSource()
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
        public IList<ActivityLogEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ActivityLogEntity> activityLogEntityList = new List<ActivityLogEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ActivityLogEntity.FLD_NAME_ActivityLogID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                activityLogEntityList = FCCActivityLog.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (activityLogEntityList != null && activityLogEntityList.Count > 0)
                {
                    totalRowCount = activityLogEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return activityLogEntityList ?? new List<ActivityLogEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ActivityLogEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ActivityLogEntity> activityLogEntityList = new List<ActivityLogEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ActivityLogEntity.FLD_NAME_ActivityLogID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        activityLogEntityList =  FCCActivityLog.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        activityLogEntityList =  FCCActivityLog.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        activityLogEntityList =  FCCActivityLog.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        activityLogEntityList =  FCCActivityLog.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (activityLogEntityList != null && activityLogEntityList.Count > 0)
                {
                    totalRowCount = activityLogEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return activityLogEntityList ?? new List<ActivityLogEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ActivityLogEntity> GetData()
        {
            IList<ActivityLogEntity> activityLogEntityList = new List<ActivityLogEntity>();
            
            try
            {
                activityLogEntityList = FCCActivityLog.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (activityLogEntityList != null && activityLogEntityList.Count > 0)
                {
                    totalRowCount = activityLogEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return activityLogEntityList ?? new List<ActivityLogEntity>();
        }
    }
}
