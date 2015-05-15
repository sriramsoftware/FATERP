// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




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
    public partial class ACMDBankAccountTransferApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public ACMDBankAccountTransferApprovalStatusDataSource()
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
        public IList<ACMDBankAccountTransferApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACMDBankAccountTransferApprovalStatusEntity> aCMDBankAccountTransferApprovalStatusEntityList = new List<ACMDBankAccountTransferApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACMDBankAccountTransferApprovalStatusEntity.FLD_NAME_BankAccountTransferApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCMDBankAccountTransferApprovalStatusEntityList = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCMDBankAccountTransferApprovalStatusEntityList != null && aCMDBankAccountTransferApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDBankAccountTransferApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCMDBankAccountTransferApprovalStatusEntityList ?? new List<ACMDBankAccountTransferApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACMDBankAccountTransferApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACMDBankAccountTransferApprovalStatusEntity> aCMDBankAccountTransferApprovalStatusEntityList = new List<ACMDBankAccountTransferApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACMDBankAccountTransferApprovalStatusEntity.FLD_NAME_BankAccountTransferApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCMDBankAccountTransferApprovalStatusEntityList =  FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCMDBankAccountTransferApprovalStatusEntityList =  FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCMDBankAccountTransferApprovalStatusEntityList =  FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCMDBankAccountTransferApprovalStatusEntityList =  FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCMDBankAccountTransferApprovalStatusEntityList != null && aCMDBankAccountTransferApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDBankAccountTransferApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCMDBankAccountTransferApprovalStatusEntityList ?? new List<ACMDBankAccountTransferApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACMDBankAccountTransferApprovalStatusEntity> GetData()
        {
            IList<ACMDBankAccountTransferApprovalStatusEntity> aCMDBankAccountTransferApprovalStatusEntityList = new List<ACMDBankAccountTransferApprovalStatusEntity>();
            
            try
            {
                aCMDBankAccountTransferApprovalStatusEntityList = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCMDBankAccountTransferApprovalStatusEntityList != null && aCMDBankAccountTransferApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDBankAccountTransferApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCMDBankAccountTransferApprovalStatusEntityList ?? new List<ACMDBankAccountTransferApprovalStatusEntity>();
        }
    }
}
