// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMCustomerAddressInfoBuilder : IEntityBuilder<CRMCustomerAddressInfoEntity>
    {
        IList<CRMCustomerAddressInfoEntity> IEntityBuilder<CRMCustomerAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMCustomerAddressInfoEntity> CRMCustomerAddressInfoEntityList = new List<CRMCustomerAddressInfoEntity>();

            while (reader.Read())
            {
                CRMCustomerAddressInfoEntityList.Add(((IEntityBuilder<CRMCustomerAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (CRMCustomerAddressInfoEntityList.Count > 0) ? CRMCustomerAddressInfoEntityList : null;
        }

        CRMCustomerAddressInfoEntity IEntityBuilder<CRMCustomerAddressInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CUSTOMERADDRESSINFOID = 0;
            const Int32 FLD_CUSTOMERID = 1;
            const Int32 FLD_CUSTOMERADDRESSTYPEID = 2;
            const Int32 FLD_ADDRESSLINE1 = 3;
            const Int32 FLD_ADDRESSLINE2 = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_CITYID = 6;
            const Int32 FLD_ZIPCODE = 7;
            const Int32 FLD_PHONE = 8;
            const Int32 FLD_EMAIL = 9;
            const Int32 FLD_WEBLINK = 10;

            CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity = new CRMCustomerAddressInfoEntity();

            cRMCustomerAddressInfoEntity.CustomerAddressInfoID = reader.GetInt64(FLD_CUSTOMERADDRESSINFOID);
            cRMCustomerAddressInfoEntity.CustomerID = reader.GetInt64(FLD_CUSTOMERID);
            cRMCustomerAddressInfoEntity.CustomerAddressTypeID = reader.GetInt64(FLD_CUSTOMERADDRESSTYPEID);
            cRMCustomerAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cRMCustomerAddressInfoEntity.AddressLine2 = String.Empty; } else { cRMCustomerAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { cRMCustomerAddressInfoEntity.CountryID = null; } else { cRMCustomerAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { cRMCustomerAddressInfoEntity.CityID = null; } else { cRMCustomerAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { cRMCustomerAddressInfoEntity.ZipCode = String.Empty; } else { cRMCustomerAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PHONE)) { cRMCustomerAddressInfoEntity.Phone = String.Empty; } else { cRMCustomerAddressInfoEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMCustomerAddressInfoEntity.Email = String.Empty; } else { cRMCustomerAddressInfoEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { cRMCustomerAddressInfoEntity.WebLink = String.Empty; } else { cRMCustomerAddressInfoEntity.WebLink = reader.GetString(FLD_WEBLINK); }

            return cRMCustomerAddressInfoEntity;
        }
    }
}
