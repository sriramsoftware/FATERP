// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public partial class MDApprovalProcessStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDApprovalProcessStatusDataSource()
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
        public IList<MDApprovalProcessStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDApprovalProcessStatusEntity> mDApprovalProcessStatusEntityList = new List<MDApprovalProcessStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalProcessStatusEntity.FLD_NAME_ApprovalProcessStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDApprovalProcessStatusEntityList = FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDApprovalProcessStatusEntityList != null && mDApprovalProcessStatusEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalProcessStatusEntityList ?? new List<MDApprovalProcessStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalProcessStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDApprovalProcessStatusEntity> mDApprovalProcessStatusEntityList = new List<MDApprovalProcessStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalProcessStatusEntity.FLD_NAME_ApprovalProcessStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalProcessStatusEntityList =  FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDApprovalProcessStatusEntityList =  FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalProcessStatusEntityList =  FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDApprovalProcessStatusEntityList =  FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDApprovalProcessStatusEntityList != null && mDApprovalProcessStatusEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalProcessStatusEntityList ?? new List<MDApprovalProcessStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalProcessStatusEntity> GetData()
        {
            IList<MDApprovalProcessStatusEntity> mDApprovalProcessStatusEntityList = new List<MDApprovalProcessStatusEntity>();
            
            try
            {
                mDApprovalProcessStatusEntityList = FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDApprovalProcessStatusEntityList != null && mDApprovalProcessStatusEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDApprovalProcessStatusEntityList ?? new List<MDApprovalProcessStatusEntity>();
        }
    }
}
