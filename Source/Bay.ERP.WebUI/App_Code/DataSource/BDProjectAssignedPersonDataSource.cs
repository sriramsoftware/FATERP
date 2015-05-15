// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




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
    public partial class BDProjectAssignedPersonDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectAssignedPersonDataSource()
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
        public IList<BDProjectAssignedPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList = new List<BDProjectAssignedPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectAssignedPersonEntity.FLD_NAME_ProjectAssignedPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectAssignedPersonEntityList = FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectAssignedPersonEntityList != null && bDProjectAssignedPersonEntityList.Count > 0)
                {
                    totalRowCount = bDProjectAssignedPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectAssignedPersonEntityList ?? new List<BDProjectAssignedPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectAssignedPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList = new List<BDProjectAssignedPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectAssignedPersonEntity.FLD_NAME_ProjectAssignedPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectAssignedPersonEntityList =  FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectAssignedPersonEntityList =  FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectAssignedPersonEntityList =  FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectAssignedPersonEntityList =  FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectAssignedPersonEntityList != null && bDProjectAssignedPersonEntityList.Count > 0)
                {
                    totalRowCount = bDProjectAssignedPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectAssignedPersonEntityList ?? new List<BDProjectAssignedPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectAssignedPersonEntity> GetData()
        {
            IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList = new List<BDProjectAssignedPersonEntity>();
            
            try
            {
                bDProjectAssignedPersonEntityList = FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectAssignedPersonEntityList != null && bDProjectAssignedPersonEntityList.Count > 0)
                {
                    totalRowCount = bDProjectAssignedPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectAssignedPersonEntityList ?? new List<BDProjectAssignedPersonEntity>();
        }
    }
}
