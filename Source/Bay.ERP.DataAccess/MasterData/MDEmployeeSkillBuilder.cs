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
    internal sealed class MDEmployeeSkillBuilder : IEntityBuilder<MDEmployeeSkillEntity>
    {
        IList<MDEmployeeSkillEntity> IEntityBuilder<MDEmployeeSkillEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeSkillEntity> MDEmployeeSkillEntityList = new List<MDEmployeeSkillEntity>();

            while (reader.Read())
            {
                MDEmployeeSkillEntityList.Add(((IEntityBuilder<MDEmployeeSkillEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeSkillEntityList.Count > 0) ? MDEmployeeSkillEntityList : null;
        }

        MDEmployeeSkillEntity IEntityBuilder<MDEmployeeSkillEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESKILLID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEmployeeSkillEntity mDEmployeeSkillEntity = new MDEmployeeSkillEntity();

            mDEmployeeSkillEntity.EmployeeSkillID = reader.GetInt64(FLD_EMPLOYEESKILLID);
            mDEmployeeSkillEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEmployeeSkillEntity.Description = String.Empty; } else { mDEmployeeSkillEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEmployeeSkillEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeSkillEntity;
        }
    }
}
