// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 07-Oct-2012, 02:35:31




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
    public partial class APMemberFeedback_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public APMemberFeedback_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APMemberFeedback_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APMemberFeedback_DetailedEntity> aPMemberFeedback_DetailedEntityList = new List<APMemberFeedback_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "APMemberFeedbackID";
                }

                //Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                aPMemberFeedback_DetailedEntityList = FCCAPMemberFeedback_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (aPMemberFeedback_DetailedEntityList != null && aPMemberFeedback_DetailedEntityList.Count > 0)
                {
                    totalRowCount = aPMemberFeedback_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return aPMemberFeedback_DetailedEntityList ?? new List<APMemberFeedback_DetailedEntity>();
        }
    }
}
