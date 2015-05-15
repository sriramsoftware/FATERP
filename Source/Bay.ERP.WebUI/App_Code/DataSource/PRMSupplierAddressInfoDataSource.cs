// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    public partial class PRMSupplierAddressInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMSupplierAddressInfoDataSource()
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
        public IList<PRMSupplierAddressInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList = new List<PRMSupplierAddressInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMSupplierAddressInfoEntity.FLD_NAME_SupplierAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMSupplierAddressInfoEntityList = FCCPRMSupplierAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMSupplierAddressInfoEntityList != null && pRMSupplierAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMSupplierAddressInfoEntityList ?? new List<PRMSupplierAddressInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMSupplierAddressInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList = new List<PRMSupplierAddressInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMSupplierAddressInfoEntity.FLD_NAME_SupplierAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMSupplierAddressInfoEntityList =  FCCPRMSupplierAddressInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMSupplierAddressInfoEntityList =  FCCPRMSupplierAddressInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMSupplierAddressInfoEntityList =  FCCPRMSupplierAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMSupplierAddressInfoEntityList =  FCCPRMSupplierAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMSupplierAddressInfoEntityList != null && pRMSupplierAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMSupplierAddressInfoEntityList ?? new List<PRMSupplierAddressInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMSupplierAddressInfoEntity> GetData()
        {
            IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList = new List<PRMSupplierAddressInfoEntity>();
            
            try
            {
                pRMSupplierAddressInfoEntityList = FCCPRMSupplierAddressInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMSupplierAddressInfoEntityList != null && pRMSupplierAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMSupplierAddressInfoEntityList ?? new List<PRMSupplierAddressInfoEntity>();
        }
    }
}
