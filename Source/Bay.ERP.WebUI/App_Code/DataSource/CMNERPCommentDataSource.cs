// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
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
    public partial class CMNERPCommentDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNERPCommentDataSource()
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
        public IList<CMNERPCommentEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNERPCommentEntity> cMNERPCommentEntityList = new List<CMNERPCommentEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNERPCommentEntity.FLD_NAME_CommentID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNERPCommentEntityList = FCCCMNERPComment.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNERPCommentEntityList != null && cMNERPCommentEntityList.Count > 0)
                {
                    totalRowCount = cMNERPCommentEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNERPCommentEntityList ?? new List<CMNERPCommentEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNERPCommentEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNERPCommentEntity> cMNERPCommentEntityList = new List<CMNERPCommentEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNERPCommentEntity.FLD_NAME_CommentID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNERPCommentEntityList =  FCCCMNERPComment.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNERPCommentEntityList =  FCCCMNERPComment.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNERPCommentEntityList =  FCCCMNERPComment.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNERPCommentEntityList =  FCCCMNERPComment.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNERPCommentEntityList != null && cMNERPCommentEntityList.Count > 0)
                {
                    totalRowCount = cMNERPCommentEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNERPCommentEntityList ?? new List<CMNERPCommentEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNERPCommentEntity> GetData()
        {
            IList<CMNERPCommentEntity> cMNERPCommentEntityList = new List<CMNERPCommentEntity>();
            
            try
            {
                cMNERPCommentEntityList = FCCCMNERPComment.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNERPCommentEntityList != null && cMNERPCommentEntityList.Count > 0)
                {
                    totalRowCount = cMNERPCommentEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNERPCommentEntityList ?? new List<CMNERPCommentEntity>();
        }
    }
}
