// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jun-2013, 04:42:43




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
    public partial class REQRequisitionDashboard_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionDashboard_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionDashboard_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionDashboard_CustomEntity> rEQRequisitionDashboard_CustomEntityList = new List<REQRequisitionDashboard_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {

                    sortExpression = REQRequisitionEntity.FLD_NAME_RequisitionDate + " " + SQLConstants.SORT_ORDER_DESCENDING; 
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                rEQRequisitionDashboard_CustomEntityList = FCCREQRequisitionDashboard_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (rEQRequisitionDashboard_CustomEntityList != null && rEQRequisitionDashboard_CustomEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionDashboard_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return rEQRequisitionDashboard_CustomEntityList ?? new List<REQRequisitionDashboard_CustomEntity>();
        }
    }
}
