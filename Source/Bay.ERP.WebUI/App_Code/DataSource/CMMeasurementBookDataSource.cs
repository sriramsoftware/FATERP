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
    public partial class CMMeasurementBookDataSource
    {
        public Int32 totalRowCount = 0;

        public CMMeasurementBookDataSource()
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
        public IList<CMMeasurementBookEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMMeasurementBookEntity> cMMeasurementBookEntityList = new List<CMMeasurementBookEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMMeasurementBookEntity.FLD_NAME_MeasurementBookID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMMeasurementBookEntityList = FCCCMMeasurementBook.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMMeasurementBookEntityList != null && cMMeasurementBookEntityList.Count > 0)
                {
                    totalRowCount = cMMeasurementBookEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMMeasurementBookEntityList ?? new List<CMMeasurementBookEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMMeasurementBookEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMMeasurementBookEntity> cMMeasurementBookEntityList = new List<CMMeasurementBookEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMMeasurementBookEntity.FLD_NAME_MeasurementBookID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMMeasurementBookEntityList =  FCCCMMeasurementBook.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMMeasurementBookEntityList =  FCCCMMeasurementBook.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMMeasurementBookEntityList =  FCCCMMeasurementBook.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMMeasurementBookEntityList =  FCCCMMeasurementBook.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMMeasurementBookEntityList != null && cMMeasurementBookEntityList.Count > 0)
                {
                    totalRowCount = cMMeasurementBookEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMMeasurementBookEntityList ?? new List<CMMeasurementBookEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMMeasurementBookEntity> GetData()
        {
            IList<CMMeasurementBookEntity> cMMeasurementBookEntityList = new List<CMMeasurementBookEntity>();
            
            try
            {
                cMMeasurementBookEntityList = FCCCMMeasurementBook.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMMeasurementBookEntityList != null && cMMeasurementBookEntityList.Count > 0)
                {
                    totalRowCount = cMMeasurementBookEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMMeasurementBookEntityList ?? new List<CMMeasurementBookEntity>();
        }
    }
}
