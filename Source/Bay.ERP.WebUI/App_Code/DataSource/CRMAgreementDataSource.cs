// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMAgreementDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMAgreementDataSource()
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
        public IList<CRMAgreementEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMAgreementEntity> cRMAgreementEntityList = new List<CRMAgreementEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMAgreementEntity.FLD_NAME_AgreementID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMAgreementEntityList = FCCCRMAgreement.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMAgreementEntityList != null && cRMAgreementEntityList.Count > 0)
                {
                    totalRowCount = cRMAgreementEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMAgreementEntityList ?? new List<CRMAgreementEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMAgreementEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMAgreementEntity> cRMAgreementEntityList = new List<CRMAgreementEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMAgreementEntity.FLD_NAME_AgreementID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMAgreementEntityList =  FCCCRMAgreement.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMAgreementEntityList =  FCCCRMAgreement.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMAgreementEntityList =  FCCCRMAgreement.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMAgreementEntityList =  FCCCRMAgreement.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMAgreementEntityList != null && cRMAgreementEntityList.Count > 0)
                {
                    totalRowCount = cRMAgreementEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMAgreementEntityList ?? new List<CRMAgreementEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMAgreementEntity> GetData()
        {
            IList<CRMAgreementEntity> cRMAgreementEntityList = new List<CRMAgreementEntity>();
            
            try
            {
                cRMAgreementEntityList = FCCCRMAgreement.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMAgreementEntityList != null && cRMAgreementEntityList.Count > 0)
                {
                    totalRowCount = cRMAgreementEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMAgreementEntityList ?? new List<CRMAgreementEntity>();
        }
    }
}
