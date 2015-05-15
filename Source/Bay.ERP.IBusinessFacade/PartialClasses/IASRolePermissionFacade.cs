using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.BusinessFacade
{
    #region IASRolePermissionFacade

    public partial interface IASRolePermissionFacade
    {
        #region Extra Methods

        IList<ASRolePermissionEntity> GetAllRolePermissionsByRoleName(string[] rolenames);

        #endregion Extra Methods
    }

    #endregion
}
