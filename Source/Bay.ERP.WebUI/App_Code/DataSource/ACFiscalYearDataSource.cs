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
    public partial class ACFiscalYearDataSource
    {
        public Int32 totalRowCount = 0;

        public ACFiscalYearDataSource()
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
        public IList<ACFiscalYearEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACFiscalYearEntity> aCFiscalYearEntityList = new List<ACFiscalYearEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACFiscalYearEntity.FLD_NAME_FiscalYearID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCFiscalYearEntityList = FCCACFiscalYear.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCFiscalYearEntityList != null && aCFiscalYearEntityList.Count > 0)
                {
                    totalRowCount = aCFiscalYearEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCFiscalYearEntityList ?? new List<ACFiscalYearEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACFiscalYearEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACFiscalYearEntity> aCFiscalYearEntityList = new List<ACFiscalYearEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACFiscalYearEntity.FLD_NAME_FiscalYearID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCFiscalYearEntityList =  FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCFiscalYearEntityList =  FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCFiscalYearEntityList =  FCCACFiscalYear.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCFiscalYearEntityList =  FCCACFiscalYear.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCFiscalYearEntityList != null && aCFiscalYearEntityList.Count > 0)
                {
                    totalRowCount = aCFiscalYearEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCFiscalYearEntityList ?? new List<ACFiscalYearEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACFiscalYearEntity> GetData()
        {
            IList<ACFiscalYearEntity> aCFiscalYearEntityList = new List<ACFiscalYearEntity>();
            
            try
            {
                aCFiscalYearEntityList = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCFiscalYearEntityList != null && aCFiscalYearEntityList.Count > 0)
                {
                    totalRowCount = aCFiscalYearEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCFiscalYearEntityList ?? new List<ACFiscalYearEntity>();
        }
    }
}
