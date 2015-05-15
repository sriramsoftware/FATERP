using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.BusinessFacade
{
    #region IASUserPermissionExcludedFacade

    public partial interface IASUserPermissionExcludedFacade
    {
        #region Extra Methods

        IList<ASUserPermissionExcludedEntity> GetAll();
        
        IList<ASUserPermissionExcludedEntity> GetByUserName(string username);
        
        long Delete(ASUserPermissionExcludedEntity asuserpermissionexcluded);

        #endregion Extra Methods
    }

    #endregion
}
