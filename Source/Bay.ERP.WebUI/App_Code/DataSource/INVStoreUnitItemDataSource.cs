// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
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
    public partial class INVStoreUnitItemDataSource
    {
        public Int32 totalRowCount = 0;

        public INVStoreUnitItemDataSource()
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
        public IList<INVStoreUnitItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVStoreUnitItemEntity> iNVStoreUnitItemEntityList = new List<INVStoreUnitItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVStoreUnitItemEntity.FLD_NAME_StoreUnitItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVStoreUnitItemEntityList = FCCINVStoreUnitItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVStoreUnitItemEntityList != null && iNVStoreUnitItemEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreUnitItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVStoreUnitItemEntityList ?? new List<INVStoreUnitItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreUnitItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVStoreUnitItemEntity> iNVStoreUnitItemEntityList = new List<INVStoreUnitItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVStoreUnitItemEntity.FLD_NAME_StoreUnitItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVStoreUnitItemEntityList =  FCCINVStoreUnitItem.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVStoreUnitItemEntityList =  FCCINVStoreUnitItem.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVStoreUnitItemEntityList =  FCCINVStoreUnitItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVStoreUnitItemEntityList =  FCCINVStoreUnitItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVStoreUnitItemEntityList != null && iNVStoreUnitItemEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreUnitItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVStoreUnitItemEntityList ?? new List<INVStoreUnitItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreUnitItemEntity> GetData()
        {
            IList<INVStoreUnitItemEntity> iNVStoreUnitItemEntityList = new List<INVStoreUnitItemEntity>();
            
            try
            {
                iNVStoreUnitItemEntityList = FCCINVStoreUnitItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVStoreUnitItemEntityList != null && iNVStoreUnitItemEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreUnitItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVStoreUnitItemEntityList ?? new List<INVStoreUnitItemEntity>();
        }
    }
}
