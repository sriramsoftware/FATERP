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
    public sealed partial class ASRolePermissionFacade
    {
        #region Extra Methods

        IList<ASRolePermissionEntity> IASRolePermissionFacade.GetAllRolePermissionsByRoleName(string[] rolenames)
        {
            IList<ASRolePermissionEntity> allobjects = null;

            string userroles = string.Concat(" IN ('", string.Join("','", rolenames), "')");
            allobjects = (this as IASRolePermissionFacade).GetIL(null, null, null, string.Concat("[", ASRolePermissionEntity.FLD_NAME_ASRoleName, "]", userroles), DatabaseOperationType.LoadWithFilterExpression);
            if (allobjects == null)
                allobjects = new List<ASRolePermissionEntity>();
            return allobjects;
        }

        #endregion
    }
}
