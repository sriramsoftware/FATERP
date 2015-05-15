// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
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
    public partial class MDCurrencyDataSource
    {
        public Int32 totalRowCount = 0;

        public MDCurrencyDataSource()
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
        public IList<MDCurrencyEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDCurrencyEntity> mDCurrencyEntityList = new List<MDCurrencyEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDCurrencyEntity.FLD_NAME_CurrencyID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDCurrencyEntityList = FCCMDCurrency.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDCurrencyEntityList != null && mDCurrencyEntityList.Count > 0)
                {
                    totalRowCount = mDCurrencyEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDCurrencyEntityList ?? new List<MDCurrencyEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDCurrencyEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDCurrencyEntity> mDCurrencyEntityList = new List<MDCurrencyEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDCurrencyEntity.FLD_NAME_CurrencyID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDCurrencyEntityList =  FCCMDCurrency.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDCurrencyEntityList =  FCCMDCurrency.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDCurrencyEntityList =  FCCMDCurrency.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDCurrencyEntityList =  FCCMDCurrency.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDCurrencyEntityList != null && mDCurrencyEntityList.Count > 0)
                {
                    totalRowCount = mDCurrencyEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDCurrencyEntityList ?? new List<MDCurrencyEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDCurrencyEntity> GetData()
        {
            IList<MDCurrencyEntity> mDCurrencyEntityList = new List<MDCurrencyEntity>();
            
            try
            {
                mDCurrencyEntityList = FCCMDCurrency.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDCurrencyEntityList != null && mDCurrencyEntityList.Count > 0)
                {
                    totalRowCount = mDCurrencyEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDCurrencyEntityList ?? new List<MDCurrencyEntity>();
        }
    }
}
