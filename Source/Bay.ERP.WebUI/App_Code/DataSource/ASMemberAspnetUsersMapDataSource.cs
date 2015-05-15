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
    public partial class ASMemberAspnetUsersMapDataSource
    {
        public Int32 totalRowCount = 0;

        public ASMemberAspnetUsersMapDataSource()
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
        public IList<ASMemberAspnetUsersMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList = new List<ASMemberAspnetUsersMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ASMemberAspnetUsersMapEntity.FLD_NAME_ASMemberAspnetUsersMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aSMemberAspnetUsersMapEntityList = FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aSMemberAspnetUsersMapEntityList != null && aSMemberAspnetUsersMapEntityList.Count > 0)
                {
                    totalRowCount = aSMemberAspnetUsersMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aSMemberAspnetUsersMapEntityList ?? new List<ASMemberAspnetUsersMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ASMemberAspnetUsersMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList = new List<ASMemberAspnetUsersMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ASMemberAspnetUsersMapEntity.FLD_NAME_ASMemberAspnetUsersMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aSMemberAspnetUsersMapEntityList =  FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aSMemberAspnetUsersMapEntityList =  FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aSMemberAspnetUsersMapEntityList =  FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aSMemberAspnetUsersMapEntityList =  FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aSMemberAspnetUsersMapEntityList != null && aSMemberAspnetUsersMapEntityList.Count > 0)
                {
                    totalRowCount = aSMemberAspnetUsersMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aSMemberAspnetUsersMapEntityList ?? new List<ASMemberAspnetUsersMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ASMemberAspnetUsersMapEntity> GetData()
        {
            IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList = new List<ASMemberAspnetUsersMapEntity>();
            
            try
            {
                aSMemberAspnetUsersMapEntityList = FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aSMemberAspnetUsersMapEntityList != null && aSMemberAspnetUsersMapEntityList.Count > 0)
                {
                    totalRowCount = aSMemberAspnetUsersMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aSMemberAspnetUsersMapEntityList ?? new List<ASMemberAspnetUsersMapEntity>();
        }
    }
}
