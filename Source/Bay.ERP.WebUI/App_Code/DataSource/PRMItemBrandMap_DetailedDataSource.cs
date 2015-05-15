// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2012, 03:52:59




using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.Web.UI
{
    [DataObject(true)]
    public partial class PRMItemBrandMap_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMItemBrandMap_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMItemBrandMap_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMItemBrandMap_DetailedEntity> pRMItemBrandMap_DetailedEntityList = new List<PRMItemBrandMap_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = SqlExpressionBuilder.PrepareSortExpression("PRMItemBrandMap." + PRMItemBrandMapEntity.FLD_NAME_BrandID, SQLSortOrderType.Decending);
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                pRMItemBrandMap_DetailedEntityList = FCCPRMItemBrandMap_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (pRMItemBrandMap_DetailedEntityList != null && pRMItemBrandMap_DetailedEntityList.Count > 0)
                {
                    totalRowCount = pRMItemBrandMap_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return pRMItemBrandMap_DetailedEntityList ?? new List<PRMItemBrandMap_DetailedEntity>();
        }
    }
}
