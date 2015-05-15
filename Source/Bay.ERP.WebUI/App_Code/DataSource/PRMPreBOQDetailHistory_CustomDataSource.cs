// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-May-2012, 10:19:19




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
    public partial class PRMPreBOQDetailHistory_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMPreBOQDetailHistory_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQDetailHistory_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMPreBOQDetailHistory_CustomEntity> pRMPreBOQDetailHistory_CustomEntityList = new List<PRMPreBOQDetailHistory_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQDetailHistoryEntity.FLD_NAME_PRMPreBOQDetailHistoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                pRMPreBOQDetailHistory_CustomEntityList = FCCPRMPreBOQDetailHistory_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (pRMPreBOQDetailHistory_CustomEntityList != null && pRMPreBOQDetailHistory_CustomEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQDetailHistory_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return pRMPreBOQDetailHistory_CustomEntityList ?? new List<PRMPreBOQDetailHistory_CustomEntity>();
        }
    }
}
