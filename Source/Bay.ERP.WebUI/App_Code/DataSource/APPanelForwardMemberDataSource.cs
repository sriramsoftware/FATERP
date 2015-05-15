// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    public partial class APPanelForwardMemberDataSource
    {
        public Int32 totalRowCount = 0;

        public APPanelForwardMemberDataSource()
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
        public IList<APPanelForwardMemberEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList = new List<APPanelForwardMemberEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APPanelForwardMemberEntity.FLD_NAME_APPanelForwardMemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPPanelForwardMemberEntityList = FCCAPPanelForwardMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPPanelForwardMemberEntityList != null && aPPanelForwardMemberEntityList.Count > 0)
                {
                    totalRowCount = aPPanelForwardMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPPanelForwardMemberEntityList ?? new List<APPanelForwardMemberEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelForwardMemberEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList = new List<APPanelForwardMemberEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APPanelForwardMemberEntity.FLD_NAME_APPanelForwardMemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPPanelForwardMemberEntityList =  FCCAPPanelForwardMember.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPPanelForwardMemberEntityList =  FCCAPPanelForwardMember.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPPanelForwardMemberEntityList =  FCCAPPanelForwardMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPPanelForwardMemberEntityList =  FCCAPPanelForwardMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPPanelForwardMemberEntityList != null && aPPanelForwardMemberEntityList.Count > 0)
                {
                    totalRowCount = aPPanelForwardMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPPanelForwardMemberEntityList ?? new List<APPanelForwardMemberEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelForwardMemberEntity> GetData()
        {
            IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList = new List<APPanelForwardMemberEntity>();
            
            try
            {
                aPPanelForwardMemberEntityList = FCCAPPanelForwardMember.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPPanelForwardMemberEntityList != null && aPPanelForwardMemberEntityList.Count > 0)
                {
                    totalRowCount = aPPanelForwardMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPPanelForwardMemberEntityList ?? new List<APPanelForwardMemberEntity>();
        }
    }
}
