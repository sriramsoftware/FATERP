// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    public partial class INVCurrentStockDataSource
    {
        public Int32 totalRowCount = 0;

        public INVCurrentStockDataSource()
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
        public IList<INVCurrentStockEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVCurrentStockEntity> iNVCurrentStockEntityList = new List<INVCurrentStockEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVCurrentStockEntity.FLD_NAME_CurrentStockID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVCurrentStockEntityList = FCCINVCurrentStock.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVCurrentStockEntityList != null && iNVCurrentStockEntityList.Count > 0)
                {
                    totalRowCount = iNVCurrentStockEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVCurrentStockEntityList ?? new List<INVCurrentStockEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVCurrentStockEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVCurrentStockEntity> iNVCurrentStockEntityList = new List<INVCurrentStockEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVCurrentStockEntity.FLD_NAME_CurrentStockID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVCurrentStockEntityList =  FCCINVCurrentStock.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVCurrentStockEntityList =  FCCINVCurrentStock.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVCurrentStockEntityList =  FCCINVCurrentStock.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVCurrentStockEntityList =  FCCINVCurrentStock.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVCurrentStockEntityList != null && iNVCurrentStockEntityList.Count > 0)
                {
                    totalRowCount = iNVCurrentStockEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVCurrentStockEntityList ?? new List<INVCurrentStockEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVCurrentStockEntity> GetData()
        {
            IList<INVCurrentStockEntity> iNVCurrentStockEntityList = new List<INVCurrentStockEntity>();
            
            try
            {
                iNVCurrentStockEntityList = FCCINVCurrentStock.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVCurrentStockEntityList != null && iNVCurrentStockEntityList.Count > 0)
                {
                    totalRowCount = iNVCurrentStockEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVCurrentStockEntityList ?? new List<INVCurrentStockEntity>();
        }
    }
}
