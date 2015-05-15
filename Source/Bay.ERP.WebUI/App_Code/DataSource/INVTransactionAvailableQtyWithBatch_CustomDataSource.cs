// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2013, 05:31:41




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
    public partial class INVTransactionAvailableQtyWithBatch_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public INVTransactionAvailableQtyWithBatch_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransactionAvailableQtyWithBatch_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVTransactionAvailableQtyWithBatch_CustomEntity> iNVTransactionAvailableQtyWithBatch_CustomEntityList = new List<INVTransactionAvailableQtyWithBatch_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "INVTransaction.ItemID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                iNVTransactionAvailableQtyWithBatch_CustomEntityList = FCCINVTransactionAvailableQtyWithBatch_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (iNVTransactionAvailableQtyWithBatch_CustomEntityList != null && iNVTransactionAvailableQtyWithBatch_CustomEntityList.Count > 0)
                {
                    totalRowCount = iNVTransactionAvailableQtyWithBatch_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return iNVTransactionAvailableQtyWithBatch_CustomEntityList ?? new List<INVTransactionAvailableQtyWithBatch_CustomEntity>();
        }
    }
}
