// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public partial class ACBankAccountDataSource
    {
        public Int32 totalRowCount = 0;

        public ACBankAccountDataSource()
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
        public IList<ACBankAccountEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACBankAccountEntity> aCBankAccountEntityList = new List<ACBankAccountEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACBankAccountEntity.FLD_NAME_BankAccountID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCBankAccountEntityList = FCCACBankAccount.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCBankAccountEntityList != null && aCBankAccountEntityList.Count > 0)
                {
                    totalRowCount = aCBankAccountEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCBankAccountEntityList ?? new List<ACBankAccountEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACBankAccountEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACBankAccountEntity> aCBankAccountEntityList = new List<ACBankAccountEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACBankAccountEntity.FLD_NAME_BankAccountID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCBankAccountEntityList =  FCCACBankAccount.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCBankAccountEntityList =  FCCACBankAccount.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCBankAccountEntityList =  FCCACBankAccount.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCBankAccountEntityList =  FCCACBankAccount.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCBankAccountEntityList != null && aCBankAccountEntityList.Count > 0)
                {
                    totalRowCount = aCBankAccountEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCBankAccountEntityList ?? new List<ACBankAccountEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACBankAccountEntity> GetData()
        {
            IList<ACBankAccountEntity> aCBankAccountEntityList = new List<ACBankAccountEntity>();
            
            try
            {
                aCBankAccountEntityList = FCCACBankAccount.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCBankAccountEntityList != null && aCBankAccountEntityList.Count > 0)
                {
                    totalRowCount = aCBankAccountEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCBankAccountEntityList ?? new List<ACBankAccountEntity>();
        }
    }
}
