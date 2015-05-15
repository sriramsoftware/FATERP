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
    internal sealed class HREmployeeAddressInfoBuilder : IEntityBuilder<HREmployeeAddressInfoEntity>
    {
        IList<HREmployeeAddressInfoEntity> IEntityBuilder<HREmployeeAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeAddressInfoEntity> HREmployeeAddressInfoEntityList = new List<HREmployeeAddressInfoEntity>();

            while (reader.Read())
            {
                HREmployeeAddressInfoEntityList.Add(((IEntityBuilder<HREmployeeAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeAddressInfoEntityList.Count > 0) ? HREmployeeAddressInfoEntityList : null;
        }

        HREmployeeAddressInfoEntity IEntityBuilder<HREmployeeAddressInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEADDRESSINFOID = 0;
            const Int32 FLD_EMPLOYEEADDRESSTYPEID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_COUNTRYID = 3;
            const Int32 FLD_CITYID = 4;
            const Int32 FLD_ADDRESSLINE1 = 5;
            const Int32 FLD_ADDRESSLINE2 = 6;
            const Int32 FLD_ZIPCODE = 7;

            HREmployeeAddressInfoEntity hREmployeeAddressInfoEntity = new HREmployeeAddressInfoEntity();

            hREmployeeAddressInfoEntity.EmployeeAddressInfoID = reader.GetInt64(FLD_EMPLOYEEADDRESSINFOID);
            hREmployeeAddressInfoEntity.EmployeeAddressTypeID = reader.GetInt64(FLD_EMPLOYEEADDRESSTYPEID);
            hREmployeeAddressInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_COUNTRYID)) { hREmployeeAddressInfoEntity.CountryID = null; } else { hREmployeeAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { hREmployeeAddressInfoEntity.CityID = null; } else { hREmployeeAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            hREmployeeAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { hREmployeeAddressInfoEntity.AddressLine2 = String.Empty; } else { hREmployeeAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { hREmployeeAddressInfoEntity.ZipCode = String.Empty; } else { hREmployeeAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }

            return hREmployeeAddressInfoEntity;
        }
    }
}
