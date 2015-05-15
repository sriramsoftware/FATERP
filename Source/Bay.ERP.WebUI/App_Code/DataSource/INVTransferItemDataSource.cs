// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 02:56:29




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
    public partial class INVTransferItemDataSource
    {
        public Int32 totalRowCount = 0;

        public INVTransferItemDataSource()
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
        public IList<INVTransferItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVTransferItemEntity> iNVTransferItemEntityList = new List<INVTransferItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTransferItemEntity.FLD_NAME_TransferItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVTransferItemEntityList = FCCINVTransferItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVTransferItemEntityList != null && iNVTransferItemEntityList.Count > 0)
                {
                    totalRowCount = iNVTransferItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTransferItemEntityList ?? new List<INVTransferItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransferItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVTransferItemEntity> iNVTransferItemEntityList = new List<INVTransferItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTransferItemEntity.FLD_NAME_TransferItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTransferItemEntityList =  FCCINVTransferItem.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVTransferItemEntityList =  FCCINVTransferItem.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTransferItemEntityList =  FCCINVTransferItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVTransferItemEntityList =  FCCINVTransferItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVTransferItemEntityList != null && iNVTransferItemEntityList.Count > 0)
                {
                    totalRowCount = iNVTransferItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTransferItemEntityList ?? new List<INVTransferItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransferItemEntity> GetData()
        {
            IList<INVTransferItemEntity> iNVTransferItemEntityList = new List<INVTransferItemEntity>();
            
            try
            {
                iNVTransferItemEntityList = FCCINVTransferItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVTransferItemEntityList != null && iNVTransferItemEntityList.Count > 0)
                {
                    totalRowCount = iNVTransferItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVTransferItemEntityList ?? new List<INVTransferItemEntity>();
        }
    }
}
