// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 28-Feb-2012, 12:56:26




using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.Web.UI
{
    [DataObject(true)]
    public partial class CMNDashboardItem_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNDashboardItem_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNDashboardItem_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNDashboardItem_DetailedEntity> cMNDashboardItem_DetailedEntityList = new List<CMNDashboardItem_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = SqlExpressionBuilder.PrepareSortExpression("CMNDashboardItem." + CMNDashboardItemEntity.FLD_NAME_DashboardItemID, SQLSortOrderType.Decending);
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                cMNDashboardItem_DetailedEntityList = FCCCMNDashboardItem_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (cMNDashboardItem_DetailedEntityList != null && cMNDashboardItem_DetailedEntityList.Count > 0)
                {
                    totalRowCount = cMNDashboardItem_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return cMNDashboardItem_DetailedEntityList ?? new List<CMNDashboardItem_DetailedEntity>();
        }
    }
}
