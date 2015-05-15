// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Sep-2012, 04:31:29




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
    public partial class PRMWorkOrderItemDetail_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMWorkOrderItemDetail_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMWorkOrderItemDetail_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMWorkOrderItemDetail_DetailedEntity> pRMWorkOrderItemDetail_DetailedEntityList = new List<PRMWorkOrderItemDetail_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMWorkOrderItemDetail_DetailedEntity.FLD_NAME_WorkOrderItemDetailID+ " " + SQLConstants.SORT_ORDER_DESCENDING; 
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                pRMWorkOrderItemDetail_DetailedEntityList = FCCPRMWorkOrderItemDetail_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (pRMWorkOrderItemDetail_DetailedEntityList != null && pRMWorkOrderItemDetail_DetailedEntityList.Count > 0)
                {
                    totalRowCount = pRMWorkOrderItemDetail_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return pRMWorkOrderItemDetail_DetailedEntityList ?? new List<PRMWorkOrderItemDetail_DetailedEntity>();
        }
    }
}
