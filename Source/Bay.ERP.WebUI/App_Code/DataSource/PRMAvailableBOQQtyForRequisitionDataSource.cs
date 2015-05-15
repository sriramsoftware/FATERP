// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 12:21:34




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
    public partial class PRMAvailableBOQQtyForRequisitionDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMAvailableBOQQtyForRequisitionDataSource()
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
        public IList<PRMAvailableBOQQtyForRequisitionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList = new List<PRMAvailableBOQQtyForRequisitionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMAvailableBOQQtyForRequisitionEntity.FLD_NAME_AvailableBOQQtyForRequisitionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMAvailableBOQQtyForRequisitionEntityList = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMAvailableBOQQtyForRequisitionEntityList != null && pRMAvailableBOQQtyForRequisitionEntityList.Count > 0)
                {
                    totalRowCount = pRMAvailableBOQQtyForRequisitionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMAvailableBOQQtyForRequisitionEntityList ?? new List<PRMAvailableBOQQtyForRequisitionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMAvailableBOQQtyForRequisitionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList = new List<PRMAvailableBOQQtyForRequisitionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMAvailableBOQQtyForRequisitionEntity.FLD_NAME_AvailableBOQQtyForRequisitionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMAvailableBOQQtyForRequisitionEntityList =  FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMAvailableBOQQtyForRequisitionEntityList =  FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMAvailableBOQQtyForRequisitionEntityList =  FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMAvailableBOQQtyForRequisitionEntityList =  FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMAvailableBOQQtyForRequisitionEntityList != null && pRMAvailableBOQQtyForRequisitionEntityList.Count > 0)
                {
                    totalRowCount = pRMAvailableBOQQtyForRequisitionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMAvailableBOQQtyForRequisitionEntityList ?? new List<PRMAvailableBOQQtyForRequisitionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMAvailableBOQQtyForRequisitionEntity> GetData()
        {
            IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList = new List<PRMAvailableBOQQtyForRequisitionEntity>();
            
            try
            {
                pRMAvailableBOQQtyForRequisitionEntityList = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMAvailableBOQQtyForRequisitionEntityList != null && pRMAvailableBOQQtyForRequisitionEntityList.Count > 0)
                {
                    totalRowCount = pRMAvailableBOQQtyForRequisitionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMAvailableBOQQtyForRequisitionEntityList ?? new List<PRMAvailableBOQQtyForRequisitionEntity>();
        }
    }
}
