// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDAttendanceLeaveAndHolidayCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public MDAttendanceLeaveAndHolidayCategoryDataSource()
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
        public IList<MDAttendanceLeaveAndHolidayCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDAttendanceLeaveAndHolidayCategoryEntity> mDAttendanceLeaveAndHolidayCategoryEntityList = new List<MDAttendanceLeaveAndHolidayCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDAttendanceLeaveAndHolidayCategoryEntity.FLD_NAME_AttendanceLeaveAndHolidayCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDAttendanceLeaveAndHolidayCategoryEntityList = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDAttendanceLeaveAndHolidayCategoryEntityList != null && mDAttendanceLeaveAndHolidayCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDAttendanceLeaveAndHolidayCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDAttendanceLeaveAndHolidayCategoryEntityList ?? new List<MDAttendanceLeaveAndHolidayCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDAttendanceLeaveAndHolidayCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDAttendanceLeaveAndHolidayCategoryEntity> mDAttendanceLeaveAndHolidayCategoryEntityList = new List<MDAttendanceLeaveAndHolidayCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDAttendanceLeaveAndHolidayCategoryEntity.FLD_NAME_AttendanceLeaveAndHolidayCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDAttendanceLeaveAndHolidayCategoryEntityList =  FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDAttendanceLeaveAndHolidayCategoryEntityList =  FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDAttendanceLeaveAndHolidayCategoryEntityList =  FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDAttendanceLeaveAndHolidayCategoryEntityList =  FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDAttendanceLeaveAndHolidayCategoryEntityList != null && mDAttendanceLeaveAndHolidayCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDAttendanceLeaveAndHolidayCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDAttendanceLeaveAndHolidayCategoryEntityList ?? new List<MDAttendanceLeaveAndHolidayCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDAttendanceLeaveAndHolidayCategoryEntity> GetData()
        {
            IList<MDAttendanceLeaveAndHolidayCategoryEntity> mDAttendanceLeaveAndHolidayCategoryEntityList = new List<MDAttendanceLeaveAndHolidayCategoryEntity>();
            
            try
            {
                mDAttendanceLeaveAndHolidayCategoryEntityList = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDAttendanceLeaveAndHolidayCategoryEntityList != null && mDAttendanceLeaveAndHolidayCategoryEntityList.Count > 0)
                {
                    totalRowCount = mDAttendanceLeaveAndHolidayCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDAttendanceLeaveAndHolidayCategoryEntityList ?? new List<MDAttendanceLeaveAndHolidayCategoryEntity>();
        }
    }
}
