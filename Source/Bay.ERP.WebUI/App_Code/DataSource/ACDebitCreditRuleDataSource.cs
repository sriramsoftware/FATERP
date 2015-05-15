// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACDebitCreditRuleDataSource
    {
        public Int32 totalRowCount = 0;

        public ACDebitCreditRuleDataSource()
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
        public IList<ACDebitCreditRuleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList = new List<ACDebitCreditRuleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACDebitCreditRuleEntity.FLD_NAME_ACDebitCreditRuleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCDebitCreditRuleEntityList = FCCACDebitCreditRule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCDebitCreditRuleEntityList != null && aCDebitCreditRuleEntityList.Count > 0)
                {
                    totalRowCount = aCDebitCreditRuleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCDebitCreditRuleEntityList ?? new List<ACDebitCreditRuleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACDebitCreditRuleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList = new List<ACDebitCreditRuleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACDebitCreditRuleEntity.FLD_NAME_ACDebitCreditRuleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCDebitCreditRuleEntityList =  FCCACDebitCreditRule.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCDebitCreditRuleEntityList =  FCCACDebitCreditRule.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCDebitCreditRuleEntityList =  FCCACDebitCreditRule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCDebitCreditRuleEntityList =  FCCACDebitCreditRule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCDebitCreditRuleEntityList != null && aCDebitCreditRuleEntityList.Count > 0)
                {
                    totalRowCount = aCDebitCreditRuleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCDebitCreditRuleEntityList ?? new List<ACDebitCreditRuleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACDebitCreditRuleEntity> GetData()
        {
            IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList = new List<ACDebitCreditRuleEntity>();
            
            try
            {
                aCDebitCreditRuleEntityList = FCCACDebitCreditRule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCDebitCreditRuleEntityList != null && aCDebitCreditRuleEntityList.Count > 0)
                {
                    totalRowCount = aCDebitCreditRuleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCDebitCreditRuleEntityList ?? new List<ACDebitCreditRuleEntity>();
        }
    }
}
