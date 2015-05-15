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
    internal sealed class MDEmployeeAddressTypeBuilder : IEntityBuilder<MDEmployeeAddressTypeEntity>
    {
        IList<MDEmployeeAddressTypeEntity> IEntityBuilder<MDEmployeeAddressTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeAddressTypeEntity> MDEmployeeAddressTypeEntityList = new List<MDEmployeeAddressTypeEntity>();

            while (reader.Read())
            {
                MDEmployeeAddressTypeEntityList.Add(((IEntityBuilder<MDEmployeeAddressTypeEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeAddressTypeEntityList.Count > 0) ? MDEmployeeAddressTypeEntityList : null;
        }

        MDEmployeeAddressTypeEntity IEntityBuilder<MDEmployeeAddressTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEADDRESSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEmployeeAddressTypeEntity mDEmployeeAddressTypeEntity = new MDEmployeeAddressTypeEntity();

            mDEmployeeAddressTypeEntity.EmployeeAddressTypeID = reader.GetInt64(FLD_EMPLOYEEADDRESSTYPEID);
            mDEmployeeAddressTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEmployeeAddressTypeEntity.Description = String.Empty; } else { mDEmployeeAddressTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEmployeeAddressTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeAddressTypeEntity;
        }
    }
}
