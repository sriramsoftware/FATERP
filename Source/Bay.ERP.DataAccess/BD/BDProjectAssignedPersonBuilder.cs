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
    internal sealed class BDProjectAssignedPersonBuilder : IEntityBuilder<BDProjectAssignedPersonEntity>
    {
        IList<BDProjectAssignedPersonEntity> IEntityBuilder<BDProjectAssignedPersonEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectAssignedPersonEntity> BDProjectAssignedPersonEntityList = new List<BDProjectAssignedPersonEntity>();

            while (reader.Read())
            {
                BDProjectAssignedPersonEntityList.Add(((IEntityBuilder<BDProjectAssignedPersonEntity>)this).BuildEntity(reader));
            }

            return (BDProjectAssignedPersonEntityList.Count > 0) ? BDProjectAssignedPersonEntityList : null;
        }

        BDProjectAssignedPersonEntity IEntityBuilder<BDProjectAssignedPersonEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTASSIGNEDPERSONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLEID = 3;
            const Int32 FLD_DESCRIPTION = 4;

            BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity = new BDProjectAssignedPersonEntity();

            bDProjectAssignedPersonEntity.ProjectAssignedPersonID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONID);
            bDProjectAssignedPersonEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectAssignedPersonEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONTEAMROLEID);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectAssignedPersonEntity.Description = String.Empty; } else { bDProjectAssignedPersonEntity.Description = reader.GetString(FLD_DESCRIPTION); }

            return bDProjectAssignedPersonEntity;
        }
    }
}
