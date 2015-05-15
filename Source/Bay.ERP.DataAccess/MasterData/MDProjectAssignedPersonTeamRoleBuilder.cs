// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDProjectAssignedPersonTeamRoleBuilder : IEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>
    {
        IList<MDProjectAssignedPersonTeamRoleEntity> IEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectAssignedPersonTeamRoleEntity> MDProjectAssignedPersonTeamRoleEntityList = new List<MDProjectAssignedPersonTeamRoleEntity>();

            while (reader.Read())
            {
                MDProjectAssignedPersonTeamRoleEntityList.Add(((IEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>)this).BuildEntity(reader));
            }

            return (MDProjectAssignedPersonTeamRoleEntityList.Count > 0) ? MDProjectAssignedPersonTeamRoleEntityList : null;
        }

        MDProjectAssignedPersonTeamRoleEntity IEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity = new MDProjectAssignedPersonTeamRoleEntity();

            mDProjectAssignedPersonTeamRoleEntity.ProjectAssignedPersonTeamRoleID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONTEAMROLEID);
            mDProjectAssignedPersonTeamRoleEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDProjectAssignedPersonTeamRoleEntity.Description = String.Empty; } else { mDProjectAssignedPersonTeamRoleEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDProjectAssignedPersonTeamRoleEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectAssignedPersonTeamRoleEntity;
        }
    }
}
