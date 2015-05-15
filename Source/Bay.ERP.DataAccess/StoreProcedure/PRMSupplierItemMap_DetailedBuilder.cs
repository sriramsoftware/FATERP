// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2012, 11:14:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierItemMap_DetailedBuilder : IEntityBuilder<PRMSupplierItemMap_DetailedEntity>
    {
        IList<PRMSupplierItemMap_DetailedEntity> IEntityBuilder<PRMSupplierItemMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierItemMap_DetailedEntity> PRMSupplierItemMap_DetailedEntityList = new List<PRMSupplierItemMap_DetailedEntity>();

            while (reader.Read())
            {
                PRMSupplierItemMap_DetailedEntityList.Add(((IEntityBuilder<PRMSupplierItemMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierItemMap_DetailedEntityList.Count > 0) ? PRMSupplierItemMap_DetailedEntityList : null;
        }

        PRMSupplierItemMap_DetailedEntity IEntityBuilder<PRMSupplierItemMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERITEMMAPID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_ITEMID = 3;
            const Int32 FLD_ORIGINREGIONID = 4;
            const Int32 FLD_ORIGINCOUNTRYID = 5;
            const Int32 FLD_ACTUALPRICE = 6;
            const Int32 FLD_DISCOUNTPERCENTAGE = 7;
            const Int32 FLD_PRICE = 8;
            const Int32 FLD_MODEL = 9;
            const Int32 FLD_WARRANTYPERIOD = 10;
            const Int32 FLD_ENTRYDATE = 11;
            const Int32 FLD_ISREMOVED = 12;
            const Int32 FLD_SUPPLIERNAME = 13;
            const Int32 FLD_BRANDNAME = 14;
            const Int32 FLD_ITEMNAME = 15;
            const Int32 FLD_REGIONNAME = 16;
            const Int32 FLD_COUNTRYNAME = 17;
            const Int32 FLD_ROWNUMBER = 18;

            PRMSupplierItemMap_DetailedEntity pRMSupplierItemMap_DetailedEntity = new PRMSupplierItemMap_DetailedEntity();

            pRMSupplierItemMap_DetailedEntity.SupplierItemMapID = reader.GetInt64(FLD_SUPPLIERITEMMAPID);
            pRMSupplierItemMap_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierItemMap_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMSupplierItemMap_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMSupplierItemMap_DetailedEntity.OriginRegionID = null; } else { pRMSupplierItemMap_DetailedEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMSupplierItemMap_DetailedEntity.OriginCountryID = null; } else { pRMSupplierItemMap_DetailedEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }
            pRMSupplierItemMap_DetailedEntity.ActualPrice = reader.GetDecimal(FLD_ACTUALPRICE);
            pRMSupplierItemMap_DetailedEntity.DiscountPercentage = reader.GetDecimal(FLD_DISCOUNTPERCENTAGE);
            pRMSupplierItemMap_DetailedEntity.Price = reader.GetDecimal(FLD_PRICE);
            if (reader.IsDBNull(FLD_MODEL)) { pRMSupplierItemMap_DetailedEntity.Model = String.Empty; } else { pRMSupplierItemMap_DetailedEntity.Model = reader.GetString(FLD_MODEL); }
            if (reader.IsDBNull(FLD_WARRANTYPERIOD)) { pRMSupplierItemMap_DetailedEntity.WarrantyPeriod = null; } else { pRMSupplierItemMap_DetailedEntity.WarrantyPeriod = reader.GetInt64(FLD_WARRANTYPERIOD); }
            pRMSupplierItemMap_DetailedEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_ISREMOVED)) { pRMSupplierItemMap_DetailedEntity.IsRemoved = false; } else { pRMSupplierItemMap_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMSupplierItemMap_DetailedEntity.SupplierName = String.Empty; } else { pRMSupplierItemMap_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMSupplierItemMap_DetailedEntity.BrandName = String.Empty; } else { pRMSupplierItemMap_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMSupplierItemMap_DetailedEntity.ItemName = String.Empty; } else { pRMSupplierItemMap_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMSupplierItemMap_DetailedEntity.RegionName = String.Empty; } else { pRMSupplierItemMap_DetailedEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMSupplierItemMap_DetailedEntity.CountryName = String.Empty; } else { pRMSupplierItemMap_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMSupplierItemMap_DetailedEntity.RowNumber = null; } else { pRMSupplierItemMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMSupplierItemMap_DetailedEntity;
        }
    }
}
