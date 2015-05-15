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
    internal sealed class HREmployeeDrivingLicenseInformationBuilder : IEntityBuilder<HREmployeeDrivingLicenseInformationEntity>
    {
        IList<HREmployeeDrivingLicenseInformationEntity> IEntityBuilder<HREmployeeDrivingLicenseInformationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeDrivingLicenseInformationEntity> HREmployeeDrivingLicenseInformationEntityList = new List<HREmployeeDrivingLicenseInformationEntity>();

            while (reader.Read())
            {
                HREmployeeDrivingLicenseInformationEntityList.Add(((IEntityBuilder<HREmployeeDrivingLicenseInformationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeDrivingLicenseInformationEntityList.Count > 0) ? HREmployeeDrivingLicenseInformationEntityList : null;
        }

        HREmployeeDrivingLicenseInformationEntity IEntityBuilder<HREmployeeDrivingLicenseInformationEntity>.BuildEntity(IDataReader reader)
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
			const Int32 FLD_ISSUEAUTHORITY = 10;
			const Int32 FLD_REMARKS = 11;

            HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity = new HREmployeeDrivingLicenseInformationEntity();

            hREmployeeDrivingLicenseInformationEntity.EmployeeDrivingLicenseInformationID = reader.GetInt64(FLD_EMPLOYEEDRIVINGLICENSEINFORMATIONID);
            hREmployeeDrivingLicenseInformationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID = reader.GetInt64(FLD_DRIVINGLICENSECATEGORYID);
            hREmployeeDrivingLicenseInformationEntity.LicenseNumber = reader.GetString(FLD_LICENSENUMBER);
            hREmployeeDrivingLicenseInformationEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            if (reader.IsDBNull(FLD_CITYNAME)) { hREmployeeDrivingLicenseInformationEntity.CityName = String.Empty; } else { hREmployeeDrivingLicenseInformationEntity.CityName = reader.GetString(FLD_CITYNAME); }
            hREmployeeDrivingLicenseInformationEntity.IssuedDate = reader.GetDateTime(FLD_ISSUEDDATE);
            if (reader.IsDBNull(FLD_EXPIRYDATE)) { hREmployeeDrivingLicenseInformationEntity.ExpiryDate = null; } else { hREmployeeDrivingLicenseInformationEntity.ExpiryDate = reader.GetDateTime(FLD_EXPIRYDATE); }
            if (reader.IsDBNull(FLD_RENEWDATE)) { hREmployeeDrivingLicenseInformationEntity.RenewDate = null; } else { hREmployeeDrivingLicenseInformationEntity.RenewDate = reader.GetDateTime(FLD_RENEWDATE); }
            hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense = reader.GetBoolean(FLD_ISDEFAULTLICENSE);
            if (reader.IsDBNull(FLD_ISSUEAUTHORITY)) { hREmployeeDrivingLicenseInformationEntity.IssueAuthority = String.Empty; } else { hREmployeeDrivingLicenseInformationEntity.IssueAuthority = reader.GetString(FLD_ISSUEAUTHORITY); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeDrivingLicenseInformationEntity.Remarks = String.Empty; } else { hREmployeeDrivingLicenseInformationEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeDrivingLicenseInformationEntity;
        }
    }
}
