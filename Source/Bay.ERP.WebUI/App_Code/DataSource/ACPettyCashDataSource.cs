// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class ACPettyCashDataSource
    {
        public Int32 totalRowCount = 0;

        public ACPettyCashDataSource()
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
        public IList<ACPettyCashEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACPettyCashEntity> aCPettyCashEntityList = new List<ACPettyCashEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACPettyCashEntity.FLD_NAME_ACPettyCashID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCPettyCashEntityList = FCCACPettyCash.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCPettyCashEntityList != null && aCPettyCashEntityList.Count > 0)
                {
                    totalRowCount = aCPettyCashEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCPettyCashEntityList ?? new List<ACPettyCashEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACPettyCashEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACPettyCashEntity> aCPettyCashEntityList = new List<ACPettyCashEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACPettyCashEntity.FLD_NAME_ACPettyCashID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCPettyCashEntityList =  FCCACPettyCash.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCPettyCashEntityList =  FCCACPettyCash.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCPettyCashEntityList =  FCCACPettyCash.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCPettyCashEntityList =  FCCACPettyCash.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCPettyCashEntityList != null && aCPettyCashEntityList.Count > 0)
                {
                    totalRowCount = aCPettyCashEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCPettyCashEntityList ?? new List<ACPettyCashEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACPettyCashEntity> GetData()
        {
            IList<ACPettyCashEntity> aCPettyCashEntityList = new List<ACPettyCashEntity>();
            
            try
            {
                aCPettyCashEntityList = FCCACPettyCash.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCPettyCashEntityList != null && aCPettyCashEntityList.Count > 0)
                {
                    totalRowCount = aCPettyCashEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCPettyCashEntityList ?? new List<ACPettyCashEntity>();
        }
    }
}
