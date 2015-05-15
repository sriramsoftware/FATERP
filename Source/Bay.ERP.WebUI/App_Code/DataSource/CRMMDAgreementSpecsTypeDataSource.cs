// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMMDAgreementSpecsTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDAgreementSpecsTypeDataSource()
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
        public IList<CRMMDAgreementSpecsTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList = new List<CRMMDAgreementSpecsTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAgreementSpecsTypeEntity.FLD_NAME_AgreementSpecsTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDAgreementSpecsTypeEntityList = FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDAgreementSpecsTypeEntityList != null && cRMMDAgreementSpecsTypeEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementSpecsTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAgreementSpecsTypeEntityList ?? new List<CRMMDAgreementSpecsTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAgreementSpecsTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList = new List<CRMMDAgreementSpecsTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAgreementSpecsTypeEntity.FLD_NAME_AgreementSpecsTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAgreementSpecsTypeEntityList =  FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDAgreementSpecsTypeEntityList =  FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAgreementSpecsTypeEntityList =  FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDAgreementSpecsTypeEntityList =  FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDAgreementSpecsTypeEntityList != null && cRMMDAgreementSpecsTypeEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementSpecsTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAgreementSpecsTypeEntityList ?? new List<CRMMDAgreementSpecsTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAgreementSpecsTypeEntity> GetData()
        {
            IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList = new List<CRMMDAgreementSpecsTypeEntity>();
            
            try
            {
                cRMMDAgreementSpecsTypeEntityList = FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDAgreementSpecsTypeEntityList != null && cRMMDAgreementSpecsTypeEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementSpecsTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDAgreementSpecsTypeEntityList ?? new List<CRMMDAgreementSpecsTypeEntity>();
        }
    }
}
