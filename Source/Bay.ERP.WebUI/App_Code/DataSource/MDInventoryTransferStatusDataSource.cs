// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




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
    public partial class MDInventoryTransferStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDInventoryTransferStatusDataSource()
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
        public IList<MDInventoryTransferStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDInventoryTransferStatusEntity> mDInventoryTransferStatusEntityList = new List<MDInventoryTransferStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDInventoryTransferStatusEntity.FLD_NAME_InventoryTransferStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDInventoryTransferStatusEntityList = FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDInventoryTransferStatusEntityList != null && mDInventoryTransferStatusEntityList.Count > 0)
                {
                    totalRowCount = mDInventoryTransferStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDInventoryTransferStatusEntityList ?? new List<MDInventoryTransferStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDInventoryTransferStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDInventoryTransferStatusEntity> mDInventoryTransferStatusEntityList = new List<MDInventoryTransferStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDInventoryTransferStatusEntity.FLD_NAME_InventoryTransferStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDInventoryTransferStatusEntityList =  FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDInventoryTransferStatusEntityList =  FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDInventoryTransferStatusEntityList =  FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDInventoryTransferStatusEntityList =  FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDInventoryTransferStatusEntityList != null && mDInventoryTransferStatusEntityList.Count > 0)
                {
                    totalRowCount = mDInventoryTransferStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDInventoryTransferStatusEntityList ?? new List<MDInventoryTransferStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDInventoryTransferStatusEntity> GetData()
        {
            IList<MDInventoryTransferStatusEntity> mDInventoryTransferStatusEntityList = new List<MDInventoryTransferStatusEntity>();
            
            try
            {
                mDInventoryTransferStatusEntityList = FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDInventoryTransferStatusEntityList != null && mDInventoryTransferStatusEntityList.Count > 0)
                {
                    totalRowCount = mDInventoryTransferStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDInventoryTransferStatusEntityList ?? new List<MDInventoryTransferStatusEntity>();
        }
    }
}
