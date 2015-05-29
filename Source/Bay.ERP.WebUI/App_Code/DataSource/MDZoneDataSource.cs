// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 07:14:37




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
    public partial class MDZoneDataSource
    {
        public Int32 totalRowCount = 0;

        public MDZoneDataSource()
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
        public IList<MDZoneEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDZoneEntity> mDZoneEntityList = new List<MDZoneEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDZoneEntity.FLD_NAME_ZoneID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDZoneEntityList = FCCMDZone.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDZoneEntityList != null && mDZoneEntityList.Count > 0)
                {
                    totalRowCount = mDZoneEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDZoneEntityList ?? new List<MDZoneEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDZoneEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDZoneEntity> mDZoneEntityList = new List<MDZoneEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDZoneEntity.FLD_NAME_ZoneID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDZoneEntityList =  FCCMDZone.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDZoneEntityList =  FCCMDZone.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDZoneEntityList =  FCCMDZone.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDZoneEntityList =  FCCMDZone.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDZoneEntityList != null && mDZoneEntityList.Count > 0)
                {
                    totalRowCount = mDZoneEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDZoneEntityList ?? new List<MDZoneEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDZoneEntity> GetData()
        {
            IList<MDZoneEntity> mDZoneEntityList = new List<MDZoneEntity>();
            
            try
            {
                mDZoneEntityList = FCCMDZone.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDZoneEntityList != null && mDZoneEntityList.Count > 0)
                {
                    totalRowCount = mDZoneEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDZoneEntityList ?? new List<MDZoneEntity>();
        }
    }
}
