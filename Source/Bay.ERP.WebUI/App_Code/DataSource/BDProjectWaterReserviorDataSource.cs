// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public partial class BDProjectWaterReserviorDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectWaterReserviorDataSource()
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
        public IList<BDProjectWaterReserviorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList = new List<BDProjectWaterReserviorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectWaterReserviorEntity.FLD_NAME_ProjectWaterReserviorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectWaterReserviorEntityList = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectWaterReserviorEntityList != null && bDProjectWaterReserviorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectWaterReserviorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectWaterReserviorEntityList ?? new List<BDProjectWaterReserviorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectWaterReserviorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList = new List<BDProjectWaterReserviorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectWaterReserviorEntity.FLD_NAME_ProjectWaterReserviorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectWaterReserviorEntityList = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectWaterReserviorEntityList = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectWaterReserviorEntityList = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectWaterReserviorEntityList = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectWaterReserviorEntityList != null && bDProjectWaterReserviorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectWaterReserviorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectWaterReserviorEntityList ?? new List<BDProjectWaterReserviorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectWaterReserviorEntity> GetData()
        {
            IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntity = new List<BDProjectWaterReserviorEntity>();
            
            try
            {
                bDProjectWaterReserviorEntity = FCCBDProjectWaterReservior.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectWaterReserviorEntity != null && bDProjectWaterReserviorEntity.Count > 0)
                {
                    totalRowCount = bDProjectWaterReserviorEntity[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectWaterReserviorEntity ?? new List<BDProjectWaterReserviorEntity>();
        }
    }
}
