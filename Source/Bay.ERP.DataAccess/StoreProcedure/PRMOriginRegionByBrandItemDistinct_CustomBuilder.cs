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
    internal sealed class PRMOriginRegionByBrandItemDistinct_CustomBuilder : IEntityBuilder<PRMOriginRegionByBrandItemDistinct_CustomEntity>
    {
        IList<PRMOriginRegionByBrandItemDistinct_CustomEntity> IEntityBuilder<PRMOriginRegionByBrandItemDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMOriginRegionByBrandItemDistinct_CustomEntity> PRMOriginRegionByBrandItemDistinct_CustomEntityList = new List<PRMOriginRegionByBrandItemDistinct_CustomEntity>();

            while (reader.Read())
            {
                PRMOriginRegionByBrandItemDistinct_CustomEntityList.Add(((IEntityBuilder<PRMOriginRegionByBrandItemDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMOriginRegionByBrandItemDistinct_CustomEntityList.Count > 0) ? PRMOriginRegionByBrandItemDistinct_CustomEntityList : null;
        }

        PRMOriginRegionByBrandItemDistinct_CustomEntity IEntityBuilder<PRMOriginRegionByBrandItemDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ORIGINREGIONID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_SUPPLIERID = 3;
            const Int32 FLD_REGIONNAME = 4;

            PRMOriginRegionByBrandItemDistinct_CustomEntity pRMOriginRegionByBrandItemDistinct_CustomEntity = new PRMOriginRegionByBrandItemDistinct_CustomEntity();

            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMOriginRegionByBrandItemDistinct_CustomEntity.OriginRegionID = null; } else { pRMOriginRegionByBrandItemDistinct_CustomEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            pRMOriginRegionByBrandItemDistinct_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMOriginRegionByBrandItemDistinct_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMOriginRegionByBrandItemDistinct_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMOriginRegionByBrandItemDistinct_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME);

            return pRMOriginRegionByBrandItemDistinct_CustomEntity;
        }
    }
}
