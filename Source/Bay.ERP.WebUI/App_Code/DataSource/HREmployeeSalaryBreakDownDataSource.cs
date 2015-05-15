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
    public partial class HREmployeeSalaryBreakDownDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeSalaryBreakDownDataSource()
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
        public IList<HREmployeeSalaryBreakDownEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeSalaryBreakDownEntity> hREmployeeSalaryBreakDownEntityList = new List<HREmployeeSalaryBreakDownEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeSalaryBreakDownEntity.FLD_NAME_EmployeeSalaryBreakDownID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeSalaryBreakDownEntityList = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeSalaryBreakDownEntityList != null && hREmployeeSalaryBreakDownEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSalaryBreakDownEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeSalaryBreakDownEntityList ?? new List<HREmployeeSalaryBreakDownEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeSalaryBreakDownEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeSalaryBreakDownEntity> hREmployeeSalaryBreakDownEntityList = new List<HREmployeeSalaryBreakDownEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeSalaryBreakDownEntity.FLD_NAME_EmployeeSalaryBreakDownID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeSalaryBreakDownEntityList =  FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeSalaryBreakDownEntityList =  FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeSalaryBreakDownEntityList =  FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeSalaryBreakDownEntityList =  FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeSalaryBreakDownEntityList != null && hREmployeeSalaryBreakDownEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSalaryBreakDownEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeSalaryBreakDownEntityList ?? new List<HREmployeeSalaryBreakDownEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeSalaryBreakDownEntity> GetData()
        {
            IList<HREmployeeSalaryBreakDownEntity> hREmployeeSalaryBreakDownEntityList = new List<HREmployeeSalaryBreakDownEntity>();
            
            try
            {
                hREmployeeSalaryBreakDownEntityList = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeSalaryBreakDownEntityList != null && hREmployeeSalaryBreakDownEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSalaryBreakDownEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeSalaryBreakDownEntityList ?? new List<HREmployeeSalaryBreakDownEntity>();
        }
    }
}
