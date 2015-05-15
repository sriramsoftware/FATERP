// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 09-May-2013, 03:37:43




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
    public partial class CRMBuyerChildrenInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMBuyerChildrenInfoDataSource()
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
        public IList<CRMBuyerChildrenInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList = new List<CRMBuyerChildrenInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMBuyerChildrenInfoEntity.FLD_NAME_BuyerChildrenInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMBuyerChildrenInfoEntityList = FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMBuyerChildrenInfoEntityList != null && cRMBuyerChildrenInfoEntityList.Count > 0)
                {
                    totalRowCount = cRMBuyerChildrenInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMBuyerChildrenInfoEntityList ?? new List<CRMBuyerChildrenInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMBuyerChildrenInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList = new List<CRMBuyerChildrenInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMBuyerChildrenInfoEntity.FLD_NAME_BuyerChildrenInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMBuyerChildrenInfoEntityList =  FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMBuyerChildrenInfoEntityList =  FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMBuyerChildrenInfoEntityList =  FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMBuyerChildrenInfoEntityList =  FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMBuyerChildrenInfoEntityList != null && cRMBuyerChildrenInfoEntityList.Count > 0)
                {
                    totalRowCount = cRMBuyerChildrenInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMBuyerChildrenInfoEntityList ?? new List<CRMBuyerChildrenInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMBuyerChildrenInfoEntity> GetData()
        {
            IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList = new List<CRMBuyerChildrenInfoEntity>();
            
            try
            {
                cRMBuyerChildrenInfoEntityList = FCCCRMBuyerChildrenInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMBuyerChildrenInfoEntityList != null && cRMBuyerChildrenInfoEntityList.Count > 0)
                {
                    totalRowCount = cRMBuyerChildrenInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMBuyerChildrenInfoEntityList ?? new List<CRMBuyerChildrenInfoEntity>();
        }
    }
}
