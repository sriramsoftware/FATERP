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
    public partial class ACBudgetDataSource
    {
        public Int32 totalRowCount = 0;

        public ACBudgetDataSource()
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
        public IList<ACBudgetEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACBudgetEntity> aCBudgetEntityList = new List<ACBudgetEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACBudgetEntity.FLD_NAME_BudgetID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCBudgetEntityList = FCCACBudget.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCBudgetEntityList != null && aCBudgetEntityList.Count > 0)
                {
                    totalRowCount = aCBudgetEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCBudgetEntityList ?? new List<ACBudgetEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACBudgetEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACBudgetEntity> aCBudgetEntityList = new List<ACBudgetEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACBudgetEntity.FLD_NAME_BudgetID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCBudgetEntityList =  FCCACBudget.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCBudgetEntityList =  FCCACBudget.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCBudgetEntityList =  FCCACBudget.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCBudgetEntityList =  FCCACBudget.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCBudgetEntityList != null && aCBudgetEntityList.Count > 0)
                {
                    totalRowCount = aCBudgetEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCBudgetEntityList ?? new List<ACBudgetEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACBudgetEntity> GetData()
        {
            IList<ACBudgetEntity> aCBudgetEntityList = new List<ACBudgetEntity>();
            
            try
            {
                aCBudgetEntityList = FCCACBudget.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCBudgetEntityList != null && aCBudgetEntityList.Count > 0)
                {
                    totalRowCount = aCBudgetEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCBudgetEntityList ?? new List<ACBudgetEntity>();
        }
    }
}
