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
    public partial class MDSurveySourceInformationDataSource
    {
        public Int32 totalRowCount = 0;

        public MDSurveySourceInformationDataSource()
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
        public IList<MDSurveySourceInformationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDSurveySourceInformationEntity> mDSurveySourceInformationEntityList = new List<MDSurveySourceInformationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSurveySourceInformationEntity.FLD_NAME_SurveySourceInformationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDSurveySourceInformationEntityList = FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDSurveySourceInformationEntityList != null && mDSurveySourceInformationEntityList.Count > 0)
                {
                    totalRowCount = mDSurveySourceInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSurveySourceInformationEntityList ?? new List<MDSurveySourceInformationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSurveySourceInformationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDSurveySourceInformationEntity> mDSurveySourceInformationEntityList = new List<MDSurveySourceInformationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDSurveySourceInformationEntity.FLD_NAME_SurveySourceInformationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSurveySourceInformationEntityList =  FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDSurveySourceInformationEntityList =  FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDSurveySourceInformationEntityList =  FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDSurveySourceInformationEntityList =  FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDSurveySourceInformationEntityList != null && mDSurveySourceInformationEntityList.Count > 0)
                {
                    totalRowCount = mDSurveySourceInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDSurveySourceInformationEntityList ?? new List<MDSurveySourceInformationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDSurveySourceInformationEntity> GetData()
        {
            IList<MDSurveySourceInformationEntity> mDSurveySourceInformationEntityList = new List<MDSurveySourceInformationEntity>();
            
            try
            {
                mDSurveySourceInformationEntityList = FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDSurveySourceInformationEntityList != null && mDSurveySourceInformationEntityList.Count > 0)
                {
                    totalRowCount = mDSurveySourceInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDSurveySourceInformationEntityList ?? new List<MDSurveySourceInformationEntity>();
        }
    }
}
