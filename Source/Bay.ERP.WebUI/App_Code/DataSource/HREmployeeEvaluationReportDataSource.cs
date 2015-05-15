// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2013, 01:17:51




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
    public partial class HREmployeeEvaluationReportDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeEvaluationReportDataSource()
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
        public IList<HREmployeeEvaluationReportEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList = new List<HREmployeeEvaluationReportEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeEvaluationReportEntity.FLD_NAME_EmployeeEvaluationReportID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeEvaluationReportEntityList = FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeEvaluationReportEntityList != null && hREmployeeEvaluationReportEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationReportEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeEvaluationReportEntityList ?? new List<HREmployeeEvaluationReportEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEvaluationReportEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList = new List<HREmployeeEvaluationReportEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeEvaluationReportEntity.FLD_NAME_EmployeeEvaluationReportID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeEvaluationReportEntityList =  FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeEvaluationReportEntityList =  FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeEvaluationReportEntityList =  FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeEvaluationReportEntityList =  FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeEvaluationReportEntityList != null && hREmployeeEvaluationReportEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationReportEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeEvaluationReportEntityList ?? new List<HREmployeeEvaluationReportEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEvaluationReportEntity> GetData()
        {
            IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList = new List<HREmployeeEvaluationReportEntity>();
            
            try
            {
                hREmployeeEvaluationReportEntityList = FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeEvaluationReportEntityList != null && hREmployeeEvaluationReportEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationReportEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeEvaluationReportEntityList ?? new List<HREmployeeEvaluationReportEntity>();
        }
    }
}
