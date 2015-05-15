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
    public partial class HREmployeeSalaryDeducationInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeSalaryDeducationInfoDataSource()
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
        public IList<HREmployeeSalaryDeducationInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList = new List<HREmployeeSalaryDeducationInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeSalaryDeducationInfoEntityList = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeSalaryDeducationInfoEntityList != null && hREmployeeSalaryDeducationInfoEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSalaryDeducationInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeSalaryDeducationInfoEntityList ?? new List<HREmployeeSalaryDeducationInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeSalaryDeducationInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList = new List<HREmployeeSalaryDeducationInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeSalaryDeducationInfoEntityList =  FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeSalaryDeducationInfoEntityList =  FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeSalaryDeducationInfoEntityList =  FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeSalaryDeducationInfoEntityList =  FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeSalaryDeducationInfoEntityList != null && hREmployeeSalaryDeducationInfoEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSalaryDeducationInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeSalaryDeducationInfoEntityList ?? new List<HREmployeeSalaryDeducationInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeSalaryDeducationInfoEntity> GetData()
        {
            IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList = new List<HREmployeeSalaryDeducationInfoEntity>();
            
            try
            {
                hREmployeeSalaryDeducationInfoEntityList = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeSalaryDeducationInfoEntityList != null && hREmployeeSalaryDeducationInfoEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSalaryDeducationInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeSalaryDeducationInfoEntityList ?? new List<HREmployeeSalaryDeducationInfoEntity>();
        }
    }
}
