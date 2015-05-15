// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 22-May-2012, 02:43:38




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
    public partial class BDProjectFloorDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectFloorDataSource()
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
        public IList<BDProjectFloorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectFloorEntity> bDProjectFloorEntityList = new List<BDProjectFloorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectFloorEntity.FLD_NAME_ProjectFloorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectFloorEntityList = FCCBDProjectFloor.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectFloorEntityList != null && bDProjectFloorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectFloorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectFloorEntityList ?? new List<BDProjectFloorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectFloorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectFloorEntity> bDProjectFloorEntityList = new List<BDProjectFloorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectFloorEntity.FLD_NAME_ProjectFloorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectFloorEntityList =  FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectFloorEntityList =  FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectFloorEntityList =  FCCBDProjectFloor.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectFloorEntityList =  FCCBDProjectFloor.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectFloorEntityList != null && bDProjectFloorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectFloorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectFloorEntityList ?? new List<BDProjectFloorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectFloorEntity> GetData()
        {
            IList<BDProjectFloorEntity> bDProjectFloorEntityList = new List<BDProjectFloorEntity>();
            
            try
            {
                bDProjectFloorEntityList = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectFloorEntityList != null && bDProjectFloorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectFloorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectFloorEntityList ?? new List<BDProjectFloorEntity>();
        }
    }
}
