// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




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
    public partial class BDProjectAddressInfo_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectAddressInfo_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectAddressInfo_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectAddressInfo_DetailedEntity> bDProjectAddressInfo_DetailedEntityList = new List<BDProjectAddressInfo_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectAddressInfo_DetailedEntity.FLD_NAME_ProjectAddressInfoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

               Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
               // startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                bDProjectAddressInfo_DetailedEntityList = FCCBDProjectAddressInfo_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (bDProjectAddressInfo_DetailedEntityList != null && bDProjectAddressInfo_DetailedEntityList.Count > 0)
                {
                    totalRowCount = bDProjectAddressInfo_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return bDProjectAddressInfo_DetailedEntityList ?? new List<BDProjectAddressInfo_DetailedEntity>();
        }
    }
}
