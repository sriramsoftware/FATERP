// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    public partial class CMFinancialStrengthMajorWorkDataSource
    {
        public Int32 totalRowCount = 0;

        public CMFinancialStrengthMajorWorkDataSource()
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
        public IList<CMFinancialStrengthMajorWorkEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList = new List<CMFinancialStrengthMajorWorkEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMFinancialStrengthMajorWorkEntity.FLD_NAME_FinancialStrengthMajorWorkID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMFinancialStrengthMajorWorkEntityList = FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMFinancialStrengthMajorWorkEntityList != null && cMFinancialStrengthMajorWorkEntityList.Count > 0)
                {
                    totalRowCount = cMFinancialStrengthMajorWorkEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMFinancialStrengthMajorWorkEntityList ?? new List<CMFinancialStrengthMajorWorkEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMFinancialStrengthMajorWorkEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList = new List<CMFinancialStrengthMajorWorkEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMFinancialStrengthMajorWorkEntity.FLD_NAME_FinancialStrengthMajorWorkID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMFinancialStrengthMajorWorkEntityList =  FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMFinancialStrengthMajorWorkEntityList =  FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMFinancialStrengthMajorWorkEntityList =  FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMFinancialStrengthMajorWorkEntityList =  FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMFinancialStrengthMajorWorkEntityList != null && cMFinancialStrengthMajorWorkEntityList.Count > 0)
                {
                    totalRowCount = cMFinancialStrengthMajorWorkEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMFinancialStrengthMajorWorkEntityList ?? new List<CMFinancialStrengthMajorWorkEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMFinancialStrengthMajorWorkEntity> GetData()
        {
            IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList = new List<CMFinancialStrengthMajorWorkEntity>();
            
            try
            {
                cMFinancialStrengthMajorWorkEntityList = FCCCMFinancialStrengthMajorWork.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMFinancialStrengthMajorWorkEntityList != null && cMFinancialStrengthMajorWorkEntityList.Count > 0)
                {
                    totalRowCount = cMFinancialStrengthMajorWorkEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMFinancialStrengthMajorWorkEntityList ?? new List<CMFinancialStrengthMajorWorkEntity>();
        }
    }
}
