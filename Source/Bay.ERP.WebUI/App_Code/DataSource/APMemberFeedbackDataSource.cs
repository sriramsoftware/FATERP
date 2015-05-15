// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APMemberFeedbackDataSource
    {
        public Int32 totalRowCount = 0;

        public APMemberFeedbackDataSource()
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
        public IList<APMemberFeedbackEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList = new List<APMemberFeedbackEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPMemberFeedbackEntityList = FCCAPMemberFeedback.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPMemberFeedbackEntityList != null && aPMemberFeedbackEntityList.Count > 0)
                {
                    totalRowCount = aPMemberFeedbackEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPMemberFeedbackEntityList ?? new List<APMemberFeedbackEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APMemberFeedbackEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList = new List<APMemberFeedbackEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPMemberFeedbackEntityList =  FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPMemberFeedbackEntityList =  FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPMemberFeedbackEntityList =  FCCAPMemberFeedback.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPMemberFeedbackEntityList =  FCCAPMemberFeedback.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPMemberFeedbackEntityList != null && aPMemberFeedbackEntityList.Count > 0)
                {
                    totalRowCount = aPMemberFeedbackEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPMemberFeedbackEntityList ?? new List<APMemberFeedbackEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APMemberFeedbackEntity> GetData()
        {
            IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList = new List<APMemberFeedbackEntity>();
            
            try
            {
                aPMemberFeedbackEntityList = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPMemberFeedbackEntityList != null && aPMemberFeedbackEntityList.Count > 0)
                {
                    totalRowCount = aPMemberFeedbackEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPMemberFeedbackEntityList ?? new List<APMemberFeedbackEntity>();
        }
    }
}
