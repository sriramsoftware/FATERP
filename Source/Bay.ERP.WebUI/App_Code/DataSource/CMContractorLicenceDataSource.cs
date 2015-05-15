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
    public partial class CMContractorLicenceDataSource
    {
        public Int32 totalRowCount = 0;

        public CMContractorLicenceDataSource()
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
        public IList<CMContractorLicenceEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMContractorLicenceEntity> cMContractorLicenceEntityList = new List<CMContractorLicenceEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorLicenceEntity.FLD_NAME_ContractorLicenceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMContractorLicenceEntityList = FCCCMContractorLicence.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMContractorLicenceEntityList != null && cMContractorLicenceEntityList.Count > 0)
                {
                    totalRowCount = cMContractorLicenceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorLicenceEntityList ?? new List<CMContractorLicenceEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorLicenceEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMContractorLicenceEntity> cMContractorLicenceEntityList = new List<CMContractorLicenceEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMContractorLicenceEntity.FLD_NAME_ContractorLicenceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorLicenceEntityList =  FCCCMContractorLicence.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMContractorLicenceEntityList =  FCCCMContractorLicence.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMContractorLicenceEntityList =  FCCCMContractorLicence.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMContractorLicenceEntityList =  FCCCMContractorLicence.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMContractorLicenceEntityList != null && cMContractorLicenceEntityList.Count > 0)
                {
                    totalRowCount = cMContractorLicenceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMContractorLicenceEntityList ?? new List<CMContractorLicenceEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMContractorLicenceEntity> GetData()
        {
            IList<CMContractorLicenceEntity> cMContractorLicenceEntityList = new List<CMContractorLicenceEntity>();
            
            try
            {
                cMContractorLicenceEntityList = FCCCMContractorLicence.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMContractorLicenceEntityList != null && cMContractorLicenceEntityList.Count > 0)
                {
                    totalRowCount = cMContractorLicenceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMContractorLicenceEntityList ?? new List<CMContractorLicenceEntity>();
        }
    }
}
