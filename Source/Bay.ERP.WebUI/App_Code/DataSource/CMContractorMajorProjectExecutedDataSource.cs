// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class CMContractorMajorProjectExecutedDataSource
    {
        public Int32 totalRowCount = 0;

        public CMContractorMajorProjectExecutedDataSource()
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
        public IList<CMContractorMajorProjectExecutedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMContractorMajorProjectExecutedEntity> cMContractorMajorProjectExecutedEntityList = new List<CMContractorMajorProjectExecutedEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorMajorProjectExecutedEntity.FLD_NAME_ContractorMajorProjectExecutedID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMContractorMajorProjectExecutedEntityList = FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMContractorMajorProjectExecutedEntityList != null && cMContractorMajorProjectExecutedEntityList.Count > 0)
                {
                    totalRowCount = cMContractorMajorProjectExecutedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorMajorProjectExecutedEntityList ?? new List<CMContractorMajorProjectExecutedEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorMajorProjectExecutedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMContractorMajorProjectExecutedEntity> cMContractorMajorProjectExecutedEntityList = new List<CMContractorMajorProjectExecutedEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorMajorProjectExecutedEntity.FLD_NAME_ContractorMajorProjectExecutedID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorMajorProjectExecutedEntityList =  FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMContractorMajorProjectExecutedEntityList =  FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorMajorProjectExecutedEntityList =  FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMContractorMajorProjectExecutedEntityList =  FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMContractorMajorProjectExecutedEntityList != null && cMContractorMajorProjectExecutedEntityList.Count > 0)
                {
                    totalRowCount = cMContractorMajorProjectExecutedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorMajorProjectExecutedEntityList ?? new List<CMContractorMajorProjectExecutedEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorMajorProjectExecutedEntity> GetData()
        {
            IList<CMContractorMajorProjectExecutedEntity> cMContractorMajorProjectExecutedEntityList = new List<CMContractorMajorProjectExecutedEntity>();
            
            try
            {
                cMContractorMajorProjectExecutedEntityList = FCCCMContractorMajorProjectExecuted.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMContractorMajorProjectExecutedEntityList != null && cMContractorMajorProjectExecutedEntityList.Count > 0)
                {
                    totalRowCount = cMContractorMajorProjectExecutedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMContractorMajorProjectExecutedEntityList ?? new List<CMContractorMajorProjectExecutedEntity>();
        }
    }
}
