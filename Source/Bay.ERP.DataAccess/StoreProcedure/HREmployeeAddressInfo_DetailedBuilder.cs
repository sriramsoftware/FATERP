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
    internal sealed class HREmployeeAddressInfo_DetailedBuilder : IEntityBuilder<HREmployeeAddressInfo_DetailedEntity>
    {
        IList<HREmployeeAddressInfo_DetailedEntity> IEntityBuilder<HREmployeeAddressInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeAddressInfo_DetailedEntity> HREmployeeAddressInfo_DetailedEntityList = new List<HREmployeeAddressInfo_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeAddressInfo_DetailedEntityList.Add(((IEntityBuilder<HREmployeeAddressInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeAddressInfo_DetailedEntityList.Count > 0) ? HREmployeeAddressInfo_DetailedEntityList : null;
        }

        HREmployeeAddressInfo_DetailedEntity IEntityBuilder<HREmployeeAddressInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEADDRESSINFOID = 0;
            const Int32 FLD_EMPLOYEEADDRESSTYPEID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_COUNTRYID = 3;
            const Int32 FLD_CITYID = 4;
            const Int32 FLD_ADDRESSLINE1 = 5;
            const Int32 FLD_ADDRESSLINE2 = 6;
            const Int32 FLD_ZIPCODE = 7;
            const Int32 FLD_EMPLOYEEFULLNAME = 8;
            const Int32 FLD_EMPLOYEEADDRESSTYPENAME = 9;
            const Int32 FLD_COUNTRYNAME = 10;
            const Int32 FLD_CITYNAME = 11;
            const Int32 FLD_ROWNUMBER = 12;

            HREmployeeAddressInfo_DetailedEntity hREmployeeAddressInfo_DetailedEntity = new HREmployeeAddressInfo_DetailedEntity();

            hREmployeeAddressInfo_DetailedEntity.EmployeeAddressInfoID = reader.GetInt64(FLD_EMPLOYEEADDRESSINFOID);
            hREmployeeAddressInfo_DetailedEntity.EmployeeAddressTypeID = reader.GetInt64(FLD_EMPLOYEEADDRESSTYPEID);
            hREmployeeAddressInfo_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_COUNTRYID)) { hREmployeeAddressInfo_DetailedEntity.CountryID = null; } else { hREmployeeAddressInfo_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { hREmployeeAddressInfo_DetailedEntity.CityID = null; } else { hREmployeeAddressInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID); }
            hREmployeeAddressInfo_DetailedEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { hREmployeeAddressInfo_DetailedEntity.AddressLine2 = String.Empty; } else { hREmployeeAddressInfo_DetailedEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { hREmployeeAddressInfo_DetailedEntity.ZipCode = String.Empty; } else { hREmployeeAddressInfo_DetailedEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeAddressInfo_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeAddressInfo_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEADDRESSTYPENAME)) { hREmployeeAddressInfo_DetailedEntity.EmployeeAddressTypeName = String.Empty; } else { hREmployeeAddressInfo_DetailedEntity.EmployeeAddressTypeName = reader.GetString(FLD_EMPLOYEEADDRESSTYPENAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { hREmployeeAddressInfo_DetailedEntity.CountryName = String.Empty; } else { hREmployeeAddressInfo_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CITYNAME)) { hREmployeeAddressInfo_DetailedEntity.CityName = String.Empty; } else { hREmployeeAddressInfo_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeAddressInfo_DetailedEntity.RowNumber = null; } else { hREmployeeAddressInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeAddressInfo_DetailedEntity;
        }
    }
}
