// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 07-Mar-2012, 03:28:59




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
    public partial class BDProjectCollectedDocumentInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectCollectedDocumentInfoDataSource()
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
        public IList<BDProjectCollectedDocumentInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList = new List<BDProjectCollectedDocumentInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectCollectedDocumentInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectCollectedDocumentInfoEntityList = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectCollectedDocumentInfoEntityList != null && bDProjectCollectedDocumentInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectCollectedDocumentInfoEntityList ?? new List<BDProjectCollectedDocumentInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectCollectedDocumentInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList = new List<BDProjectCollectedDocumentInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectCollectedDocumentInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectCollectedDocumentInfoEntityList =  FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectCollectedDocumentInfoEntityList =  FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectCollectedDocumentInfoEntityList =  FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectCollectedDocumentInfoEntityList =  FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectCollectedDocumentInfoEntityList != null && bDProjectCollectedDocumentInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectCollectedDocumentInfoEntityList ?? new List<BDProjectCollectedDocumentInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectCollectedDocumentInfoEntity> GetData()
        {
            IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList = new List<BDProjectCollectedDocumentInfoEntity>();
            
            try
            {
                bDProjectCollectedDocumentInfoEntityList = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectCollectedDocumentInfoEntityList != null && bDProjectCollectedDocumentInfoEntityList.Count > 0)
                {
                    totalRowCount = bDProjectCollectedDocumentInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectCollectedDocumentInfoEntityList ?? new List<BDProjectCollectedDocumentInfoEntity>();
        }
    }
}
