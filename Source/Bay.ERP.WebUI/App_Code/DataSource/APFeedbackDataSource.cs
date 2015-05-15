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
    public partial class APFeedbackDataSource
    {
        public Int32 totalRowCount = 0;

        public APFeedbackDataSource()
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
        public IList<APFeedbackEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APFeedbackEntity> aPFeedbackEntityList = new List<APFeedbackEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APFeedbackEntity.FLD_NAME_APFeedbackID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPFeedbackEntityList = FCCAPFeedback.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPFeedbackEntityList != null && aPFeedbackEntityList.Count > 0)
                {
                    totalRowCount = aPFeedbackEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPFeedbackEntityList ?? new List<APFeedbackEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APFeedbackEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APFeedbackEntity> aPFeedbackEntityList = new List<APFeedbackEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APFeedbackEntity.FLD_NAME_APFeedbackID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPFeedbackEntityList =  FCCAPFeedback.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPFeedbackEntityList =  FCCAPFeedback.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPFeedbackEntityList =  FCCAPFeedback.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPFeedbackEntityList =  FCCAPFeedback.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPFeedbackEntityList != null && aPFeedbackEntityList.Count > 0)
                {
                    totalRowCount = aPFeedbackEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPFeedbackEntityList ?? new List<APFeedbackEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APFeedbackEntity> GetData()
        {
            IList<APFeedbackEntity> aPFeedbackEntityList = new List<APFeedbackEntity>();
            
            try
            {
                aPFeedbackEntityList = FCCAPFeedback.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPFeedbackEntityList != null && aPFeedbackEntityList.Count > 0)
                {
                    totalRowCount = aPFeedbackEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPFeedbackEntityList ?? new List<APFeedbackEntity>();
        }
    }
}
