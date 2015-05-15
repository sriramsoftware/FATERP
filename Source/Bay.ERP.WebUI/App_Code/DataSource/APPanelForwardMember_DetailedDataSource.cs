// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 21-Oct-2012, 06:49:23




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
    public partial class APPanelForwardMember_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public APPanelForwardMember_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelForwardMember_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APPanelForwardMember_DetailedEntity> aPPanelForwardMember_DetailedEntityList = new List<APPanelForwardMember_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "APPanelForwardMemberID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;                

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                aPPanelForwardMember_DetailedEntityList = FCCAPPanelForwardMember_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (aPPanelForwardMember_DetailedEntityList != null && aPPanelForwardMember_DetailedEntityList.Count > 0)
                {
                    totalRowCount = aPPanelForwardMember_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return aPPanelForwardMember_DetailedEntityList ?? new List<APPanelForwardMember_DetailedEntity>();
        }
    }
}
