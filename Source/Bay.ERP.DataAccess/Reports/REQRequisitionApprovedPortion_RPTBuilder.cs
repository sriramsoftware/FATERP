// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 11:43:31




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionApprovedPortion_RPTBuilder : IEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>
    {
        IList<REQRequisitionApprovedPortion_RPTEntity> IEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionApprovedPortion_RPTEntity> REQRequisitionApprovedPortion_RPTEntityList = new List<REQRequisitionApprovedPortion_RPTEntity>();

            while (reader.Read())
            {
                REQRequisitionApprovedPortion_RPTEntityList.Add(((IEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionApprovedPortion_RPTEntityList.Count > 0) ? REQRequisitionApprovedPortion_RPTEntityList : null;
        }

        REQRequisitionApprovedPortion_RPTEntity IEntityBuilder<REQRequisitionApprovedPortion_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTASSIGNEDPERSONID = 0;
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLEID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_PROJECTID = 3;
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLE = 4;
            const Int32 FLD_MEMBERFULLNAME = 5;
            const Int32 FLD_PROJECTASSIGNEDPERSONTEAMROLENAME = 6;

            REQRequisitionApprovedPortion_RPTEntity rEQRequisitionApprovedPortion_RPTEntity = new REQRequisitionApprovedPortion_RPTEntity();

            rEQRequisitionApprovedPortion_RPTEntity.ProjectAssignedPersonID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONID);
            rEQRequisitionApprovedPortion_RPTEntity.ProjectAssignedPersonTeamRoleID = reader.GetInt64(FLD_PROJECTASSIGNEDPERSONTEAMROLEID);
            rEQRequisitionApprovedPortion_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            rEQRequisitionApprovedPortion_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            rEQRequisitionApprovedPortion_RPTEntity.ProjectAssignedPersonTeamRole = reader.GetString(FLD_PROJECTASSIGNEDPERSONTEAMROLE);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { rEQRequisitionApprovedPortion_RPTEntity.MemberFullName = String.Empty; } else { rEQRequisitionApprovedPortion_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            rEQRequisitionApprovedPortion_RPTEntity.ProjectAssignedPersonTeamRoleName = reader.GetString(FLD_PROJECTASSIGNEDPERSONTEAMROLENAME);

            return rEQRequisitionApprovedPortion_RPTEntity;
        }
    }
}
