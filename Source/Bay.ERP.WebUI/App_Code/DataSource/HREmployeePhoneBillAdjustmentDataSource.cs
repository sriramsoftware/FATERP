// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    public partial class HREmployeePhoneBillAdjustmentDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeePhoneBillAdjustmentDataSource()
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
        public IList<HREmployeePhoneBillAdjustmentEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntityList = new List<HREmployeePhoneBillAdjustmentEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeePhoneBillAdjustmentEntity.FLD_NAME_PhoneBillAdjustmentID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeePhoneBillAdjustmentEntityList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeePhoneBillAdjustmentEntityList != null && hREmployeePhoneBillAdjustmentEntityList.Count > 0)
                {
                    totalRowCount = hREmployeePhoneBillAdjustmentEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeePhoneBillAdjustmentEntityList ?? new List<HREmployeePhoneBillAdjustmentEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeePhoneBillAdjustmentEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntityList = new List<HREmployeePhoneBillAdjustmentEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeePhoneBillAdjustmentEntity.FLD_NAME_PhoneBillAdjustmentID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeePhoneBillAdjustmentEntityList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeePhoneBillAdjustmentEntityList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeePhoneBillAdjustmentEntityList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeePhoneBillAdjustmentEntityList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeePhoneBillAdjustmentEntityList != null && hREmployeePhoneBillAdjustmentEntityList.Count > 0)
                {
                    totalRowCount = hREmployeePhoneBillAdjustmentEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeePhoneBillAdjustmentEntityList ?? new List<HREmployeePhoneBillAdjustmentEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeePhoneBillAdjustmentEntity> GetData()
        {
            IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntityList = new List<HREmployeePhoneBillAdjustmentEntity>();
            
            try
            {
                hREmployeePhoneBillAdjustmentEntityList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeePhoneBillAdjustmentEntityList != null && hREmployeePhoneBillAdjustmentEntityList.Count > 0)
                {
                    totalRowCount = hREmployeePhoneBillAdjustmentEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeePhoneBillAdjustmentEntityList ?? new List<HREmployeePhoneBillAdjustmentEntity>();
        }
    }
}
