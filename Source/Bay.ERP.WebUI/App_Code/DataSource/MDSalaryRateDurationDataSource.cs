// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public partial class MDSalaryRateDurationDataSource
    {
        public Int32 totalRowCount = 0;

        public MDSalaryRateDurationDataSource()
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
        public IList<MDSalaryRateDurationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDSalaryRateDurationEntity> mDSalaryRateDurationEntityList = new List<MDSalaryRateDurationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSalaryRateDurationEntity.FLD_NAME_SalaryRateDurationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDSalaryRateDurationEntityList = FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDSalaryRateDurationEntityList != null && mDSalaryRateDurationEntityList.Count > 0)
                {
                    totalRowCount = mDSalaryRateDurationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSalaryRateDurationEntityList ?? new List<MDSalaryRateDurationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSalaryRateDurationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDSalaryRateDurationEntity> mDSalaryRateDurationEntityList = new List<MDSalaryRateDurationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSalaryRateDurationEntity.FLD_NAME_SalaryRateDurationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSalaryRateDurationEntityList =  FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDSalaryRateDurationEntityList =  FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSalaryRateDurationEntityList =  FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDSalaryRateDurationEntityList =  FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDSalaryRateDurationEntityList != null && mDSalaryRateDurationEntityList.Count > 0)
                {
                    totalRowCount = mDSalaryRateDurationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSalaryRateDurationEntityList ?? new List<MDSalaryRateDurationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSalaryRateDurationEntity> GetData()
        {
            IList<MDSalaryRateDurationEntity> mDSalaryRateDurationEntityList = new List<MDSalaryRateDurationEntity>();
            
            try
            {
                mDSalaryRateDurationEntityList = FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDSalaryRateDurationEntityList != null && mDSalaryRateDurationEntityList.Count > 0)
                {
                    totalRowCount = mDSalaryRateDurationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDSalaryRateDurationEntityList ?? new List<MDSalaryRateDurationEntity>();
        }
    }
}
