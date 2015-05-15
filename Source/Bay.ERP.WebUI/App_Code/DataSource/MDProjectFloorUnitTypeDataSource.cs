// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 03:04:35




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
    public partial class MDProjectFloorUnitTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDProjectFloorUnitTypeDataSource()
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
        public IList<MDProjectFloorUnitTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDProjectFloorUnitTypeEntity> mDProjectFloorUnitTypeEntityList = new List<MDProjectFloorUnitTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDProjectFloorUnitTypeEntity.FLD_NAME_ProjectFloorUnitTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDProjectFloorUnitTypeEntityList = FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDProjectFloorUnitTypeEntityList != null && mDProjectFloorUnitTypeEntityList.Count > 0)
                {
                    totalRowCount = mDProjectFloorUnitTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDProjectFloorUnitTypeEntityList ?? new List<MDProjectFloorUnitTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDProjectFloorUnitTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDProjectFloorUnitTypeEntity> mDProjectFloorUnitTypeEntityList = new List<MDProjectFloorUnitTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDProjectFloorUnitTypeEntity.FLD_NAME_ProjectFloorUnitTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDProjectFloorUnitTypeEntityList =  FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDProjectFloorUnitTypeEntityList =  FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDProjectFloorUnitTypeEntityList =  FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDProjectFloorUnitTypeEntityList =  FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDProjectFloorUnitTypeEntityList != null && mDProjectFloorUnitTypeEntityList.Count > 0)
                {
                    totalRowCount = mDProjectFloorUnitTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDProjectFloorUnitTypeEntityList ?? new List<MDProjectFloorUnitTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDProjectFloorUnitTypeEntity> GetData()
        {
            IList<MDProjectFloorUnitTypeEntity> mDProjectFloorUnitTypeEntityList = new List<MDProjectFloorUnitTypeEntity>();
            
            try
            {
                mDProjectFloorUnitTypeEntityList = FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDProjectFloorUnitTypeEntityList != null && mDProjectFloorUnitTypeEntityList.Count > 0)
                {
                    totalRowCount = mDProjectFloorUnitTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDProjectFloorUnitTypeEntityList ?? new List<MDProjectFloorUnitTypeEntity>();
        }
    }
}
