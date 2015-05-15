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
    public partial class MDApprovalRuleDesignationMapDataSource
    {
        public Int32 totalRowCount = 0;

        public MDApprovalRuleDesignationMapDataSource()
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
        public IList<MDApprovalRuleDesignationMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDApprovalRuleDesignationMapEntity> mDApprovalRuleDesignationMapEntityList = new List<MDApprovalRuleDesignationMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalRuleDesignationMapEntity.FLD_NAME_ApprovalRuleDesignationMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDApprovalRuleDesignationMapEntityList = FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDApprovalRuleDesignationMapEntityList != null && mDApprovalRuleDesignationMapEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalRuleDesignationMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalRuleDesignationMapEntityList ?? new List<MDApprovalRuleDesignationMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalRuleDesignationMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDApprovalRuleDesignationMapEntity> mDApprovalRuleDesignationMapEntityList = new List<MDApprovalRuleDesignationMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDApprovalRuleDesignationMapEntity.FLD_NAME_ApprovalRuleDesignationMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalRuleDesignationMapEntityList =  FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDApprovalRuleDesignationMapEntityList =  FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDApprovalRuleDesignationMapEntityList =  FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDApprovalRuleDesignationMapEntityList =  FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDApprovalRuleDesignationMapEntityList != null && mDApprovalRuleDesignationMapEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalRuleDesignationMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDApprovalRuleDesignationMapEntityList ?? new List<MDApprovalRuleDesignationMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDApprovalRuleDesignationMapEntity> GetData()
        {
            IList<MDApprovalRuleDesignationMapEntity> mDApprovalRuleDesignationMapEntityList = new List<MDApprovalRuleDesignationMapEntity>();
            
            try
            {
                mDApprovalRuleDesignationMapEntityList = FCCMDApprovalRuleDesignationMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDApprovalRuleDesignationMapEntityList != null && mDApprovalRuleDesignationMapEntityList.Count > 0)
                {
                    totalRowCount = mDApprovalRuleDesignationMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDApprovalRuleDesignationMapEntityList ?? new List<MDApprovalRuleDesignationMapEntity>();
        }
    }
}
