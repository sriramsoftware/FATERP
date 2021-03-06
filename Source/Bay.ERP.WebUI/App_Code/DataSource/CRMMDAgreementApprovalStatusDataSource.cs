// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMMDAgreementApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDAgreementApprovalStatusDataSource()
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
        public IList<CRMMDAgreementApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDAgreementApprovalStatusEntity> cRMMDAgreementApprovalStatusEntityList = new List<CRMMDAgreementApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAgreementApprovalStatusEntity.FLD_NAME_AgreementApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDAgreementApprovalStatusEntityList = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDAgreementApprovalStatusEntityList != null && cRMMDAgreementApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAgreementApprovalStatusEntityList ?? new List<CRMMDAgreementApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAgreementApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDAgreementApprovalStatusEntity> cRMMDAgreementApprovalStatusEntityList = new List<CRMMDAgreementApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAgreementApprovalStatusEntity.FLD_NAME_AgreementApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAgreementApprovalStatusEntityList =  FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDAgreementApprovalStatusEntityList =  FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAgreementApprovalStatusEntityList =  FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDAgreementApprovalStatusEntityList =  FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDAgreementApprovalStatusEntityList != null && cRMMDAgreementApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAgreementApprovalStatusEntityList ?? new List<CRMMDAgreementApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAgreementApprovalStatusEntity> GetData()
        {
            IList<CRMMDAgreementApprovalStatusEntity> cRMMDAgreementApprovalStatusEntityList = new List<CRMMDAgreementApprovalStatusEntity>();
            
            try
            {
                cRMMDAgreementApprovalStatusEntityList = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDAgreementApprovalStatusEntityList != null && cRMMDAgreementApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDAgreementApprovalStatusEntityList ?? new List<CRMMDAgreementApprovalStatusEntity>();
        }
    }
}
