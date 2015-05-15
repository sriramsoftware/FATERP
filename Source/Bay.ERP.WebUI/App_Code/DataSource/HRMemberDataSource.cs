// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class HRMemberDataSource
    {
        public Int32 totalRowCount = 0;

        public HRMemberDataSource()
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
        public IList<HRMemberEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HRMemberEntity> hRMemberEntityList = new List<HRMemberEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRMemberEntity.FLD_NAME_MemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hRMemberEntityList = FCCHRMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hRMemberEntityList != null && hRMemberEntityList.Count > 0)
                {
                    totalRowCount = hRMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRMemberEntityList ?? new List<HRMemberEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRMemberEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HRMemberEntity> hRMemberEntityList = new List<HRMemberEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRMemberEntity.FLD_NAME_MemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRMemberEntityList =  FCCHRMember.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hRMemberEntityList =  FCCHRMember.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRMemberEntityList =  FCCHRMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hRMemberEntityList =  FCCHRMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hRMemberEntityList != null && hRMemberEntityList.Count > 0)
                {
                    totalRowCount = hRMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRMemberEntityList ?? new List<HRMemberEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRMemberEntity> GetData()
        {
            IList<HRMemberEntity> hRMemberEntityList = new List<HRMemberEntity>();
            
            try
            {
                hRMemberEntityList = FCCHRMember.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hRMemberEntityList != null && hRMemberEntityList.Count > 0)
                {
                    totalRowCount = hRMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hRMemberEntityList ?? new List<HRMemberEntity>();
        }
    }
}
