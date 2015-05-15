// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




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
    public partial class ACAccountStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public ACAccountStatusDataSource()
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
        public IList<ACAccountStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACAccountStatusEntity> aCAccountStatusEntityList = new List<ACAccountStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACAccountStatusEntity.FLD_NAME_AccountStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCAccountStatusEntityList = FCCACAccountStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCAccountStatusEntityList != null && aCAccountStatusEntityList.Count > 0)
                {
                    totalRowCount = aCAccountStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCAccountStatusEntityList ?? new List<ACAccountStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACAccountStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACAccountStatusEntity> aCAccountStatusEntityList = new List<ACAccountStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACAccountStatusEntity.FLD_NAME_AccountStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCAccountStatusEntityList =  FCCACAccountStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCAccountStatusEntityList =  FCCACAccountStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCAccountStatusEntityList =  FCCACAccountStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCAccountStatusEntityList =  FCCACAccountStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCAccountStatusEntityList != null && aCAccountStatusEntityList.Count > 0)
                {
                    totalRowCount = aCAccountStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCAccountStatusEntityList ?? new List<ACAccountStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACAccountStatusEntity> GetData()
        {
            IList<ACAccountStatusEntity> aCAccountStatusEntityList = new List<ACAccountStatusEntity>();
            
            try
            {
                aCAccountStatusEntityList = FCCACAccountStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCAccountStatusEntityList != null && aCAccountStatusEntityList.Count > 0)
                {
                    totalRowCount = aCAccountStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCAccountStatusEntityList ?? new List<ACAccountStatusEntity>();
        }
    }
}
