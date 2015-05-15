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
    public partial class ACItemAccountMapDataSource
    {
        public Int32 totalRowCount = 0;

        public ACItemAccountMapDataSource()
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
        public IList<ACItemAccountMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACItemAccountMapEntity> aCItemAccountMapEntityList = new List<ACItemAccountMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACItemAccountMapEntity.FLD_NAME_ItemAccountMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCItemAccountMapEntityList = FCCACItemAccountMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCItemAccountMapEntityList != null && aCItemAccountMapEntityList.Count > 0)
                {
                    totalRowCount = aCItemAccountMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCItemAccountMapEntityList ?? new List<ACItemAccountMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACItemAccountMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACItemAccountMapEntity> aCItemAccountMapEntityList = new List<ACItemAccountMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACItemAccountMapEntity.FLD_NAME_ItemAccountMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCItemAccountMapEntityList =  FCCACItemAccountMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCItemAccountMapEntityList =  FCCACItemAccountMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCItemAccountMapEntityList =  FCCACItemAccountMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCItemAccountMapEntityList =  FCCACItemAccountMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCItemAccountMapEntityList != null && aCItemAccountMapEntityList.Count > 0)
                {
                    totalRowCount = aCItemAccountMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCItemAccountMapEntityList ?? new List<ACItemAccountMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACItemAccountMapEntity> GetData()
        {
            IList<ACItemAccountMapEntity> aCItemAccountMapEntityList = new List<ACItemAccountMapEntity>();
            
            try
            {
                aCItemAccountMapEntityList = FCCACItemAccountMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCItemAccountMapEntityList != null && aCItemAccountMapEntityList.Count > 0)
                {
                    totalRowCount = aCItemAccountMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCItemAccountMapEntityList ?? new List<ACItemAccountMapEntity>();
        }
    }
}
