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
    public partial class CRMMDPaymentApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDPaymentApprovalStatusDataSource()
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
        public IList<CRMMDPaymentApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDPaymentApprovalStatusEntity> cRMMDPaymentApprovalStatusEntityList = new List<CRMMDPaymentApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDPaymentApprovalStatusEntity.FLD_NAME_PaymentApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDPaymentApprovalStatusEntityList = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDPaymentApprovalStatusEntityList != null && cRMMDPaymentApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = cRMMDPaymentApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDPaymentApprovalStatusEntityList ?? new List<CRMMDPaymentApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDPaymentApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDPaymentApprovalStatusEntity> cRMMDPaymentApprovalStatusEntityList = new List<CRMMDPaymentApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDPaymentApprovalStatusEntity.FLD_NAME_PaymentApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDPaymentApprovalStatusEntityList =  FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDPaymentApprovalStatusEntityList =  FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDPaymentApprovalStatusEntityList =  FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDPaymentApprovalStatusEntityList =  FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDPaymentApprovalStatusEntityList != null && cRMMDPaymentApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = cRMMDPaymentApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDPaymentApprovalStatusEntityList ?? new List<CRMMDPaymentApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDPaymentApprovalStatusEntity> GetData()
        {
            IList<CRMMDPaymentApprovalStatusEntity> cRMMDPaymentApprovalStatusEntityList = new List<CRMMDPaymentApprovalStatusEntity>();
            
            try
            {
                cRMMDPaymentApprovalStatusEntityList = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDPaymentApprovalStatusEntityList != null && cRMMDPaymentApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = cRMMDPaymentApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDPaymentApprovalStatusEntityList ?? new List<CRMMDPaymentApprovalStatusEntity>();
        }
    }
}
