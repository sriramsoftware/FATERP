// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeLoanApplicationDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeLoanApplicationDataSource()
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
        public IList<HREmployeeLoanApplicationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeLoanApplicationEntity> hREmployeeLoanApplicationEntityList = new List<HREmployeeLoanApplicationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeLoanApplicationEntity.FLD_NAME_EmployeeLoanApplicationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeLoanApplicationEntityList = FCCHREmployeeLoanApplication.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeLoanApplicationEntityList != null && hREmployeeLoanApplicationEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeLoanApplicationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeLoanApplicationEntityList ?? new List<HREmployeeLoanApplicationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeLoanApplicationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeLoanApplicationEntity> hREmployeeLoanApplicationEntityList = new List<HREmployeeLoanApplicationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeLoanApplicationEntity.FLD_NAME_EmployeeLoanApplicationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeLoanApplicationEntityList =  FCCHREmployeeLoanApplication.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeLoanApplicationEntityList =  FCCHREmployeeLoanApplication.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeLoanApplicationEntityList =  FCCHREmployeeLoanApplication.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeLoanApplicationEntityList =  FCCHREmployeeLoanApplication.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeLoanApplicationEntityList != null && hREmployeeLoanApplicationEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeLoanApplicationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeLoanApplicationEntityList ?? new List<HREmployeeLoanApplicationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeLoanApplicationEntity> GetData()
        {
            IList<HREmployeeLoanApplicationEntity> hREmployeeLoanApplicationEntityList = new List<HREmployeeLoanApplicationEntity>();
            
            try
            {
                hREmployeeLoanApplicationEntityList = FCCHREmployeeLoanApplication.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeLoanApplicationEntityList != null && hREmployeeLoanApplicationEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeLoanApplicationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeLoanApplicationEntityList ?? new List<HREmployeeLoanApplicationEntity>();
        }
    }
}