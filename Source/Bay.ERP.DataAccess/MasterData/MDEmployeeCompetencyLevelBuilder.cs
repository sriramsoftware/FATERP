// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEmployeeCompetencyLevelBuilder : IEntityBuilder<MDEmployeeCompetencyLevelEntity>
    {
        IList<MDEmployeeCompetencyLevelEntity> IEntityBuilder<MDEmployeeCompetencyLevelEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeCompetencyLevelEntity> MDEmployeeCompetencyLevelEntityList = new List<MDEmployeeCompetencyLevelEntity>();

            while (reader.Read())
            {
                MDEmployeeCompetencyLevelEntityList.Add(((IEntityBuilder<MDEmployeeCompetencyLevelEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeCompetencyLevelEntityList.Count > 0) ? MDEmployeeCompetencyLevelEntityList : null;
        }

        MDEmployeeCompetencyLevelEntity IEntityBuilder<MDEmployeeCompetencyLevelEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity = new MDEmployeeCompetencyLevelEntity();

            mDEmployeeCompetencyLevelEntity.EmployeeCompetencyLevelID = reader.GetInt64(FLD_EMPLOYEECOMPETENCYLEVELID);
            mDEmployeeCompetencyLevelEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEmployeeCompetencyLevelEntity.Description = String.Empty; } else { mDEmployeeCompetencyLevelEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEmployeeCompetencyLevelEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeCompetencyLevelEntity;
        }
    }
}
