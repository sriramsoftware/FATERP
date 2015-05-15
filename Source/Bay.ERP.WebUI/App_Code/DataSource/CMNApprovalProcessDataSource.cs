// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
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
    public partial class CMNApprovalProcessDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNApprovalProcessDataSource()
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
        public IList<CMNApprovalProcessEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList = new List<CMNApprovalProcessEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNApprovalProcessEntity.FLD_NAME_ApprovalProcessID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNApprovalProcessEntityList = FCCCMNApprovalProcess.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNApprovalProcessEntityList != null && cMNApprovalProcessEntityList.Count > 0)
                {
                    totalRowCount = cMNApprovalProcessEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNApprovalProcessEntityList ?? new List<CMNApprovalProcessEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNApprovalProcessEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList = new List<CMNApprovalProcessEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNApprovalProcessEntity.FLD_NAME_ApprovalProcessID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNApprovalProcessEntityList =  FCCCMNApprovalProcess.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNApprovalProcessEntityList =  FCCCMNApprovalProcess.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNApprovalProcessEntityList =  FCCCMNApprovalProcess.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNApprovalProcessEntityList =  FCCCMNApprovalProcess.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNApprovalProcessEntityList != null && cMNApprovalProcessEntityList.Count > 0)
                {
                    totalRowCount = cMNApprovalProcessEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNApprovalProcessEntityList ?? new List<CMNApprovalProcessEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNApprovalProcessEntity> GetData()
        {
            IList<CMNApprovalProcessEntity> cMNApprovalProcessEntityList = new List<CMNApprovalProcessEntity>();
            
            try
            {
                cMNApprovalProcessEntityList = FCCCMNApprovalProcess.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNApprovalProcessEntityList != null && cMNApprovalProcessEntityList.Count > 0)
                {
                    totalRowCount = cMNApprovalProcessEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNApprovalProcessEntityList ?? new List<CMNApprovalProcessEntity>();
        }
    }
}
