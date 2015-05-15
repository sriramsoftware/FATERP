// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    public partial class MDArtGalleriaLocationDataSource
    {
        public Int32 totalRowCount = 0;

        public MDArtGalleriaLocationDataSource()
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
        public IList<MDArtGalleriaLocationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList = new List<MDArtGalleriaLocationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDArtGalleriaLocationEntity.FLD_NAME_ArtGalleriaLocationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDArtGalleriaLocationEntityList = FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDArtGalleriaLocationEntityList != null && mDArtGalleriaLocationEntityList.Count > 0)
                {
                    totalRowCount = mDArtGalleriaLocationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDArtGalleriaLocationEntityList ?? new List<MDArtGalleriaLocationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDArtGalleriaLocationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList = new List<MDArtGalleriaLocationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDArtGalleriaLocationEntity.FLD_NAME_ArtGalleriaLocationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDArtGalleriaLocationEntityList =  FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDArtGalleriaLocationEntityList =  FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDArtGalleriaLocationEntityList =  FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDArtGalleriaLocationEntityList =  FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDArtGalleriaLocationEntityList != null && mDArtGalleriaLocationEntityList.Count > 0)
                {
                    totalRowCount = mDArtGalleriaLocationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDArtGalleriaLocationEntityList ?? new List<MDArtGalleriaLocationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDArtGalleriaLocationEntity> GetData()
        {
            IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList = new List<MDArtGalleriaLocationEntity>();
            
            try
            {
                mDArtGalleriaLocationEntityList = FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDArtGalleriaLocationEntityList != null && mDArtGalleriaLocationEntityList.Count > 0)
                {
                    totalRowCount = mDArtGalleriaLocationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDArtGalleriaLocationEntityList ?? new List<MDArtGalleriaLocationEntity>();
        }
    }
}
