// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 02:11:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierBrandMap_DetailedBuilder : IEntityBuilder<PRMSupplierBrandMap_DetailedEntity>
    {
        IList<PRMSupplierBrandMap_DetailedEntity> IEntityBuilder<PRMSupplierBrandMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierBrandMap_DetailedEntity> PRMSupplierBrandMap_DetailedEntityList = new List<PRMSupplierBrandMap_DetailedEntity>();

            while (reader.Read())
            {
                PRMSupplierBrandMap_DetailedEntityList.Add(((IEntityBuilder<PRMSupplierBrandMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierBrandMap_DetailedEntityList.Count > 0) ? PRMSupplierBrandMap_DetailedEntityList : null;
        }

        PRMSupplierBrandMap_DetailedEntity IEntityBuilder<PRMSupplierBrandMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERBRANDMAPID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_ORIGINREGIONID = 3;
            const Int32 FLD_ORIGINCOUNTRYID = 4;
            const Int32 FLD_SUPPLIERNAME = 5;
            const Int32 FLD_BRANDNAME = 6;
            const Int32 FLD_REGIONNAME = 7;
            const Int32 FLD_COUNTRYNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            PRMSupplierBrandMap_DetailedEntity pRMSupplierBrandMap_DetailedEntity = new PRMSupplierBrandMap_DetailedEntity();

            pRMSupplierBrandMap_DetailedEntity.SupplierBrandMapID = reader.GetInt64(FLD_SUPPLIERBRANDMAPID);
            pRMSupplierBrandMap_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierBrandMap_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMSupplierBrandMap_DetailedEntity.OriginRegionID = null; } else { pRMSupplierBrandMap_DetailedEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMSupplierBrandMap_DetailedEntity.OriginCountryID = null; } else { pRMSupplierBrandMap_DetailedEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMSupplierBrandMap_DetailedEntity.SupplierName = String.Empty; } else { pRMSupplierBrandMap_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMSupplierBrandMap_DetailedEntity.BrandName = String.Empty; } else { pRMSupplierBrandMap_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMSupplierBrandMap_DetailedEntity.RegionName = String.Empty; } else { pRMSupplierBrandMap_DetailedEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMSupplierBrandMap_DetailedEntity.CountryName = String.Empty; } else { pRMSupplierBrandMap_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMSupplierBrandMap_DetailedEntity.RowNumber = null; } else { pRMSupplierBrandMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMSupplierBrandMap_DetailedEntity;
        }
    }
}
