// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




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
    public partial class CMBillUploadInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public CMBillUploadInfoDataSource()
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
        public IList<CMBillUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMBillUploadInfoEntity> cMBillUploadInfoEntityList = new List<CMBillUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillUploadInfoEntity.FLD_NAME_BillUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMBillUploadInfoEntityList = FCCCMBillUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMBillUploadInfoEntityList != null && cMBillUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = cMBillUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillUploadInfoEntityList ?? new List<CMBillUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMBillUploadInfoEntity> cMBillUploadInfoEntityList = new List<CMBillUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillUploadInfoEntity.FLD_NAME_BillUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillUploadInfoEntityList =  FCCCMBillUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMBillUploadInfoEntityList =  FCCCMBillUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillUploadInfoEntityList =  FCCCMBillUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMBillUploadInfoEntityList =  FCCCMBillUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMBillUploadInfoEntityList != null && cMBillUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = cMBillUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillUploadInfoEntityList ?? new List<CMBillUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillUploadInfoEntity> GetData()
        {
            IList<CMBillUploadInfoEntity> cMBillUploadInfoEntityList = new List<CMBillUploadInfoEntity>();
            
            try
            {
                cMBillUploadInfoEntityList = FCCCMBillUploadInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMBillUploadInfoEntityList != null && cMBillUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = cMBillUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMBillUploadInfoEntityList ?? new List<CMBillUploadInfoEntity>();
        }
    }
}
