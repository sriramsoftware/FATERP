// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
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
    public partial class CMMDBillFloorDetailCategoryDataSource
    {
        public Int32 totalRowCount = 0;

        public CMMDBillFloorDetailCategoryDataSource()
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
        public IList<CMMDBillFloorDetailCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList = new List<CMMDBillFloorDetailCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMMDBillFloorDetailCategoryEntity.FLD_NAME_BillFloorDetailCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMMDBillFloorDetailCategoryEntityList = FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMMDBillFloorDetailCategoryEntityList != null && cMMDBillFloorDetailCategoryEntityList.Count > 0)
                {
                    totalRowCount = cMMDBillFloorDetailCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMMDBillFloorDetailCategoryEntityList ?? new List<CMMDBillFloorDetailCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMMDBillFloorDetailCategoryEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList = new List<CMMDBillFloorDetailCategoryEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMMDBillFloorDetailCategoryEntity.FLD_NAME_BillFloorDetailCategoryID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMMDBillFloorDetailCategoryEntityList =  FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMMDBillFloorDetailCategoryEntityList =  FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMMDBillFloorDetailCategoryEntityList =  FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMMDBillFloorDetailCategoryEntityList =  FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMMDBillFloorDetailCategoryEntityList != null && cMMDBillFloorDetailCategoryEntityList.Count > 0)
                {
                    totalRowCount = cMMDBillFloorDetailCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMMDBillFloorDetailCategoryEntityList ?? new List<CMMDBillFloorDetailCategoryEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMMDBillFloorDetailCategoryEntity> GetData()
        {
            IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList = new List<CMMDBillFloorDetailCategoryEntity>();
            
            try
            {
                cMMDBillFloorDetailCategoryEntityList = FCCCMMDBillFloorDetailCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMMDBillFloorDetailCategoryEntityList != null && cMMDBillFloorDetailCategoryEntityList.Count > 0)
                {
                    totalRowCount = cMMDBillFloorDetailCategoryEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMMDBillFloorDetailCategoryEntityList ?? new List<CMMDBillFloorDetailCategoryEntity>();
        }
    }
}
