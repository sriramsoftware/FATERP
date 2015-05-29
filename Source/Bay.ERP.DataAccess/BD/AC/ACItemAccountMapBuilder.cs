// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACItemAccountMapBuilder : IEntityBuilder<ACItemAccountMapEntity>
    {
        IList<ACItemAccountMapEntity> IEntityBuilder<ACItemAccountMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ACItemAccountMapEntity> ACItemAccountMapEntityList = new List<ACItemAccountMapEntity>();

            while (reader.Read())
            {
                ACItemAccountMapEntityList.Add(((IEntityBuilder<ACItemAccountMapEntity>)this).BuildEntity(reader));
            }

            return (ACItemAccountMapEntityList.Count > 0) ? ACItemAccountMapEntityList : null;
        }

        ACItemAccountMapEntity IEntityBuilder<ACItemAccountMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMACCOUNTMAPID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_DIMENSIONID = 2;
            const Int32 FLD_SALESACCOUNTID = 3;
            const Int32 FLD_INVENTORYACCOUNTID = 4;
            const Int32 FLD_COGSACCOUNTID = 5;
            const Int32 FLD_INVENTORYADJUSTMENTSACCOUNTID = 6;
            const Int32 FLD_ASSETTYPE = 7;
            const Int32 FLD_PURCHASEDATE = 8;
            const Int32 FLD_PURCHASEPRICE = 9;
            const Int32 FLD_DEPRECIATIONRATE = 10;
            const Int32 FLD_DEPRECIATIONMETHODID = 11;
            const Int32 FLD_DEPRECIATIONACCOUNTID = 12;

            ACItemAccountMapEntity aCItemAccountMapEntity = new ACItemAccountMapEntity();

            aCItemAccountMapEntity.ItemAccountMapID = reader.GetInt64(FLD_ITEMACCOUNTMAPID);
            aCItemAccountMapEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCItemAccountMapEntity.DimensionID = null; } else { aCItemAccountMapEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_SALESACCOUNTID)) { aCItemAccountMapEntity.SalesAccountID = null; } else { aCItemAccountMapEntity.SalesAccountID = reader.GetInt64(FLD_SALESACCOUNTID); }
            if (reader.IsDBNull(FLD_INVENTORYACCOUNTID)) { aCItemAccountMapEntity.InventoryAccountID = null; } else { aCItemAccountMapEntity.InventoryAccountID = reader.GetInt64(FLD_INVENTORYACCOUNTID); }
            if (reader.IsDBNull(FLD_COGSACCOUNTID)) { aCItemAccountMapEntity.COGSAccountID = null; } else { aCItemAccountMapEntity.COGSAccountID = reader.GetInt64(FLD_COGSACCOUNTID); }
            if (reader.IsDBNull(FLD_INVENTORYADJUSTMENTSACCOUNTID)) { aCItemAccountMapEntity.InventoryAdjustmentsAccountID = null; } else { aCItemAccountMapEntity.InventoryAdjustmentsAccountID = reader.GetInt64(FLD_INVENTORYADJUSTMENTSACCOUNTID); }
            if (reader.IsDBNull(FLD_ASSETTYPE)) { aCItemAccountMapEntity.AssetType = String.Empty; } else { aCItemAccountMapEntity.AssetType = reader.GetString(FLD_ASSETTYPE); }
            if (reader.IsDBNull(FLD_PURCHASEDATE)) { aCItemAccountMapEntity.PurchaseDate = null; } else { aCItemAccountMapEntity.PurchaseDate = reader.GetDateTime(FLD_PURCHASEDATE); }
            if (reader.IsDBNull(FLD_PURCHASEPRICE)) { aCItemAccountMapEntity.PurchasePrice = null; } else { aCItemAccountMapEntity.PurchasePrice = reader.GetDecimal(FLD_PURCHASEPRICE); }
            if (reader.IsDBNull(FLD_DEPRECIATIONRATE)) { aCItemAccountMapEntity.DepreciationRate = null; } else { aCItemAccountMapEntity.DepreciationRate = reader.GetDecimal(FLD_DEPRECIATIONRATE); }
            if (reader.IsDBNull(FLD_DEPRECIATIONMETHODID)) { aCItemAccountMapEntity.DepreciationMethodID = null; } else { aCItemAccountMapEntity.DepreciationMethodID = reader.GetInt64(FLD_DEPRECIATIONMETHODID); }
            if (reader.IsDBNull(FLD_DEPRECIATIONACCOUNTID)) { aCItemAccountMapEntity.DepreciationAccountID = null; } else { aCItemAccountMapEntity.DepreciationAccountID = reader.GetInt64(FLD_DEPRECIATIONACCOUNTID); }

            return aCItemAccountMapEntity;
        }
    }
}
