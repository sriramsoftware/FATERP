// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




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
    public partial class INVTransactionDataSource
    {
        public Int32 totalRowCount = 0;

        public INVTransactionDataSource()
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
        public IList<INVTransactionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVTransactionEntity> iNVTransactionEntityList = new List<INVTransactionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTransactionEntity.FLD_NAME_TransactionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVTransactionEntityList = FCCINVTransaction.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVTransactionEntityList != null && iNVTransactionEntityList.Count > 0)
                {
                    totalRowCount = iNVTransactionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTransactionEntityList ?? new List<INVTransactionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransactionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVTransactionEntity> iNVTransactionEntityList = new List<INVTransactionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTransactionEntity.FLD_NAME_TransactionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTransactionEntityList =  FCCINVTransaction.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVTransactionEntityList =  FCCINVTransaction.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTransactionEntityList =  FCCINVTransaction.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVTransactionEntityList =  FCCINVTransaction.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVTransactionEntityList != null && iNVTransactionEntityList.Count > 0)
                {
                    totalRowCount = iNVTransactionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTransactionEntityList ?? new List<INVTransactionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransactionEntity> GetData()
        {
            IList<INVTransactionEntity> iNVTransactionEntityList = new List<INVTransactionEntity>();
            
            try
            {
                iNVTransactionEntityList = FCCINVTransaction.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVTransactionEntityList != null && iNVTransactionEntityList.Count > 0)
                {
                    totalRowCount = iNVTransactionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVTransactionEntityList ?? new List<INVTransactionEntity>();
        }
    }
}
