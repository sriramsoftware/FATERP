// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    public partial class INVStoreIssueNoteDataSource
    {
        public Int32 totalRowCount = 0;

        public INVStoreIssueNoteDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreIssueNoteEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList = new List<INVStoreIssueNoteEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVStoreIssueNoteEntityList = FCCINVStoreIssueNote.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVStoreIssueNoteEntityList != null && iNVStoreIssueNoteEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVStoreIssueNoteEntityList ?? new List<INVStoreIssueNoteEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreIssueNoteEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList = new List<INVStoreIssueNoteEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVStoreIssueNoteEntityList =  FCCINVStoreIssueNote.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVStoreIssueNoteEntityList =  FCCINVStoreIssueNote.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVStoreIssueNoteEntityList =  FCCINVStoreIssueNote.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVStoreIssueNoteEntityList =  FCCINVStoreIssueNote.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVStoreIssueNoteEntityList != null && iNVStoreIssueNoteEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVStoreIssueNoteEntityList ?? new List<INVStoreIssueNoteEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreIssueNoteEntity> GetData()
        {
            IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList = new List<INVStoreIssueNoteEntity>();
            
            try
            {
                iNVStoreIssueNoteEntityList = FCCINVStoreIssueNote.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVStoreIssueNoteEntityList != null && iNVStoreIssueNoteEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVStoreIssueNoteEntityList ?? new List<INVStoreIssueNoteEntity>();
        }
    }
}
