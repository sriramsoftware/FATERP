// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACItemGroupAccountMapDataSource
    {
        public Int32 totalRowCount = 0;

        public ACItemGroupAccountMapDataSource()
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
        public IList<ACItemGroupAccountMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList = new List<ACItemGroupAccountMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACItemGroupAccountMapEntity.FLD_NAME_ItemGroupAccountMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCItemGroupAccountMapEntityList = FCCACItemGroupAccountMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCItemGroupAccountMapEntityList != null && aCItemGroupAccountMapEntityList.Count > 0)
                {
                    totalRowCount = aCItemGroupAccountMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCItemGroupAccountMapEntityList ?? new List<ACItemGroupAccountMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACItemGroupAccountMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList = new List<ACItemGroupAccountMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACItemGroupAccountMapEntity.FLD_NAME_ItemGroupAccountMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCItemGroupAccountMapEntityList =  FCCACItemGroupAccountMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCItemGroupAccountMapEntityList =  FCCACItemGroupAccountMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCItemGroupAccountMapEntityList =  FCCACItemGroupAccountMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCItemGroupAccountMapEntityList =  FCCACItemGroupAccountMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCItemGroupAccountMapEntityList != null && aCItemGroupAccountMapEntityList.Count > 0)
                {
                    totalRowCount = aCItemGroupAccountMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCItemGroupAccountMapEntityList ?? new List<ACItemGroupAccountMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACItemGroupAccountMapEntity> GetData()
        {
            IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList = new List<ACItemGroupAccountMapEntity>();
            
            try
            {
                aCItemGroupAccountMapEntityList = FCCACItemGroupAccountMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCItemGroupAccountMapEntityList != null && aCItemGroupAccountMapEntityList.Count > 0)
                {
                    totalRowCount = aCItemGroupAccountMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCItemGroupAccountMapEntityList ?? new List<ACItemGroupAccountMapEntity>();
        }
    }
}
