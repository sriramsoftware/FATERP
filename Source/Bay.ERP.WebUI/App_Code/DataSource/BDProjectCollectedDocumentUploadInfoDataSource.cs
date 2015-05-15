// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Nov-2011, 02:22:45




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
    public partial class BDProjectCollectedDocumentUploadInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectCollectedDocumentUploadInfoDataSource()
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
        public IList<BDProjectCollectedDocumentUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList = new List<BDProjectCollectedDocumentUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectCollectedDocumentUploadInfoEntityList = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectCollectedDocumentUploadInfoEntityList != null && bDProjectCollectedDocumentUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectCollectedDocumentUploadInfoEntityList ?? new List<BDProjectCollectedDocumentUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectCollectedDocumentUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList = new List<BDProjectCollectedDocumentUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectCollectedDocumentUploadInfoEntityList =  FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectCollectedDocumentUploadInfoEntityList =  FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectCollectedDocumentUploadInfoEntityList =  FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectCollectedDocumentUploadInfoEntityList =  FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectCollectedDocumentUploadInfoEntityList != null && bDProjectCollectedDocumentUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectCollectedDocumentUploadInfoEntityList ?? new List<BDProjectCollectedDocumentUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectCollectedDocumentUploadInfoEntity> GetData()
        {
            IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList = new List<BDProjectCollectedDocumentUploadInfoEntity>();
            
            try
            {
                bDProjectCollectedDocumentUploadInfoEntityList = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectCollectedDocumentUploadInfoEntityList != null && bDProjectCollectedDocumentUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectCollectedDocumentUploadInfoEntityList ?? new List<BDProjectCollectedDocumentUploadInfoEntity>();
        }
    }
}
