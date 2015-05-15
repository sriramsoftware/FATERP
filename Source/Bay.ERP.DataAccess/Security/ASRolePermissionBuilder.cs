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
    internal sealed class ASRolePermissionBuilder : IEntityBuilder<ASRolePermissionEntity>
    {
        IList<ASRolePermissionEntity> IEntityBuilder<ASRolePermissionEntity>.BuildEntities(IDataReader reader)
        {
            List<ASRolePermissionEntity> ASRolePermissionEntityList = new List<ASRolePermissionEntity>();

            while (reader.Read())
            {
                ASRolePermissionEntityList.Add(((IEntityBuilder<ASRolePermissionEntity>)this).BuildEntity(reader));
            }

            return (ASRolePermissionEntityList.Count > 0) ? ASRolePermissionEntityList : null;
        }

        ASRolePermissionEntity IEntityBuilder<ASRolePermissionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASROLEPERMISSIONID = 0;
            const Int32 FLD_ASROLENAME = 1;
            const Int32 FLD_PERMISSIONKEY = 2;
            const Int32 FLD_TS = 3;

            ASRolePermissionEntity aSRolePermissionEntity = new ASRolePermissionEntity();

            aSRolePermissionEntity.ASRolePermissionID = reader.GetInt64(FLD_ASROLEPERMISSIONID);
            aSRolePermissionEntity.ASRoleName = reader.GetString(FLD_ASROLENAME);
            aSRolePermissionEntity.PermissionKey = reader.GetString(FLD_PERMISSIONKEY);
            aSRolePermissionEntity.Ts = reader.GetInt64(FLD_TS);

            return aSRolePermissionEntity;
        }
    }
}
