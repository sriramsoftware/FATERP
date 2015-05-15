// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 10:30:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierItemMapHistory_RPTBuilder : IEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>
    {
        IList<PRMSupplierItemMapHistory_RPTEntity> IEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierItemMapHistory_RPTEntity> PRMSupplierItemMapHistory_RPTEntityList = new List<PRMSupplierItemMapHistory_RPTEntity>();

            while (reader.Read())
            {
                PRMSupplierItemMapHistory_RPTEntityList.Add(((IEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierItemMapHistory_RPTEntityList.Count > 0) ? PRMSupplierItemMapHistory_RPTEntityList : null;
        }

        PRMSupplierItemMapHistory_RPTEntity IEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>.BuildEntity(IDataReader reader)
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

            PRMSupplierItemMapHistory_RPTEntity pRMSupplierItemMapHistory_RPTEntity = new PRMSupplierItemMapHistory_RPTEntity();

            pRMSupplierItemMapHistory_RPTEntity.SupplierItemMapHistoryID = reader.GetInt64(FLD_SUPPLIERITEMMAPHISTORYID);
            pRMSupplierItemMapHistory_RPTEntity.SupplierItemMapID = reader.GetInt64(FLD_SUPPLIERITEMMAPID);
            pRMSupplierItemMapHistory_RPTEntity.ActualPrice = reader.GetDecimal(FLD_ACTUALPRICE);
            pRMSupplierItemMapHistory_RPTEntity.DiscountPercentage = reader.GetDecimal(FLD_DISCOUNTPERCENTAGE);
            pRMSupplierItemMapHistory_RPTEntity.Price = reader.GetDecimal(FLD_PRICE);
            pRMSupplierItemMapHistory_RPTEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMSupplierItemMapHistory_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMSupplierItemMapHistory_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMSupplierItemMapHistory_RPTEntity.OriginRegionID = null; } else { pRMSupplierItemMapHistory_RPTEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMSupplierItemMapHistory_RPTEntity.OriginCountryID = null; } else { pRMSupplierItemMapHistory_RPTEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }
            if (reader.IsDBNull(FLD_WARRANTYPERIOD)) { pRMSupplierItemMapHistory_RPTEntity.WarrantyPeriod = null; } else { pRMSupplierItemMapHistory_RPTEntity.WarrantyPeriod = reader.GetInt64(FLD_WARRANTYPERIOD); }
            pRMSupplierItemMapHistory_RPTEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMSupplierItemMapHistory_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            pRMSupplierItemMapHistory_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierItemMapHistory_RPTEntity.Phone = String.Empty; } else { pRMSupplierItemMapHistory_RPTEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { pRMSupplierItemMapHistory_RPTEntity.Relationship = String.Empty; } else { pRMSupplierItemMapHistory_RPTEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            pRMSupplierItemMapHistory_RPTEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMSupplierItemMapHistory_RPTEntity.RegionName = String.Empty; } else { pRMSupplierItemMapHistory_RPTEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMSupplierItemMapHistory_RPTEntity.CountryName = String.Empty; } else { pRMSupplierItemMapHistory_RPTEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }

            return pRMSupplierItemMapHistory_RPTEntity;
        }
    }
}
