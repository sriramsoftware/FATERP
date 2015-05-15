// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    public partial class MDFloorUnitLocationCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDFloorUnitLocationCategoryDataSource()
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
        public IList<MDFloorUnitLocationCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList = new List<MDFloorUnitLocationCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDFloorUnitLocationCategoryEntity.FLD_NAME_FloorUnitLocationCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDFloorUnitLocationCategoryEntityList = FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDFloorUnitLocationCategoryEntityList != null && mDFloorUnitLocationCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDFloorUnitLocationCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDFloorUnitLocationCategoryEntityList ?? new List<MDFloorUnitLocationCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDFloorUnitLocationCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList = new List<MDFloorUnitLocationCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDFloorUnitLocationCategoryEntity.FLD_NAME_FloorUnitLocationCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDFloorUnitLocationCategoryEntityList =  FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDFloorUnitLocationCategoryEntityList =  FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDFloorUnitLocationCategoryEntityList =  FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDFloorUnitLocationCategoryEntityList =  FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDFloorUnitLocationCategoryEntityList != null && mDFloorUnitLocationCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDFloorUnitLocationCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDFloorUnitLocationCategoryEntityList ?? new List<MDFloorUnitLocationCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDFloorUnitLocationCategoryEntity> GetData()
        {
            IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList = new List<MDFloorUnitLocationCategoryEntity>();
            
            try
            {
                mDFloorUnitLocationCategoryEntityList = FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDFloorUnitLocationCategoryEntityList != null && mDFloorUnitLocationCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDFloorUnitLocationCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDFloorUnitLocationCategoryEntityList ?? new List<MDFloorUnitLocationCategoryEntity>();
        }
    }
}
