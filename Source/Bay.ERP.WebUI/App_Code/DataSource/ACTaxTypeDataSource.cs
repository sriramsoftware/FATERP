// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    public partial class ACTaxTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public ACTaxTypeDataSource()
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
        public IList<ACTaxTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACTaxTypeEntity> aCTaxTypeEntityList = new List<ACTaxTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACTaxTypeEntity.FLD_NAME_TaxTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCTaxTypeEntityList = FCCACTaxType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCTaxTypeEntityList != null && aCTaxTypeEntityList.Count > 0)
                {
                    totalRowCount = aCTaxTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCTaxTypeEntityList ?? new List<ACTaxTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTaxTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACTaxTypeEntity> aCTaxTypeEntityList = new List<ACTaxTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACTaxTypeEntity.FLD_NAME_TaxTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCTaxTypeEntityList =  FCCACTaxType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCTaxTypeEntityList =  FCCACTaxType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCTaxTypeEntityList =  FCCACTaxType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCTaxTypeEntityList =  FCCACTaxType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCTaxTypeEntityList != null && aCTaxTypeEntityList.Count > 0)
                {
                    totalRowCount = aCTaxTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCTaxTypeEntityList ?? new List<ACTaxTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTaxTypeEntity> GetData()
        {
            IList<ACTaxTypeEntity> aCTaxTypeEntityList = new List<ACTaxTypeEntity>();
            
            try
            {
                aCTaxTypeEntityList = FCCACTaxType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCTaxTypeEntityList != null && aCTaxTypeEntityList.Count > 0)
                {
                    totalRowCount = aCTaxTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCTaxTypeEntityList ?? new List<ACTaxTypeEntity>();
        }
    }
}