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
    public partial class OTScheduleResourceDataSource
    {
        public Int32 totalRowCount = 0;

        public OTScheduleResourceDataSource()
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
        public IList<OTScheduleResourceEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<OTScheduleResourceEntity> oTScheduleResourceEntityList = new List<OTScheduleResourceEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTScheduleResourceEntity.FLD_NAME_OTScheduleResourceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                oTScheduleResourceEntityList = FCCOTScheduleResource.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (oTScheduleResourceEntityList != null && oTScheduleResourceEntityList.Count > 0)
                {
                    totalRowCount = oTScheduleResourceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTScheduleResourceEntityList ?? new List<OTScheduleResourceEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTScheduleResourceEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<OTScheduleResourceEntity> oTScheduleResourceEntityList = new List<OTScheduleResourceEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTScheduleResourceEntity.FLD_NAME_OTScheduleResourceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTScheduleResourceEntityList =  FCCOTScheduleResource.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        oTScheduleResourceEntityList =  FCCOTScheduleResource.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTScheduleResourceEntityList =  FCCOTScheduleResource.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        oTScheduleResourceEntityList =  FCCOTScheduleResource.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (oTScheduleResourceEntityList != null && oTScheduleResourceEntityList.Count > 0)
                {
                    totalRowCount = oTScheduleResourceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTScheduleResourceEntityList ?? new List<OTScheduleResourceEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTScheduleResourceEntity> GetData()
        {
            IList<OTScheduleResourceEntity> oTScheduleResourceEntityList = new List<OTScheduleResourceEntity>();
            
            try
            {
                oTScheduleResourceEntityList = FCCOTScheduleResource.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (oTScheduleResourceEntityList != null && oTScheduleResourceEntityList.Count > 0)
                {
                    totalRowCount = oTScheduleResourceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return oTScheduleResourceEntityList ?? new List<OTScheduleResourceEntity>();
        }
    }
}
