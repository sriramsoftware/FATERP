// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 18-Jul-2012, 01:15:03




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
    public partial class HRMember_CustomDataSource
    {
        public Int32 totalRowCount = 0;

        public HRMember_CustomDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRMember_CustomEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HRMember_CustomEntity> hRMember_CustomEntityList = new List<HRMember_CustomEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "HRMember." + HRMemberEntity.FLD_NAME_MemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                hRMember_CustomEntityList = FCCHRMember_Custom.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (hRMember_CustomEntityList != null && hRMember_CustomEntityList.Count > 0)
                {
                    totalRowCount = hRMember_CustomEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return hRMember_CustomEntityList ?? new List<HRMember_CustomEntity>();
        }
    }
}
