// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 21-Jan-2013, 04:58:29




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
    public partial class ACCRequisitionWorkOrderMRRDetail_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public ACCRequisitionWorkOrderMRRDetail_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACCRequisitionWorkOrderMRRDetail_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACCRequisitionWorkOrderMRRDetail_DetailedEntity> aCCRequisitionWorkOrderMRRDetail_DetailedEntityList = new List<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "RequisitionItemID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                aCCRequisitionWorkOrderMRRDetail_DetailedEntityList = FCCACCRequisitionWorkOrderMRRDetail_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (aCCRequisitionWorkOrderMRRDetail_DetailedEntityList != null && aCCRequisitionWorkOrderMRRDetail_DetailedEntityList.Count > 0)
                {
                    totalRowCount = aCCRequisitionWorkOrderMRRDetail_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return aCCRequisitionWorkOrderMRRDetail_DetailedEntityList ?? new List<ACCRequisitionWorkOrderMRRDetail_DetailedEntity>();
        }
    }
}
