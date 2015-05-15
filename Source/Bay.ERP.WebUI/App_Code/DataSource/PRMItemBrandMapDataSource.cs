// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class PRMItemBrandMapDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMItemBrandMapDataSource()
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
        public IList<PRMItemBrandMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMItemBrandMapEntity> pRMItemBrandMapEntityList = new List<PRMItemBrandMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMItemBrandMapEntity.FLD_NAME_ItemBrandMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMItemBrandMapEntityList = FCCPRMItemBrandMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMItemBrandMapEntityList != null && pRMItemBrandMapEntityList.Count > 0)
                {
                    totalRowCount = pRMItemBrandMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMItemBrandMapEntityList ?? new List<PRMItemBrandMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMItemBrandMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMItemBrandMapEntity> pRMItemBrandMapEntityList = new List<PRMItemBrandMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMItemBrandMapEntity.FLD_NAME_ItemBrandMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMItemBrandMapEntityList =  FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMItemBrandMapEntityList =  FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMItemBrandMapEntityList =  FCCPRMItemBrandMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMItemBrandMapEntityList =  FCCPRMItemBrandMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMItemBrandMapEntityList != null && pRMItemBrandMapEntityList.Count > 0)
                {
                    totalRowCount = pRMItemBrandMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMItemBrandMapEntityList ?? new List<PRMItemBrandMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMItemBrandMapEntity> GetData()
        {
            IList<PRMItemBrandMapEntity> pRMItemBrandMapEntityList = new List<PRMItemBrandMapEntity>();
            
            try
            {
                pRMItemBrandMapEntityList = FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMItemBrandMapEntityList != null && pRMItemBrandMapEntityList.Count > 0)
                {
                    totalRowCount = pRMItemBrandMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMItemBrandMapEntityList ?? new List<PRMItemBrandMapEntity>();
        }
    }
}
