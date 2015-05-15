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
    public partial class MDApprovalProcessTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDApprovalProcessTypeDataSource()
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
        public IList<MDApprovalProcessTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDApprovalProcessTypeEntity> mDApprovalProcessTypeEntityList = new List<MDApprovalProcessTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalProcessTypeEntity.FLD_NAME_ApprovalProcessTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDApprovalProcessTypeEntityList = FCCMDApprovalProcessType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDApprovalProcessTypeEntityList != null && mDApprovalProcessTypeEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalProcessTypeEntityList ?? new List<MDApprovalProcessTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalProcessTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDApprovalProcessTypeEntity> mDApprovalProcessTypeEntityList = new List<MDApprovalProcessTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalProcessTypeEntity.FLD_NAME_ApprovalProcessTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalProcessTypeEntityList =  FCCMDApprovalProcessType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDApprovalProcessTypeEntityList =  FCCMDApprovalProcessType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalProcessTypeEntityList =  FCCMDApprovalProcessType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDApprovalProcessTypeEntityList =  FCCMDApprovalProcessType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDApprovalProcessTypeEntityList != null && mDApprovalProcessTypeEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalProcessTypeEntityList ?? new List<MDApprovalProcessTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalProcessTypeEntity> GetData()
        {
            IList<MDApprovalProcessTypeEntity> mDApprovalProcessTypeEntityList = new List<MDApprovalProcessTypeEntity>();
            
            try
            {
                mDApprovalProcessTypeEntityList = FCCMDApprovalProcessType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDApprovalProcessTypeEntityList != null && mDApprovalProcessTypeEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalProcessTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDApprovalProcessTypeEntityList ?? new List<MDApprovalProcessTypeEntity>();
        }
    }
}
