// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




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
    public partial class MDDocumentStorageTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDDocumentStorageTypeDataSource()
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
        public IList<MDDocumentStorageTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDDocumentStorageTypeEntity> mDDocumentStorageTypeEntityList = new List<MDDocumentStorageTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDDocumentStorageTypeEntity.FLD_NAME_DocumentStorageTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDDocumentStorageTypeEntityList = FCCMDDocumentStorageType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDDocumentStorageTypeEntityList != null && mDDocumentStorageTypeEntityList.Count > 0)
                {
                    totalRowCount = mDDocumentStorageTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDDocumentStorageTypeEntityList ?? new List<MDDocumentStorageTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDDocumentStorageTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDDocumentStorageTypeEntity> mDDocumentStorageTypeEntityList = new List<MDDocumentStorageTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDDocumentStorageTypeEntity.FLD_NAME_DocumentStorageTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDDocumentStorageTypeEntityList =  FCCMDDocumentStorageType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDDocumentStorageTypeEntityList =  FCCMDDocumentStorageType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDDocumentStorageTypeEntityList =  FCCMDDocumentStorageType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDDocumentStorageTypeEntityList =  FCCMDDocumentStorageType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDDocumentStorageTypeEntityList != null && mDDocumentStorageTypeEntityList.Count > 0)
                {
                    totalRowCount = mDDocumentStorageTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDDocumentStorageTypeEntityList ?? new List<MDDocumentStorageTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDDocumentStorageTypeEntity> GetData()
        {
            IList<MDDocumentStorageTypeEntity> mDDocumentStorageTypeEntityList = new List<MDDocumentStorageTypeEntity>();
            
            try
            {
                mDDocumentStorageTypeEntityList = FCCMDDocumentStorageType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDDocumentStorageTypeEntityList != null && mDDocumentStorageTypeEntityList.Count > 0)
                {
                    totalRowCount = mDDocumentStorageTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDDocumentStorageTypeEntityList ?? new List<MDDocumentStorageTypeEntity>();
        }
    }
}
