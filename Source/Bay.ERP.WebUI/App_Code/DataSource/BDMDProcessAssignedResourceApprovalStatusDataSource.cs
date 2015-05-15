// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDMDProcessAssignedResourceApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public BDMDProcessAssignedResourceApprovalStatusDataSource()
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
        public IList<BDMDProcessAssignedResourceApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList = new List<BDMDProcessAssignedResourceApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDProcessAssignedResourceApprovalStatusEntity.FLD_NAME_ProcessAssignedResourceApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDMDProcessAssignedResourceApprovalStatusEntityList = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDMDProcessAssignedResourceApprovalStatusEntityList != null && bDMDProcessAssignedResourceApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = bDMDProcessAssignedResourceApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDProcessAssignedResourceApprovalStatusEntityList ?? new List<BDMDProcessAssignedResourceApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDProcessAssignedResourceApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList = new List<BDMDProcessAssignedResourceApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDProcessAssignedResourceApprovalStatusEntity.FLD_NAME_ProcessAssignedResourceApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDProcessAssignedResourceApprovalStatusEntityList =  FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDMDProcessAssignedResourceApprovalStatusEntityList =  FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDProcessAssignedResourceApprovalStatusEntityList =  FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDMDProcessAssignedResourceApprovalStatusEntityList =  FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDMDProcessAssignedResourceApprovalStatusEntityList != null && bDMDProcessAssignedResourceApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = bDMDProcessAssignedResourceApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDProcessAssignedResourceApprovalStatusEntityList ?? new List<BDMDProcessAssignedResourceApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDProcessAssignedResourceApprovalStatusEntity> GetData()
        {
            IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList = new List<BDMDProcessAssignedResourceApprovalStatusEntity>();
            
            try
            {
                bDMDProcessAssignedResourceApprovalStatusEntityList = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDMDProcessAssignedResourceApprovalStatusEntityList != null && bDMDProcessAssignedResourceApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = bDMDProcessAssignedResourceApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDMDProcessAssignedResourceApprovalStatusEntityList ?? new List<BDMDProcessAssignedResourceApprovalStatusEntity>();
        }
    }
}
