// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class CRMCustomerDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMCustomerDataSource()
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
        public IList<CRMCustomerEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMCustomerEntity> cRMCustomerEntityList = new List<CRMCustomerEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMCustomerEntity.FLD_NAME_CustomerID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMCustomerEntityList = FCCCRMCustomer.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMCustomerEntityList != null && cRMCustomerEntityList.Count > 0)
                {
                    totalRowCount = cRMCustomerEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMCustomerEntityList ?? new List<CRMCustomerEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMCustomerEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMCustomerEntity> cRMCustomerEntityList = new List<CRMCustomerEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMCustomerEntity.FLD_NAME_CustomerID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMCustomerEntityList =  FCCCRMCustomer.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMCustomerEntityList =  FCCCRMCustomer.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMCustomerEntityList =  FCCCRMCustomer.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMCustomerEntityList =  FCCCRMCustomer.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMCustomerEntityList != null && cRMCustomerEntityList.Count > 0)
                {
                    totalRowCount = cRMCustomerEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMCustomerEntityList ?? new List<CRMCustomerEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMCustomerEntity> GetData()
        {
            IList<CRMCustomerEntity> cRMCustomerEntityList = new List<CRMCustomerEntity>();
            
            try
            {
                cRMCustomerEntityList = FCCCRMCustomer.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMCustomerEntityList != null && cRMCustomerEntityList.Count > 0)
                {
                    totalRowCount = cRMCustomerEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMCustomerEntityList ?? new List<CRMCustomerEntity>();
        }
    }
}
