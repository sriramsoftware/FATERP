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
    internal sealed class ACItemGroupAccountMapBuilder : IEntityBuilder<ACItemGroupAccountMapEntity>
    {
        IList<ACItemGroupAccountMapEntity> IEntityBuilder<ACItemGroupAccountMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ACItemGroupAccountMapEntity> ACItemGroupAccountMapEntityList = new List<ACItemGroupAccountMapEntity>();

            while (reader.Read())
            {
                ACItemGroupAccountMapEntityList.Add(((IEntityBuilder<ACItemGroupAccountMapEntity>)this).BuildEntity(reader));
            }

            return (ACItemGroupAccountMapEntityList.Count > 0) ? ACItemGroupAccountMapEntityList : null;
        }

        ACItemGroupAccountMapEntity IEntityBuilder<ACItemGroupAccountMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMGROUPACCOUNTMAPID = 0;
            const Int32 FLD_ITEMCATEGORYID = 1;
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

            ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity = new ACItemGroupAccountMapEntity();

            aCItemGroupAccountMapEntity.ItemGroupAccountMapID = reader.GetInt64(FLD_ITEMGROUPACCOUNTMAPID);
            aCItemGroupAccountMapEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCItemGroupAccountMapEntity.DimensionID = null; } else { aCItemGroupAccountMapEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_SALESACCOUNTID)) { aCItemGroupAccountMapEntity.SalesAccountID = null; } else { aCItemGroupAccountMapEntity.SalesAccountID = reader.GetInt64(FLD_SALESACCOUNTID); }
            if (reader.IsDBNull(FLD_INVENTORYACCOUNTID)) { aCItemGroupAccountMapEntity.InventoryAccountID = null; } else { aCItemGroupAccountMapEntity.InventoryAccountID = reader.GetInt64(FLD_INVENTORYACCOUNTID); }
            if (reader.IsDBNull(FLD_COGSACCOUNTID)) { aCItemGroupAccountMapEntity.COGSAccountID = null; } else { aCItemGroupAccountMapEntity.COGSAccountID = reader.GetInt64(FLD_COGSACCOUNTID); }
            if (reader.IsDBNull(FLD_INVENTORYADJUSTMENTSACCOUNTID)) { aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID = null; } else { aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID = reader.GetInt64(FLD_INVENTORYADJUSTMENTSACCOUNTID); }
            if (reader.IsDBNull(FLD_ASSETTYPE)) { aCItemGroupAccountMapEntity.AssetType = String.Empty; } else { aCItemGroupAccountMapEntity.AssetType = reader.GetString(FLD_ASSETTYPE); }
            if (reader.IsDBNull(FLD_PURCHASEDATE)) { aCItemGroupAccountMapEntity.PurchaseDate = null; } else { aCItemGroupAccountMapEntity.PurchaseDate = reader.GetDateTime(FLD_PURCHASEDATE); }
            if (reader.IsDBNull(FLD_PURCHASEPRICE)) { aCItemGroupAccountMapEntity.PurchasePrice = null; } else { aCItemGroupAccountMapEntity.PurchasePrice = reader.GetDecimal(FLD_PURCHASEPRICE); }
            if (reader.IsDBNull(FLD_DEPRECIATIONRATE)) { aCItemGroupAccountMapEntity.DepreciationRate = null; } else { aCItemGroupAccountMapEntity.DepreciationRate = reader.GetDecimal(FLD_DEPRECIATIONRATE); }
            if (reader.IsDBNull(FLD_DEPRECIATIONMETHODID)) { aCItemGroupAccountMapEntity.DepreciationMethodID = null; } else { aCItemGroupAccountMapEntity.DepreciationMethodID = reader.GetInt64(FLD_DEPRECIATIONMETHODID); }
            if (reader.IsDBNull(FLD_DEPRECIATIONACCOUNTID)) { aCItemGroupAccountMapEntity.DepreciationAccountID = null; } else { aCItemGroupAccountMapEntity.DepreciationAccountID = reader.GetInt64(FLD_DEPRECIATIONACCOUNTID); }

            return aCItemGroupAccountMapEntity;
        }
    }
}
