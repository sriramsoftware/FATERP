// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 19-Feb-2013, 01:42:07




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
    public partial class ACTemporaryJournalMaster_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public ACTemporaryJournalMaster_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTemporaryJournalMaster_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACTemporaryJournalMaster_DetailedEntity> aCTemporaryJournalMaster_DetailedEntityList = new List<ACTemporaryJournalMaster_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "TemporaryJournalMasterID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                aCTemporaryJournalMaster_DetailedEntityList = FCCACTemporaryJournalMaster_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (aCTemporaryJournalMaster_DetailedEntityList != null && aCTemporaryJournalMaster_DetailedEntityList.Count > 0)
                {
                    totalRowCount = aCTemporaryJournalMaster_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return aCTemporaryJournalMaster_DetailedEntityList ?? new List<ACTemporaryJournalMaster_DetailedEntity>();
        }
    }
}