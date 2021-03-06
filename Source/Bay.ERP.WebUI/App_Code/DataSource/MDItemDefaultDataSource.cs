// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class MDItemDefaultDataSource
    {
        public Int32 totalRowCount = 0;

        public MDItemDefaultDataSource()
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
        public IList<MDItemDefaultEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDItemDefaultEntity> mDItemDefaultEntityList = new List<MDItemDefaultEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDItemDefaultEntity.FLD_NAME_ItemDefaultID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDItemDefaultEntityList = FCCMDItemDefault.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDItemDefaultEntityList != null && mDItemDefaultEntityList.Count > 0)
                {
                    totalRowCount = mDItemDefaultEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDItemDefaultEntityList ?? new List<MDItemDefaultEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDItemDefaultEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDItemDefaultEntity> mDItemDefaultEntityList = new List<MDItemDefaultEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDItemDefaultEntity.FLD_NAME_ItemDefaultID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDItemDefaultEntityList =  FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDItemDefaultEntityList =  FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDItemDefaultEntityList =  FCCMDItemDefault.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDItemDefaultEntityList =  FCCMDItemDefault.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDItemDefaultEntityList != null && mDItemDefaultEntityList.Count > 0)
                {
                    totalRowCount = mDItemDefaultEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDItemDefaultEntityList ?? new List<MDItemDefaultEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDItemDefaultEntity> GetData()
        {
            IList<MDItemDefaultEntity> mDItemDefaultEntityList = new List<MDItemDefaultEntity>();
            
            try
            {
                mDItemDefaultEntityList = FCCMDItemDefault.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDItemDefaultEntityList != null && mDItemDefaultEntityList.Count > 0)
                {
                    totalRowCount = mDItemDefaultEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDItemDefaultEntityList ?? new List<MDItemDefaultEntity>();
        }
    }
}
