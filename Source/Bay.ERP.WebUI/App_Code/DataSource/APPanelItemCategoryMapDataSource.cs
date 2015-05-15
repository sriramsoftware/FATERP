// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APPanelItemCategoryMapDataSource
    {
        public Int32 totalRowCount = 0;

        public APPanelItemCategoryMapDataSource()
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
        public IList<APPanelItemCategoryMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APPanelItemCategoryMapEntity> aPPanelItemCategoryMapEntityList = new List<APPanelItemCategoryMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APPanelItemCategoryMapEntity.FLD_NAME_APPanelItemCategoryMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPPanelItemCategoryMapEntityList = FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPPanelItemCategoryMapEntityList != null && aPPanelItemCategoryMapEntityList.Count > 0)
                {
                    totalRowCount = aPPanelItemCategoryMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPPanelItemCategoryMapEntityList ?? new List<APPanelItemCategoryMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelItemCategoryMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APPanelItemCategoryMapEntity> aPPanelItemCategoryMapEntityList = new List<APPanelItemCategoryMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APPanelItemCategoryMapEntity.FLD_NAME_APPanelItemCategoryMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPPanelItemCategoryMapEntityList =  FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPPanelItemCategoryMapEntityList =  FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPPanelItemCategoryMapEntityList =  FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPPanelItemCategoryMapEntityList =  FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPPanelItemCategoryMapEntityList != null && aPPanelItemCategoryMapEntityList.Count > 0)
                {
                    totalRowCount = aPPanelItemCategoryMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPPanelItemCategoryMapEntityList ?? new List<APPanelItemCategoryMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelItemCategoryMapEntity> GetData()
        {
            IList<APPanelItemCategoryMapEntity> aPPanelItemCategoryMapEntityList = new List<APPanelItemCategoryMapEntity>();
            
            try
            {
                aPPanelItemCategoryMapEntityList = FCCAPPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPPanelItemCategoryMapEntityList != null && aPPanelItemCategoryMapEntityList.Count > 0)
                {
                    totalRowCount = aPPanelItemCategoryMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPPanelItemCategoryMapEntityList ?? new List<APPanelItemCategoryMapEntity>();
        }
    }
}
