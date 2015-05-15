// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 18-Dec-2012, 10:49:09




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
    public partial class INVStoreIssueNoteItemMap_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public INVStoreIssueNoteItemMap_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreIssueNoteItemMap_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVStoreIssueNoteItemMap_DetailedEntity> iNVStoreIssueNoteItemMap_DetailedEntityList = new List<INVStoreIssueNoteItemMap_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "StoreIssueNoteItemMapID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                iNVStoreIssueNoteItemMap_DetailedEntityList = FCCINVStoreIssueNoteItemMap_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (iNVStoreIssueNoteItemMap_DetailedEntityList != null && iNVStoreIssueNoteItemMap_DetailedEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteItemMap_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return iNVStoreIssueNoteItemMap_DetailedEntityList ?? new List<INVStoreIssueNoteItemMap_DetailedEntity>();
        }
    }
}
