// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2012, 03:22:36




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierByBrand_CustomBuilder : IEntityBuilder<PRMSupplierByBrand_CustomEntity>
    {
        IList<PRMSupplierByBrand_CustomEntity> IEntityBuilder<PRMSupplierByBrand_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierByBrand_CustomEntity> PRMSupplierByBrand_CustomEntityList = new List<PRMSupplierByBrand_CustomEntity>();

            while (reader.Read())
            {
                PRMSupplierByBrand_CustomEntityList.Add(((IEntityBuilder<PRMSupplierByBrand_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierByBrand_CustomEntityList.Count > 0) ? PRMSupplierByBrand_CustomEntityList : null;
        }

        PRMSupplierByBrand_CustomEntity IEntityBuilder<PRMSupplierByBrand_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERBRANDMAPID = 0;
            const Int32 FLD_BRANDID = 1;
            const Int32 FLD_SUPPLIERID = 2;
            const Int32 FLD_SUPPLIERCODE = 3;
            const Int32 FLD_SUPPLIERNAME = 4;

            PRMSupplierByBrand_CustomEntity pRMSupplierByBrand_CustomEntity = new PRMSupplierByBrand_CustomEntity();

            pRMSupplierByBrand_CustomEntity.SupplierBrandMapID = reader.GetInt64(FLD_SUPPLIERBRANDMAPID);
            pRMSupplierByBrand_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMSupplierByBrand_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMSupplierByBrand_CustomEntity.SupplierCode = String.Empty; } else { pRMSupplierByBrand_CustomEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMSupplierByBrand_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);

            return pRMSupplierByBrand_CustomEntity;
        }
    }
}
