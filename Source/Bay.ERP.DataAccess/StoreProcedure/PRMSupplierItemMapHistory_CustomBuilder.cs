// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 04:11:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierItemMapHistory_CustomBuilder : IEntityBuilder<PRMSupplierItemMapHistory_CustomEntity>
    {
        IList<PRMSupplierItemMapHistory_CustomEntity> IEntityBuilder<PRMSupplierItemMapHistory_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierItemMapHistory_CustomEntity> PRMSupplierItemMapHistory_CustomEntityList = new List<PRMSupplierItemMapHistory_CustomEntity>();

            while (reader.Read())
            {
                PRMSupplierItemMapHistory_CustomEntityList.Add(((IEntityBuilder<PRMSupplierItemMapHistory_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierItemMapHistory_CustomEntityList.Count > 0) ? PRMSupplierItemMapHistory_CustomEntityList : null;
        }

        PRMSupplierItemMapHistory_CustomEntity IEntityBuilder<PRMSupplierItemMapHistory_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERITEMMAPHISTORYID = 0;
            const Int32 FLD_SUPPLIERITEMMAPID = 1;
            const Int32 FLD_ACTUALPRICE = 2;
            const Int32 FLD_DISCOUNTPERCENTAGE = 3;
            const Int32 FLD_PRICE = 4;
            const Int32 FLD_ENTRYDATE = 5;
            const Int32 FLD_ITEMID = 6;
            const Int32 FLD_SUPPLIERID = 7;
            const Int32 FLD_ORIGINREGIONID = 8;
            const Int32 FLD_ORIGINCOUNTRYID = 9;
            const Int32 FLD_WARRANTYPERIOD = 10;
            const Int32 FLD_BRANDID = 11;
            const Int32 FLD_ITEMNAME = 12;
            const Int32 FLD_SUPPLIERNAME = 13;
            const Int32 FLD_PHONE = 14;
            const Int32 FLD_RELATIONSHIP = 15;
            const Int32 FLD_BRANDNAME = 16;
            const Int32 FLD_REGIONNAME = 17;
            const Int32 FLD_COUNTRYNAME = 18;

            PRMSupplierItemMapHistory_CustomEntity pRMSupplierItemMapHistory_CustomEntity = new PRMSupplierItemMapHistory_CustomEntity();

            pRMSupplierItemMapHistory_CustomEntity.SupplierItemMapHistoryID = reader.GetInt64(FLD_SUPPLIERITEMMAPHISTORYID);
            pRMSupplierItemMapHistory_CustomEntity.SupplierItemMapID = reader.GetInt64(FLD_SUPPLIERITEMMAPID);
            pRMSupplierItemMapHistory_CustomEntity.ActualPrice = reader.GetDecimal(FLD_ACTUALPRICE);
            pRMSupplierItemMapHistory_CustomEntity.DiscountPercentage = reader.GetDecimal(FLD_DISCOUNTPERCENTAGE);
            pRMSupplierItemMapHistory_CustomEntity.Price = reader.GetDecimal(FLD_PRICE);
            pRMSupplierItemMapHistory_CustomEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMSupplierItemMapHistory_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMSupplierItemMapHistory_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMSupplierItemMapHistory_CustomEntity.OriginRegionID = null; } else { pRMSupplierItemMapHistory_CustomEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMSupplierItemMapHistory_CustomEntity.OriginCountryID = null; } else { pRMSupplierItemMapHistory_CustomEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }
            if (reader.IsDBNull(FLD_WARRANTYPERIOD)) { pRMSupplierItemMapHistory_CustomEntity.WarrantyPeriod = null; } else { pRMSupplierItemMapHistory_CustomEntity.WarrantyPeriod = reader.GetInt64(FLD_WARRANTYPERIOD); }
            pRMSupplierItemMapHistory_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMSupplierItemMapHistory_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            pRMSupplierItemMapHistory_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierItemMapHistory_CustomEntity.Phone = String.Empty; } else { pRMSupplierItemMapHistory_CustomEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { pRMSupplierItemMapHistory_CustomEntity.Relationship = String.Empty; } else { pRMSupplierItemMapHistory_CustomEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            pRMSupplierItemMapHistory_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMSupplierItemMapHistory_CustomEntity.RegionName = String.Empty; } else { pRMSupplierItemMapHistory_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMSupplierItemMapHistory_CustomEntity.CountryName = String.Empty; } else { pRMSupplierItemMapHistory_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }

            return pRMSupplierItemMapHistory_CustomEntity;
        }
    }
}
