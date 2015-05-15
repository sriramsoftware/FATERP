// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:18:05




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
    public partial class MDInventoryStoreUnitTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDInventoryStoreUnitTypeDataSource()
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
        public IList<MDInventoryStoreUnitTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDInventoryStoreUnitTypeEntity> mDInventoryStoreUnitTypeEntityList = new List<MDInventoryStoreUnitTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDInventoryStoreUnitTypeEntity.FLD_NAME_InventoryStoreUnitTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDInventoryStoreUnitTypeEntityList = FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDInventoryStoreUnitTypeEntityList != null && mDInventoryStoreUnitTypeEntityList.Count > 0)
                {
                    totalRowCount = mDInventoryStoreUnitTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDInventoryStoreUnitTypeEntityList ?? new List<MDInventoryStoreUnitTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDInventoryStoreUnitTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDInventoryStoreUnitTypeEntity> mDInventoryStoreUnitTypeEntityList = new List<MDInventoryStoreUnitTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDInventoryStoreUnitTypeEntity.FLD_NAME_InventoryStoreUnitTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDInventoryStoreUnitTypeEntityList =  FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDInventoryStoreUnitTypeEntityList =  FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDInventoryStoreUnitTypeEntityList =  FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDInventoryStoreUnitTypeEntityList =  FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDInventoryStoreUnitTypeEntityList != null && mDInventoryStoreUnitTypeEntityList.Count > 0)
                {
                    totalRowCount = mDInventoryStoreUnitTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDInventoryStoreUnitTypeEntityList ?? new List<MDInventoryStoreUnitTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDInventoryStoreUnitTypeEntity> GetData()
        {
            IList<MDInventoryStoreUnitTypeEntity> mDInventoryStoreUnitTypeEntityList = new List<MDInventoryStoreUnitTypeEntity>();
            
            try
            {
                mDInventoryStoreUnitTypeEntityList = FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDInventoryStoreUnitTypeEntityList != null && mDInventoryStoreUnitTypeEntityList.Count > 0)
                {
                    totalRowCount = mDInventoryStoreUnitTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDInventoryStoreUnitTypeEntityList ?? new List<MDInventoryStoreUnitTypeEntity>();
        }
    }
}
