// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




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
    public partial class MDConstructionToolWorkingConditionDataSource
    {
        public Int32 totalRowCount = 0;

        public MDConstructionToolWorkingConditionDataSource()
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
        public IList<MDConstructionToolWorkingConditionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDConstructionToolWorkingConditionEntity> mDConstructionToolWorkingConditionEntityList = new List<MDConstructionToolWorkingConditionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDConstructionToolWorkingConditionEntity.FLD_NAME_ConstructionToolWorkingConditionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDConstructionToolWorkingConditionEntityList = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDConstructionToolWorkingConditionEntityList != null && mDConstructionToolWorkingConditionEntityList.Count > 0)
                {
                    totalRowCount = mDConstructionToolWorkingConditionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDConstructionToolWorkingConditionEntityList ?? new List<MDConstructionToolWorkingConditionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDConstructionToolWorkingConditionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDConstructionToolWorkingConditionEntity> mDConstructionToolWorkingConditionEntityList = new List<MDConstructionToolWorkingConditionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDConstructionToolWorkingConditionEntity.FLD_NAME_ConstructionToolWorkingConditionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDConstructionToolWorkingConditionEntityList =  FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDConstructionToolWorkingConditionEntityList =  FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDConstructionToolWorkingConditionEntityList =  FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDConstructionToolWorkingConditionEntityList =  FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDConstructionToolWorkingConditionEntityList != null && mDConstructionToolWorkingConditionEntityList.Count > 0)
                {
                    totalRowCount = mDConstructionToolWorkingConditionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDConstructionToolWorkingConditionEntityList ?? new List<MDConstructionToolWorkingConditionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDConstructionToolWorkingConditionEntity> GetData()
        {
            IList<MDConstructionToolWorkingConditionEntity> mDConstructionToolWorkingConditionEntityList = new List<MDConstructionToolWorkingConditionEntity>();
            
            try
            {
                mDConstructionToolWorkingConditionEntityList = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDConstructionToolWorkingConditionEntityList != null && mDConstructionToolWorkingConditionEntityList.Count > 0)
                {
                    totalRowCount = mDConstructionToolWorkingConditionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDConstructionToolWorkingConditionEntityList ?? new List<MDConstructionToolWorkingConditionEntity>();
        }
    }
}
