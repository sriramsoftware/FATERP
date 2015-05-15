// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-May-2012, 04:19:57




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
    public partial class PRMPreBOQDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMPreBOQDataSource()
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
        public IList<PRMPreBOQEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMPreBOQEntity> pRMPreBOQEntityList = new List<PRMPreBOQEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQEntity.FLD_NAME_PreBOQID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMPreBOQEntityList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMPreBOQEntityList != null && pRMPreBOQEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMPreBOQEntityList ?? new List<PRMPreBOQEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMPreBOQEntity> pRMPreBOQEntityList = new List<PRMPreBOQEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQEntity.FLD_NAME_PreBOQID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMPreBOQEntityList =  FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMPreBOQEntityList =  FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMPreBOQEntityList =  FCCPRMPreBOQ.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMPreBOQEntityList =  FCCPRMPreBOQ.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMPreBOQEntityList != null && pRMPreBOQEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMPreBOQEntityList ?? new List<PRMPreBOQEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQEntity> GetData()
        {
            IList<PRMPreBOQEntity> pRMPreBOQEntityList = new List<PRMPreBOQEntity>();
            
            try
            {
                pRMPreBOQEntityList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMPreBOQEntityList != null && pRMPreBOQEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMPreBOQEntityList ?? new List<PRMPreBOQEntity>();
        }
    }
}
