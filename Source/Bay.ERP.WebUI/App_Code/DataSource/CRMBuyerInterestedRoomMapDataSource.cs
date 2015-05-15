// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMBuyerInterestedRoomMapDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMBuyerInterestedRoomMapDataSource()
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
        public IList<CRMBuyerInterestedRoomMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList = new List<CRMBuyerInterestedRoomMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerInterestedRoomMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMBuyerInterestedRoomMapEntityList = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMBuyerInterestedRoomMapEntityList != null && cRMBuyerInterestedRoomMapEntityList.Count > 0)
                {
                    totalRowCount = cRMBuyerInterestedRoomMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMBuyerInterestedRoomMapEntityList ?? new List<CRMBuyerInterestedRoomMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMBuyerInterestedRoomMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList = new List<CRMBuyerInterestedRoomMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerInterestedRoomMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMBuyerInterestedRoomMapEntityList =  FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMBuyerInterestedRoomMapEntityList =  FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMBuyerInterestedRoomMapEntityList =  FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMBuyerInterestedRoomMapEntityList =  FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMBuyerInterestedRoomMapEntityList != null && cRMBuyerInterestedRoomMapEntityList.Count > 0)
                {
                    totalRowCount = cRMBuyerInterestedRoomMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMBuyerInterestedRoomMapEntityList ?? new List<CRMBuyerInterestedRoomMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMBuyerInterestedRoomMapEntity> GetData()
        {
            IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList = new List<CRMBuyerInterestedRoomMapEntity>();
            
            try
            {
                cRMBuyerInterestedRoomMapEntityList = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMBuyerInterestedRoomMapEntityList != null && cRMBuyerInterestedRoomMapEntityList.Count > 0)
                {
                    totalRowCount = cRMBuyerInterestedRoomMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMBuyerInterestedRoomMapEntityList ?? new List<CRMBuyerInterestedRoomMapEntity>();
        }
    }
}
