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
    public partial class CMContractorContactPersonDataSource
    {
        public Int32 totalRowCount = 0;

        public CMContractorContactPersonDataSource()
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
        public IList<CMContractorContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMContractorContactPersonEntity> cMContractorContactPersonEntityList = new List<CMContractorContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorContactPersonEntity.FLD_NAME_ContractorContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMContractorContactPersonEntityList = FCCCMContractorContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMContractorContactPersonEntityList != null && cMContractorContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cMContractorContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorContactPersonEntityList ?? new List<CMContractorContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMContractorContactPersonEntity> cMContractorContactPersonEntityList = new List<CMContractorContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorContactPersonEntity.FLD_NAME_ContractorContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorContactPersonEntityList =  FCCCMContractorContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMContractorContactPersonEntityList =  FCCCMContractorContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorContactPersonEntityList =  FCCCMContractorContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMContractorContactPersonEntityList =  FCCCMContractorContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMContractorContactPersonEntityList != null && cMContractorContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cMContractorContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorContactPersonEntityList ?? new List<CMContractorContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorContactPersonEntity> GetData()
        {
            IList<CMContractorContactPersonEntity> cMContractorContactPersonEntityList = new List<CMContractorContactPersonEntity>();
            
            try
            {
                cMContractorContactPersonEntityList = FCCCMContractorContactPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMContractorContactPersonEntityList != null && cMContractorContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cMContractorContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMContractorContactPersonEntityList ?? new List<CMContractorContactPersonEntity>();
        }
    }
}
