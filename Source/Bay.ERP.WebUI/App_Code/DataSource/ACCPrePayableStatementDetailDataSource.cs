// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class ACCPrePayableStatementDetailDataSource
    {
        public Int32 totalRowCount = 0;

        public ACCPrePayableStatementDetailDataSource()
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
        public IList<ACCPrePayableStatementDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList = new List<ACCPrePayableStatementDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCCPrePayableStatementDetailEntityList = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCCPrePayableStatementDetailEntityList != null && aCCPrePayableStatementDetailEntityList.Count > 0)
                {
                    totalRowCount = aCCPrePayableStatementDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCCPrePayableStatementDetailEntityList ?? new List<ACCPrePayableStatementDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACCPrePayableStatementDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList = new List<ACCPrePayableStatementDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCCPrePayableStatementDetailEntityList =  FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCCPrePayableStatementDetailEntityList =  FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCCPrePayableStatementDetailEntityList =  FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCCPrePayableStatementDetailEntityList =  FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCCPrePayableStatementDetailEntityList != null && aCCPrePayableStatementDetailEntityList.Count > 0)
                {
                    totalRowCount = aCCPrePayableStatementDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCCPrePayableStatementDetailEntityList ?? new List<ACCPrePayableStatementDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACCPrePayableStatementDetailEntity> GetData()
        {
            IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList = new List<ACCPrePayableStatementDetailEntity>();
            
            try
            {
                aCCPrePayableStatementDetailEntityList = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCCPrePayableStatementDetailEntityList != null && aCCPrePayableStatementDetailEntityList.Count > 0)
                {
                    totalRowCount = aCCPrePayableStatementDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCCPrePayableStatementDetailEntityList ?? new List<ACCPrePayableStatementDetailEntity>();
        }
    }
}
