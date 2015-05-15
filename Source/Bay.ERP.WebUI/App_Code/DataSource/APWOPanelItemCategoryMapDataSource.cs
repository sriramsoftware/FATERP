// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 06-Oct-2012, 10:59:14




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
    public partial class APWOPanelItemCategoryMapDataSource
    {
        public Int32 totalRowCount = 0;

        public APWOPanelItemCategoryMapDataSource()
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
        public IList<APWOPanelItemCategoryMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APWOPanelItemCategoryMapEntity> aPWOPanelItemCategoryMapEntityList = new List<APWOPanelItemCategoryMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APWOPanelItemCategoryMapEntity.FLD_NAME_APWOPanelItemCategoryMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPWOPanelItemCategoryMapEntityList = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPWOPanelItemCategoryMapEntityList != null && aPWOPanelItemCategoryMapEntityList.Count > 0)
                {
                    totalRowCount = aPWOPanelItemCategoryMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPWOPanelItemCategoryMapEntityList ?? new List<APWOPanelItemCategoryMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APWOPanelItemCategoryMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APWOPanelItemCategoryMapEntity> aPWOPanelItemCategoryMapEntityList = new List<APWOPanelItemCategoryMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APWOPanelItemCategoryMapEntity.FLD_NAME_APWOPanelItemCategoryMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPWOPanelItemCategoryMapEntityList =  FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPWOPanelItemCategoryMapEntityList =  FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPWOPanelItemCategoryMapEntityList =  FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPWOPanelItemCategoryMapEntityList =  FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPWOPanelItemCategoryMapEntityList != null && aPWOPanelItemCategoryMapEntityList.Count > 0)
                {
                    totalRowCount = aPWOPanelItemCategoryMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPWOPanelItemCategoryMapEntityList ?? new List<APWOPanelItemCategoryMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APWOPanelItemCategoryMapEntity> GetData()
        {
            IList<APWOPanelItemCategoryMapEntity> aPWOPanelItemCategoryMapEntityList = new List<APWOPanelItemCategoryMapEntity>();
            
            try
            {
                aPWOPanelItemCategoryMapEntityList = FCCAPWOPanelItemCategoryMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPWOPanelItemCategoryMapEntityList != null && aPWOPanelItemCategoryMapEntityList.Count > 0)
                {
                    totalRowCount = aPWOPanelItemCategoryMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPWOPanelItemCategoryMapEntityList ?? new List<APWOPanelItemCategoryMapEntity>();
        }
    }
}
