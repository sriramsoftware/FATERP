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
    public partial class PRMSupplierContactPersonDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMSupplierContactPersonDataSource()
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
        public IList<PRMSupplierContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMSupplierContactPersonEntity> pRMSupplierContactPersonEntityList = new List<PRMSupplierContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMSupplierContactPersonEntity.FLD_NAME_SupplierContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMSupplierContactPersonEntityList = FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMSupplierContactPersonEntityList != null && pRMSupplierContactPersonEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMSupplierContactPersonEntityList ?? new List<PRMSupplierContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMSupplierContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMSupplierContactPersonEntity> pRMSupplierContactPersonEntityList = new List<PRMSupplierContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMSupplierContactPersonEntity.FLD_NAME_SupplierContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMSupplierContactPersonEntityList =  FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMSupplierContactPersonEntityList =  FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMSupplierContactPersonEntityList =  FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMSupplierContactPersonEntityList =  FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMSupplierContactPersonEntityList != null && pRMSupplierContactPersonEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMSupplierContactPersonEntityList ?? new List<PRMSupplierContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMSupplierContactPersonEntity> GetData()
        {
            IList<PRMSupplierContactPersonEntity> pRMSupplierContactPersonEntityList = new List<PRMSupplierContactPersonEntity>();
            
            try
            {
                pRMSupplierContactPersonEntityList = FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMSupplierContactPersonEntityList != null && pRMSupplierContactPersonEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMSupplierContactPersonEntityList ?? new List<PRMSupplierContactPersonEntity>();
        }
    }
}
