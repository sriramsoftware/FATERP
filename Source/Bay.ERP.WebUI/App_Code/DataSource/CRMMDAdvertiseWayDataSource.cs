// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMMDAdvertiseWayDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDAdvertiseWayDataSource()
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
        public IList<CRMMDAdvertiseWayEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDAdvertiseWayEntity> cRMMDAdvertiseWayEntityList = new List<CRMMDAdvertiseWayEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAdvertiseWayEntity.FLD_NAME_AdvertiseWayID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDAdvertiseWayEntityList = FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDAdvertiseWayEntityList != null && cRMMDAdvertiseWayEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAdvertiseWayEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAdvertiseWayEntityList ?? new List<CRMMDAdvertiseWayEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAdvertiseWayEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDAdvertiseWayEntity> cRMMDAdvertiseWayEntityList = new List<CRMMDAdvertiseWayEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAdvertiseWayEntity.FLD_NAME_AdvertiseWayID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAdvertiseWayEntityList =  FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDAdvertiseWayEntityList =  FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAdvertiseWayEntityList =  FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDAdvertiseWayEntityList =  FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDAdvertiseWayEntityList != null && cRMMDAdvertiseWayEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAdvertiseWayEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAdvertiseWayEntityList ?? new List<CRMMDAdvertiseWayEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAdvertiseWayEntity> GetData()
        {
            IList<CRMMDAdvertiseWayEntity> cRMMDAdvertiseWayEntityList = new List<CRMMDAdvertiseWayEntity>();
            
            try
            {
                cRMMDAdvertiseWayEntityList = FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDAdvertiseWayEntityList != null && cRMMDAdvertiseWayEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAdvertiseWayEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDAdvertiseWayEntityList ?? new List<CRMMDAdvertiseWayEntity>();
        }
    }
}
