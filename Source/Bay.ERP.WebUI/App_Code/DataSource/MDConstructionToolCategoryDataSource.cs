// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




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
    public partial class MDConstructionToolCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDConstructionToolCategoryDataSource()
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
        public IList<MDConstructionToolCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDConstructionToolCategoryEntity> mDConstructionToolCategoryEntityList = new List<MDConstructionToolCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDConstructionToolCategoryEntity.FLD_NAME_ConstructionToolCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDConstructionToolCategoryEntityList = FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDConstructionToolCategoryEntityList != null && mDConstructionToolCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDConstructionToolCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDConstructionToolCategoryEntityList ?? new List<MDConstructionToolCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDConstructionToolCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDConstructionToolCategoryEntity> mDConstructionToolCategoryEntityList = new List<MDConstructionToolCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDConstructionToolCategoryEntity.FLD_NAME_ConstructionToolCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDConstructionToolCategoryEntityList =  FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDConstructionToolCategoryEntityList =  FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDConstructionToolCategoryEntityList =  FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDConstructionToolCategoryEntityList =  FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDConstructionToolCategoryEntityList != null && mDConstructionToolCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDConstructionToolCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDConstructionToolCategoryEntityList ?? new List<MDConstructionToolCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDConstructionToolCategoryEntity> GetData()
        {
            IList<MDConstructionToolCategoryEntity> mDConstructionToolCategoryEntityList = new List<MDConstructionToolCategoryEntity>();
            
            try
            {
                mDConstructionToolCategoryEntityList = FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDConstructionToolCategoryEntityList != null && mDConstructionToolCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDConstructionToolCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDConstructionToolCategoryEntityList ?? new List<MDConstructionToolCategoryEntity>();
        }
    }
}
