// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    public partial class MDSurveyBuildingStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDSurveyBuildingStatusDataSource()
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
        public IList<MDSurveyBuildingStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDSurveyBuildingStatusEntity> mDSurveyBuildingStatusEntityList = new List<MDSurveyBuildingStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSurveyBuildingStatusEntity.FLD_NAME_SurveyBuildingStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDSurveyBuildingStatusEntityList = FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDSurveyBuildingStatusEntityList != null && mDSurveyBuildingStatusEntityList.Count > 0)
                {
                    totalRowCount = mDSurveyBuildingStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSurveyBuildingStatusEntityList ?? new List<MDSurveyBuildingStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSurveyBuildingStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDSurveyBuildingStatusEntity> mDSurveyBuildingStatusEntityList = new List<MDSurveyBuildingStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSurveyBuildingStatusEntity.FLD_NAME_SurveyBuildingStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSurveyBuildingStatusEntityList =  FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDSurveyBuildingStatusEntityList =  FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSurveyBuildingStatusEntityList =  FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDSurveyBuildingStatusEntityList =  FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDSurveyBuildingStatusEntityList != null && mDSurveyBuildingStatusEntityList.Count > 0)
                {
                    totalRowCount = mDSurveyBuildingStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSurveyBuildingStatusEntityList ?? new List<MDSurveyBuildingStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSurveyBuildingStatusEntity> GetData()
        {
            IList<MDSurveyBuildingStatusEntity> mDSurveyBuildingStatusEntityList = new List<MDSurveyBuildingStatusEntity>();
            
            try
            {
                mDSurveyBuildingStatusEntityList = FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDSurveyBuildingStatusEntityList != null && mDSurveyBuildingStatusEntityList.Count > 0)
                {
                    totalRowCount = mDSurveyBuildingStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDSurveyBuildingStatusEntityList ?? new List<MDSurveyBuildingStatusEntity>();
        }
    }
}
