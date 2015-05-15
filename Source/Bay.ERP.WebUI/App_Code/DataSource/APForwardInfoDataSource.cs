// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    public partial class APForwardInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public APForwardInfoDataSource()
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
        public IList<APForwardInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APForwardInfoEntity> aPForwardInfoEntityList = new List<APForwardInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APForwardInfoEntity.FLD_NAME_APForwardInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPForwardInfoEntityList = FCCAPForwardInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPForwardInfoEntityList != null && aPForwardInfoEntityList.Count > 0)
                {
                    totalRowCount = aPForwardInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPForwardInfoEntityList ?? new List<APForwardInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APForwardInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APForwardInfoEntity> aPForwardInfoEntityList = new List<APForwardInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APForwardInfoEntity.FLD_NAME_APForwardInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPForwardInfoEntityList =  FCCAPForwardInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPForwardInfoEntityList =  FCCAPForwardInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPForwardInfoEntityList =  FCCAPForwardInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPForwardInfoEntityList =  FCCAPForwardInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPForwardInfoEntityList != null && aPForwardInfoEntityList.Count > 0)
                {
                    totalRowCount = aPForwardInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPForwardInfoEntityList ?? new List<APForwardInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APForwardInfoEntity> GetData()
        {
            IList<APForwardInfoEntity> aPForwardInfoEntityList = new List<APForwardInfoEntity>();
            
            try
            {
                aPForwardInfoEntityList = FCCAPForwardInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPForwardInfoEntityList != null && aPForwardInfoEntityList.Count > 0)
                {
                    totalRowCount = aPForwardInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPForwardInfoEntityList ?? new List<APForwardInfoEntity>();
        }
    }
}
