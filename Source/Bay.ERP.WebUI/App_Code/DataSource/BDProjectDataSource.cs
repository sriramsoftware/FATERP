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
    public partial class BDProjectDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectDataSource()
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
        public IList<BDProjectEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectEntity> bDProjectEntityList = new List<BDProjectEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectEntity.FLD_NAME_ProjectCode + " " + SQLConstants.SORT_ORDER_ASCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectEntityList = FCCBDProject.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectEntityList != null && bDProjectEntityList.Count > 0)
                {
                    totalRowCount = bDProjectEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectEntityList ?? new List<BDProjectEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectEntity> bDProjectEntityList = new List<BDProjectEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectEntity.FLD_NAME_ProjectID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectEntityList =  FCCBDProject.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectEntityList =  FCCBDProject.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectEntityList =  FCCBDProject.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectEntityList =  FCCBDProject.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectEntityList != null && bDProjectEntityList.Count > 0)
                {
                    totalRowCount = bDProjectEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectEntityList ?? new List<BDProjectEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectEntity> GetData()
        {
            IList<BDProjectEntity> bDProjectEntityList = new List<BDProjectEntity>();
            
            try
            {
                bDProjectEntityList = FCCBDProject.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectEntityList != null && bDProjectEntityList.Count > 0)
                {
                    totalRowCount = bDProjectEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectEntityList ?? new List<BDProjectEntity>();
        }
    }
}
