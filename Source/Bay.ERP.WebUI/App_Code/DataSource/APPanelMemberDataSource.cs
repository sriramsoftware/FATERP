// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APPanelMemberDataSource
    {
        public Int32 totalRowCount = 0;

        public APPanelMemberDataSource()
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
        public IList<APPanelMemberEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<APPanelMemberEntity> aPPanelMemberEntityList = new List<APPanelMemberEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APPanelMemberEntity.FLD_NAME_APPanelMemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aPPanelMemberEntityList = FCCAPPanelMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aPPanelMemberEntityList != null && aPPanelMemberEntityList.Count > 0)
                {
                    totalRowCount = aPPanelMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPPanelMemberEntityList ?? new List<APPanelMemberEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelMemberEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<APPanelMemberEntity> aPPanelMemberEntityList = new List<APPanelMemberEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = APPanelMemberEntity.FLD_NAME_APPanelMemberID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPPanelMemberEntityList =  FCCAPPanelMember.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aPPanelMemberEntityList =  FCCAPPanelMember.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aPPanelMemberEntityList =  FCCAPPanelMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aPPanelMemberEntityList =  FCCAPPanelMember.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aPPanelMemberEntityList != null && aPPanelMemberEntityList.Count > 0)
                {
                    totalRowCount = aPPanelMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aPPanelMemberEntityList ?? new List<APPanelMemberEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<APPanelMemberEntity> GetData()
        {
            IList<APPanelMemberEntity> aPPanelMemberEntityList = new List<APPanelMemberEntity>();
            
            try
            {
                aPPanelMemberEntityList = FCCAPPanelMember.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aPPanelMemberEntityList != null && aPPanelMemberEntityList.Count > 0)
                {
                    totalRowCount = aPPanelMemberEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aPPanelMemberEntityList ?? new List<APPanelMemberEntity>();
        }
    }
}
