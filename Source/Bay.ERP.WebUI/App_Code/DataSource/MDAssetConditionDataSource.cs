// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    public partial class MDAssetConditionDataSource
    {
        public Int32 totalRowCount = 0;

        public MDAssetConditionDataSource()
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
        public IList<MDAssetConditionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDAssetConditionEntity> mDAssetConditionEntityList = new List<MDAssetConditionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDAssetConditionEntity.FLD_NAME_AssetConditionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDAssetConditionEntityList = FCCMDAssetCondition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDAssetConditionEntityList != null && mDAssetConditionEntityList.Count > 0)
                {
                    totalRowCount = mDAssetConditionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDAssetConditionEntityList ?? new List<MDAssetConditionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDAssetConditionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDAssetConditionEntity> mDAssetConditionEntityList = new List<MDAssetConditionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDAssetConditionEntity.FLD_NAME_AssetConditionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDAssetConditionEntityList =  FCCMDAssetCondition.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDAssetConditionEntityList =  FCCMDAssetCondition.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDAssetConditionEntityList =  FCCMDAssetCondition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDAssetConditionEntityList =  FCCMDAssetCondition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDAssetConditionEntityList != null && mDAssetConditionEntityList.Count > 0)
                {
                    totalRowCount = mDAssetConditionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDAssetConditionEntityList ?? new List<MDAssetConditionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDAssetConditionEntity> GetData()
        {
            IList<MDAssetConditionEntity> mDAssetConditionEntityList = new List<MDAssetConditionEntity>();
            
            try
            {
                mDAssetConditionEntityList = FCCMDAssetCondition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDAssetConditionEntityList != null && mDAssetConditionEntityList.Count > 0)
                {
                    totalRowCount = mDAssetConditionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDAssetConditionEntityList ?? new List<MDAssetConditionEntity>();
        }
    }
}
