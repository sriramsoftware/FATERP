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
    public partial class CRMSurveyOwnerContactPersonDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMSurveyOwnerContactPersonDataSource()
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
        public IList<CRMSurveyOwnerContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList = new List<CRMSurveyOwnerContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMSurveyOwnerContactPersonEntity.FLD_NAME_SurveyOwnerContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMSurveyOwnerContactPersonEntityList = FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMSurveyOwnerContactPersonEntityList != null && cRMSurveyOwnerContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cRMSurveyOwnerContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMSurveyOwnerContactPersonEntityList ?? new List<CRMSurveyOwnerContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMSurveyOwnerContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList = new List<CRMSurveyOwnerContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMSurveyOwnerContactPersonEntity.FLD_NAME_SurveyOwnerContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMSurveyOwnerContactPersonEntityList =  FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMSurveyOwnerContactPersonEntityList =  FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMSurveyOwnerContactPersonEntityList =  FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMSurveyOwnerContactPersonEntityList =  FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMSurveyOwnerContactPersonEntityList != null && cRMSurveyOwnerContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cRMSurveyOwnerContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMSurveyOwnerContactPersonEntityList ?? new List<CRMSurveyOwnerContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMSurveyOwnerContactPersonEntity> GetData()
        {
            IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList = new List<CRMSurveyOwnerContactPersonEntity>();
            
            try
            {
                cRMSurveyOwnerContactPersonEntityList = FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMSurveyOwnerContactPersonEntityList != null && cRMSurveyOwnerContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cRMSurveyOwnerContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMSurveyOwnerContactPersonEntityList ?? new List<CRMSurveyOwnerContactPersonEntity>();
        }
    }
}
