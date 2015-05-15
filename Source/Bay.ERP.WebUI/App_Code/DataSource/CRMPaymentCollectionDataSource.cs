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
    public partial class CRMPaymentCollectionDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMPaymentCollectionDataSource()
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
        public IList<CRMPaymentCollectionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList = new List<CRMPaymentCollectionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMPaymentCollectionEntity.FLD_NAME_PaymentCollectionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMPaymentCollectionEntityList = FCCCRMPaymentCollection.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMPaymentCollectionEntityList != null && cRMPaymentCollectionEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentCollectionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMPaymentCollectionEntityList ?? new List<CRMPaymentCollectionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMPaymentCollectionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList = new List<CRMPaymentCollectionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMPaymentCollectionEntity.FLD_NAME_PaymentCollectionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMPaymentCollectionEntityList =  FCCCRMPaymentCollection.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMPaymentCollectionEntityList =  FCCCRMPaymentCollection.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMPaymentCollectionEntityList =  FCCCRMPaymentCollection.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMPaymentCollectionEntityList =  FCCCRMPaymentCollection.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMPaymentCollectionEntityList != null && cRMPaymentCollectionEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentCollectionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMPaymentCollectionEntityList ?? new List<CRMPaymentCollectionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMPaymentCollectionEntity> GetData()
        {
            IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList = new List<CRMPaymentCollectionEntity>();
            
            try
            {
                cRMPaymentCollectionEntityList = FCCCRMPaymentCollection.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMPaymentCollectionEntityList != null && cRMPaymentCollectionEntityList.Count > 0)
                {
                    totalRowCount = cRMPaymentCollectionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMPaymentCollectionEntityList ?? new List<CRMPaymentCollectionEntity>();
        }
    }
}
