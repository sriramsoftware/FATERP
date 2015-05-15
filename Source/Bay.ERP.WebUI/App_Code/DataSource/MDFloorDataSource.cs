// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 02:43:38




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
    public partial class MDFloorDataSource
    {
        public Int32 totalRowCount = 0;

        public MDFloorDataSource()
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
        public IList<MDFloorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDFloorEntity> mDFloorEntityList = new List<MDFloorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDFloorEntity.FLD_NAME_FloorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDFloorEntityList = FCCMDFloor.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDFloorEntityList != null && mDFloorEntityList.Count > 0)
                {
                    totalRowCount = mDFloorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDFloorEntityList ?? new List<MDFloorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDFloorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDFloorEntity> mDFloorEntityList = new List<MDFloorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDFloorEntity.FLD_NAME_FloorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDFloorEntityList =  FCCMDFloor.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDFloorEntityList =  FCCMDFloor.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDFloorEntityList =  FCCMDFloor.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDFloorEntityList =  FCCMDFloor.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDFloorEntityList != null && mDFloorEntityList.Count > 0)
                {
                    totalRowCount = mDFloorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDFloorEntityList ?? new List<MDFloorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDFloorEntity> GetData()
        {
            IList<MDFloorEntity> mDFloorEntityList = new List<MDFloorEntity>();
            
            try
            {
                mDFloorEntityList = FCCMDFloor.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDFloorEntityList != null && mDFloorEntityList.Count > 0)
                {
                    totalRowCount = mDFloorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDFloorEntityList ?? new List<MDFloorEntity>();
        }
    }
}
