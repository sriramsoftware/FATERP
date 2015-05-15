// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




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
    public partial class ACClassDataSource
    {
        public Int32 totalRowCount = 0;

        public ACClassDataSource()
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
        public IList<ACClassEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACClassEntity> aCClassEntityList = new List<ACClassEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACClassEntity.FLD_NAME_ClassID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCClassEntityList = FCCACClass.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCClassEntityList != null && aCClassEntityList.Count > 0)
                {
                    totalRowCount = aCClassEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCClassEntityList ?? new List<ACClassEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACClassEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACClassEntity> aCClassEntityList = new List<ACClassEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACClassEntity.FLD_NAME_ClassID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCClassEntityList =  FCCACClass.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCClassEntityList =  FCCACClass.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCClassEntityList =  FCCACClass.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCClassEntityList =  FCCACClass.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCClassEntityList != null && aCClassEntityList.Count > 0)
                {
                    totalRowCount = aCClassEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCClassEntityList ?? new List<ACClassEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACClassEntity> GetData()
        {
            IList<ACClassEntity> aCClassEntityList = new List<ACClassEntity>();
            
            try
            {
                aCClassEntityList = FCCACClass.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCClassEntityList != null && aCClassEntityList.Count > 0)
                {
                    totalRowCount = aCClassEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCClassEntityList ?? new List<ACClassEntity>();
        }
    }
}
