// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
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
    public partial class PRMMaterialReceiveItemMapDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMMaterialReceiveItemMapDataSource()
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
        public IList<PRMMaterialReceiveItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMMaterialReceiveItemMapEntity> pRMMaterialReceiveItemMapEntityList = new List<PRMMaterialReceiveItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMMaterialReceiveItemMapEntityList = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMMaterialReceiveItemMapEntityList != null && pRMMaterialReceiveItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMMaterialReceiveItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMMaterialReceiveItemMapEntityList ?? new List<PRMMaterialReceiveItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMMaterialReceiveItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMMaterialReceiveItemMapEntity> pRMMaterialReceiveItemMapEntityList = new List<PRMMaterialReceiveItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMMaterialReceiveItemMapEntityList =  FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMMaterialReceiveItemMapEntityList =  FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMMaterialReceiveItemMapEntityList =  FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMMaterialReceiveItemMapEntityList =  FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMMaterialReceiveItemMapEntityList != null && pRMMaterialReceiveItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMMaterialReceiveItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMMaterialReceiveItemMapEntityList ?? new List<PRMMaterialReceiveItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMMaterialReceiveItemMapEntity> GetData()
        {
            IList<PRMMaterialReceiveItemMapEntity> pRMMaterialReceiveItemMapEntityList = new List<PRMMaterialReceiveItemMapEntity>();
            
            try
            {
                pRMMaterialReceiveItemMapEntityList = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMMaterialReceiveItemMapEntityList != null && pRMMaterialReceiveItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMMaterialReceiveItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMMaterialReceiveItemMapEntityList ?? new List<PRMMaterialReceiveItemMapEntity>();
        }
    }
}
