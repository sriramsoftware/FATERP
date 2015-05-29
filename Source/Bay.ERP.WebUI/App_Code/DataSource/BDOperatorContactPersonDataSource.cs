// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




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
    public partial class BDOperatorContactPersonDataSource
    {
        public Int32 totalRowCount = 0;

        public BDOperatorContactPersonDataSource()
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
        public IList<BDOperatorContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList = new List<BDOperatorContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDOperatorContactPersonEntity.FLD_NAME_OperatorContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDOperatorContactPersonEntityList = FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDOperatorContactPersonEntityList != null && bDOperatorContactPersonEntityList.Count > 0)
                {
                    totalRowCount = bDOperatorContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDOperatorContactPersonEntityList ?? new List<BDOperatorContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDOperatorContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList = new List<BDOperatorContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDOperatorContactPersonEntity.FLD_NAME_OperatorContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDOperatorContactPersonEntityList =  FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDOperatorContactPersonEntityList =  FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDOperatorContactPersonEntityList =  FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDOperatorContactPersonEntityList =  FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDOperatorContactPersonEntityList != null && bDOperatorContactPersonEntityList.Count > 0)
                {
                    totalRowCount = bDOperatorContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDOperatorContactPersonEntityList ?? new List<BDOperatorContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDOperatorContactPersonEntity> GetData()
        {
            IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList = new List<BDOperatorContactPersonEntity>();
            
            try
            {
                bDOperatorContactPersonEntityList = FCCBDOperatorContactPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDOperatorContactPersonEntityList != null && bDOperatorContactPersonEntityList.Count > 0)
                {
                    totalRowCount = bDOperatorContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDOperatorContactPersonEntityList ?? new List<BDOperatorContactPersonEntity>();
        }
    }
}
