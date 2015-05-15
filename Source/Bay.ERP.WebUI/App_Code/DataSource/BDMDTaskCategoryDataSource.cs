// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDMDTaskCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public BDMDTaskCategoryDataSource()
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
        public IList<BDMDTaskCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDMDTaskCategoryEntity> bDMDTaskCategoryEntityList = new List<BDMDTaskCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDTaskCategoryEntity.FLD_NAME_TaskCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDMDTaskCategoryEntityList = FCCBDMDTaskCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDMDTaskCategoryEntityList != null && bDMDTaskCategoryEntityList.Count > 0)
                {
                    totalRowCount = bDMDTaskCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDTaskCategoryEntityList ?? new List<BDMDTaskCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDTaskCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDMDTaskCategoryEntity> bDMDTaskCategoryEntityList = new List<BDMDTaskCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDTaskCategoryEntity.FLD_NAME_TaskCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDTaskCategoryEntityList =  FCCBDMDTaskCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDMDTaskCategoryEntityList =  FCCBDMDTaskCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDTaskCategoryEntityList =  FCCBDMDTaskCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDMDTaskCategoryEntityList =  FCCBDMDTaskCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDMDTaskCategoryEntityList != null && bDMDTaskCategoryEntityList.Count > 0)
                {
                    totalRowCount = bDMDTaskCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDTaskCategoryEntityList ?? new List<BDMDTaskCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDTaskCategoryEntity> GetData()
        {
            IList<BDMDTaskCategoryEntity> bDMDTaskCategoryEntityList = new List<BDMDTaskCategoryEntity>();
            
            try
            {
                bDMDTaskCategoryEntityList = FCCBDMDTaskCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDMDTaskCategoryEntityList != null && bDMDTaskCategoryEntityList.Count > 0)
                {
                    totalRowCount = bDMDTaskCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDMDTaskCategoryEntityList ?? new List<BDMDTaskCategoryEntity>();
        }
    }
}
