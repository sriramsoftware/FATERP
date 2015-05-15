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
    public partial class OTIssueAssignedResourceDataSource
    {
        public Int32 totalRowCount = 0;

        public OTIssueAssignedResourceDataSource()
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
        public IList<OTIssueAssignedResourceEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList = new List<OTIssueAssignedResourceEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTIssueAssignedResourceEntity.FLD_NAME_IssueAssignedResourceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                oTIssueAssignedResourceEntityList = FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (oTIssueAssignedResourceEntityList != null && oTIssueAssignedResourceEntityList.Count > 0)
                {
                    totalRowCount = oTIssueAssignedResourceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTIssueAssignedResourceEntityList ?? new List<OTIssueAssignedResourceEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTIssueAssignedResourceEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList = new List<OTIssueAssignedResourceEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = OTIssueAssignedResourceEntity.FLD_NAME_IssueAssignedResourceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTIssueAssignedResourceEntityList =  FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        oTIssueAssignedResourceEntityList =  FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        oTIssueAssignedResourceEntityList =  FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        oTIssueAssignedResourceEntityList =  FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (oTIssueAssignedResourceEntityList != null && oTIssueAssignedResourceEntityList.Count > 0)
                {
                    totalRowCount = oTIssueAssignedResourceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return oTIssueAssignedResourceEntityList ?? new List<OTIssueAssignedResourceEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<OTIssueAssignedResourceEntity> GetData()
        {
            IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList = new List<OTIssueAssignedResourceEntity>();
            
            try
            {
                oTIssueAssignedResourceEntityList = FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (oTIssueAssignedResourceEntityList != null && oTIssueAssignedResourceEntityList.Count > 0)
                {
                    totalRowCount = oTIssueAssignedResourceEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return oTIssueAssignedResourceEntityList ?? new List<OTIssueAssignedResourceEntity>();
        }
    }
}
