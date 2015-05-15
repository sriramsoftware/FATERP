// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 11:29:57




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
    public partial class MDIssueAssignTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDIssueAssignTypeDataSource()
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
        public IList<MDIssueAssignTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDIssueAssignTypeEntity> mDIssueAssignTypeEntityList = new List<MDIssueAssignTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDIssueAssignTypeEntity.FLD_NAME_IssueAssignTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDIssueAssignTypeEntityList = FCCMDIssueAssignType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDIssueAssignTypeEntityList != null && mDIssueAssignTypeEntityList.Count > 0)
                {
                    totalRowCount = mDIssueAssignTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDIssueAssignTypeEntityList ?? new List<MDIssueAssignTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDIssueAssignTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDIssueAssignTypeEntity> mDIssueAssignTypeEntityList = new List<MDIssueAssignTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDIssueAssignTypeEntity.FLD_NAME_IssueAssignTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDIssueAssignTypeEntityList =  FCCMDIssueAssignType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDIssueAssignTypeEntityList =  FCCMDIssueAssignType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDIssueAssignTypeEntityList =  FCCMDIssueAssignType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDIssueAssignTypeEntityList =  FCCMDIssueAssignType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDIssueAssignTypeEntityList != null && mDIssueAssignTypeEntityList.Count > 0)
                {
                    totalRowCount = mDIssueAssignTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDIssueAssignTypeEntityList ?? new List<MDIssueAssignTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDIssueAssignTypeEntity> GetData()
        {
            IList<MDIssueAssignTypeEntity> mDIssueAssignTypeEntityList = new List<MDIssueAssignTypeEntity>();
            
            try
            {
                mDIssueAssignTypeEntityList = FCCMDIssueAssignType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDIssueAssignTypeEntityList != null && mDIssueAssignTypeEntityList.Count > 0)
                {
                    totalRowCount = mDIssueAssignTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDIssueAssignTypeEntityList ?? new List<MDIssueAssignTypeEntity>();
        }
    }
}
