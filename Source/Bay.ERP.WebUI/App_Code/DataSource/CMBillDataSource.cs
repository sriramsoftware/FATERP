// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




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
    public partial class CMBillDataSource
    {
        public Int32 totalRowCount = 0;

        public CMBillDataSource()
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
        public IList<CMBillEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMBillEntity> cMBillEntityList = new List<CMBillEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillEntity.FLD_NAME_BillID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMBillEntityList = FCCCMBill.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMBillEntityList != null && cMBillEntityList.Count > 0)
                {
                    totalRowCount = cMBillEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillEntityList ?? new List<CMBillEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMBillEntity> cMBillEntityList = new List<CMBillEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillEntity.FLD_NAME_BillID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillEntityList =  FCCCMBill.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMBillEntityList =  FCCCMBill.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillEntityList =  FCCCMBill.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMBillEntityList =  FCCCMBill.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMBillEntityList != null && cMBillEntityList.Count > 0)
                {
                    totalRowCount = cMBillEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillEntityList ?? new List<CMBillEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillEntity> GetData()
        {
            IList<CMBillEntity> cMBillEntityList = new List<CMBillEntity>();
            
            try
            {
                cMBillEntityList = FCCCMBill.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMBillEntityList != null && cMBillEntityList.Count > 0)
                {
                    totalRowCount = cMBillEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMBillEntityList ?? new List<CMBillEntity>();
        }
    }
}
