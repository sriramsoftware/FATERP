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
    internal sealed class MDEmployeeContactTypeBuilder : IEntityBuilder<MDEmployeeContactTypeEntity>
    {
        IList<MDEmployeeContactTypeEntity> IEntityBuilder<MDEmployeeContactTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeContactTypeEntity> MDEmployeeContactTypeEntityList = new List<MDEmployeeContactTypeEntity>();

            while (reader.Read())
            {
                MDEmployeeContactTypeEntityList.Add(((IEntityBuilder<MDEmployeeContactTypeEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeContactTypeEntityList.Count > 0) ? MDEmployeeContactTypeEntityList : null;
        }

        MDEmployeeContactTypeEntity IEntityBuilder<MDEmployeeContactTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEECONTACTTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity = new MDEmployeeContactTypeEntity();

            mDEmployeeContactTypeEntity.EmployeeContactTypeID = reader.GetInt64(FLD_EMPLOYEECONTACTTYPEID);
            mDEmployeeContactTypeEntity.Name = reader.GetString(FLD_NAME);
            mDEmployeeContactTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeContactTypeEntity;
        }
    }
}
