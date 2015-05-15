// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class OTIssueDataSource
    {
        public Int32 totalRowCount = 0;

        public OTIssueDataSource()
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
        public IList<OTIssueEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<OTIssueEntity> oTIssueEntityList = new List<OTIssueEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTIssueEntity.FLD_NAME_IssueID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                oTIssueEntityList = FCCOTIssue.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (oTIssueEntityList != null && oTIssueEntityList.Count > 0)
                {
                    totalRowCount = oTIssueEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTIssueEntityList ?? new List<OTIssueEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTIssueEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<OTIssueEntity> oTIssueEntityList = new List<OTIssueEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTIssueEntity.FLD_NAME_IssueID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTIssueEntityList =  FCCOTIssue.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        oTIssueEntityList =  FCCOTIssue.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTIssueEntityList =  FCCOTIssue.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        oTIssueEntityList =  FCCOTIssue.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (oTIssueEntityList != null && oTIssueEntityList.Count > 0)
                {
                    totalRowCount = oTIssueEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTIssueEntityList ?? new List<OTIssueEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTIssueEntity> GetData()
        {
            IList<OTIssueEntity> oTIssueEntityList = new List<OTIssueEntity>();
            
            try
            {
                oTIssueEntityList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (oTIssueEntityList != null && oTIssueEntityList.Count > 0)
                {
                    totalRowCount = oTIssueEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return oTIssueEntityList ?? new List<OTIssueEntity>();
        }
    }
}
