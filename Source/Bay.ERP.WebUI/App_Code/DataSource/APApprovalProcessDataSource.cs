// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APApprovalProcessDataSource
    {
        public Int32 totalRowCount = 0;

        public APApprovalProcessDataSource()
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
        public IList<APApprovalProcessEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APApprovalProcessEntity> aPApprovalProcessEntityList = new List<APApprovalProcessEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APApprovalProcessEntity.FLD_NAME_APApprovalProcessID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPApprovalProcessEntityList = FCCAPApprovalProcess.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPApprovalProcessEntityList != null && aPApprovalProcessEntityList.Count > 0)
                {
                    totalRowCount = aPApprovalProcessEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPApprovalProcessEntityList ?? new List<APApprovalProcessEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APApprovalProcessEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APApprovalProcessEntity> aPApprovalProcessEntityList = new List<APApprovalProcessEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APApprovalProcessEntity.FLD_NAME_APApprovalProcessID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPApprovalProcessEntityList =  FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPApprovalProcessEntityList =  FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPApprovalProcessEntityList =  FCCAPApprovalProcess.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPApprovalProcessEntityList =  FCCAPApprovalProcess.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPApprovalProcessEntityList != null && aPApprovalProcessEntityList.Count > 0)
                {
                    totalRowCount = aPApprovalProcessEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPApprovalProcessEntityList ?? new List<APApprovalProcessEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APApprovalProcessEntity> GetData()
        {
            IList<APApprovalProcessEntity> aPApprovalProcessEntityList = new List<APApprovalProcessEntity>();
            
            try
            {
                aPApprovalProcessEntityList = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPApprovalProcessEntityList != null && aPApprovalProcessEntityList.Count > 0)
                {
                    totalRowCount = aPApprovalProcessEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPApprovalProcessEntityList ?? new List<APApprovalProcessEntity>();
        }
    }
}
