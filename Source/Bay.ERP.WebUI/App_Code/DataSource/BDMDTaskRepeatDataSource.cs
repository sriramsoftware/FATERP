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
    public partial class BDMDTaskRepeatDataSource
    {
        public Int32 totalRowCount = 0;

        public BDMDTaskRepeatDataSource()
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
        public IList<BDMDTaskRepeatEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDMDTaskRepeatEntity> bDMDTaskRepeatEntityList = new List<BDMDTaskRepeatEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDTaskRepeatEntity.FLD_NAME_TaskRepeatID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDMDTaskRepeatEntityList = FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDMDTaskRepeatEntityList != null && bDMDTaskRepeatEntityList.Count > 0)
                {
                    totalRowCount = bDMDTaskRepeatEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDTaskRepeatEntityList ?? new List<BDMDTaskRepeatEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDTaskRepeatEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDMDTaskRepeatEntity> bDMDTaskRepeatEntityList = new List<BDMDTaskRepeatEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDMDTaskRepeatEntity.FLD_NAME_TaskRepeatID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDTaskRepeatEntityList =  FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDMDTaskRepeatEntityList =  FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDMDTaskRepeatEntityList =  FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDMDTaskRepeatEntityList =  FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDMDTaskRepeatEntityList != null && bDMDTaskRepeatEntityList.Count > 0)
                {
                    totalRowCount = bDMDTaskRepeatEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDMDTaskRepeatEntityList ?? new List<BDMDTaskRepeatEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDMDTaskRepeatEntity> GetData()
        {
            IList<BDMDTaskRepeatEntity> bDMDTaskRepeatEntityList = new List<BDMDTaskRepeatEntity>();
            
            try
            {
                bDMDTaskRepeatEntityList = FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDMDTaskRepeatEntityList != null && bDMDTaskRepeatEntityList.Count > 0)
                {
                    totalRowCount = bDMDTaskRepeatEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDMDTaskRepeatEntityList ?? new List<BDMDTaskRepeatEntity>();
        }
    }
}