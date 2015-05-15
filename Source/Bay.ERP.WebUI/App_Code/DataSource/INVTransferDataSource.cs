// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 02:56:29




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
    public partial class INVTransferDataSource
    {
        public Int32 totalRowCount = 0;

        public INVTransferDataSource()
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
        public IList<INVTransferEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<INVTransferEntity> iNVTransferEntityList = new List<INVTransferEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTransferEntity.FLD_NAME_TransferID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                iNVTransferEntityList = FCCINVTransfer.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (iNVTransferEntityList != null && iNVTransferEntityList.Count > 0)
                {
                    totalRowCount = iNVTransferEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTransferEntityList ?? new List<INVTransferEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransferEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVTransferEntity> iNVTransferEntityList = new List<INVTransferEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = INVTransferEntity.FLD_NAME_TransferID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTransferEntityList =  FCCINVTransfer.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        iNVTransferEntityList =  FCCINVTransfer.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        iNVTransferEntityList =  FCCINVTransfer.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        iNVTransferEntityList =  FCCINVTransfer.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (iNVTransferEntityList != null && iNVTransferEntityList.Count > 0)
                {
                    totalRowCount = iNVTransferEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return iNVTransferEntityList ?? new List<INVTransferEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransferEntity> GetData()
        {
            IList<INVTransferEntity> iNVTransferEntityList = new List<INVTransferEntity>();
            
            try
            {
                iNVTransferEntityList = FCCINVTransfer.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (iNVTransferEntityList != null && iNVTransferEntityList.Count > 0)
                {
                    totalRowCount = iNVTransferEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return iNVTransferEntityList ?? new List<INVTransferEntity>();
        }
    }
}
