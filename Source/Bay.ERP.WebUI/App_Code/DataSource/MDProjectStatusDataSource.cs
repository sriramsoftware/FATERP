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
    public partial class MDProjectStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDProjectStatusDataSource()
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
        public IList<MDProjectStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDProjectStatusEntity> mDProjectStatusEntityList = new List<MDProjectStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDProjectStatusEntity.FLD_NAME_ProjectStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDProjectStatusEntityList = FCCMDProjectStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDProjectStatusEntityList != null && mDProjectStatusEntityList.Count > 0)
                {
                    totalRowCount = mDProjectStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDProjectStatusEntityList ?? new List<MDProjectStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDProjectStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDProjectStatusEntity> mDProjectStatusEntityList = new List<MDProjectStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDProjectStatusEntity.FLD_NAME_ProjectStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDProjectStatusEntityList =  FCCMDProjectStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDProjectStatusEntityList =  FCCMDProjectStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDProjectStatusEntityList =  FCCMDProjectStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDProjectStatusEntityList =  FCCMDProjectStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDProjectStatusEntityList != null && mDProjectStatusEntityList.Count > 0)
                {
                    totalRowCount = mDProjectStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDProjectStatusEntityList ?? new List<MDProjectStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDProjectStatusEntity> GetData()
        {
            IList<MDProjectStatusEntity> mDProjectStatusEntityList = new List<MDProjectStatusEntity>();
            
            try
            {
                mDProjectStatusEntityList = FCCMDProjectStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDProjectStatusEntityList != null && mDProjectStatusEntityList.Count > 0)
                {
                    totalRowCount = mDProjectStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDProjectStatusEntityList ?? new List<MDProjectStatusEntity>();
        }
    }
}
