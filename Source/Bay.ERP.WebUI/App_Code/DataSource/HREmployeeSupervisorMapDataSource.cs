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
    public partial class HREmployeeSupervisorMapDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeSupervisorMapDataSource()
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
        public IList<HREmployeeSupervisorMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapEntityList = new List<HREmployeeSupervisorMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeSupervisorMapEntity.FLD_NAME_EmployeeSupervisorMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeSupervisorMapEntityList = FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeSupervisorMapEntityList != null && hREmployeeSupervisorMapEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSupervisorMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeSupervisorMapEntityList ?? new List<HREmployeeSupervisorMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeSupervisorMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapEntityList = new List<HREmployeeSupervisorMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeSupervisorMapEntity.FLD_NAME_EmployeeSupervisorMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeSupervisorMapEntityList =  FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeSupervisorMapEntityList =  FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeSupervisorMapEntityList =  FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeSupervisorMapEntityList =  FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeSupervisorMapEntityList != null && hREmployeeSupervisorMapEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSupervisorMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeSupervisorMapEntityList ?? new List<HREmployeeSupervisorMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeSupervisorMapEntity> GetData()
        {
            IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapEntityList = new List<HREmployeeSupervisorMapEntity>();
            
            try
            {
                hREmployeeSupervisorMapEntityList = FCCHREmployeeSupervisorMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeSupervisorMapEntityList != null && hREmployeeSupervisorMapEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeSupervisorMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeSupervisorMapEntityList ?? new List<HREmployeeSupervisorMapEntity>();
        }
    }
}
