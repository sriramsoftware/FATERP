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
    public partial class ACAccountGroupDataSource
    {
        public Int32 totalRowCount = 0;

        public ACAccountGroupDataSource()
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
        public IList<ACAccountGroupEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACAccountGroupEntity> aCAccountGroupEntityList = new List<ACAccountGroupEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACAccountGroupEntity.FLD_NAME_AccountGroupID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCAccountGroupEntityList = FCCACAccountGroup.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCAccountGroupEntityList != null && aCAccountGroupEntityList.Count > 0)
                {
                    totalRowCount = aCAccountGroupEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCAccountGroupEntityList ?? new List<ACAccountGroupEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACAccountGroupEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACAccountGroupEntity> aCAccountGroupEntityList = new List<ACAccountGroupEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACAccountGroupEntity.FLD_NAME_AccountGroupID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCAccountGroupEntityList =  FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCAccountGroupEntityList =  FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCAccountGroupEntityList =  FCCACAccountGroup.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCAccountGroupEntityList =  FCCACAccountGroup.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCAccountGroupEntityList != null && aCAccountGroupEntityList.Count > 0)
                {
                    totalRowCount = aCAccountGroupEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCAccountGroupEntityList ?? new List<ACAccountGroupEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACAccountGroupEntity> GetData()
        {
            IList<ACAccountGroupEntity> aCAccountGroupEntityList = new List<ACAccountGroupEntity>();
            
            try
            {
                aCAccountGroupEntityList = FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCAccountGroupEntityList != null && aCAccountGroupEntityList.Count > 0)
                {
                    totalRowCount = aCAccountGroupEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCAccountGroupEntityList ?? new List<ACAccountGroupEntity>();
        }
    }
}
