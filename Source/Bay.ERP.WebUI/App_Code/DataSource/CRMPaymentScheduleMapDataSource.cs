// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




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
    public partial class CRMPaymentScheduleMapDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMPaymentScheduleMapDataSource()
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
        public IList<CRMPaymentScheduleMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList = new List<CRMPaymentScheduleMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMPaymentScheduleMapEntityList = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMPaymentScheduleMapEntityList != null && cRMPaymentScheduleMapEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentScheduleMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMPaymentScheduleMapEntityList ?? new List<CRMPaymentScheduleMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMPaymentScheduleMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList = new List<CRMPaymentScheduleMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID + " " + SQLConstants.SORT_ORDER_ASCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMPaymentScheduleMapEntityList =  FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMPaymentScheduleMapEntityList =  FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMPaymentScheduleMapEntityList =  FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMPaymentScheduleMapEntityList =  FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMPaymentScheduleMapEntityList != null && cRMPaymentScheduleMapEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentScheduleMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMPaymentScheduleMapEntityList ?? new List<CRMPaymentScheduleMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMPaymentScheduleMapEntity> GetData()
        {
            IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList = new List<CRMPaymentScheduleMapEntity>();
            
            try
            {
                cRMPaymentScheduleMapEntityList = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMPaymentScheduleMapEntityList != null && cRMPaymentScheduleMapEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentScheduleMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMPaymentScheduleMapEntityList ?? new List<CRMPaymentScheduleMapEntity>();
        }
    }
}
