// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jun-2012, 11:52:40




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
    public partial class REQRequisitionItemDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionItemDataSource()
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
        public IList<REQRequisitionItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList = new List<REQRequisitionItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionItemEntity.FLD_NAME_RequisitionItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                rEQRequisitionItemEntityList = FCCREQRequisitionItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (rEQRequisitionItemEntityList != null && rEQRequisitionItemEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionItemEntityList ?? new List<REQRequisitionItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionItemEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList = new List<REQRequisitionItemEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionItemEntity.FLD_NAME_RequisitionItemID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionItemEntityList =  FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionItemEntityList =  FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionItemEntityList =  FCCREQRequisitionItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionItemEntityList =  FCCREQRequisitionItem.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (rEQRequisitionItemEntityList != null && rEQRequisitionItemEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionItemEntityList ?? new List<REQRequisitionItemEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionItemEntity> GetData()
        {
            IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList = new List<REQRequisitionItemEntity>();
            
            try
            {
                rEQRequisitionItemEntityList = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (rEQRequisitionItemEntityList != null && rEQRequisitionItemEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionItemEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return rEQRequisitionItemEntityList ?? new List<REQRequisitionItemEntity>();
        }
    }
}
