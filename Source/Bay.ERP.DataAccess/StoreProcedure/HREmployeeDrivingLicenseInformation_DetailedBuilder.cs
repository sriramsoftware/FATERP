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
    internal sealed class HREmployeeDrivingLicenseInformation_DetailedBuilder : IEntityBuilder<HREmployeeDrivingLicenseInformation_DetailedEntity>
    {
        IList<HREmployeeDrivingLicenseInformation_DetailedEntity> IEntityBuilder<HREmployeeDrivingLicenseInformation_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeDrivingLicenseInformation_DetailedEntity> HREmployeeDrivingLicenseInformation_DetailedEntityList = new List<HREmployeeDrivingLicenseInformation_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeDrivingLicenseInformation_DetailedEntityList.Add(((IEntityBuilder<HREmployeeDrivingLicenseInformation_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeDrivingLicenseInformation_DetailedEntityList.Count > 0) ? HREmployeeDrivingLicenseInformation_DetailedEntityList : null;
        }

        HREmployeeDrivingLicenseInformation_DetailedEntity IEntityBuilder<HREmployeeDrivingLicenseInformation_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEDRIVINGLICENSEINFORMATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_DRIVINGLICENSECATEGORYID = 2;
            const Int32 FLD_LICENSENUMBER = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_CITYNAME = 5;
            const Int32 FLD_ISSUEDDATE = 6;
            const Int32 FLD_EXPIRYDATE = 7;
            const Int32 FLD_RENEWDATE = 8;
            const Int32 FLD_ISDEFAULTLICENSE = 9;
            const Int32 FLD_EMPLOYEEFULLNAME = 10;
            const Int32 FLD_DRIVINGLICENSECATEGORYNAME = 11;
            const Int32 FLD_COUNTRYNAME = 12;
            const Int32 FLD_ROWNUMBER = 13;

            HREmployeeDrivingLicenseInformation_DetailedEntity hREmployeeDrivingLicenseInformation_DetailedEntity = new HREmployeeDrivingLicenseInformation_DetailedEntity();

            hREmployeeDrivingLicenseInformation_DetailedEntity.EmployeeDrivingLicenseInformationID = reader.GetInt64(FLD_EMPLOYEEDRIVINGLICENSEINFORMATIONID);
            hREmployeeDrivingLicenseInformation_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeDrivingLicenseInformation_DetailedEntity.DrivingLicenseCategoryID = reader.GetInt64(FLD_DRIVINGLICENSECATEGORYID);
            hREmployeeDrivingLicenseInformation_DetailedEntity.LicenseNumber = reader.GetString(FLD_LICENSENUMBER);
            hREmployeeDrivingLicenseInformation_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            if (reader.IsDBNull(FLD_CITYNAME)) { hREmployeeDrivingLicenseInformation_DetailedEntity.CityName = String.Empty; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            hREmployeeDrivingLicenseInformation_DetailedEntity.IssuedDate = reader.GetDateTime(FLD_ISSUEDDATE);
            if (reader.IsDBNull(FLD_EXPIRYDATE)) { hREmployeeDrivingLicenseInformation_DetailedEntity.ExpiryDate = null; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.ExpiryDate = reader.GetDateTime(FLD_EXPIRYDATE); }
            if (reader.IsDBNull(FLD_RENEWDATE)) { hREmployeeDrivingLicenseInformation_DetailedEntity.RenewDate = null; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.RenewDate = reader.GetDateTime(FLD_RENEWDATE); }
            hREmployeeDrivingLicenseInformation_DetailedEntity.IsDefaultLicense = reader.GetBoolean(FLD_ISDEFAULTLICENSE);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeDrivingLicenseInformation_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_DRIVINGLICENSECATEGORYNAME)) { hREmployeeDrivingLicenseInformation_DetailedEntity.DrivingLicenseCategoryName = String.Empty; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.DrivingLicenseCategoryName = reader.GetString(FLD_DRIVINGLICENSECATEGORYNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { hREmployeeDrivingLicenseInformation_DetailedEntity.CountryName = String.Empty; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeDrivingLicenseInformation_DetailedEntity.RowNumber = null; } else { hREmployeeDrivingLicenseInformation_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeDrivingLicenseInformation_DetailedEntity;
        }
    }
}
