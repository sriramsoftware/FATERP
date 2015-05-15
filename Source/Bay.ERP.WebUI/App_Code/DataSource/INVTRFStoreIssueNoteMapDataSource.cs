// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




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
    public partial class INVTRFStoreIssueNoteMapDataSource
    {
        public Int32 totalRowCount = 0;

        public INVTRFStoreIssueNoteMapDataSource()
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
        public IList<INVTRFStoreIssueNoteMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList = new List<INVTRFStoreIssueNoteMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTRFStoreIssueNoteMapEntity.FLD_NAME_TRFStoreIssueNoteMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVTRFStoreIssueNoteMapEntityList = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVTRFStoreIssueNoteMapEntityList != null && iNVTRFStoreIssueNoteMapEntityList.Count > 0)
                {
                    totalRowCount = iNVTRFStoreIssueNoteMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTRFStoreIssueNoteMapEntityList ?? new List<INVTRFStoreIssueNoteMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTRFStoreIssueNoteMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList = new List<INVTRFStoreIssueNoteMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTRFStoreIssueNoteMapEntity.FLD_NAME_TRFStoreIssueNoteMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTRFStoreIssueNoteMapEntityList =  FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVTRFStoreIssueNoteMapEntityList =  FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTRFStoreIssueNoteMapEntityList =  FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVTRFStoreIssueNoteMapEntityList =  FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVTRFStoreIssueNoteMapEntityList != null && iNVTRFStoreIssueNoteMapEntityList.Count > 0)
                {
                    totalRowCount = iNVTRFStoreIssueNoteMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTRFStoreIssueNoteMapEntityList ?? new List<INVTRFStoreIssueNoteMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTRFStoreIssueNoteMapEntity> GetData()
        {
            IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList = new List<INVTRFStoreIssueNoteMapEntity>();
            
            try
            {
                iNVTRFStoreIssueNoteMapEntityList = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVTRFStoreIssueNoteMapEntityList != null && iNVTRFStoreIssueNoteMapEntityList.Count > 0)
                {
                    totalRowCount = iNVTRFStoreIssueNoteMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVTRFStoreIssueNoteMapEntityList ?? new List<INVTRFStoreIssueNoteMapEntity>();
        }
    }
}
