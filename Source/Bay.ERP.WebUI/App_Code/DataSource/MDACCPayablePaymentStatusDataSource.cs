// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public partial class MDACCPayablePaymentStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDACCPayablePaymentStatusDataSource()
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
        public IList<MDACCPayablePaymentStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDACCPayablePaymentStatusEntity> mDACCPayablePaymentStatusEntityList = new List<MDACCPayablePaymentStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDACCPayablePaymentStatusEntity.FLD_NAME_ACCPayablePaymentStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDACCPayablePaymentStatusEntityList = FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDACCPayablePaymentStatusEntityList != null && mDACCPayablePaymentStatusEntityList.Count > 0)
                {
                    totalRowCount = mDACCPayablePaymentStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDACCPayablePaymentStatusEntityList ?? new List<MDACCPayablePaymentStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDACCPayablePaymentStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDACCPayablePaymentStatusEntity> mDACCPayablePaymentStatusEntityList = new List<MDACCPayablePaymentStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDACCPayablePaymentStatusEntity.FLD_NAME_ACCPayablePaymentStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDACCPayablePaymentStatusEntityList =  FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDACCPayablePaymentStatusEntityList =  FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDACCPayablePaymentStatusEntityList =  FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDACCPayablePaymentStatusEntityList =  FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDACCPayablePaymentStatusEntityList != null && mDACCPayablePaymentStatusEntityList.Count > 0)
                {
                    totalRowCount = mDACCPayablePaymentStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDACCPayablePaymentStatusEntityList ?? new List<MDACCPayablePaymentStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDACCPayablePaymentStatusEntity> GetData()
        {
            IList<MDACCPayablePaymentStatusEntity> mDACCPayablePaymentStatusEntityList = new List<MDACCPayablePaymentStatusEntity>();
            
            try
            {
                mDACCPayablePaymentStatusEntityList = FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDACCPayablePaymentStatusEntityList != null && mDACCPayablePaymentStatusEntityList.Count > 0)
                {
                    totalRowCount = mDACCPayablePaymentStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDACCPayablePaymentStatusEntityList ?? new List<MDACCPayablePaymentStatusEntity>();
        }
    }
}
