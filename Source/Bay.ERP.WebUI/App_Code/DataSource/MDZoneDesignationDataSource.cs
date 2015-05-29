// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2015, 10:30:28




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
    public partial class MDZoneDesignationDataSource
    {
        public Int32 totalRowCount = 0;

        public MDZoneDesignationDataSource()
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
        public IList<MDZoneDesignationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDZoneDesignationEntity> mDZoneDesignationEntityList = new List<MDZoneDesignationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDZoneDesignationEntity.FLD_NAME_ZoneDesignationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDZoneDesignationEntityList = FCCMDZoneDesignation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDZoneDesignationEntityList != null && mDZoneDesignationEntityList.Count > 0)
                {
                    totalRowCount = mDZoneDesignationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDZoneDesignationEntityList ?? new List<MDZoneDesignationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDZoneDesignationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDZoneDesignationEntity> mDZoneDesignationEntityList = new List<MDZoneDesignationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDZoneDesignationEntity.FLD_NAME_ZoneDesignationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDZoneDesignationEntityList =  FCCMDZoneDesignation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDZoneDesignationEntityList =  FCCMDZoneDesignation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDZoneDesignationEntityList =  FCCMDZoneDesignation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDZoneDesignationEntityList =  FCCMDZoneDesignation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDZoneDesignationEntityList != null && mDZoneDesignationEntityList.Count > 0)
                {
                    totalRowCount = mDZoneDesignationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDZoneDesignationEntityList ?? new List<MDZoneDesignationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDZoneDesignationEntity> GetData()
        {
            IList<MDZoneDesignationEntity> mDZoneDesignationEntityList = new List<MDZoneDesignationEntity>();
            
            try
            {
                mDZoneDesignationEntityList = FCCMDZoneDesignation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDZoneDesignationEntityList != null && mDZoneDesignationEntityList.Count > 0)
                {
                    totalRowCount = mDZoneDesignationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDZoneDesignationEntityList ?? new List<MDZoneDesignationEntity>();
        }
    }
}
