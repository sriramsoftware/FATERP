// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierBrandMapBuilder : IEntityBuilder<PRMSupplierBrandMapEntity>
    {
        IList<PRMSupplierBrandMapEntity> IEntityBuilder<PRMSupplierBrandMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierBrandMapEntity> PRMSupplierBrandMapEntityList = new List<PRMSupplierBrandMapEntity>();

            while (reader.Read())
            {
                PRMSupplierBrandMapEntityList.Add(((IEntityBuilder<PRMSupplierBrandMapEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierBrandMapEntityList.Count > 0) ? PRMSupplierBrandMapEntityList : null;
        }

        PRMSupplierBrandMapEntity IEntityBuilder<PRMSupplierBrandMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERBRANDMAPID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_ORIGINREGIONID = 3;
            const Int32 FLD_ORIGINCOUNTRYID = 4;

            PRMSupplierBrandMapEntity pRMSupplierBrandMapEntity = new PRMSupplierBrandMapEntity();

            pRMSupplierBrandMapEntity.SupplierBrandMapID = reader.GetInt64(FLD_SUPPLIERBRANDMAPID);
            pRMSupplierBrandMapEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierBrandMapEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMSupplierBrandMapEntity.OriginRegionID = null; } else { pRMSupplierBrandMapEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMSupplierBrandMapEntity.OriginCountryID = null; } else { pRMSupplierBrandMapEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }

            return pRMSupplierBrandMapEntity;
        }
    }
}
