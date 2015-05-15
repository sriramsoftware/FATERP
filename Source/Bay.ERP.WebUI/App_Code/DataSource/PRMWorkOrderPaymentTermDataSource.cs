// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
    public partial class PRMWorkOrderPaymentTermDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMWorkOrderPaymentTermDataSource()
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
        public IList<PRMWorkOrderPaymentTermEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList = new List<PRMWorkOrderPaymentTermEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMWorkOrderPaymentTermEntity.FLD_NAME_WorkOrderPaymentTermID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMWorkOrderPaymentTermEntityList = FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMWorkOrderPaymentTermEntityList != null && pRMWorkOrderPaymentTermEntityList.Count > 0)
                {
                    totalRowCount = pRMWorkOrderPaymentTermEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMWorkOrderPaymentTermEntityList ?? new List<PRMWorkOrderPaymentTermEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMWorkOrderPaymentTermEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList = new List<PRMWorkOrderPaymentTermEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMWorkOrderPaymentTermEntity.FLD_NAME_WorkOrderPaymentTermID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMWorkOrderPaymentTermEntityList =  FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMWorkOrderPaymentTermEntityList =  FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMWorkOrderPaymentTermEntityList =  FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMWorkOrderPaymentTermEntityList =  FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMWorkOrderPaymentTermEntityList != null && pRMWorkOrderPaymentTermEntityList.Count > 0)
                {
                    totalRowCount = pRMWorkOrderPaymentTermEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMWorkOrderPaymentTermEntityList ?? new List<PRMWorkOrderPaymentTermEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMWorkOrderPaymentTermEntity> GetData()
        {
            IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList = new List<PRMWorkOrderPaymentTermEntity>();
            
            try
            {
                pRMWorkOrderPaymentTermEntityList = FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMWorkOrderPaymentTermEntityList != null && pRMWorkOrderPaymentTermEntityList.Count > 0)
                {
                    totalRowCount = pRMWorkOrderPaymentTermEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMWorkOrderPaymentTermEntityList ?? new List<PRMWorkOrderPaymentTermEntity>();
        }
    }
}