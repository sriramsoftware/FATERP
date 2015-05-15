// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreUnitItemBuilder : IEntityBuilder<INVStoreUnitItemEntity>
    {
        IList<INVStoreUnitItemEntity> IEntityBuilder<INVStoreUnitItemEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreUnitItemEntity> INVStoreUnitItemEntityList = new List<INVStoreUnitItemEntity>();

            while (reader.Read())
            {
                INVStoreUnitItemEntityList.Add(((IEntityBuilder<INVStoreUnitItemEntity>)this).BuildEntity(reader));
            }

            return (INVStoreUnitItemEntityList.Count > 0) ? INVStoreUnitItemEntityList : null;
        }

        INVStoreUnitItemEntity IEntityBuilder<INVStoreUnitItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREUNITITEMID = 0;
            const Int32 FLD_STOREUNITID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_BRANDID = 3;
            const Int32 FLD_REGIONID = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_UNITCURRENTSTOCK = 6;

            INVStoreUnitItemEntity iNVStoreUnitItemEntity = new INVStoreUnitItemEntity();

            iNVStoreUnitItemEntity.StoreUnitItemID = reader.GetInt64(FLD_STOREUNITITEMID);
            iNVStoreUnitItemEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID);
            iNVStoreUnitItemEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVStoreUnitItemEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVStoreUnitItemEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVStoreUnitItemEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVStoreUnitItemEntity.UnitCurrentStock = reader.GetInt64(FLD_UNITCURRENTSTOCK);

            return iNVStoreUnitItemEntity;
        }
    }
}
