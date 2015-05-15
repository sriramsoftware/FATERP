// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Jul-2012, 04:00:14




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
    public partial class REQRequisitionDataSource
    {
        public Int32 totalRowCount = 0;

        public REQRequisitionDataSource()
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
        public IList<REQRequisitionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<REQRequisitionEntity> rEQRequisitionEntityList = new List<REQRequisitionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionEntity.FLD_NAME_RequisitionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                rEQRequisitionEntityList = FCCREQRequisition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (rEQRequisitionEntityList != null && rEQRequisitionEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionEntityList ?? new List<REQRequisitionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<REQRequisitionEntity> rEQRequisitionEntityList = new List<REQRequisitionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = REQRequisitionEntity.FLD_NAME_RequisitionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionEntityList =  FCCREQRequisition.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionEntityList =  FCCREQRequisition.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        rEQRequisitionEntityList =  FCCREQRequisition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        rEQRequisitionEntityList =  FCCREQRequisition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (rEQRequisitionEntityList != null && rEQRequisitionEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return rEQRequisitionEntityList ?? new List<REQRequisitionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<REQRequisitionEntity> GetData()
        {
            IList<REQRequisitionEntity> rEQRequisitionEntityList = new List<REQRequisitionEntity>();
            
            try
            {
                rEQRequisitionEntityList = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (rEQRequisitionEntityList != null && rEQRequisitionEntityList.Count > 0)
                {
                    totalRowCount = rEQRequisitionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return rEQRequisitionEntityList ?? new List<REQRequisitionEntity>();
        }
    }
}
