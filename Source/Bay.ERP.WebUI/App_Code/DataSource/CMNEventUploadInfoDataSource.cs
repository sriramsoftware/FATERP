// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




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
    public partial class CMNEventUploadInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNEventUploadInfoDataSource()
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
        public IList<CMNEventUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNEventUploadInfoEntity> cMNEventUploadInfoEntityList = new List<CMNEventUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNEventUploadInfoEntity.FLD_NAME_EventUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNEventUploadInfoEntityList = FCCCMNEventUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNEventUploadInfoEntityList != null && cMNEventUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = cMNEventUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNEventUploadInfoEntityList ?? new List<CMNEventUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNEventUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNEventUploadInfoEntity> cMNEventUploadInfoEntityList = new List<CMNEventUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNEventUploadInfoEntity.FLD_NAME_EventUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNEventUploadInfoEntityList =  FCCCMNEventUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNEventUploadInfoEntityList =  FCCCMNEventUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNEventUploadInfoEntityList =  FCCCMNEventUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNEventUploadInfoEntityList =  FCCCMNEventUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNEventUploadInfoEntityList != null && cMNEventUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = cMNEventUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNEventUploadInfoEntityList ?? new List<CMNEventUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNEventUploadInfoEntity> GetData()
        {
            IList<CMNEventUploadInfoEntity> cMNEventUploadInfoEntityList = new List<CMNEventUploadInfoEntity>();
            
            try
            {
                cMNEventUploadInfoEntityList = FCCCMNEventUploadInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNEventUploadInfoEntityList != null && cMNEventUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = cMNEventUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNEventUploadInfoEntityList ?? new List<CMNEventUploadInfoEntity>();
        }
    }
}
