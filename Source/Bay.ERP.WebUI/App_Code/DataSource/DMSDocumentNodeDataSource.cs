// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    public partial class DMSDocumentNodeDataSource
    {
        public Int32 totalRowCount = 0;

        public DMSDocumentNodeDataSource()
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
        public IList<DMSDocumentNodeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList = new List<DMSDocumentNodeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                dMSDocumentNodeEntityList = FCCDMSDocumentNode.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (dMSDocumentNodeEntityList != null && dMSDocumentNodeEntityList.Count > 0)
                {
                    totalRowCount = dMSDocumentNodeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return dMSDocumentNodeEntityList ?? new List<DMSDocumentNodeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<DMSDocumentNodeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList = new List<DMSDocumentNodeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        dMSDocumentNodeEntityList =  FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        dMSDocumentNodeEntityList =  FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        dMSDocumentNodeEntityList =  FCCDMSDocumentNode.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        dMSDocumentNodeEntityList =  FCCDMSDocumentNode.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (dMSDocumentNodeEntityList != null && dMSDocumentNodeEntityList.Count > 0)
                {
                    totalRowCount = dMSDocumentNodeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return dMSDocumentNodeEntityList ?? new List<DMSDocumentNodeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<DMSDocumentNodeEntity> GetData()
        {
            IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList = new List<DMSDocumentNodeEntity>();
            
            try
            {
                dMSDocumentNodeEntityList = FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (dMSDocumentNodeEntityList != null && dMSDocumentNodeEntityList.Count > 0)
                {
                    totalRowCount = dMSDocumentNodeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return dMSDocumentNodeEntityList ?? new List<DMSDocumentNodeEntity>();
        }
    }
}