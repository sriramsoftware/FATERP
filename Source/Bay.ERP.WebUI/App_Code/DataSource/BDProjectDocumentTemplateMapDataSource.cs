// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 30-Nov-2011, 02:22:45




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
    public partial class BDProjectDocumentTemplateMapDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectDocumentTemplateMapDataSource()
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
        public IList<BDProjectDocumentTemplateMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList = new List<BDProjectDocumentTemplateMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectDocumentTemplateMapEntity.FLD_NAME_ProjectDocumentTemplateMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectDocumentTemplateMapEntityList = FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectDocumentTemplateMapEntityList != null && bDProjectDocumentTemplateMapEntityList.Count > 0)
                {
                    totalRowCount = bDProjectDocumentTemplateMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectDocumentTemplateMapEntityList ?? new List<BDProjectDocumentTemplateMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectDocumentTemplateMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList = new List<BDProjectDocumentTemplateMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectDocumentTemplateMapEntity.FLD_NAME_ProjectDocumentTemplateMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectDocumentTemplateMapEntityList =  FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectDocumentTemplateMapEntityList =  FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectDocumentTemplateMapEntityList =  FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectDocumentTemplateMapEntityList =  FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectDocumentTemplateMapEntityList != null && bDProjectDocumentTemplateMapEntityList.Count > 0)
                {
                    totalRowCount = bDProjectDocumentTemplateMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectDocumentTemplateMapEntityList ?? new List<BDProjectDocumentTemplateMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectDocumentTemplateMapEntity> GetData()
        {
            IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList = new List<BDProjectDocumentTemplateMapEntity>();
            
            try
            {
                bDProjectDocumentTemplateMapEntityList = FCCBDProjectDocumentTemplateMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectDocumentTemplateMapEntityList != null && bDProjectDocumentTemplateMapEntityList.Count > 0)
                {
                    totalRowCount = bDProjectDocumentTemplateMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectDocumentTemplateMapEntityList ?? new List<BDProjectDocumentTemplateMapEntity>();
        }
    }
}
