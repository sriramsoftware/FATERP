// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    public partial class REQRequisitionItemFloorDetailDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionItemFloorDetailDataSource()
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
        public IList<REQRequisitionItemFloorDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList = new List<REQRequisitionItemFloorDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemFloorDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                rEQRequisitionItemFloorDetailEntityList = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (rEQRequisitionItemFloorDetailEntityList != null && rEQRequisitionItemFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionItemFloorDetailEntityList ?? new List<REQRequisitionItemFloorDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionItemFloorDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList = new List<REQRequisitionItemFloorDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemFloorDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionItemFloorDetailEntityList =  FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionItemFloorDetailEntityList =  FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionItemFloorDetailEntityList =  FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionItemFloorDetailEntityList =  FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (rEQRequisitionItemFloorDetailEntityList != null && rEQRequisitionItemFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionItemFloorDetailEntityList ?? new List<REQRequisitionItemFloorDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionItemFloorDetailEntity> GetData()
        {
            IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList = new List<REQRequisitionItemFloorDetailEntity>();
            
            try
            {
                rEQRequisitionItemFloorDetailEntityList = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (rEQRequisitionItemFloorDetailEntityList != null && rEQRequisitionItemFloorDetailEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemFloorDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return rEQRequisitionItemFloorDetailEntityList ?? new List<REQRequisitionItemFloorDetailEntity>();
        }
    }
}
