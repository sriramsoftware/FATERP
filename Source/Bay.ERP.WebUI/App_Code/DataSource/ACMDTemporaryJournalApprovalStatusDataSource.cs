// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 17-Feb-2013, 12:50:45




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
    public partial class ACMDTemporaryJournalApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public ACMDTemporaryJournalApprovalStatusDataSource()
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
        public IList<ACMDTemporaryJournalApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList = new List<ACMDTemporaryJournalApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACMDTemporaryJournalApprovalStatusEntity.FLD_NAME_TemporyJournalApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCMDTemporaryJournalApprovalStatusEntityList = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCMDTemporaryJournalApprovalStatusEntityList != null && aCMDTemporaryJournalApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDTemporaryJournalApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCMDTemporaryJournalApprovalStatusEntityList ?? new List<ACMDTemporaryJournalApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACMDTemporaryJournalApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList = new List<ACMDTemporaryJournalApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACMDTemporaryJournalApprovalStatusEntity.FLD_NAME_TemporyJournalApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCMDTemporaryJournalApprovalStatusEntityList =  FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCMDTemporaryJournalApprovalStatusEntityList =  FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCMDTemporaryJournalApprovalStatusEntityList =  FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCMDTemporaryJournalApprovalStatusEntityList =  FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCMDTemporaryJournalApprovalStatusEntityList != null && aCMDTemporaryJournalApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDTemporaryJournalApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCMDTemporaryJournalApprovalStatusEntityList ?? new List<ACMDTemporaryJournalApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACMDTemporaryJournalApprovalStatusEntity> GetData()
        {
            IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList = new List<ACMDTemporaryJournalApprovalStatusEntity>();
            
            try
            {
                aCMDTemporaryJournalApprovalStatusEntityList = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCMDTemporaryJournalApprovalStatusEntityList != null && aCMDTemporaryJournalApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDTemporaryJournalApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCMDTemporaryJournalApprovalStatusEntityList ?? new List<ACMDTemporaryJournalApprovalStatusEntity>();
        }
    }
}
