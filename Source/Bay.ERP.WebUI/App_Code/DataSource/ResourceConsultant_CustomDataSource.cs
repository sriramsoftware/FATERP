// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Feb-2012, 11:07:17




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
    public partial class ResourceConsultant_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public ResourceConsultant_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ResourceConsultant_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ResourceConsultant_CustomEntity> resourceConsultant_CustomEntityList = new List<ResourceConsultant_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ResourceConsultant_CustomEntity.FLD_NAME_ResourceID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                resourceConsultant_CustomEntityList = FCCResourceConsultant_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (resourceConsultant_CustomEntityList != null && resourceConsultant_CustomEntityList.Count > 0)
                {
                    totalRowCount = resourceConsultant_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return resourceConsultant_CustomEntityList ?? new List<ResourceConsultant_CustomEntity>();
        }
    }
}
