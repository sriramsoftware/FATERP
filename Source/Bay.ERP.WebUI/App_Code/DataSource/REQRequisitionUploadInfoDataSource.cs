// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    public partial class REQRequisitionUploadInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionUploadInfoDataSource()
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
        public IList<REQRequisitionUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList = new List<REQRequisitionUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                rEQRequisitionUploadInfoEntityList = FCCREQRequisitionUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (rEQRequisitionUploadInfoEntityList != null && rEQRequisitionUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionUploadInfoEntityList ?? new List<REQRequisitionUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionUploadInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList = new List<REQRequisitionUploadInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionUploadInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionUploadInfoEntityList =  FCCREQRequisitionUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionUploadInfoEntityList =  FCCREQRequisitionUploadInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionUploadInfoEntityList =  FCCREQRequisitionUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionUploadInfoEntityList =  FCCREQRequisitionUploadInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (rEQRequisitionUploadInfoEntityList != null && rEQRequisitionUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionUploadInfoEntityList ?? new List<REQRequisitionUploadInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionUploadInfoEntity> GetData()
        {
            IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList = new List<REQRequisitionUploadInfoEntity>();
            
            try
            {
                rEQRequisitionUploadInfoEntityList = FCCREQRequisitionUploadInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (rEQRequisitionUploadInfoEntityList != null && rEQRequisitionUploadInfoEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionUploadInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return rEQRequisitionUploadInfoEntityList ?? new List<REQRequisitionUploadInfoEntity>();
        }
    }
}
