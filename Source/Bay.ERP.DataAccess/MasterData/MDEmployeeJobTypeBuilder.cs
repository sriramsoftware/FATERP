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
    internal sealed class MDEmployeeJobTypeBuilder : IEntityBuilder<MDEmployeeJobTypeEntity>
    {
        IList<MDEmployeeJobTypeEntity> IEntityBuilder<MDEmployeeJobTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeJobTypeEntity> MDEmployeeJobTypeEntityList = new List<MDEmployeeJobTypeEntity>();

            while (reader.Read())
            {
                MDEmployeeJobTypeEntityList.Add(((IEntityBuilder<MDEmployeeJobTypeEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeJobTypeEntityList.Count > 0) ? MDEmployeeJobTypeEntityList : null;
        }

        MDEmployeeJobTypeEntity IEntityBuilder<MDEmployeeJobTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEJOBTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;

            MDEmployeeJobTypeEntity mDEmployeeJobTypeEntity = new MDEmployeeJobTypeEntity();

            mDEmployeeJobTypeEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            mDEmployeeJobTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEmployeeJobTypeEntity.Description = String.Empty; } else { mDEmployeeJobTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }

            return mDEmployeeJobTypeEntity;
        }
    }
}
