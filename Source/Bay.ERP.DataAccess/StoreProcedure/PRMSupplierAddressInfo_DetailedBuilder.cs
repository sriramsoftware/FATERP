// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Feb-2012, 10:17:53




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierAddressInfo_DetailedBuilder : IEntityBuilder<PRMSupplierAddressInfo_DetailedEntity>
    {
        IList<PRMSupplierAddressInfo_DetailedEntity> IEntityBuilder<PRMSupplierAddressInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierAddressInfo_DetailedEntity> PRMSupplierAddressInfo_DetailedEntityList = new List<PRMSupplierAddressInfo_DetailedEntity>();

            while (reader.Read())
            {
                PRMSupplierAddressInfo_DetailedEntityList.Add(((IEntityBuilder<PRMSupplierAddressInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierAddressInfo_DetailedEntityList.Count > 0) ? PRMSupplierAddressInfo_DetailedEntityList : null;
        }

        PRMSupplierAddressInfo_DetailedEntity IEntityBuilder<PRMSupplierAddressInfo_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_SUPPLIERSUPPLIERNAME = 11;
            const Int32 FLD_SUPPLIERADDRESSTYPE = 12;
            const Int32 FLD_COUNTRY = 13;
            const Int32 FLD_CITY = 14;
            const Int32 FLD_ROWNUMBER = 15;

            PRMSupplierAddressInfo_DetailedEntity pRMSupplierAddressInfo_DetailedEntity = new PRMSupplierAddressInfo_DetailedEntity();

            pRMSupplierAddressInfo_DetailedEntity.SupplierAddressInfoID = reader.GetInt64(FLD_SUPPLIERADDRESSINFOID);
            pRMSupplierAddressInfo_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierAddressInfo_DetailedEntity.SupplierAddressTypeID = reader.GetInt64(FLD_SUPPLIERADDRESSTYPEID);
            pRMSupplierAddressInfo_DetailedEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { pRMSupplierAddressInfo_DetailedEntity.AddressLine2 = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMSupplierAddressInfo_DetailedEntity.CountryID = null; } else { pRMSupplierAddressInfo_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { pRMSupplierAddressInfo_DetailedEntity.CityID = null; } else { pRMSupplierAddressInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { pRMSupplierAddressInfo_DetailedEntity.ZipCode = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierAddressInfo_DetailedEntity.Phone = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMSupplierAddressInfo_DetailedEntity.Email = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMSupplierAddressInfo_DetailedEntity.WebLink = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            if (reader.IsDBNull(FLD_SUPPLIERSUPPLIERNAME)) { pRMSupplierAddressInfo_DetailedEntity.SupplierSupplierName = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.SupplierSupplierName = reader.GetString(FLD_SUPPLIERSUPPLIERNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERADDRESSTYPE)) { pRMSupplierAddressInfo_DetailedEntity.SupplierAddressType = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.SupplierAddressType = reader.GetString(FLD_SUPPLIERADDRESSTYPE); }
            if (reader.IsDBNull(FLD_COUNTRY)) { pRMSupplierAddressInfo_DetailedEntity.Country = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.Country = reader.GetString(FLD_COUNTRY); }
            if (reader.IsDBNull(FLD_CITY)) { pRMSupplierAddressInfo_DetailedEntity.City = String.Empty; } else { pRMSupplierAddressInfo_DetailedEntity.City = reader.GetString(FLD_CITY); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMSupplierAddressInfo_DetailedEntity.RowNumber = null; } else { pRMSupplierAddressInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMSupplierAddressInfo_DetailedEntity;
        }
    }
}
