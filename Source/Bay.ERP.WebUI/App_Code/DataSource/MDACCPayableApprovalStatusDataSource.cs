// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public partial class MDACCPayableApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDACCPayableApprovalStatusDataSource()
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
        public IList<MDACCPayableApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDACCPayableApprovalStatusEntity> mDACCPayableApprovalStatusEntityList = new List<MDACCPayableApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDACCPayableApprovalStatusEntity.FLD_NAME_ACCPayableApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDACCPayableApprovalStatusEntityList = FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDACCPayableApprovalStatusEntityList != null && mDACCPayableApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDACCPayableApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDACCPayableApprovalStatusEntityList ?? new List<MDACCPayableApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDACCPayableApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDACCPayableApprovalStatusEntity> mDACCPayableApprovalStatusEntityList = new List<MDACCPayableApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDACCPayableApprovalStatusEntity.FLD_NAME_ACCPayableApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDACCPayableApprovalStatusEntityList =  FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDACCPayableApprovalStatusEntityList =  FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDACCPayableApprovalStatusEntityList =  FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDACCPayableApprovalStatusEntityList =  FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDACCPayableApprovalStatusEntityList != null && mDACCPayableApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDACCPayableApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDACCPayableApprovalStatusEntityList ?? new List<MDACCPayableApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDACCPayableApprovalStatusEntity> GetData()
        {
            IList<MDACCPayableApprovalStatusEntity> mDACCPayableApprovalStatusEntityList = new List<MDACCPayableApprovalStatusEntity>();
            
            try
            {
                mDACCPayableApprovalStatusEntityList = FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDACCPayableApprovalStatusEntityList != null && mDACCPayableApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDACCPayableApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDACCPayableApprovalStatusEntityList ?? new List<MDACCPayableApprovalStatusEntity>();
        }
    }
}
