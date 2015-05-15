// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class MDItemGroupDataSource
    {
        public Int32 totalRowCount = 0;

        public MDItemGroupDataSource()
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
        public IList<MDItemGroupEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDItemGroupEntity> mDItemGroupEntityList = new List<MDItemGroupEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDItemGroupEntity.FLD_NAME_ItemGroupID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDItemGroupEntityList = FCCMDItemGroup.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDItemGroupEntityList != null && mDItemGroupEntityList.Count > 0)
                {
                    totalRowCount = mDItemGroupEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDItemGroupEntityList ?? new List<MDItemGroupEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDItemGroupEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDItemGroupEntity> mDItemGroupEntityList = new List<MDItemGroupEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDItemGroupEntity.FLD_NAME_ItemGroupID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDItemGroupEntityList =  FCCMDItemGroup.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDItemGroupEntityList =  FCCMDItemGroup.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDItemGroupEntityList =  FCCMDItemGroup.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDItemGroupEntityList =  FCCMDItemGroup.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDItemGroupEntityList != null && mDItemGroupEntityList.Count > 0)
                {
                    totalRowCount = mDItemGroupEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDItemGroupEntityList ?? new List<MDItemGroupEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDItemGroupEntity> GetData()
        {
            IList<MDItemGroupEntity> mDItemGroupEntityList = new List<MDItemGroupEntity>();
            
            try
            {
                mDItemGroupEntityList = FCCMDItemGroup.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDItemGroupEntityList != null && mDItemGroupEntityList.Count > 0)
                {
                    totalRowCount = mDItemGroupEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDItemGroupEntityList ?? new List<MDItemGroupEntity>();
        }
    }
}
