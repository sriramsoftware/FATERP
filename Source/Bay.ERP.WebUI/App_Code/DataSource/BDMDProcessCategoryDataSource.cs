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
    public partial class BDMDProcessCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public BDMDProcessCategoryDataSource()
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
        public IList<BDMDProcessCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDMDProcessCategoryEntity> bDMDProcessCategoryEntityList = new List<BDMDProcessCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDProcessCategoryEntity.FLD_NAME_ProcessCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDMDProcessCategoryEntityList = FCCBDMDProcessCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDMDProcessCategoryEntityList != null && bDMDProcessCategoryEntityList.Count > 0)
                {
                    totalRowCount = bDMDProcessCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDProcessCategoryEntityList ?? new List<BDMDProcessCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDProcessCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDMDProcessCategoryEntity> bDMDProcessCategoryEntityList = new List<BDMDProcessCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDProcessCategoryEntity.FLD_NAME_ProcessCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDProcessCategoryEntityList =  FCCBDMDProcessCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDMDProcessCategoryEntityList =  FCCBDMDProcessCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDProcessCategoryEntityList =  FCCBDMDProcessCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDMDProcessCategoryEntityList =  FCCBDMDProcessCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDMDProcessCategoryEntityList != null && bDMDProcessCategoryEntityList.Count > 0)
                {
                    totalRowCount = bDMDProcessCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDProcessCategoryEntityList ?? new List<BDMDProcessCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDProcessCategoryEntity> GetData()
        {
            IList<BDMDProcessCategoryEntity> bDMDProcessCategoryEntityList = new List<BDMDProcessCategoryEntity>();
            
            try
            {
                bDMDProcessCategoryEntityList = FCCBDMDProcessCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDMDProcessCategoryEntityList != null && bDMDProcessCategoryEntityList.Count > 0)
                {
                    totalRowCount = bDMDProcessCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDMDProcessCategoryEntityList ?? new List<BDMDProcessCategoryEntity>();
        }
    }
}
