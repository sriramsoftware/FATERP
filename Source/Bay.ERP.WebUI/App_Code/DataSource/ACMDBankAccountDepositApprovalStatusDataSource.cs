// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




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
    public partial class ACMDBankAccountDepositApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public ACMDBankAccountDepositApprovalStatusDataSource()
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
        public IList<ACMDBankAccountDepositApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACMDBankAccountDepositApprovalStatusEntity> aCMDBankAccountDepositApprovalStatusEntityList = new List<ACMDBankAccountDepositApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACMDBankAccountDepositApprovalStatusEntity.FLD_NAME_BankAccountDepositApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCMDBankAccountDepositApprovalStatusEntityList = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCMDBankAccountDepositApprovalStatusEntityList != null && aCMDBankAccountDepositApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDBankAccountDepositApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCMDBankAccountDepositApprovalStatusEntityList ?? new List<ACMDBankAccountDepositApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACMDBankAccountDepositApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACMDBankAccountDepositApprovalStatusEntity> aCMDBankAccountDepositApprovalStatusEntityList = new List<ACMDBankAccountDepositApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACMDBankAccountDepositApprovalStatusEntity.FLD_NAME_BankAccountDepositApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCMDBankAccountDepositApprovalStatusEntityList =  FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCMDBankAccountDepositApprovalStatusEntityList =  FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCMDBankAccountDepositApprovalStatusEntityList =  FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCMDBankAccountDepositApprovalStatusEntityList =  FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCMDBankAccountDepositApprovalStatusEntityList != null && aCMDBankAccountDepositApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDBankAccountDepositApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCMDBankAccountDepositApprovalStatusEntityList ?? new List<ACMDBankAccountDepositApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACMDBankAccountDepositApprovalStatusEntity> GetData()
        {
            IList<ACMDBankAccountDepositApprovalStatusEntity> aCMDBankAccountDepositApprovalStatusEntityList = new List<ACMDBankAccountDepositApprovalStatusEntity>();
            
            try
            {
                aCMDBankAccountDepositApprovalStatusEntityList = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCMDBankAccountDepositApprovalStatusEntityList != null && aCMDBankAccountDepositApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = aCMDBankAccountDepositApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCMDBankAccountDepositApprovalStatusEntityList ?? new List<ACMDBankAccountDepositApprovalStatusEntity>();
        }
    }
}
