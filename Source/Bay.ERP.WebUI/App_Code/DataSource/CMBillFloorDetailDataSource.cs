// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    public partial class CMBillFloorDetailDataSource
    {
        public Int32 totalRowCount = 0;

        public CMBillFloorDetailDataSource()
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
        public IList<CMBillFloorDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList = new List<CMBillFloorDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillFloorDetailEntity.FLD_NAME_BillFloorDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMBillFloorDetailEntityList = FCCCMBillFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMBillFloorDetailEntityList != null && cMBillFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = cMBillFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillFloorDetailEntityList ?? new List<CMBillFloorDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillFloorDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList = new List<CMBillFloorDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillFloorDetailEntity.FLD_NAME_BillFloorDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillFloorDetailEntityList =  FCCCMBillFloorDetail.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMBillFloorDetailEntityList =  FCCCMBillFloorDetail.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillFloorDetailEntityList =  FCCCMBillFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMBillFloorDetailEntityList =  FCCCMBillFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMBillFloorDetailEntityList != null && cMBillFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = cMBillFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillFloorDetailEntityList ?? new List<CMBillFloorDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillFloorDetailEntity> GetData()
        {
            IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList = new List<CMBillFloorDetailEntity>();
            
            try
            {
                cMBillFloorDetailEntityList = FCCCMBillFloorDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMBillFloorDetailEntityList != null && cMBillFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = cMBillFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMBillFloorDetailEntityList ?? new List<CMBillFloorDetailEntity>();
        }
    }
}
