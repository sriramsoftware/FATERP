// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 07-Oct-2012, 01:36:13




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
    public partial class CMMeasurementBookDetailDataSource
    {
        public Int32 totalRowCount = 0;

        public CMMeasurementBookDetailDataSource()
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
        public IList<CMMeasurementBookDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList = new List<CMMeasurementBookDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMMeasurementBookDetailEntityList = FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMMeasurementBookDetailEntityList != null && cMMeasurementBookDetailEntityList.Count > 0)
                {
                    totalRowCount = cMMeasurementBookDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMMeasurementBookDetailEntityList ?? new List<CMMeasurementBookDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMMeasurementBookDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList = new List<CMMeasurementBookDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMMeasurementBookDetailEntityList =  FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMMeasurementBookDetailEntityList =  FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMMeasurementBookDetailEntityList =  FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMMeasurementBookDetailEntityList =  FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMMeasurementBookDetailEntityList != null && cMMeasurementBookDetailEntityList.Count > 0)
                {
                    totalRowCount = cMMeasurementBookDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMMeasurementBookDetailEntityList ?? new List<CMMeasurementBookDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMMeasurementBookDetailEntity> GetData()
        {
            IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList = new List<CMMeasurementBookDetailEntity>();
            
            try
            {
                cMMeasurementBookDetailEntityList = FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMMeasurementBookDetailEntityList != null && cMMeasurementBookDetailEntityList.Count > 0)
                {
                    totalRowCount = cMMeasurementBookDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMMeasurementBookDetailEntityList ?? new List<CMMeasurementBookDetailEntity>();
        }
    }
}
