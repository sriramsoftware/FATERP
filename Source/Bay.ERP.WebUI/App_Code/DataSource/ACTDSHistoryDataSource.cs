// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 05-Mar-2013, 10:30:04




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
    public partial class ACTDSHistoryDataSource
    {
        public Int32 totalRowCount = 0;

        public ACTDSHistoryDataSource()
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
        public IList<ACTDSHistoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACTDSHistoryEntity> aCTDSHistoryEntityList = new List<ACTDSHistoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACTDSHistoryEntity.FLD_NAME_TDSHistoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCTDSHistoryEntityList = FCCACTDSHistory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCTDSHistoryEntityList != null && aCTDSHistoryEntityList.Count > 0)
                {
                    totalRowCount = aCTDSHistoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCTDSHistoryEntityList ?? new List<ACTDSHistoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTDSHistoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACTDSHistoryEntity> aCTDSHistoryEntityList = new List<ACTDSHistoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACTDSHistoryEntity.FLD_NAME_TDSHistoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCTDSHistoryEntityList =  FCCACTDSHistory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCTDSHistoryEntityList =  FCCACTDSHistory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCTDSHistoryEntityList =  FCCACTDSHistory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCTDSHistoryEntityList =  FCCACTDSHistory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCTDSHistoryEntityList != null && aCTDSHistoryEntityList.Count > 0)
                {
                    totalRowCount = aCTDSHistoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCTDSHistoryEntityList ?? new List<ACTDSHistoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTDSHistoryEntity> GetData()
        {
            IList<ACTDSHistoryEntity> aCTDSHistoryEntityList = new List<ACTDSHistoryEntity>();
            
            try
            {
                aCTDSHistoryEntityList = FCCACTDSHistory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCTDSHistoryEntityList != null && aCTDSHistoryEntityList.Count > 0)
                {
                    totalRowCount = aCTDSHistoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCTDSHistoryEntityList ?? new List<ACTDSHistoryEntity>();
        }
    }
}
