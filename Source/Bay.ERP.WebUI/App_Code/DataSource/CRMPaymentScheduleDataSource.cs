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
    public partial class CRMPaymentScheduleDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMPaymentScheduleDataSource()
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
        public IList<CRMPaymentScheduleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList = new List<CRMPaymentScheduleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMPaymentScheduleEntity.FLD_NAME_PaymentScheduleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMPaymentScheduleEntityList = FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMPaymentScheduleEntityList != null && cRMPaymentScheduleEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentScheduleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMPaymentScheduleEntityList ?? new List<CRMPaymentScheduleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMPaymentScheduleEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList = new List<CRMPaymentScheduleEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMPaymentScheduleEntity.FLD_NAME_PaymentScheduleID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMPaymentScheduleEntityList =  FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMPaymentScheduleEntityList =  FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMPaymentScheduleEntityList =  FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMPaymentScheduleEntityList =  FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMPaymentScheduleEntityList != null && cRMPaymentScheduleEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentScheduleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMPaymentScheduleEntityList ?? new List<CRMPaymentScheduleEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMPaymentScheduleEntity> GetData()
        {
            IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList = new List<CRMPaymentScheduleEntity>();
            
            try
            {
                cRMPaymentScheduleEntityList = FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMPaymentScheduleEntityList != null && cRMPaymentScheduleEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentScheduleEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMPaymentScheduleEntityList ?? new List<CRMPaymentScheduleEntity>();
        }
    }
}
