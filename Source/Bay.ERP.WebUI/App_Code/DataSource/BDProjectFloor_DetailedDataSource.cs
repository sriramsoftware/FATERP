// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 24-May-2012, 10:39:09




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
    public partial class BDProjectFloor_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectFloor_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectFloor_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectFloor_DetailedEntity> bDProjectFloor_DetailedEntityList = new List<BDProjectFloor_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectFloorEntity.FLD_NAME_ProjectFloorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                bDProjectFloor_DetailedEntityList = FCCBDProjectFloor_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (bDProjectFloor_DetailedEntityList != null && bDProjectFloor_DetailedEntityList.Count > 0)
                {
                    totalRowCount = bDProjectFloor_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return bDProjectFloor_DetailedEntityList ?? new List<BDProjectFloor_DetailedEntity>();
        }
    }
}
