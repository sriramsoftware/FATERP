// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 10:46:54




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
    public partial class BDOperatorAddressInfoDataSource
    {
        public Int32 totalRowCount = 0;

        public BDOperatorAddressInfoDataSource()
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
        public IList<BDOperatorAddressInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList = new List<BDOperatorAddressInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDOperatorAddressInfoEntity.FLD_NAME_OperatorAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDOperatorAddressInfoEntityList = FCCBDOperatorAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDOperatorAddressInfoEntityList != null && bDOperatorAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = bDOperatorAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDOperatorAddressInfoEntityList ?? new List<BDOperatorAddressInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDOperatorAddressInfoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList = new List<BDOperatorAddressInfoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDOperatorAddressInfoEntity.FLD_NAME_OperatorAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDOperatorAddressInfoEntityList =  FCCBDOperatorAddressInfo.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDOperatorAddressInfoEntityList =  FCCBDOperatorAddressInfo.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDOperatorAddressInfoEntityList =  FCCBDOperatorAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDOperatorAddressInfoEntityList =  FCCBDOperatorAddressInfo.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDOperatorAddressInfoEntityList != null && bDOperatorAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = bDOperatorAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDOperatorAddressInfoEntityList ?? new List<BDOperatorAddressInfoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDOperatorAddressInfoEntity> GetData()
        {
            IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList = new List<BDOperatorAddressInfoEntity>();
            
            try
            {
                bDOperatorAddressInfoEntityList = FCCBDOperatorAddressInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDOperatorAddressInfoEntityList != null && bDOperatorAddressInfoEntityList.Count > 0)
                {
                    totalRowCount = bDOperatorAddressInfoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDOperatorAddressInfoEntityList ?? new List<BDOperatorAddressInfoEntity>();
        }
    }
}