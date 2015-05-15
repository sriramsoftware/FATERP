// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Aug-2013, 01:37:35




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
    public partial class REQRequisitionItemFloorDetail_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionItemFloorDetail_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionItemFloorDetail_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionItemFloorDetail_DetailedEntity> rEQRequisitionItemFloorDetail_DetailedEntityList = new List<REQRequisitionItemFloorDetail_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "RequisitionItemFloorDetailID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                rEQRequisitionItemFloorDetail_DetailedEntityList = FCCREQRequisitionItemFloorDetail_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (rEQRequisitionItemFloorDetail_DetailedEntityList != null && rEQRequisitionItemFloorDetail_DetailedEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemFloorDetail_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return rEQRequisitionItemFloorDetail_DetailedEntityList ?? new List<REQRequisitionItemFloorDetail_DetailedEntity>();
        }
    }
}
