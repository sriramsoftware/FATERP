// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ASUserPermissionExcludedBuilder : IEntityBuilder<ASUserPermissionExcludedEntity>
    {
        IList<ASUserPermissionExcludedEntity> IEntityBuilder<ASUserPermissionExcludedEntity>.BuildEntities(IDataReader reader)
        {
            List<ASUserPermissionExcludedEntity> ASUserPermissionExcludedEntityList = new List<ASUserPermissionExcludedEntity>();

            while (reader.Read())
            {
                ASUserPermissionExcludedEntityList.Add(((IEntityBuilder<ASUserPermissionExcludedEntity>)this).BuildEntity(reader));
            }

            return (ASUserPermissionExcludedEntityList.Count > 0) ? ASUserPermissionExcludedEntityList : null;
        }

        ASUserPermissionExcludedEntity IEntityBuilder<ASUserPermissionExcludedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASUSERPERMISSIONEXCLUDEDID = 0;
            const Int32 FLD_ASUSERNAME = 1;
            const Int32 FLD_PERMISSIONKEY = 2;
            const Int32 FLD_TS = 3;

            ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity = new ASUserPermissionExcludedEntity();

            aSUserPermissionExcludedEntity.ASUserPermissionExcludedID = reader.GetInt64(FLD_ASUSERPERMISSIONEXCLUDEDID);
            aSUserPermissionExcludedEntity.ASUserName = reader.GetString(FLD_ASUSERNAME);
            aSUserPermissionExcludedEntity.PermissionKey = reader.GetString(FLD_PERMISSIONKEY);
            aSUserPermissionExcludedEntity.Ts = reader.GetInt64(FLD_TS);

            return aSUserPermissionExcludedEntity;
        }
    }
}
