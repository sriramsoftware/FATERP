// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public partial class MDEvaluationSessionCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDEvaluationSessionCategoryDataSource()
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
        public IList<MDEvaluationSessionCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDEvaluationSessionCategoryEntity> mDEvaluationSessionCategoryEntityList = new List<MDEvaluationSessionCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEvaluationSessionCategoryEntity.FLD_NAME_SessionCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDEvaluationSessionCategoryEntityList = FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDEvaluationSessionCategoryEntityList != null && mDEvaluationSessionCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDEvaluationSessionCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEvaluationSessionCategoryEntityList ?? new List<MDEvaluationSessionCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEvaluationSessionCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDEvaluationSessionCategoryEntity> mDEvaluationSessionCategoryEntityList = new List<MDEvaluationSessionCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEvaluationSessionCategoryEntity.FLD_NAME_SessionCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEvaluationSessionCategoryEntityList =  FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDEvaluationSessionCategoryEntityList =  FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEvaluationSessionCategoryEntityList =  FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDEvaluationSessionCategoryEntityList =  FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDEvaluationSessionCategoryEntityList != null && mDEvaluationSessionCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDEvaluationSessionCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEvaluationSessionCategoryEntityList ?? new List<MDEvaluationSessionCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEvaluationSessionCategoryEntity> GetData()
        {
            IList<MDEvaluationSessionCategoryEntity> mDEvaluationSessionCategoryEntityList = new List<MDEvaluationSessionCategoryEntity>();
            
            try
            {
                mDEvaluationSessionCategoryEntityList = FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDEvaluationSessionCategoryEntityList != null && mDEvaluationSessionCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDEvaluationSessionCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDEvaluationSessionCategoryEntityList ?? new List<MDEvaluationSessionCategoryEntity>();
        }
    }
}
