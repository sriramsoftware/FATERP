// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class MDPayableClassificationDataSource
    {
        public Int32 totalRowCount = 0;

        public MDPayableClassificationDataSource()
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
        public IList<MDPayableClassificationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDPayableClassificationEntity> mDPayableClassificationEntityList = new List<MDPayableClassificationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDPayableClassificationEntity.FLD_NAME_PayableClassificationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDPayableClassificationEntityList = FCCMDPayableClassification.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDPayableClassificationEntityList != null && mDPayableClassificationEntityList.Count > 0)
                {
                    totalRowCount = mDPayableClassificationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDPayableClassificationEntityList ?? new List<MDPayableClassificationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDPayableClassificationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDPayableClassificationEntity> mDPayableClassificationEntityList = new List<MDPayableClassificationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDPayableClassificationEntity.FLD_NAME_PayableClassificationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDPayableClassificationEntityList =  FCCMDPayableClassification.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDPayableClassificationEntityList =  FCCMDPayableClassification.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDPayableClassificationEntityList =  FCCMDPayableClassification.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDPayableClassificationEntityList =  FCCMDPayableClassification.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDPayableClassificationEntityList != null && mDPayableClassificationEntityList.Count > 0)
                {
                    totalRowCount = mDPayableClassificationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDPayableClassificationEntityList ?? new List<MDPayableClassificationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDPayableClassificationEntity> GetData()
        {
            IList<MDPayableClassificationEntity> mDPayableClassificationEntityList = new List<MDPayableClassificationEntity>();
            
            try
            {
                mDPayableClassificationEntityList = FCCMDPayableClassification.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDPayableClassificationEntityList != null && mDPayableClassificationEntityList.Count > 0)
                {
                    totalRowCount = mDPayableClassificationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDPayableClassificationEntityList ?? new List<MDPayableClassificationEntity>();
        }
    }
}
