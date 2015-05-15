// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




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
    public partial class CMNMDEventOptionDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNMDEventOptionDataSource()
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
        public IList<CMNMDEventOptionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNMDEventOptionEntity> cMNMDEventOptionEntityList = new List<CMNMDEventOptionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNMDEventOptionEntity.FLD_NAME_EventOptionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNMDEventOptionEntityList = FCCCMNMDEventOption.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNMDEventOptionEntityList != null && cMNMDEventOptionEntityList.Count > 0)
                {
                    totalRowCount = cMNMDEventOptionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNMDEventOptionEntityList ?? new List<CMNMDEventOptionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNMDEventOptionEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNMDEventOptionEntity> cMNMDEventOptionEntityList = new List<CMNMDEventOptionEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNMDEventOptionEntity.FLD_NAME_EventOptionID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNMDEventOptionEntityList =  FCCCMNMDEventOption.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNMDEventOptionEntityList =  FCCCMNMDEventOption.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNMDEventOptionEntityList =  FCCCMNMDEventOption.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNMDEventOptionEntityList =  FCCCMNMDEventOption.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNMDEventOptionEntityList != null && cMNMDEventOptionEntityList.Count > 0)
                {
                    totalRowCount = cMNMDEventOptionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNMDEventOptionEntityList ?? new List<CMNMDEventOptionEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNMDEventOptionEntity> GetData()
        {
            IList<CMNMDEventOptionEntity> cMNMDEventOptionEntityList = new List<CMNMDEventOptionEntity>();
            
            try
            {
                cMNMDEventOptionEntityList = FCCCMNMDEventOption.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNMDEventOptionEntityList != null && cMNMDEventOptionEntityList.Count > 0)
                {
                    totalRowCount = cMNMDEventOptionEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNMDEventOptionEntityList ?? new List<CMNMDEventOptionEntity>();
        }
    }
}