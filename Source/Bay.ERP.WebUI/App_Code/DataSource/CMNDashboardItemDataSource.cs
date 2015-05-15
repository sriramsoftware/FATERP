// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




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
    public partial class CMNDashboardItemDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNDashboardItemDataSource()
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
        public IList<CMNDashboardItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNDashboardItemEntity> cMNDashboardItemEntityList = new List<CMNDashboardItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNDashboardItemEntity.FLD_NAME_DashboardItemID + " " + SQLConstants.SORT_ORDER_ASCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNDashboardItemEntityList = FCCCMNDashboardItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNDashboardItemEntityList != null && cMNDashboardItemEntityList.Count > 0)
                {
                    totalRowCount = cMNDashboardItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNDashboardItemEntityList ?? new List<CMNDashboardItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNDashboardItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNDashboardItemEntity> cMNDashboardItemEntityList = new List<CMNDashboardItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNDashboardItemEntity.FLD_NAME_SequenceID + " " + SQLConstants.SORT_ORDER_ASCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNDashboardItemEntityList =  FCCCMNDashboardItem.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNDashboardItemEntityList =  FCCCMNDashboardItem.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNDashboardItemEntityList =  FCCCMNDashboardItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNDashboardItemEntityList =  FCCCMNDashboardItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNDashboardItemEntityList != null && cMNDashboardItemEntityList.Count > 0)
                {
                    totalRowCount = cMNDashboardItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNDashboardItemEntityList ?? new List<CMNDashboardItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNDashboardItemEntity> GetData()
        {
            IList<CMNDashboardItemEntity> cMNDashboardItemEntityList = new List<CMNDashboardItemEntity>();
            
            try
            {
                cMNDashboardItemEntityList = FCCCMNDashboardItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNDashboardItemEntityList != null && cMNDashboardItemEntityList.Count > 0)
                {
                    totalRowCount = cMNDashboardItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNDashboardItemEntityList ?? new List<CMNDashboardItemEntity>();
        }
    }
}
