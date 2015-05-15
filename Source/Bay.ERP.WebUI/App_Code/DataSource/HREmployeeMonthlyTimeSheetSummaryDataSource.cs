// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public partial class HREmployeeMonthlyTimeSheetSummaryDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeMonthlyTimeSheetSummaryDataSource()
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
        public IList<HREmployeeMonthlyTimeSheetSummaryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList = new List<HREmployeeMonthlyTimeSheetSummaryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeMonthlyTimeSheetID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeMonthlyTimeSheetSummaryEntityList = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeMonthlyTimeSheetSummaryEntityList != null && hREmployeeMonthlyTimeSheetSummaryEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeMonthlyTimeSheetSummaryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeMonthlyTimeSheetSummaryEntityList ?? new List<HREmployeeMonthlyTimeSheetSummaryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeMonthlyTimeSheetSummaryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList = new List<HREmployeeMonthlyTimeSheetSummaryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeMonthlyTimeSheetID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeMonthlyTimeSheetSummaryEntityList =  FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeMonthlyTimeSheetSummaryEntityList =  FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeMonthlyTimeSheetSummaryEntityList =  FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeMonthlyTimeSheetSummaryEntityList =  FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeMonthlyTimeSheetSummaryEntityList != null && hREmployeeMonthlyTimeSheetSummaryEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeMonthlyTimeSheetSummaryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeMonthlyTimeSheetSummaryEntityList ?? new List<HREmployeeMonthlyTimeSheetSummaryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeMonthlyTimeSheetSummaryEntity> GetData()
        {
            IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList = new List<HREmployeeMonthlyTimeSheetSummaryEntity>();
            
            try
            {
                hREmployeeMonthlyTimeSheetSummaryEntityList = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeMonthlyTimeSheetSummaryEntityList != null && hREmployeeMonthlyTimeSheetSummaryEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeMonthlyTimeSheetSummaryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeMonthlyTimeSheetSummaryEntityList ?? new List<HREmployeeMonthlyTimeSheetSummaryEntity>();
        }
    }
}
