// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class PRMSupplierItemMapDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMSupplierItemMapDataSource()
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
        public IList<PRMSupplierItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList = new List<PRMSupplierItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMSupplierItemMapEntity.FLD_NAME_SupplierItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMSupplierItemMapEntityList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMSupplierItemMapEntityList != null && pRMSupplierItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMSupplierItemMapEntityList ?? new List<PRMSupplierItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMSupplierItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList = new List<PRMSupplierItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMSupplierItemMapEntity.FLD_NAME_SupplierItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMSupplierItemMapEntityList =  FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMSupplierItemMapEntityList =  FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMSupplierItemMapEntityList =  FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMSupplierItemMapEntityList =  FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMSupplierItemMapEntityList != null && pRMSupplierItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMSupplierItemMapEntityList ?? new List<PRMSupplierItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMSupplierItemMapEntity> GetData()
        {
            IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList = new List<PRMSupplierItemMapEntity>();
            
            try
            {
                pRMSupplierItemMapEntityList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMSupplierItemMapEntityList != null && pRMSupplierItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMSupplierItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMSupplierItemMapEntityList ?? new List<PRMSupplierItemMapEntity>();
        }
    }
}