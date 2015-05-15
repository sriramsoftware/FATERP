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
    public partial class OTScheduleDataSource
    {
        public Int32 totalRowCount = 0;

        public OTScheduleDataSource()
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
        public IList<OTScheduleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<OTScheduleEntity> oTScheduleEntityList = new List<OTScheduleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTScheduleEntity.FLD_NAME_ScheduleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                oTScheduleEntityList = FCCOTSchedule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (oTScheduleEntityList != null && oTScheduleEntityList.Count > 0)
                {
                    totalRowCount = oTScheduleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTScheduleEntityList ?? new List<OTScheduleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTScheduleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<OTScheduleEntity> oTScheduleEntityList = new List<OTScheduleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTScheduleEntity.FLD_NAME_ScheduleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTScheduleEntityList =  FCCOTSchedule.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        oTScheduleEntityList =  FCCOTSchedule.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTScheduleEntityList =  FCCOTSchedule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        oTScheduleEntityList =  FCCOTSchedule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (oTScheduleEntityList != null && oTScheduleEntityList.Count > 0)
                {
                    totalRowCount = oTScheduleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTScheduleEntityList ?? new List<OTScheduleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTScheduleEntity> GetData()
        {
            IList<OTScheduleEntity> oTScheduleEntityList = new List<OTScheduleEntity>();
            
            try
            {
                oTScheduleEntityList = FCCOTSchedule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (oTScheduleEntityList != null && oTScheduleEntityList.Count > 0)
                {
                    totalRowCount = oTScheduleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return oTScheduleEntityList ?? new List<OTScheduleEntity>();
        }
    }
}
