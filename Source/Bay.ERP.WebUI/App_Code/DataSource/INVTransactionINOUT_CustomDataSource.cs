// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 08-May-2013, 01:11:15




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
    public partial class INVTransactionINOUT_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public INVTransactionINOUT_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<INVTransactionINOUT_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<INVTransactionINOUT_CustomEntity> iNVTransactionINOUT_CustomEntityList = new List<INVTransactionINOUT_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "ItemID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                iNVTransactionINOUT_CustomEntityList = FCCINVTransactionINOUT_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (iNVTransactionINOUT_CustomEntityList != null && iNVTransactionINOUT_CustomEntityList.Count > 0)
                {
                    totalRowCount = iNVTransactionINOUT_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return iNVTransactionINOUT_CustomEntityList ?? new List<INVTransactionINOUT_CustomEntity>();
        }
    }
}