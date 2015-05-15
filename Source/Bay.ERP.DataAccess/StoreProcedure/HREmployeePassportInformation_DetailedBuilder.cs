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
    internal sealed class HREmployeePassportInformation_DetailedBuilder : IEntityBuilder<HREmployeePassportInformation_DetailedEntity>
    {
        IList<HREmployeePassportInformation_DetailedEntity> IEntityBuilder<HREmployeePassportInformation_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeePassportInformation_DetailedEntity> HREmployeePassportInformation_DetailedEntityList = new List<HREmployeePassportInformation_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeePassportInformation_DetailedEntityList.Add(((IEntityBuilder<HREmployeePassportInformation_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeePassportInformation_DetailedEntityList.Count > 0) ? HREmployeePassportInformation_DetailedEntityList : null;
        }

        HREmployeePassportInformation_DetailedEntity IEntityBuilder<HREmployeePassportInformation_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEPASSPORTINFORMATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_PASSPORTCOUNTRY = 2;
            const Int32 FLD_CITYNAME = 3;
            const Int32 FLD_PASSPORTNUMBER = 4;
            const Int32 FLD_ISSUEDDATE = 5;
            const Int32 FLD_EXPIREDATE = 6;
            const Int32 FLD_PASSPORTPROFESSION = 7;
            const Int32 FLD_NOTE = 8;
            const Int32 FLD_EMPLOYEEFULLNAME = 9;
            const Int32 FLD_COUNTRYNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            HREmployeePassportInformation_DetailedEntity hREmployeePassportInformation_DetailedEntity = new HREmployeePassportInformation_DetailedEntity();

            hREmployeePassportInformation_DetailedEntity.EmployeePassportInformationID = reader.GetInt64(FLD_EMPLOYEEPASSPORTINFORMATIONID);
            hREmployeePassportInformation_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeePassportInformation_DetailedEntity.PassportCountry = reader.GetInt64(FLD_PASSPORTCOUNTRY);
            if (reader.IsDBNull(FLD_CITYNAME)) { hREmployeePassportInformation_DetailedEntity.CityName = String.Empty; } else { hREmployeePassportInformation_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            hREmployeePassportInformation_DetailedEntity.PassportNumber = reader.GetString(FLD_PASSPORTNUMBER);
            hREmployeePassportInformation_DetailedEntity.IssuedDate = reader.GetDateTime(FLD_ISSUEDDATE);
            hREmployeePassportInformation_DetailedEntity.ExpireDate = reader.GetDateTime(FLD_EXPIREDATE);
            if (reader.IsDBNull(FLD_PASSPORTPROFESSION)) { hREmployeePassportInformation_DetailedEntity.PassportProfession = String.Empty; } else { hREmployeePassportInformation_DetailedEntity.PassportProfession = reader.GetString(FLD_PASSPORTPROFESSION); }
            if (reader.IsDBNull(FLD_NOTE)) { hREmployeePassportInformation_DetailedEntity.Note = String.Empty; } else { hREmployeePassportInformation_DetailedEntity.Note = reader.GetString(FLD_NOTE); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeePassportInformation_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeePassportInformation_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { hREmployeePassportInformation_DetailedEntity.CountryName = String.Empty; } else { hREmployeePassportInformation_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeePassportInformation_DetailedEntity.RowNumber = null; } else { hREmployeePassportInformation_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeePassportInformation_DetailedEntity;
        }
    }
}
