// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 11:12:01




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
    public partial class MDMaterialReceiveApprovalStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public MDMaterialReceiveApprovalStatusDataSource()
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
        public IList<MDMaterialReceiveApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDMaterialReceiveApprovalStatusEntity> mDMaterialReceiveApprovalStatusEntityList = new List<MDMaterialReceiveApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDMaterialReceiveApprovalStatusEntity.FLD_NAME_MaterialReceiveApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDMaterialReceiveApprovalStatusEntityList = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDMaterialReceiveApprovalStatusEntityList != null && mDMaterialReceiveApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDMaterialReceiveApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDMaterialReceiveApprovalStatusEntityList ?? new List<MDMaterialReceiveApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDMaterialReceiveApprovalStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDMaterialReceiveApprovalStatusEntity> mDMaterialReceiveApprovalStatusEntityList = new List<MDMaterialReceiveApprovalStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDMaterialReceiveApprovalStatusEntity.FLD_NAME_MaterialReceiveApprovalStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDMaterialReceiveApprovalStatusEntityList =  FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDMaterialReceiveApprovalStatusEntityList =  FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDMaterialReceiveApprovalStatusEntityList =  FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDMaterialReceiveApprovalStatusEntityList =  FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDMaterialReceiveApprovalStatusEntityList != null && mDMaterialReceiveApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDMaterialReceiveApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDMaterialReceiveApprovalStatusEntityList ?? new List<MDMaterialReceiveApprovalStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDMaterialReceiveApprovalStatusEntity> GetData()
        {
            IList<MDMaterialReceiveApprovalStatusEntity> mDMaterialReceiveApprovalStatusEntityList = new List<MDMaterialReceiveApprovalStatusEntity>();
            
            try
            {
                mDMaterialReceiveApprovalStatusEntityList = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDMaterialReceiveApprovalStatusEntityList != null && mDMaterialReceiveApprovalStatusEntityList.Count > 0)
                {
                    totalRowCount = mDMaterialReceiveApprovalStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDMaterialReceiveApprovalStatusEntityList ?? new List<MDMaterialReceiveApprovalStatusEntity>();
        }
    }
}
