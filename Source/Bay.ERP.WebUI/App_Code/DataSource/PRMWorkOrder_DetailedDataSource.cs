// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jun-2012, 01:17:39




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
    public partial class PRMWorkOrder_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMWorkOrder_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        //public Int32 TotalRowCount(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMWorkOrder_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMWorkOrder_DetailedEntity> pRMWorkOrder_DetailedEntityList = new List<PRMWorkOrder_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "WorkOrderID DESC";
                }

                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;
                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;                

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                pRMWorkOrder_DetailedEntityList = FCCPRMWorkOrder_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (pRMWorkOrder_DetailedEntityList != null && pRMWorkOrder_DetailedEntityList.Count > 0)
                {
                    totalRowCount = pRMWorkOrder_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return pRMWorkOrder_DetailedEntityList ?? new List<PRMWorkOrder_DetailedEntity>();
        }
    }
}
