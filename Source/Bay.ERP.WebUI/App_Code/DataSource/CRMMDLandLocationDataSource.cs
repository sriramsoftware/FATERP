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
    public partial class CRMMDLandLocationDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDLandLocationDataSource()
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
        public IList<CRMMDLandLocationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDLandLocationEntity> cRMMDLandLocationEntityList = new List<CRMMDLandLocationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDLandLocationEntity.FLD_NAME_LandLocationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDLandLocationEntityList = FCCCRMMDLandLocation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDLandLocationEntityList != null && cRMMDLandLocationEntityList.Count > 0)
                {
                    totalRowCount = cRMMDLandLocationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDLandLocationEntityList ?? new List<CRMMDLandLocationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDLandLocationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDLandLocationEntity> cRMMDLandLocationEntityList = new List<CRMMDLandLocationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDLandLocationEntity.FLD_NAME_LandLocationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDLandLocationEntityList =  FCCCRMMDLandLocation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDLandLocationEntityList =  FCCCRMMDLandLocation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDLandLocationEntityList =  FCCCRMMDLandLocation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDLandLocationEntityList =  FCCCRMMDLandLocation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDLandLocationEntityList != null && cRMMDLandLocationEntityList.Count > 0)
                {
                    totalRowCount = cRMMDLandLocationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDLandLocationEntityList ?? new List<CRMMDLandLocationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDLandLocationEntity> GetData()
        {
            IList<CRMMDLandLocationEntity> cRMMDLandLocationEntityList = new List<CRMMDLandLocationEntity>();
            
            try
            {
                cRMMDLandLocationEntityList = FCCCRMMDLandLocation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDLandLocationEntityList != null && cRMMDLandLocationEntityList.Count > 0)
                {
                    totalRowCount = cRMMDLandLocationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDLandLocationEntityList ?? new List<CRMMDLandLocationEntity>();
        }
    }
}
