// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSkillMap_DetailedBuilder : IEntityBuilder<HREmployeeSkillMap_DetailedEntity>
    {
        IList<HREmployeeSkillMap_DetailedEntity> IEntityBuilder<HREmployeeSkillMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSkillMap_DetailedEntity> HREmployeeSkillMap_DetailedEntityList = new List<HREmployeeSkillMap_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeSkillMap_DetailedEntityList.Add(((IEntityBuilder<HREmployeeSkillMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSkillMap_DetailedEntityList.Count > 0) ? HREmployeeSkillMap_DetailedEntityList : null;
        }

        HREmployeeSkillMap_DetailedEntity IEntityBuilder<HREmployeeSkillMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESKILLMAPID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEESKILLID = 2;
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELID = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_EMPLOYEEFULLNAME = 5;
            const Int32 FLD_EMPLOYEESKILLNAME = 6;
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELNAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            HREmployeeSkillMap_DetailedEntity hREmployeeSkillMap_DetailedEntity = new HREmployeeSkillMap_DetailedEntity();

            hREmployeeSkillMap_DetailedEntity.EmployeeSkillMapID = reader.GetInt64(FLD_EMPLOYEESKILLMAPID);
            hREmployeeSkillMap_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSkillMap_DetailedEntity.EmployeeSkillID = reader.GetInt64(FLD_EMPLOYEESKILLID);
            hREmployeeSkillMap_DetailedEntity.EmployeeCompetencyLevelID = reader.GetInt64(FLD_EMPLOYEECOMPETENCYLEVELID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeSkillMap_DetailedEntity.Remarks = String.Empty; } else { hREmployeeSkillMap_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeSkillMap_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeSkillMap_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEESKILLNAME)) { hREmployeeSkillMap_DetailedEntity.EmployeeSkillName = String.Empty; } else { hREmployeeSkillMap_DetailedEntity.EmployeeSkillName = reader.GetString(FLD_EMPLOYEESKILLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECOMPETENCYLEVELNAME)) { hREmployeeSkillMap_DetailedEntity.EmployeeCompetencyLevelName = String.Empty; } else { hREmployeeSkillMap_DetailedEntity.EmployeeCompetencyLevelName = reader.GetString(FLD_EMPLOYEECOMPETENCYLEVELNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeSkillMap_DetailedEntity.RowNumber = null; } else { hREmployeeSkillMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeSkillMap_DetailedEntity;
        }
    }
}
