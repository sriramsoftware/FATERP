using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class ASUserPermissionExcludedFacade
    {
        #region Extra Methods

        IList<ASUserPermissionExcludedEntity> IASUserPermissionExcludedFacade.GetAll()
        {
            IList<ASUserPermissionExcludedEntity> allobjects = null;
            allobjects = (this as IASUserPermissionExcludedFacade).GetIL(null, null, null, null, DatabaseOperationType.Load);
            if (allobjects == null)
                allobjects = new List<ASUserPermissionExcludedEntity>();
            return allobjects;
        }

        IList<ASUserPermissionExcludedEntity> IASUserPermissionExcludedFacade.GetByUserName(string username)
        {
            IList<ASUserPermissionExcludedEntity> allobjects = null;
            allobjects = (this as IASUserPermissionExcludedFacade).GetIL(null, null, null, SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_ASUserName, username, SQLMatchType.Equal), DatabaseOperationType.LoadWithFilterExpression);
            if (allobjects == null)
                allobjects = new List<ASUserPermissionExcludedEntity>();
            return allobjects;
        }

        long IASUserPermissionExcludedFacade.Delete(ASUserPermissionExcludedEntity asuserpermissionexcluded)
        {
            return (this as IASUserPermissionExcludedFacade).Delete(asuserpermissionexcluded, SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_ASUserPermissionExcludedID, asuserpermissionexcluded.ASUserPermissionExcludedID.ToString(), SQLMatchType.Equal), DatabaseOperationType.Delete, TransactionRequired.No);
        }

        #endregion
    }
}
