// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class MDCriterionCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDCriterionCategoryDataSource()
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
        public IList<MDCriterionCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDCriterionCategoryEntity> mDCriterionCategoryEntityList = new List<MDCriterionCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDCriterionCategoryEntity.FLD_NAME_CriterionCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDCriterionCategoryEntityList = FCCMDCriterionCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDCriterionCategoryEntityList != null && mDCriterionCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDCriterionCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDCriterionCategoryEntityList ?? new List<MDCriterionCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDCriterionCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDCriterionCategoryEntity> mDCriterionCategoryEntityList = new List<MDCriterionCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDCriterionCategoryEntity.FLD_NAME_CriterionCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDCriterionCategoryEntityList =  FCCMDCriterionCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDCriterionCategoryEntityList =  FCCMDCriterionCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDCriterionCategoryEntityList =  FCCMDCriterionCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDCriterionCategoryEntityList =  FCCMDCriterionCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDCriterionCategoryEntityList != null && mDCriterionCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDCriterionCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDCriterionCategoryEntityList ?? new List<MDCriterionCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDCriterionCategoryEntity> GetData()
        {
            IList<MDCriterionCategoryEntity> mDCriterionCategoryEntityList = new List<MDCriterionCategoryEntity>();
            
            try
            {
                mDCriterionCategoryEntityList = FCCMDCriterionCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDCriterionCategoryEntityList != null && mDCriterionCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDCriterionCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDCriterionCategoryEntityList ?? new List<MDCriterionCategoryEntity>();
        }
    }
}
