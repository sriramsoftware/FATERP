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
    public partial class CRMMDAgreementVariableDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDAgreementVariableDataSource()
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
        public IList<CRMMDAgreementVariableEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDAgreementVariableEntity> cRMMDAgreementVariableEntityList = new List<CRMMDAgreementVariableEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAgreementVariableEntity.FLD_NAME_AgreementVariableID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDAgreementVariableEntityList = FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDAgreementVariableEntityList != null && cRMMDAgreementVariableEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementVariableEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAgreementVariableEntityList ?? new List<CRMMDAgreementVariableEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAgreementVariableEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDAgreementVariableEntity> cRMMDAgreementVariableEntityList = new List<CRMMDAgreementVariableEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDAgreementVariableEntity.FLD_NAME_AgreementVariableID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAgreementVariableEntityList =  FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDAgreementVariableEntityList =  FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDAgreementVariableEntityList =  FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDAgreementVariableEntityList =  FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDAgreementVariableEntityList != null && cRMMDAgreementVariableEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementVariableEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDAgreementVariableEntityList ?? new List<CRMMDAgreementVariableEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDAgreementVariableEntity> GetData()
        {
            IList<CRMMDAgreementVariableEntity> cRMMDAgreementVariableEntityList = new List<CRMMDAgreementVariableEntity>();
            
            try
            {
                cRMMDAgreementVariableEntityList = FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDAgreementVariableEntityList != null && cRMMDAgreementVariableEntityList.Count > 0)
                {
                    totalRowCount = cRMMDAgreementVariableEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDAgreementVariableEntityList ?? new List<CRMMDAgreementVariableEntity>();
        }
    }
}
