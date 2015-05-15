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
    public partial class MDProjectCollectedDocumentStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDProjectCollectedDocumentStatusDataSource()
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
        public IList<MDProjectCollectedDocumentStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList = new List<MDProjectCollectedDocumentStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDProjectCollectedDocumentStatusEntity.FLD_NAME_ProjectCollectedDocumentStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDProjectCollectedDocumentStatusEntityList = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDProjectCollectedDocumentStatusEntityList != null && mDProjectCollectedDocumentStatusEntityList.Count > 0)
                {
                    totalRowCount = mDProjectCollectedDocumentStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDProjectCollectedDocumentStatusEntityList ?? new List<MDProjectCollectedDocumentStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDProjectCollectedDocumentStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList = new List<MDProjectCollectedDocumentStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDProjectCollectedDocumentStatusEntity.FLD_NAME_ProjectCollectedDocumentStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDProjectCollectedDocumentStatusEntityList =  FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDProjectCollectedDocumentStatusEntityList =  FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDProjectCollectedDocumentStatusEntityList =  FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDProjectCollectedDocumentStatusEntityList =  FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDProjectCollectedDocumentStatusEntityList != null && mDProjectCollectedDocumentStatusEntityList.Count > 0)
                {
                    totalRowCount = mDProjectCollectedDocumentStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDProjectCollectedDocumentStatusEntityList ?? new List<MDProjectCollectedDocumentStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDProjectCollectedDocumentStatusEntity> GetData()
        {
            IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList = new List<MDProjectCollectedDocumentStatusEntity>();
            
            try
            {
                mDProjectCollectedDocumentStatusEntityList = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDProjectCollectedDocumentStatusEntityList != null && mDProjectCollectedDocumentStatusEntityList.Count > 0)
                {
                    totalRowCount = mDProjectCollectedDocumentStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDProjectCollectedDocumentStatusEntityList ?? new List<MDProjectCollectedDocumentStatusEntity>();
        }
    }
}
