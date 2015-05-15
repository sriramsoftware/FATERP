// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public partial class MDSupervisorTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDSupervisorTypeDataSource()
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
        public IList<MDSupervisorTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDSupervisorTypeEntity> mDSupervisorTypeEntityList = new List<MDSupervisorTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSupervisorTypeEntity.FLD_NAME_SupervisorTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDSupervisorTypeEntityList = FCCMDSupervisorType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDSupervisorTypeEntityList != null && mDSupervisorTypeEntityList.Count > 0)
                {
                    totalRowCount = mDSupervisorTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSupervisorTypeEntityList ?? new List<MDSupervisorTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSupervisorTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDSupervisorTypeEntity> mDSupervisorTypeEntityList = new List<MDSupervisorTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSupervisorTypeEntity.FLD_NAME_SupervisorTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSupervisorTypeEntityList =  FCCMDSupervisorType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDSupervisorTypeEntityList =  FCCMDSupervisorType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSupervisorTypeEntityList =  FCCMDSupervisorType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDSupervisorTypeEntityList =  FCCMDSupervisorType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDSupervisorTypeEntityList != null && mDSupervisorTypeEntityList.Count > 0)
                {
                    totalRowCount = mDSupervisorTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSupervisorTypeEntityList ?? new List<MDSupervisorTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSupervisorTypeEntity> GetData()
        {
            IList<MDSupervisorTypeEntity> mDSupervisorTypeEntityList = new List<MDSupervisorTypeEntity>();
            
            try
            {
                mDSupervisorTypeEntityList = FCCMDSupervisorType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDSupervisorTypeEntityList != null && mDSupervisorTypeEntityList.Count > 0)
                {
                    totalRowCount = mDSupervisorTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDSupervisorTypeEntityList ?? new List<MDSupervisorTypeEntity>();
        }
    }
}
