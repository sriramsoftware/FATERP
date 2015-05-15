// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Jun-2013, 02:26:08




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
    public partial class ACBankAccountPaymentPostPayableStatementDetailMapDataSource
    {
        public Int32 totalRowCount = 0;

        public ACBankAccountPaymentPostPayableStatementDetailMapDataSource()
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
        public IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> aCBankAccountPaymentPostPayableStatementDetailMapEntityList = new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACBankAccountPaymentPostPayableStatementDetailMapEntity.FLD_NAME_BankAccountPaymentPostPayableStatementDetailMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCBankAccountPaymentPostPayableStatementDetailMapEntityList = FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCBankAccountPaymentPostPayableStatementDetailMapEntityList != null && aCBankAccountPaymentPostPayableStatementDetailMapEntityList.Count > 0)
                {
                    totalRowCount = aCBankAccountPaymentPostPayableStatementDetailMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCBankAccountPaymentPostPayableStatementDetailMapEntityList ?? new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> aCBankAccountPaymentPostPayableStatementDetailMapEntityList = new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACBankAccountPaymentPostPayableStatementDetailMapEntity.FLD_NAME_BankAccountPaymentPostPayableStatementDetailMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCBankAccountPaymentPostPayableStatementDetailMapEntityList =  FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCBankAccountPaymentPostPayableStatementDetailMapEntityList =  FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCBankAccountPaymentPostPayableStatementDetailMapEntityList =  FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCBankAccountPaymentPostPayableStatementDetailMapEntityList =  FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCBankAccountPaymentPostPayableStatementDetailMapEntityList != null && aCBankAccountPaymentPostPayableStatementDetailMapEntityList.Count > 0)
                {
                    totalRowCount = aCBankAccountPaymentPostPayableStatementDetailMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCBankAccountPaymentPostPayableStatementDetailMapEntityList ?? new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> GetData()
        {
            IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> aCBankAccountPaymentPostPayableStatementDetailMapEntityList = new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();
            
            try
            {
                aCBankAccountPaymentPostPayableStatementDetailMapEntityList = FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCBankAccountPaymentPostPayableStatementDetailMapEntityList != null && aCBankAccountPaymentPostPayableStatementDetailMapEntityList.Count > 0)
                {
                    totalRowCount = aCBankAccountPaymentPostPayableStatementDetailMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCBankAccountPaymentPostPayableStatementDetailMapEntityList ?? new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();
        }
    }
}
