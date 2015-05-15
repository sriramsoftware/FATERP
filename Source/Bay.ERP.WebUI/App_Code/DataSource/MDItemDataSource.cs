// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
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
    public partial class MDItemDataSource
    {
        public Int32 totalRowCount = 0;

        public MDItemDataSource()
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
        public IList<MDItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDItemEntity> mDItemEntityList = new List<MDItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDItemEntity.FLD_NAME_ItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDItemEntityList = FCCMDItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDItemEntityList != null && mDItemEntityList.Count > 0)
                {
                    totalRowCount = mDItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDItemEntityList ?? new List<MDItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDItemEntity> mDItemEntityList = new List<MDItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDItemEntity.FLD_NAME_ItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDItemEntityList =  FCCMDItem.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDItemEntityList =  FCCMDItem.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDItemEntityList =  FCCMDItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDItemEntityList =  FCCMDItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDItemEntityList != null && mDItemEntityList.Count > 0)
                {
                    totalRowCount = mDItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDItemEntityList ?? new List<MDItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDItemEntity> GetData()
        {
            IList<MDItemEntity> mDItemEntityList = new List<MDItemEntity>();
            
            try
            {
                mDItemEntityList = FCCMDItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDItemEntityList != null && mDItemEntityList.Count > 0)
                {
                    totalRowCount = mDItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDItemEntityList ?? new List<MDItemEntity>();
        }
    }
}
