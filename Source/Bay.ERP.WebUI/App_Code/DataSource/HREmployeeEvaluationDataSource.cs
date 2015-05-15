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
    public partial class HREmployeeEvaluationDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeEvaluationDataSource()
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
        public IList<HREmployeeEvaluationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList = new List<HREmployeeEvaluationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeEvaluationEntity.FLD_NAME_EmployeeEvaluationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeEvaluationEntityList = FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeEvaluationEntityList != null && hREmployeeEvaluationEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeEvaluationEntityList ?? new List<HREmployeeEvaluationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEvaluationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList = new List<HREmployeeEvaluationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeEvaluationEntity.FLD_NAME_EmployeeEvaluationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeEvaluationEntityList =  FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeEvaluationEntityList =  FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeEvaluationEntityList =  FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeEvaluationEntityList =  FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeEvaluationEntityList != null && hREmployeeEvaluationEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeEvaluationEntityList ?? new List<HREmployeeEvaluationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEvaluationEntity> GetData()
        {
            IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList = new List<HREmployeeEvaluationEntity>();
            
            try
            {
                hREmployeeEvaluationEntityList = FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeEvaluationEntityList != null && hREmployeeEvaluationEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEvaluationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeEvaluationEntityList ?? new List<HREmployeeEvaluationEntity>();
        }
    }
}
