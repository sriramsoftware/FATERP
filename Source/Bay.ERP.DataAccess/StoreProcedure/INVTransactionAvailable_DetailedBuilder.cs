// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 10:37:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransactionAvailable_DetailedBuilder : IEntityBuilder<INVTransactionAvailable_DetailedEntity>
    {
        IList<INVTransactionAvailable_DetailedEntity> IEntityBuilder<INVTransactionAvailable_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransactionAvailable_DetailedEntity> INVTransactionAvailable_DetailedEntityList = new List<INVTransactionAvailable_DetailedEntity>();

            while (reader.Read())
            {
                INVTransactionAvailable_DetailedEntityList.Add(((IEntityBuilder<INVTransactionAvailable_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVTransactionAvailable_DetailedEntityList.Count > 0) ? INVTransactionAvailable_DetailedEntityList : null;
        }

        INVTransactionAvailable_DetailedEntity IEntityBuilder<INVTransactionAvailable_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_ITEMNAME = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_REGIONID = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_TOTALINQTY = 5;
            const Int32 FLD_UNITPRICE = 6;
            const Int32 FLD_TOTALOUTQTY = 7;
            const Int32 FLD_AVAILABLEQTY = 8;
            const Int32 FLD_STOREID = 9;
            const Int32 FLD_STOREUNITID = 10;

            INVTransactionAvailable_DetailedEntity iNVTransactionAvailable_DetailedEntity = new INVTransactionAvailable_DetailedEntity();

            iNVTransactionAvailable_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransactionAvailable_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            iNVTransactionAvailable_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransactionAvailable_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransactionAvailable_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            if (reader.IsDBNull(FLD_TOTALINQTY)) { iNVTransactionAvailable_DetailedEntity.TotalINQty = null; } else { iNVTransactionAvailable_DetailedEntity.TotalINQty = reader.GetInt64(FLD_TOTALINQTY); }
            iNVTransactionAvailable_DetailedEntity.UnitPrice = reader.GetDecimal(FLD_UNITPRICE);
            if (reader.IsDBNull(FLD_TOTALOUTQTY)) { iNVTransactionAvailable_DetailedEntity.TotalOUTQty = null; } else { iNVTransactionAvailable_DetailedEntity.TotalOUTQty = reader.GetInt64(FLD_TOTALOUTQTY); }
            if (reader.IsDBNull(FLD_AVAILABLEQTY)) { iNVTransactionAvailable_DetailedEntity.AvailableQty = null; } else { iNVTransactionAvailable_DetailedEntity.AvailableQty = reader.GetInt64(FLD_AVAILABLEQTY); }
            if (reader.IsDBNull(FLD_STOREID)) { iNVTransactionAvailable_DetailedEntity.StoreID = null; } else { iNVTransactionAvailable_DetailedEntity.StoreID = reader.GetInt64(FLD_STOREID); }
            if (reader.IsDBNull(FLD_STOREUNITID)) { iNVTransactionAvailable_DetailedEntity.StoreUnitID = null; } else { iNVTransactionAvailable_DetailedEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID); }

            return iNVTransactionAvailable_DetailedEntity;
        }
    }
}
