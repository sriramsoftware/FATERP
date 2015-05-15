// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 01:00:46




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
    public partial class PRMBOQFloorDetailDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMBOQFloorDetailDataSource()
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
        public IList<PRMBOQFloorDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList = new List<PRMBOQFloorDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMBOQFloorDetailEntityList = FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMBOQFloorDetailEntityList != null && pRMBOQFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = pRMBOQFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMBOQFloorDetailEntityList ?? new List<PRMBOQFloorDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMBOQFloorDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList = new List<PRMBOQFloorDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMBOQFloorDetailEntityList =  FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMBOQFloorDetailEntityList =  FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMBOQFloorDetailEntityList =  FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMBOQFloorDetailEntityList =  FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMBOQFloorDetailEntityList != null && pRMBOQFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = pRMBOQFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMBOQFloorDetailEntityList ?? new List<PRMBOQFloorDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMBOQFloorDetailEntity> GetData()
        {
            IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList = new List<PRMBOQFloorDetailEntity>();
            
            try
            {
                pRMBOQFloorDetailEntityList = FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMBOQFloorDetailEntityList != null && pRMBOQFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = pRMBOQFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMBOQFloorDetailEntityList ?? new List<PRMBOQFloorDetailEntity>();
        }
    }
}
