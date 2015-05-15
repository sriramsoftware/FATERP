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
    internal sealed class HREmployeeConfidentialInfoBuilder : IEntityBuilder<HREmployeeConfidentialInfoEntity>
    {
        IList<HREmployeeConfidentialInfoEntity> IEntityBuilder<HREmployeeConfidentialInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeConfidentialInfoEntity> HREmployeeConfidentialInfoEntityList = new List<HREmployeeConfidentialInfoEntity>();

            while (reader.Read())
            {
                HREmployeeConfidentialInfoEntityList.Add(((IEntityBuilder<HREmployeeConfidentialInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeConfidentialInfoEntityList.Count > 0) ? HREmployeeConfidentialInfoEntityList : null;
        }

        HREmployeeConfidentialInfoEntity IEntityBuilder<HREmployeeConfidentialInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEECONFIDENTIALINFOID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_NUMBEROFCHILDREN = 2;
            const Int32 FLD_DATEOFBIRTH = 3;
            const Int32 FLD_MARITALSTATUSID = 4;
            const Int32 FLD_CITYOFBIRTH = 5;
            const Int32 FLD_BIRTHOFSTATEID = 6;
            const Int32 FLD_COUNTRYOFBIRTHCOUNTRYID = 7;
            const Int32 FLD_RESIDENCECOUNTRYID = 8;
            const Int32 FLD_PERSONLTAXIDNUMBER = 9;
            const Int32 FLD_NATIONALIDNUMBER = 10;
            const Int32 FLD_REGIONID = 11;
            const Int32 FLD_RELIGIONID = 12;
            const Int32 FLD_BIRTHMARK = 13;
            const Int32 FLD_BLOODGROUPID = 14;
            const Int32 FLD_DISABILITYINFORMATION = 15;
            const Int32 FLD_GENDERID = 16;
            const Int32 FLD_ANNIVERSARYDATE = 17;
            const Int32 FLD_HEIGHT = 18;
            const Int32 FLD_WEIGHT = 19;
            const Int32 FLD_CURRENTNATIONALITYCOUNTRYID = 20;
            const Int32 FLD_PREVIOUSNATIONALITYCOUNTRYID = 21;
            const Int32 FLD_HASPASSPORT = 22;
            const Int32 FLD_HASDRIVINGLISENCE = 23;
            const Int32 FLD_ISREMOVED = 24;
            const Int32 FLD_DISTRICT = 25;

            HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity = new HREmployeeConfidentialInfoEntity();

            hREmployeeConfidentialInfoEntity.EmployeeConfidentialInfoID = reader.GetInt64(FLD_EMPLOYEECONFIDENTIALINFOID);
            hREmployeeConfidentialInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_NUMBEROFCHILDREN)) { hREmployeeConfidentialInfoEntity.NumberofChildren = null; } else { hREmployeeConfidentialInfoEntity.NumberofChildren = reader.GetInt32(FLD_NUMBEROFCHILDREN); }
            if (reader.IsDBNull(FLD_DATEOFBIRTH)) { hREmployeeConfidentialInfoEntity.DateofBirth = null; } else { hREmployeeConfidentialInfoEntity.DateofBirth = reader.GetDateTime(FLD_DATEOFBIRTH); }
            if (reader.IsDBNull(FLD_MARITALSTATUSID)) { hREmployeeConfidentialInfoEntity.MaritalStatusID = null; } else { hREmployeeConfidentialInfoEntity.MaritalStatusID = reader.GetInt64(FLD_MARITALSTATUSID); }
            if (reader.IsDBNull(FLD_CITYOFBIRTH)) { hREmployeeConfidentialInfoEntity.CityofBirth = String.Empty; } else { hREmployeeConfidentialInfoEntity.CityofBirth = reader.GetString(FLD_CITYOFBIRTH); }
            if (reader.IsDBNull(FLD_BIRTHOFSTATEID)) { hREmployeeConfidentialInfoEntity.BirthOfStateID = null; } else { hREmployeeConfidentialInfoEntity.BirthOfStateID = reader.GetInt64(FLD_BIRTHOFSTATEID); }
            if (reader.IsDBNull(FLD_COUNTRYOFBIRTHCOUNTRYID)) { hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID = null; } else { hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID = reader.GetInt64(FLD_COUNTRYOFBIRTHCOUNTRYID); }
            if (reader.IsDBNull(FLD_RESIDENCECOUNTRYID)) { hREmployeeConfidentialInfoEntity.ResidenceCountryID = null; } else { hREmployeeConfidentialInfoEntity.ResidenceCountryID = reader.GetInt64(FLD_RESIDENCECOUNTRYID); }
            if (reader.IsDBNull(FLD_PERSONLTAXIDNUMBER)) { hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber = String.Empty; } else { hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber = reader.GetString(FLD_PERSONLTAXIDNUMBER); }
            if (reader.IsDBNull(FLD_NATIONALIDNUMBER)) { hREmployeeConfidentialInfoEntity.NationalIdNumber = String.Empty; } else { hREmployeeConfidentialInfoEntity.NationalIdNumber = reader.GetString(FLD_NATIONALIDNUMBER); }
            if (reader.IsDBNull(FLD_REGIONID)) { hREmployeeConfidentialInfoEntity.RegionID = null; } else { hREmployeeConfidentialInfoEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_RELIGIONID)) { hREmployeeConfidentialInfoEntity.ReligionID = null; } else { hREmployeeConfidentialInfoEntity.ReligionID = reader.GetInt64(FLD_RELIGIONID); }
            if (reader.IsDBNull(FLD_BIRTHMARK)) { hREmployeeConfidentialInfoEntity.BirthMark = String.Empty; } else { hREmployeeConfidentialInfoEntity.BirthMark = reader.GetString(FLD_BIRTHMARK); }
            if (reader.IsDBNull(FLD_BLOODGROUPID)) { hREmployeeConfidentialInfoEntity.BloodGroupID = null; } else { hREmployeeConfidentialInfoEntity.BloodGroupID = reader.GetInt64(FLD_BLOODGROUPID); }
            if (reader.IsDBNull(FLD_DISABILITYINFORMATION)) { hREmployeeConfidentialInfoEntity.DisabilityInformation = String.Empty; } else { hREmployeeConfidentialInfoEntity.DisabilityInformation = reader.GetString(FLD_DISABILITYINFORMATION); }
            if (reader.IsDBNull(FLD_GENDERID)) { hREmployeeConfidentialInfoEntity.GenderID = null; } else { hREmployeeConfidentialInfoEntity.GenderID = reader.GetInt64(FLD_GENDERID); }
            if (reader.IsDBNull(FLD_ANNIVERSARYDATE)) { hREmployeeConfidentialInfoEntity.AnniversaryDate = null; } else { hREmployeeConfidentialInfoEntity.AnniversaryDate = reader.GetDateTime(FLD_ANNIVERSARYDATE); }
            if (reader.IsDBNull(FLD_HEIGHT)) { hREmployeeConfidentialInfoEntity.Height = String.Empty; } else { hREmployeeConfidentialInfoEntity.Height = reader.GetString(FLD_HEIGHT); }
            if (reader.IsDBNull(FLD_WEIGHT)) { hREmployeeConfidentialInfoEntity.Weight = String.Empty; } else { hREmployeeConfidentialInfoEntity.Weight = reader.GetString(FLD_WEIGHT); }
            if (reader.IsDBNull(FLD_CURRENTNATIONALITYCOUNTRYID)) { hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID = null; } else { hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID = reader.GetInt64(FLD_CURRENTNATIONALITYCOUNTRYID); }
            if (reader.IsDBNull(FLD_PREVIOUSNATIONALITYCOUNTRYID)) { hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID = null; } else { hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID = reader.GetInt64(FLD_PREVIOUSNATIONALITYCOUNTRYID); }
            if (reader.IsDBNull(FLD_HASPASSPORT)) { hREmployeeConfidentialInfoEntity.HasPassport = false; } else { hREmployeeConfidentialInfoEntity.HasPassport = reader.GetBoolean(FLD_HASPASSPORT); }
            if (reader.IsDBNull(FLD_HASDRIVINGLISENCE)) { hREmployeeConfidentialInfoEntity.HasDrivingLisence = false; } else { hREmployeeConfidentialInfoEntity.HasDrivingLisence = reader.GetBoolean(FLD_HASDRIVINGLISENCE); }
            if (reader.IsDBNull(FLD_DISTRICT)) { hREmployeeConfidentialInfoEntity.District = null; } else { hREmployeeConfidentialInfoEntity.District = reader.GetInt64(FLD_DISTRICT); }
            hREmployeeConfidentialInfoEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return hREmployeeConfidentialInfoEntity;
        }
    }
}
