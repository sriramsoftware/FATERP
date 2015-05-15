// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 10:51:15




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
    public partial class REQRequisitionWithWorkOrder_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionWithWorkOrder_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionWithWorkOrder_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionWithWorkOrder_CustomEntity> rEQRequisitionWithWorkOrder_CustomEntityList = new List<REQRequisitionWithWorkOrder_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "REQRequisition.RequisitionID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                rEQRequisitionWithWorkOrder_CustomEntityList = FCCREQRequisitionWithWorkOrder_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (rEQRequisitionWithWorkOrder_CustomEntityList != null && rEQRequisitionWithWorkOrder_CustomEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionWithWorkOrder_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return rEQRequisitionWithWorkOrder_CustomEntityList ?? new List<REQRequisitionWithWorkOrder_CustomEntity>();
        }
    }
}
