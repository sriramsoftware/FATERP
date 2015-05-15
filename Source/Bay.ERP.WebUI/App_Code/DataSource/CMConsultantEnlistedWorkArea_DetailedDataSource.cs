// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 09-Jan-2012, 01:42:10




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
    public partial class CMConsultantEnlistedWorkArea_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantEnlistedWorkArea_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantEnlistedWorkArea_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantEnlistedWorkArea_DetailedEntity> cMConsultantEnlistedWorkArea_DetailedEntityList = new List<CMConsultantEnlistedWorkArea_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantEnlistedWorkArea_DetailedEntity.FLD_NAME_ConsultantEnlistedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                cMConsultantEnlistedWorkArea_DetailedEntityList = FCCCMConsultantEnlistedWorkArea_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (cMConsultantEnlistedWorkArea_DetailedEntityList != null && cMConsultantEnlistedWorkArea_DetailedEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEnlistedWorkArea_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return cMConsultantEnlistedWorkArea_DetailedEntityList ?? new List<CMConsultantEnlistedWorkArea_DetailedEntity>();
        }
    }
}
