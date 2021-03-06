// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




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
    public partial class CMConstructionToolDetailDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConstructionToolDetailDataSource()
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
        public IList<CMConstructionToolDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMConstructionToolDetailEntity> cMConstructionToolDetailEntityList = new List<CMConstructionToolDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConstructionToolDetailEntity.FLD_NAME_ConstructionToolDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMConstructionToolDetailEntityList = FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMConstructionToolDetailEntityList != null && cMConstructionToolDetailEntityList.Count > 0)
                {
                    totalRowCount = cMConstructionToolDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConstructionToolDetailEntityList ?? new List<CMConstructionToolDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConstructionToolDetailEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConstructionToolDetailEntity> cMConstructionToolDetailEntityList = new List<CMConstructionToolDetailEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConstructionToolDetailEntity.FLD_NAME_ConstructionToolDetailID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConstructionToolDetailEntityList =  FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMConstructionToolDetailEntityList =  FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConstructionToolDetailEntityList =  FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMConstructionToolDetailEntityList =  FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMConstructionToolDetailEntityList != null && cMConstructionToolDetailEntityList.Count > 0)
                {
                    totalRowCount = cMConstructionToolDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConstructionToolDetailEntityList ?? new List<CMConstructionToolDetailEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConstructionToolDetailEntity> GetData()
        {
            IList<CMConstructionToolDetailEntity> cMConstructionToolDetailEntityList = new List<CMConstructionToolDetailEntity>();
            
            try
            {
                cMConstructionToolDetailEntityList = FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMConstructionToolDetailEntityList != null && cMConstructionToolDetailEntityList.Count > 0)
                {
                    totalRowCount = cMConstructionToolDetailEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMConstructionToolDetailEntityList ?? new List<CMConstructionToolDetailEntity>();
        }
    }
}
