// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 10:35:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectAssignedPerson_DetailedBuilder : IEntityBuilder<BDProjectAssignedPerson_DetailedEntity>
    {
        IList<BDProjectAssignedPerson_DetailedEntity> IEntityBuilder<BDProjectAssignedPerson_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectAssignedPerson_DetailedEntity> BDProjectAssignedPerson_DetailedEntityList = new List<BDProjectAssignedPerson_DetailedEntity>();

            while (reader.Read())
            {
                BDProjectAssignedPerson_DetailedEntityList.Add(((IEntityBuilder<BDProjectAssignedPerson_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProjectAssignedPerson_DetailedEntityList.Count > 0) ? BDProjectAssignedPerson_DetailedEntityList : null;
        }

        BDProjectAssignedPerson_DetailedEntity IEntityBuilder<BDProjectAssignedPerson_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTASSIGNEDPERSONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLEID = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_BDPROJECTPROJECTNAME = 5;
            const Int32 FLD_MEMBERFULLNAME = 6;
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLENAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            BDProjectAssignedPerson_DetailedEntity bDProjectAssignedPerson_DetailedEntity = new BDProjectAssignedPerson_DetailedEntity();

            bDProjectAssignedPerson_DetailedEntity.ProjectAssignedPersonID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONID);
            bDProjectAssignedPerson_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectAssignedPerson_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            bDProjectAssignedPerson_DetailedEntity.ProjectAssignedPersonTeamRoleID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONTEAMROLEID);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectAssignedPerson_DetailedEntity.Description = String.Empty; } else { bDProjectAssignedPerson_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { bDProjectAssignedPerson_DetailedEntity.BDProjectProjectName = String.Empty; } else { bDProjectAssignedPerson_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { bDProjectAssignedPerson_DetailedEntity.MemberFullName = String.Empty; } else { bDProjectAssignedPerson_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTASSIGNEDPERSONTEAMROLENAME)) { bDProjectAssignedPerson_DetailedEntity.ProjectAssignedPersonTeamRoleName = String.Empty; } else { bDProjectAssignedPerson_DetailedEntity.ProjectAssignedPersonTeamRoleName = reader.GetString(FLD_PROJECTASSIGNEDPERSONTEAMROLENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectAssignedPerson_DetailedEntity.RowNumber = null; } else { bDProjectAssignedPerson_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProjectAssignedPerson_DetailedEntity;
        }
    }
}
