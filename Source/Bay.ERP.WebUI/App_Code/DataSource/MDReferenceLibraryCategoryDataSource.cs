// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    public partial class MDReferenceLibraryCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDReferenceLibraryCategoryDataSource()
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
        public IList<MDReferenceLibraryCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDReferenceLibraryCategoryEntity> mDReferenceLibraryCategoryEntityList = new List<MDReferenceLibraryCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDReferenceLibraryCategoryEntity.FLD_NAME_ReferenceLibraryCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDReferenceLibraryCategoryEntityList = FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDReferenceLibraryCategoryEntityList != null && mDReferenceLibraryCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDReferenceLibraryCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDReferenceLibraryCategoryEntityList ?? new List<MDReferenceLibraryCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDReferenceLibraryCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDReferenceLibraryCategoryEntity> mDReferenceLibraryCategoryEntityList = new List<MDReferenceLibraryCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDReferenceLibraryCategoryEntity.FLD_NAME_ReferenceLibraryCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDReferenceLibraryCategoryEntityList =  FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDReferenceLibraryCategoryEntityList =  FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDReferenceLibraryCategoryEntityList =  FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDReferenceLibraryCategoryEntityList =  FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDReferenceLibraryCategoryEntityList != null && mDReferenceLibraryCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDReferenceLibraryCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDReferenceLibraryCategoryEntityList ?? new List<MDReferenceLibraryCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDReferenceLibraryCategoryEntity> GetData()
        {
            IList<MDReferenceLibraryCategoryEntity> mDReferenceLibraryCategoryEntityList = new List<MDReferenceLibraryCategoryEntity>();
            
            try
            {
                mDReferenceLibraryCategoryEntityList = FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDReferenceLibraryCategoryEntityList != null && mDReferenceLibraryCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDReferenceLibraryCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDReferenceLibraryCategoryEntityList ?? new List<MDReferenceLibraryCategoryEntity>();
        }
    }
}
