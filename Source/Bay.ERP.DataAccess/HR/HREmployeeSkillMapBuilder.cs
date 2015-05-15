// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSkillMapBuilder : IEntityBuilder<HREmployeeSkillMapEntity>
    {
        IList<HREmployeeSkillMapEntity> IEntityBuilder<HREmployeeSkillMapEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSkillMapEntity> HREmployeeSkillMapEntityList = new List<HREmployeeSkillMapEntity>();

            while (reader.Read())
            {
                HREmployeeSkillMapEntityList.Add(((IEntityBuilder<HREmployeeSkillMapEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSkillMapEntityList.Count > 0) ? HREmployeeSkillMapEntityList : null;
        }

        HREmployeeSkillMapEntity IEntityBuilder<HREmployeeSkillMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESKILLMAPID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEESKILLID = 2;
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELID = 3;
            const Int32 FLD_REMARKS = 4;

            HREmployeeSkillMapEntity hREmployeeSkillMapEntity = new HREmployeeSkillMapEntity();

            hREmployeeSkillMapEntity.EmployeeSkillMapID = reader.GetInt64(FLD_EMPLOYEESKILLMAPID);
            hREmployeeSkillMapEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSkillMapEntity.EmployeeSkillID = reader.GetInt64(FLD_EMPLOYEESKILLID);
            hREmployeeSkillMapEntity.EmployeeCompetencyLevelID = reader.GetInt64(FLD_EMPLOYEECOMPETENCYLEVELID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeSkillMapEntity.Remarks = String.Empty; } else { hREmployeeSkillMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeSkillMapEntity;
        }
    }
}
