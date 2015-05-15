// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 02:21:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMOriginCountryByBrandItemRegionDistinct_CustomBuilder : IEntityBuilder<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity>
    {
        IList<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity> IEntityBuilder<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity> PRMOriginCountryByBrandItemRegionDistinct_CustomEntityList = new List<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity>();

            while (reader.Read())
            {
                PRMOriginCountryByBrandItemRegionDistinct_CustomEntityList.Add(((IEntityBuilder<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMOriginCountryByBrandItemRegionDistinct_CustomEntityList.Count > 0) ? PRMOriginCountryByBrandItemRegionDistinct_CustomEntityList : null;
        }

        PRMOriginCountryByBrandItemRegionDistinct_CustomEntity IEntityBuilder<PRMOriginCountryByBrandItemRegionDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ORIGINCOUNTRYID = 0;
            const Int32 FLD_ORIGINREGIONID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_BRANDID = 3;
            const Int32 FLD_SUPPLIERID = 4;
            const Int32 FLD_COUNTRYNAME = 5;

            PRMOriginCountryByBrandItemRegionDistinct_CustomEntity pRMOriginCountryByBrandItemRegionDistinct_CustomEntity = new PRMOriginCountryByBrandItemRegionDistinct_CustomEntity();

            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.OriginCountryID = null; } else { pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.OriginRegionID = null; } else { pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMOriginCountryByBrandItemRegionDistinct_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME);

            return pRMOriginCountryByBrandItemRegionDistinct_CustomEntity;
        }
    }
}
