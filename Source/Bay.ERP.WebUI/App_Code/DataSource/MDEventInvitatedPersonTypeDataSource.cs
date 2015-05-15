// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




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
    public partial class MDEventInvitatedPersonTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDEventInvitatedPersonTypeDataSource()
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
        public IList<MDEventInvitatedPersonTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList = new List<MDEventInvitatedPersonTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEventInvitatedPersonTypeEntity.FLD_NAME_EventInvitatedPersonTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDEventInvitatedPersonTypeEntityList = FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDEventInvitatedPersonTypeEntityList != null && mDEventInvitatedPersonTypeEntityList.Count > 0)
                {
                    totalRowCount = mDEventInvitatedPersonTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEventInvitatedPersonTypeEntityList ?? new List<MDEventInvitatedPersonTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEventInvitatedPersonTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList = new List<MDEventInvitatedPersonTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEventInvitatedPersonTypeEntity.FLD_NAME_EventInvitatedPersonTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEventInvitatedPersonTypeEntityList =  FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDEventInvitatedPersonTypeEntityList =  FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEventInvitatedPersonTypeEntityList =  FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDEventInvitatedPersonTypeEntityList =  FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDEventInvitatedPersonTypeEntityList != null && mDEventInvitatedPersonTypeEntityList.Count > 0)
                {
                    totalRowCount = mDEventInvitatedPersonTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEventInvitatedPersonTypeEntityList ?? new List<MDEventInvitatedPersonTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEventInvitatedPersonTypeEntity> GetData()
        {
            IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList = new List<MDEventInvitatedPersonTypeEntity>();
            
            try
            {
                mDEventInvitatedPersonTypeEntityList = FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDEventInvitatedPersonTypeEntityList != null && mDEventInvitatedPersonTypeEntityList.Count > 0)
                {
                    totalRowCount = mDEventInvitatedPersonTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDEventInvitatedPersonTypeEntityList ?? new List<MDEventInvitatedPersonTypeEntity>();
        }
    }
}
