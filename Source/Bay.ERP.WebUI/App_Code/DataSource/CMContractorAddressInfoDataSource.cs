// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    public partial class CMContractorAddressInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public CMContractorAddressInfoDataSource()
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
        public IList<CMContractorAddressInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList = new List<CMContractorAddressInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorAddressInfoEntity.FLD_NAME_ContractorAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMContractorAddressInfoEntityList = FCCCMContractorAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMContractorAddressInfoEntityList != null && cMContractorAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = cMContractorAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorAddressInfoEntityList ?? new List<CMContractorAddressInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorAddressInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList = new List<CMContractorAddressInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorAddressInfoEntity.FLD_NAME_ContractorAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorAddressInfoEntityList =  FCCCMContractorAddressInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMContractorAddressInfoEntityList =  FCCCMContractorAddressInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorAddressInfoEntityList =  FCCCMContractorAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMContractorAddressInfoEntityList =  FCCCMContractorAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMContractorAddressInfoEntityList != null && cMContractorAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = cMContractorAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorAddressInfoEntityList ?? new List<CMContractorAddressInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorAddressInfoEntity> GetData()
        {
            IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList = new List<CMContractorAddressInfoEntity>();
            
            try
            {
                cMContractorAddressInfoEntityList = FCCCMContractorAddressInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMContractorAddressInfoEntityList != null && cMContractorAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = cMContractorAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMContractorAddressInfoEntityList ?? new List<CMContractorAddressInfoEntity>();
        }
    }
}
