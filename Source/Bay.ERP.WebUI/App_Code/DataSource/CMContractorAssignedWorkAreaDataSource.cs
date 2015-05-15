// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




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
    public partial class CMContractorAssignedWorkAreaDataSource
    {
        public Int32 totalRowCount = 0;

        public CMContractorAssignedWorkAreaDataSource()
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
        public IList<CMContractorAssignedWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList = new List<CMContractorAssignedWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorAssignedWorkAreaEntity.FLD_NAME_ContractorAssignedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMContractorAssignedWorkAreaEntityList = FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMContractorAssignedWorkAreaEntityList != null && cMContractorAssignedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMContractorAssignedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorAssignedWorkAreaEntityList ?? new List<CMContractorAssignedWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorAssignedWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList = new List<CMContractorAssignedWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorAssignedWorkAreaEntity.FLD_NAME_ContractorAssignedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorAssignedWorkAreaEntityList =  FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMContractorAssignedWorkAreaEntityList =  FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorAssignedWorkAreaEntityList =  FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMContractorAssignedWorkAreaEntityList =  FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMContractorAssignedWorkAreaEntityList != null && cMContractorAssignedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMContractorAssignedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorAssignedWorkAreaEntityList ?? new List<CMContractorAssignedWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorAssignedWorkAreaEntity> GetData()
        {
            IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList = new List<CMContractorAssignedWorkAreaEntity>();
            
            try
            {
                cMContractorAssignedWorkAreaEntityList = FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMContractorAssignedWorkAreaEntityList != null && cMContractorAssignedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMContractorAssignedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMContractorAssignedWorkAreaEntityList ?? new List<CMContractorAssignedWorkAreaEntity>();
        }
    }
}
