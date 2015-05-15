// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 18-Dec-2012, 09:34:17




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
    public partial class INVStoreIssueNoteItemMapDataSource
    {
        public Int32 totalRowCount = 0;

        public INVStoreIssueNoteItemMapDataSource()
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
        public IList<INVStoreIssueNoteItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList = new List<INVStoreIssueNoteItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVStoreIssueNoteItemMapEntityList = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVStoreIssueNoteItemMapEntityList != null && iNVStoreIssueNoteItemMapEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVStoreIssueNoteItemMapEntityList ?? new List<INVStoreIssueNoteItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreIssueNoteItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList = new List<INVStoreIssueNoteItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVStoreIssueNoteItemMapEntityList =  FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVStoreIssueNoteItemMapEntityList =  FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVStoreIssueNoteItemMapEntityList =  FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVStoreIssueNoteItemMapEntityList =  FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVStoreIssueNoteItemMapEntityList != null && iNVStoreIssueNoteItemMapEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVStoreIssueNoteItemMapEntityList ?? new List<INVStoreIssueNoteItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVStoreIssueNoteItemMapEntity> GetData()
        {
            IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList = new List<INVStoreIssueNoteItemMapEntity>();
            
            try
            {
                iNVStoreIssueNoteItemMapEntityList = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVStoreIssueNoteItemMapEntityList != null && iNVStoreIssueNoteItemMapEntityList.Count > 0)
                {
                    totalRowCount = iNVStoreIssueNoteItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVStoreIssueNoteItemMapEntityList ?? new List<INVStoreIssueNoteItemMapEntity>();
        }
    }
}
