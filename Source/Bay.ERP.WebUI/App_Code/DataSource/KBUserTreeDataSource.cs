// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class KBUserTreeDataSource
    {
        public Int32 totalRowCount = 0;

        public KBUserTreeDataSource()
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
        public IList<KBUserTreeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<KBUserTreeEntity> kBUserTreeEntityList = new List<KBUserTreeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = KBUserTreeEntity.FLD_NAME_UserTreeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                kBUserTreeEntityList = FCCKBUserTree.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (kBUserTreeEntityList != null && kBUserTreeEntityList.Count > 0)
                {
                    totalRowCount = kBUserTreeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return kBUserTreeEntityList ?? new List<KBUserTreeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<KBUserTreeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<KBUserTreeEntity> kBUserTreeEntityList = new List<KBUserTreeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = KBUserTreeEntity.FLD_NAME_UserTreeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        kBUserTreeEntityList =  FCCKBUserTree.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        kBUserTreeEntityList =  FCCKBUserTree.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        kBUserTreeEntityList =  FCCKBUserTree.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        kBUserTreeEntityList =  FCCKBUserTree.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (kBUserTreeEntityList != null && kBUserTreeEntityList.Count > 0)
                {
                    totalRowCount = kBUserTreeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return kBUserTreeEntityList ?? new List<KBUserTreeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<KBUserTreeEntity> GetData()
        {
            IList<KBUserTreeEntity> kBUserTreeEntityList = new List<KBUserTreeEntity>();
            
            try
            {
                kBUserTreeEntityList = FCCKBUserTree.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (kBUserTreeEntityList != null && kBUserTreeEntityList.Count > 0)
                {
                    totalRowCount = kBUserTreeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return kBUserTreeEntityList ?? new List<KBUserTreeEntity>();
        }
    }
}
