// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class CMNFavoriteDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNFavoriteDataSource()
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
        public IList<CMNFavoriteEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNFavoriteEntity> cMNFavoriteEntityList = new List<CMNFavoriteEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNFavoriteEntity.FLD_NAME_FavoriteID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNFavoriteEntityList = FCCCMNFavorite.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNFavoriteEntityList != null && cMNFavoriteEntityList.Count > 0)
                {
                    totalRowCount = cMNFavoriteEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNFavoriteEntityList ?? new List<CMNFavoriteEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNFavoriteEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNFavoriteEntity> cMNFavoriteEntityList = new List<CMNFavoriteEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNFavoriteEntity.FLD_NAME_FavoriteID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNFavoriteEntityList =  FCCCMNFavorite.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNFavoriteEntityList =  FCCCMNFavorite.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNFavoriteEntityList =  FCCCMNFavorite.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNFavoriteEntityList =  FCCCMNFavorite.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNFavoriteEntityList != null && cMNFavoriteEntityList.Count > 0)
                {
                    totalRowCount = cMNFavoriteEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNFavoriteEntityList ?? new List<CMNFavoriteEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNFavoriteEntity> GetData()
        {
            IList<CMNFavoriteEntity> cMNFavoriteEntityList = new List<CMNFavoriteEntity>();
            
            try
            {
                cMNFavoriteEntityList = FCCCMNFavorite.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNFavoriteEntityList != null && cMNFavoriteEntityList.Count > 0)
                {
                    totalRowCount = cMNFavoriteEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNFavoriteEntityList ?? new List<CMNFavoriteEntity>();
        }
    }
}
