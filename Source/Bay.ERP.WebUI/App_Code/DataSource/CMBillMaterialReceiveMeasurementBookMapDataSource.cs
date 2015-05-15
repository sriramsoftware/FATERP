// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




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
    public partial class CMBillMaterialReceiveMeasurementBookMapDataSource
    {
        public Int32 totalRowCount = 0;

        public CMBillMaterialReceiveMeasurementBookMapDataSource()
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
        public IList<CMBillMaterialReceiveMeasurementBookMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList = new List<CMBillMaterialReceiveMeasurementBookMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillMaterialReceiveMeasurementBookMapEntity.FLD_NAME_BillMaterialReceiveMeasurementBookMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMBillMaterialReceiveMeasurementBookMapEntityList = FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMBillMaterialReceiveMeasurementBookMapEntityList != null && cMBillMaterialReceiveMeasurementBookMapEntityList.Count > 0)
                {
                    totalRowCount = cMBillMaterialReceiveMeasurementBookMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillMaterialReceiveMeasurementBookMapEntityList ?? new List<CMBillMaterialReceiveMeasurementBookMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillMaterialReceiveMeasurementBookMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList = new List<CMBillMaterialReceiveMeasurementBookMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMBillMaterialReceiveMeasurementBookMapEntity.FLD_NAME_BillMaterialReceiveMeasurementBookMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillMaterialReceiveMeasurementBookMapEntityList =  FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMBillMaterialReceiveMeasurementBookMapEntityList =  FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMBillMaterialReceiveMeasurementBookMapEntityList =  FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMBillMaterialReceiveMeasurementBookMapEntityList =  FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMBillMaterialReceiveMeasurementBookMapEntityList != null && cMBillMaterialReceiveMeasurementBookMapEntityList.Count > 0)
                {
                    totalRowCount = cMBillMaterialReceiveMeasurementBookMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMBillMaterialReceiveMeasurementBookMapEntityList ?? new List<CMBillMaterialReceiveMeasurementBookMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMBillMaterialReceiveMeasurementBookMapEntity> GetData()
        {
            IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList = new List<CMBillMaterialReceiveMeasurementBookMapEntity>();
            
            try
            {
                cMBillMaterialReceiveMeasurementBookMapEntityList = FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMBillMaterialReceiveMeasurementBookMapEntityList != null && cMBillMaterialReceiveMeasurementBookMapEntityList.Count > 0)
                {
                    totalRowCount = cMBillMaterialReceiveMeasurementBookMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMBillMaterialReceiveMeasurementBookMapEntityList ?? new List<CMBillMaterialReceiveMeasurementBookMapEntity>();
        }
    }
}
