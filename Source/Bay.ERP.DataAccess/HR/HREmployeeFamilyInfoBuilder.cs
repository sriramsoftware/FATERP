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
    internal sealed class HREmployeeFamilyInfoBuilder : IEntityBuilder<HREmployeeFamilyInfoEntity>
    {
        IList<HREmployeeFamilyInfoEntity> IEntityBuilder<HREmployeeFamilyInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeFamilyInfoEntity> HREmployeeFamilyInfoEntityList = new List<HREmployeeFamilyInfoEntity>();

            while (reader.Read())
            {
                HREmployeeFamilyInfoEntityList.Add(((IEntityBuilder<HREmployeeFamilyInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeFamilyInfoEntityList.Count > 0) ? HREmployeeFamilyInfoEntityList : null;
        }

        HREmployeeFamilyInfoEntity IEntityBuilder<HREmployeeFamilyInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_HREMPLOYEEFAMILYINFOID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_FAMILYRELATIONTYPEID = 2;
            const Int32 FLD_FIRSTNAME = 3;
            const Int32 FLD_MIDDLENAME = 4;
            const Int32 FLD_LASTNAME = 5;
            const Int32 FLD_PROFESSION = 6;
            const Int32 FLD_ISDEPENDENT = 7;
            const Int32 FLD_LASTEDUCATIONACQUIRED = 8;
            const Int32 FLD_ISEMPLOYED = 9;
            const Int32 FLD_AGE = 10;
            const Int32 FLD_EMAILADDRESS = 11;
            const Int32 FLD_PHONE = 12;

            HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity = new HREmployeeFamilyInfoEntity();

            hREmployeeFamilyInfoEntity.HREmployeeFamilyInfoID = reader.GetInt64(FLD_HREMPLOYEEFAMILYINFOID);
            hREmployeeFamilyInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeFamilyInfoEntity.FamilyRelationTypeID = reader.GetInt64(FLD_FAMILYRELATIONTYPEID);
            hREmployeeFamilyInfoEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hREmployeeFamilyInfoEntity.MiddleName = String.Empty; } else { hREmployeeFamilyInfoEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hREmployeeFamilyInfoEntity.LastName = reader.GetString(FLD_LASTNAME);
            if (reader.IsDBNull(FLD_PROFESSION)) { hREmployeeFamilyInfoEntity.Profession = String.Empty; } else { hREmployeeFamilyInfoEntity.Profession = reader.GetString(FLD_PROFESSION); }
            hREmployeeFamilyInfoEntity.IsDependent = reader.GetBoolean(FLD_ISDEPENDENT);
            hREmployeeFamilyInfoEntity.LastEducationAcquired = reader.GetInt64(FLD_LASTEDUCATIONACQUIRED);
            hREmployeeFamilyInfoEntity.IsEmployed = reader.GetBoolean(FLD_ISEMPLOYED);
            if (reader.IsDBNull(FLD_AGE)) { hREmployeeFamilyInfoEntity.Age = null; } else { hREmployeeFamilyInfoEntity.Age = reader.GetDecimal(FLD_AGE); }
            if (reader.IsDBNull(FLD_EMAILADDRESS)) { hREmployeeFamilyInfoEntity.EmailAddress = String.Empty; } else { hREmployeeFamilyInfoEntity.EmailAddress = reader.GetString(FLD_EMAILADDRESS); }
            if (reader.IsDBNull(FLD_PHONE)) { hREmployeeFamilyInfoEntity.Phone = String.Empty; } else { hREmployeeFamilyInfoEntity.Phone = reader.GetString(FLD_PHONE); }

            return hREmployeeFamilyInfoEntity;
        }
    }
}
