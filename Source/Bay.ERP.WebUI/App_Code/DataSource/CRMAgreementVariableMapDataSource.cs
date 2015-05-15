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
    public partial class CRMAgreementVariableMapDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMAgreementVariableMapDataSource()
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
        public IList<CRMAgreementVariableMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList = new List<CRMAgreementVariableMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMAgreementVariableMapEntity.FLD_NAME_AgreementVariableMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMAgreementVariableMapEntityList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMAgreementVariableMapEntityList != null && cRMAgreementVariableMapEntityList.Count > 0)
                {
                    totalRowCount = cRMAgreementVariableMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMAgreementVariableMapEntityList ?? new List<CRMAgreementVariableMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMAgreementVariableMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList = new List<CRMAgreementVariableMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMAgreementVariableMapEntity.FLD_NAME_AgreementVariableMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMAgreementVariableMapEntityList =  FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMAgreementVariableMapEntityList =  FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMAgreementVariableMapEntityList =  FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMAgreementVariableMapEntityList =  FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMAgreementVariableMapEntityList != null && cRMAgreementVariableMapEntityList.Count > 0)
                {
                    totalRowCount = cRMAgreementVariableMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMAgreementVariableMapEntityList ?? new List<CRMAgreementVariableMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMAgreementVariableMapEntity> GetData()
        {
            IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList = new List<CRMAgreementVariableMapEntity>();
            
            try
            {
                cRMAgreementVariableMapEntityList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMAgreementVariableMapEntityList != null && cRMAgreementVariableMapEntityList.Count > 0)
                {
                    totalRowCount = cRMAgreementVariableMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMAgreementVariableMapEntityList ?? new List<CRMAgreementVariableMapEntity>();
        }
    }
}
