// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Nov-2011, 02:22:45




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
    public partial class BDProjectCollectedDocumentCategoryInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectCollectedDocumentCategoryInfoDataSource()
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
        public IList<BDProjectCollectedDocumentCategoryInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectCollectedDocumentCategoryInfoEntity> bDProjectCollectedDocumentCategoryInfoEntityList = new List<BDProjectCollectedDocumentCategoryInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectCollectedDocumentCategoryInfoEntity.FLD_NAME_ProjectCollectedDocumentCategoryInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectCollectedDocumentCategoryInfoEntityList = FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectCollectedDocumentCategoryInfoEntityList != null && bDProjectCollectedDocumentCategoryInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentCategoryInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectCollectedDocumentCategoryInfoEntityList ?? new List<BDProjectCollectedDocumentCategoryInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectCollectedDocumentCategoryInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectCollectedDocumentCategoryInfoEntity> bDProjectCollectedDocumentCategoryInfoEntityList = new List<BDProjectCollectedDocumentCategoryInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectCollectedDocumentCategoryInfoEntity.FLD_NAME_ProjectCollectedDocumentCategoryInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectCollectedDocumentCategoryInfoEntityList =  FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectCollectedDocumentCategoryInfoEntityList =  FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectCollectedDocumentCategoryInfoEntityList =  FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectCollectedDocumentCategoryInfoEntityList =  FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectCollectedDocumentCategoryInfoEntityList != null && bDProjectCollectedDocumentCategoryInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentCategoryInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectCollectedDocumentCategoryInfoEntityList ?? new List<BDProjectCollectedDocumentCategoryInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectCollectedDocumentCategoryInfoEntity> GetData()
        {
            IList<BDProjectCollectedDocumentCategoryInfoEntity> bDProjectCollectedDocumentCategoryInfoEntityList = new List<BDProjectCollectedDocumentCategoryInfoEntity>();
            
            try
            {
                bDProjectCollectedDocumentCategoryInfoEntityList = FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectCollectedDocumentCategoryInfoEntityList != null && bDProjectCollectedDocumentCategoryInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentCategoryInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectCollectedDocumentCategoryInfoEntityList ?? new List<BDProjectCollectedDocumentCategoryInfoEntity>();
        }
    }
}
