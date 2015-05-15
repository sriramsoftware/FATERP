// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HRMemberLeaveAccountDataSource
    {
        public Int32 totalRowCount = 0;

        public HRMemberLeaveAccountDataSource()
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
        public IList<HRMemberLeaveAccountEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList = new List<HRMemberLeaveAccountEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRMemberLeaveAccountEntity.FLD_NAME_MemberLeaveAccountID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hRMemberLeaveAccountEntityList = FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hRMemberLeaveAccountEntityList != null && hRMemberLeaveAccountEntityList.Count > 0)
                {
                    totalRowCount = hRMemberLeaveAccountEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRMemberLeaveAccountEntityList ?? new List<HRMemberLeaveAccountEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRMemberLeaveAccountEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList = new List<HRMemberLeaveAccountEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRMemberLeaveAccountEntity.FLD_NAME_MemberLeaveAccountID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRMemberLeaveAccountEntityList =  FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hRMemberLeaveAccountEntityList =  FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRMemberLeaveAccountEntityList =  FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hRMemberLeaveAccountEntityList =  FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hRMemberLeaveAccountEntityList != null && hRMemberLeaveAccountEntityList.Count > 0)
                {
                    totalRowCount = hRMemberLeaveAccountEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRMemberLeaveAccountEntityList ?? new List<HRMemberLeaveAccountEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRMemberLeaveAccountEntity> GetData()
        {
            IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList = new List<HRMemberLeaveAccountEntity>();
            
            try
            {
                hRMemberLeaveAccountEntityList = FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hRMemberLeaveAccountEntityList != null && hRMemberLeaveAccountEntityList.Count > 0)
                {
                    totalRowCount = hRMemberLeaveAccountEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hRMemberLeaveAccountEntityList ?? new List<HRMemberLeaveAccountEntity>();
        }
    }
}
