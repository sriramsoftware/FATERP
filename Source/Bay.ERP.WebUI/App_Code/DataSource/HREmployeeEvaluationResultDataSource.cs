// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public partial class HREmployeeEvaluationResultDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeEvaluationResultDataSource()
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
        public IList<HREmployeeEvaluationResultEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList = new List<HREmployeeEvaluationResultEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeEvaluationResultEntity.FLD_NAME_EmployeeEvaluationResultID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeEvaluationResultEntityList = FCCHREmployeeEvaluationResult.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeEvaluationResultEntityList != null && hREmployeeEvaluationResultEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationResultEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeEvaluationResultEntityList ?? new List<HREmployeeEvaluationResultEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEvaluationResultEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList = new List<HREmployeeEvaluationResultEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeEvaluationResultEntity.FLD_NAME_EmployeeEvaluationResultID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeEvaluationResultEntityList =  FCCHREmployeeEvaluationResult.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeEvaluationResultEntityList =  FCCHREmployeeEvaluationResult.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeEvaluationResultEntityList =  FCCHREmployeeEvaluationResult.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeEvaluationResultEntityList =  FCCHREmployeeEvaluationResult.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeEvaluationResultEntityList != null && hREmployeeEvaluationResultEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationResultEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeEvaluationResultEntityList ?? new List<HREmployeeEvaluationResultEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEvaluationResultEntity> GetData()
        {
            IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList = new List<HREmployeeEvaluationResultEntity>();
            
            try
            {
                hREmployeeEvaluationResultEntityList = FCCHREmployeeEvaluationResult.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeEvaluationResultEntityList != null && hREmployeeEvaluationResultEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationResultEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeEvaluationResultEntityList ?? new List<HREmployeeEvaluationResultEntity>();
        }
    }
}