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
    public partial class HRHolidayDataSource
    {
        public Int32 totalRowCount = 0;

        public HRHolidayDataSource()
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
        public IList<HRHolidayEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HRHolidayEntity> hRHolidayEntityList = new List<HRHolidayEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRHolidayEntity.FLD_NAME_HolidayID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hRHolidayEntityList = FCCHRHoliday.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hRHolidayEntityList != null && hRHolidayEntityList.Count > 0)
                {
                    totalRowCount = hRHolidayEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRHolidayEntityList ?? new List<HRHolidayEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRHolidayEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HRHolidayEntity> hRHolidayEntityList = new List<HRHolidayEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRHolidayEntity.FLD_NAME_HolidayID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRHolidayEntityList =  FCCHRHoliday.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hRHolidayEntityList =  FCCHRHoliday.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRHolidayEntityList =  FCCHRHoliday.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hRHolidayEntityList =  FCCHRHoliday.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hRHolidayEntityList != null && hRHolidayEntityList.Count > 0)
                {
                    totalRowCount = hRHolidayEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRHolidayEntityList ?? new List<HRHolidayEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRHolidayEntity> GetData()
        {
            IList<HRHolidayEntity> hRHolidayEntityList = new List<HRHolidayEntity>();
            
            try
            {
                hRHolidayEntityList = FCCHRHoliday.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hRHolidayEntityList != null && hRHolidayEntityList.Count > 0)
                {
                    totalRowCount = hRHolidayEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hRHolidayEntityList ?? new List<HRHolidayEntity>();
        }
    }
}
