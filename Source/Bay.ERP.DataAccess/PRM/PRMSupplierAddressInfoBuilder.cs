// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierAddressInfoBuilder : IEntityBuilder<PRMSupplierAddressInfoEntity>
    {
        IList<PRMSupplierAddressInfoEntity> IEntityBuilder<PRMSupplierAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierAddressInfoEntity> PRMSupplierAddressInfoEntityList = new List<PRMSupplierAddressInfoEntity>();

            while (reader.Read())
            {
                PRMSupplierAddressInfoEntityList.Add(((IEntityBuilder<PRMSupplierAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierAddressInfoEntityList.Count > 0) ? PRMSupplierAddressInfoEntityList : null;
        }

        PRMSupplierAddressInfoEntity IEntityBuilder<PRMSupplierAddressInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERADDRESSINFOID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_SUPPLIERADDRESSTYPEID = 2;
            const Int32 FLD_ADDRESSLINE1 = 3;
            const Int32 FLD_ADDRESSLINE2 = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_CITYID = 6;
            const Int32 FLD_ZIPCODE = 7;
            const Int32 FLD_PHONE = 8;
            const Int32 FLD_EMAIL = 9;
            const Int32 FLD_WEBLINK = 10;

            PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity = new PRMSupplierAddressInfoEntity();

            pRMSupplierAddressInfoEntity.SupplierAddressInfoID = reader.GetInt64(FLD_SUPPLIERADDRESSINFOID);
            pRMSupplierAddressInfoEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierAddressInfoEntity.SupplierAddressTypeID = reader.GetInt64(FLD_SUPPLIERADDRESSTYPEID);
            pRMSupplierAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { pRMSupplierAddressInfoEntity.AddressLine2 = String.Empty; } else { pRMSupplierAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMSupplierAddressInfoEntity.CountryID = null; } else { pRMSupplierAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { pRMSupplierAddressInfoEntity.CityID = null; } else { pRMSupplierAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { pRMSupplierAddressInfoEntity.ZipCode = String.Empty; } else { pRMSupplierAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierAddressInfoEntity.Phone = String.Empty; } else { pRMSupplierAddressInfoEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMSupplierAddressInfoEntity.Email = String.Empty; } else { pRMSupplierAddressInfoEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMSupplierAddressInfoEntity.WebLink = String.Empty; } else { pRMSupplierAddressInfoEntity.WebLink = reader.GetString(FLD_WEBLINK); }

            return pRMSupplierAddressInfoEntity;
        }
    }
}
