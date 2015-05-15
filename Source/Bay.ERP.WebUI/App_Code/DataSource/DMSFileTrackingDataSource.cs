// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




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
    public partial class DMSFileTrackingDataSource
    {
        public Int32 totalRowCount = 0;

        public DMSFileTrackingDataSource()
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
        public IList<DMSFileTrackingEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<DMSFileTrackingEntity> dMSFileTrackingEntityList = new List<DMSFileTrackingEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = DMSFileTrackingEntity.FLD_NAME_FileTrackingID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                dMSFileTrackingEntityList = FCCDMSFileTracking.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (dMSFileTrackingEntityList != null && dMSFileTrackingEntityList.Count > 0)
                {
                    totalRowCount = dMSFileTrackingEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return dMSFileTrackingEntityList ?? new List<DMSFileTrackingEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<DMSFileTrackingEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<DMSFileTrackingEntity> dMSFileTrackingEntityList = new List<DMSFileTrackingEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = DMSFileTrackingEntity.FLD_NAME_FileTrackingID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        dMSFileTrackingEntityList =  FCCDMSFileTracking.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        dMSFileTrackingEntityList =  FCCDMSFileTracking.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        dMSFileTrackingEntityList =  FCCDMSFileTracking.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        dMSFileTrackingEntityList =  FCCDMSFileTracking.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (dMSFileTrackingEntityList != null && dMSFileTrackingEntityList.Count > 0)
                {
                    totalRowCount = dMSFileTrackingEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return dMSFileTrackingEntityList ?? new List<DMSFileTrackingEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<DMSFileTrackingEntity> GetData()
        {
            IList<DMSFileTrackingEntity> dMSFileTrackingEntityList = new List<DMSFileTrackingEntity>();
            
            try
            {
                dMSFileTrackingEntityList = FCCDMSFileTracking.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (dMSFileTrackingEntityList != null && dMSFileTrackingEntityList.Count > 0)
                {
                    totalRowCount = dMSFileTrackingEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return dMSFileTrackingEntityList ?? new List<DMSFileTrackingEntity>();
        }
    }
}
