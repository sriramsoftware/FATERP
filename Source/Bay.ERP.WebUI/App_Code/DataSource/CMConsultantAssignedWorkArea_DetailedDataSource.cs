// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 09-Jan-2012, 11:59:55




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
    public partial class CMConsultantAssignedWorkArea_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantAssignedWorkArea_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantAssignedWorkArea_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantAssignedWorkArea_DetailedEntity> cMConsultantAssignedWorkArea_DetailedEntityList = new List<CMConsultantAssignedWorkArea_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantAssignedWorkArea_DetailedEntity.FLD_NAME_ConsultantAssignedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                cMConsultantAssignedWorkArea_DetailedEntityList = FCCCMConsultantAssignedWorkArea_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (cMConsultantAssignedWorkArea_DetailedEntityList != null && cMConsultantAssignedWorkArea_DetailedEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantAssignedWorkArea_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return cMConsultantAssignedWorkArea_DetailedEntityList ?? new List<CMConsultantAssignedWorkArea_DetailedEntity>();
        }
    }
}
