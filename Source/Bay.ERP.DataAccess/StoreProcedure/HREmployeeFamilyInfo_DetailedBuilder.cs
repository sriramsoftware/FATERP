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
    internal sealed class HREmployeeFamilyInfo_DetailedBuilder : IEntityBuilder<HREmployeeFamilyInfo_DetailedEntity>
    {
        IList<HREmployeeFamilyInfo_DetailedEntity> IEntityBuilder<HREmployeeFamilyInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeFamilyInfo_DetailedEntity> HREmployeeFamilyInfo_DetailedEntityList = new List<HREmployeeFamilyInfo_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeFamilyInfo_DetailedEntityList.Add(((IEntityBuilder<HREmployeeFamilyInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeFamilyInfo_DetailedEntityList.Count > 0) ? HREmployeeFamilyInfo_DetailedEntityList : null;
        }

        HREmployeeFamilyInfo_DetailedEntity IEntityBuilder<HREmployeeFamilyInfo_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 13;
            const Int32 FLD_FAMILYRELATIONTYPENAME = 14;
            const Int32 FLD_EDUCATIONALDEGREENAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            HREmployeeFamilyInfo_DetailedEntity hREmployeeFamilyInfo_DetailedEntity = new HREmployeeFamilyInfo_DetailedEntity();

            hREmployeeFamilyInfo_DetailedEntity.HREmployeeFamilyInfoID = reader.GetInt64(FLD_HREMPLOYEEFAMILYINFOID);
            hREmployeeFamilyInfo_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeFamilyInfo_DetailedEntity.FamilyRelationTypeID = reader.GetInt64(FLD_FAMILYRELATIONTYPEID);
            hREmployeeFamilyInfo_DetailedEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hREmployeeFamilyInfo_DetailedEntity.MiddleName = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hREmployeeFamilyInfo_DetailedEntity.LastName = reader.GetString(FLD_LASTNAME);
            if (reader.IsDBNull(FLD_PROFESSION)) { hREmployeeFamilyInfo_DetailedEntity.Profession = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.Profession = reader.GetString(FLD_PROFESSION); }
            hREmployeeFamilyInfo_DetailedEntity.IsDependent = reader.GetBoolean(FLD_ISDEPENDENT);
            hREmployeeFamilyInfo_DetailedEntity.LastEducationAcquired = reader.GetInt64(FLD_LASTEDUCATIONACQUIRED);
            hREmployeeFamilyInfo_DetailedEntity.IsEmployed = reader.GetBoolean(FLD_ISEMPLOYED);
            if (reader.IsDBNull(FLD_AGE)) { hREmployeeFamilyInfo_DetailedEntity.Age = null; } else { hREmployeeFamilyInfo_DetailedEntity.Age = reader.GetDecimal(FLD_AGE); }
            if (reader.IsDBNull(FLD_EMAILADDRESS)) { hREmployeeFamilyInfo_DetailedEntity.EmailAddress = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.EmailAddress = reader.GetString(FLD_EMAILADDRESS); }
            if (reader.IsDBNull(FLD_PHONE)) { hREmployeeFamilyInfo_DetailedEntity.Phone = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeFamilyInfo_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_FAMILYRELATIONTYPENAME)) { hREmployeeFamilyInfo_DetailedEntity.FamilyRelationTypeName = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.FamilyRelationTypeName = reader.GetString(FLD_FAMILYRELATIONTYPENAME); }
            if (reader.IsDBNull(FLD_EDUCATIONALDEGREENAME)) { hREmployeeFamilyInfo_DetailedEntity.EducationalDegreeName = String.Empty; } else { hREmployeeFamilyInfo_DetailedEntity.EducationalDegreeName = reader.GetString(FLD_EDUCATIONALDEGREENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeFamilyInfo_DetailedEntity.RowNumber = null; } else { hREmployeeFamilyInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeFamilyInfo_DetailedEntity;
        }
    }
}
