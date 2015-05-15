using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System;
using System.Linq;
using System.Linq.Expressions;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.BusinessEntities;

using System.Collections.Generic;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI.Manager
{
    public static class ERPCommentEngine
    {
        #region Properties

        #endregion

        #region Methods

        #region Create Process Wise Comment 

        public static Int64 CreateComment(Int64 processCategory,Int64 referenceID,String comments,Int64 employeeID)
        {
            Int64 commentID = 0;

            try
            {
                CMNERPCommentEntity cMNERPCommentEntity = new CMNERPCommentEntity();
                cMNERPCommentEntity.ProcessCategoryID = processCategory;
                cMNERPCommentEntity.ReferenceID = referenceID;
                cMNERPCommentEntity.Comment = comments;
                cMNERPCommentEntity.CommentDate = DateTime.Now;
                cMNERPCommentEntity.IP = MiscUtil.GetLocalIP();
                cMNERPCommentEntity.EmployeeID = employeeID;

                commentID = FCCCMNERPComment.GetFacadeCreate().Add(cMNERPCommentEntity, DatabaseOperationType.Add, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return commentID;
        }

        #endregion

        #region Get All ERP Comments

        public static IList<CMNERPCommentEntity> GetAllComments()
        {
            IList<CMNERPCommentEntity> list = FCCCMNERPComment.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            return list;
        }

        #endregion

        #region Get Process Wise Comments

        public static IList<CMNERPCommentEntity> GetAllCommentByProcessAndReference(Int64 processCategoryID,Int64 referenceID)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMNERPCommentEntity.FLD_NAME_ProcessCategoryID, processCategoryID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMNERPCommentEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<CMNERPCommentEntity> list = FCCCMNERPComment.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            return list;
        }

        #endregion

        #endregion
    }
}